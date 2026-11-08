using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tugas_1
{
    // Mengelola daftar peminjaman aktif dan proses pencatatan pengembalian.
    public partial class Pengembalian : Form
    {
        private readonly TextBox txtCari = new TextBox();
        private readonly ComboBox cmbStatus = new ComboBox();
        private readonly DataGridView tabelPengembalian = new DataGridView();

        public Pengembalian()
        {
            InitializeComponent();
            BangunTampilan();
        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            MuatData();
        }

        private void BangunTampilan()
        {
            // Membuat header, filter, tabel, dan tombol pengembalian.
            BackColor = Color.FromArgb(244, 246, 250);
            Padding = new Padding(16, 0, 16, 16);

            Panel header = new Panel { Dock = DockStyle.Top, Height = 52, BackColor = Color.White };
            Label judul = new Label
            {
                Text = "Pengembalian Barang",
                AutoSize = true,
                Location = new Point(16, 16),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 24, 39)
            };
            header.Controls.Add(judul);

            Panel filter = new Panel { Dock = DockStyle.Top, Height = 64, BackColor = Color.FromArgb(244, 246, 250) };
            txtCari.Location = new Point(0, 16);
            txtCari.Size = new Size(180, 25);
            txtCari.Text = "Cari nama peminjam...";
            txtCari.ForeColor = Color.Silver;
            txtCari.Font = new Font("Segoe UI", 8F);
            txtCari.Enter += delegate
            {
                if (txtCari.Text == "Cari nama peminjam...")
                {
                    txtCari.Clear();
                    txtCari.ForeColor = Color.FromArgb(31, 41, 55);
                }
            };
            txtCari.Leave += delegate
            {
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    txtCari.Text = "Cari nama peminjam...";
                    txtCari.ForeColor = Color.Silver;
                }
            };
            txtCari.TextChanged += delegate
            {
                if (IsHandleCreated && txtCari.Text != "Cari nama peminjam...") MuatData();
            };

            cmbStatus.Location = new Point(190, 16);
            cmbStatus.Size = new Size(110, 25);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 8F);
            cmbStatus.Items.AddRange(new object[] { "Status: Semua", "Status: Dipinjam", "Status: Terlambat" });
            cmbStatus.SelectedIndex = 0;
            cmbStatus.SelectedIndexChanged += delegate { if (IsHandleCreated) MuatData(); };
            filter.Controls.Add(txtCari);
            filter.Controls.Add(cmbStatus);

            tabelPengembalian.Dock = DockStyle.Fill;
            tabelPengembalian.AllowUserToAddRows = false;
            tabelPengembalian.AllowUserToDeleteRows = false;
            tabelPengembalian.ReadOnly = true;
            tabelPengembalian.RowHeadersVisible = false;
            tabelPengembalian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelPengembalian.BackgroundColor = Color.White;
            tabelPengembalian.BorderStyle = BorderStyle.None;
            tabelPengembalian.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabelPengembalian.GridColor = Color.FromArgb(229, 231, 235);
            tabelPengembalian.EnableHeadersVisualStyles = false;
            tabelPengembalian.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            tabelPengembalian.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(75, 85, 99);
            tabelPengembalian.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            tabelPengembalian.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
            tabelPengembalian.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            tabelPengembalian.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
            tabelPengembalian.RowTemplate.Height = 34;
            tabelPengembalian.Columns.Add("id_peminjaman", "ID");
            tabelPengembalian.Columns.Add("peminjam", "Peminjam");
            tabelPengembalian.Columns.Add("barang", "Barang");
            tabelPengembalian.Columns.Add("jumlah", "Jumlah");
            tabelPengembalian.Columns.Add("tanggal_pinjam", "Tgl Pinjam");
            tabelPengembalian.Columns.Add("tanggal_kembali", "Jatuh Tempo");
            tabelPengembalian.Columns.Add("status", "Status");
            tabelPengembalian.Columns.Add(new DataGridViewButtonColumn { Name = "catat", HeaderText = "Aksi", Text = "Catat Pengembalian", UseColumnTextForButtonValue = true });
            tabelPengembalian.Columns["id_peminjaman"].Visible = false;
            tabelPengembalian.CellClick += tabelPengembalian_CellClick;
            tabelPengembalian.CellPainting += tabelPengembalian_CellPainting;

            Controls.Add(tabelPengembalian);
            Controls.Add(filter);
            Controls.Add(header);
        }

        private void MuatData()
        {
            // Mengambil peminjaman yang sudah disetujui dan belum dikembalikan.
            if (!IsHandleCreated) return;
            tabelPengembalian.Rows.Clear();
            string keyword = txtCari.Text == "Cari nama peminjam..." ? string.Empty : txtCari.Text.Trim();
            string status = cmbStatus.Text.Replace("Status: ", string.Empty);
            string query = "SELECT p.id_peminjaman, u.nama_user, b.nama_barang, d.jumlah_pinjam, " +
                "p.tanggal_pinjam, p.rencana_kembali " +
                "FROM PEMINJAMAN p JOIN USER u ON u.id_user = p.id_user " +
                "JOIN DETAIL_PEMINJAMAN d ON d.id_peminjaman = p.id_peminjaman " +
                "JOIN BARANG b ON b.id_barang = d.id_barang " +
                "LEFT JOIN PENGEMBALIAN k ON k.id_peminjaman = p.id_peminjaman " +
                "WHERE p.status_persetujuan = 'Disetujui' AND k.id_pengembalian IS NULL " +
                "AND u.nama_user LIKE @keyword ORDER BY p.rencana_kembali";

            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime jatuhTempo = Convert.ToDateTime(reader["rencana_kembali"]);
                            string statusBaris = jatuhTempo.Date < DateTime.Today ? "Terlambat" : "Dipinjam";
                            if (status != "Semua" && status != statusBaris) continue;
                            tabelPengembalian.Rows.Add(
                                reader["id_peminjaman"], reader["nama_user"], reader["nama_barang"], reader["jumlah_pinjam"],
                                Convert.ToDateTime(reader["tanggal_pinjam"]).ToString("dd MMM yyyy"),
                                jatuhTempo.ToString("dd MMM yyyy"), statusBaris);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data pengembalian: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabelPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || tabelPengembalian.Columns[e.ColumnIndex].Name != "catat") return;
            int idPeminjaman = Convert.ToInt32(tabelPengembalian.Rows[e.RowIndex].Cells["id_peminjaman"].Value);
            int jumlah = Convert.ToInt32(tabelPengembalian.Rows[e.RowIndex].Cells["jumlah"].Value);
            string barang = tabelPengembalian.Rows[e.RowIndex].Cells["barang"].Value.ToString();
            string peminjam = tabelPengembalian.Rows[e.RowIndex].Cells["peminjam"].Value.ToString();

            string kondisi;
            if (!TampilkanModalPengembalian(barang, peminjam, jumlah, out kondisi)) return;
            SimpanPengembalian(idPeminjaman, jumlah, kondisi);
        }

        private bool TampilkanModalPengembalian(string barang, string peminjam, int jumlah, out string kondisi)
        {
            // Menampilkan dialog untuk memilih kondisi barang saat dikembalikan.
            kondisi = "Baik";
            using (Form modal = new Form())
            {
                modal.Text = "Catat Pengembalian";
                modal.StartPosition = FormStartPosition.CenterParent;
                modal.FormBorderStyle = FormBorderStyle.FixedDialog;
                modal.MaximizeBox = false;
                modal.MinimizeBox = false;
                modal.ClientSize = new Size(360, 285);
                modal.BackColor = Color.White;

                Label judul = new Label { Text = "Catat Pengembalian", Location = new Point(16, 14), AutoSize = true, Font = new Font("Segoe UI", 11F, FontStyle.Bold) };
                Label detail = new Label { Text = barang + " - " + peminjam + " (" + jumlah + " unit)", Location = new Point(16, 42), AutoSize = true, ForeColor = Color.Gray, Font = new Font("Segoe UI", 8F) };
                Label labelKondisi = new Label { Text = "Kondisi saat dikembalikan", Location = new Point(16, 75), AutoSize = true, Font = new Font("Segoe UI", 8F, FontStyle.Bold) };
                RadioButton baik = new RadioButton { Text = "Baik", Location = new Point(16, 98), AutoSize = true, Checked = true };
                RadioButton ringan = new RadioButton { Text = "Rusak ringan", Location = new Point(105, 98), AutoSize = true };
                RadioButton rusak = new RadioButton { Text = "Rusak", Location = new Point(220, 98), AutoSize = true };
                Label labelCatatan = new Label { Text = "Catatan (opsional)", Location = new Point(16, 135), AutoSize = true, Font = new Font("Segoe UI", 8F, FontStyle.Bold) };
                TextBox catatan = new TextBox { Location = new Point(16, 158), Size = new Size(328, 48), Multiline = true, BorderStyle = BorderStyle.FixedSingle };
                Button batal = new Button { Text = "Batal", Location = new Point(170, 230), Size = new Size(75, 30), DialogResult = DialogResult.Cancel, FlatStyle = FlatStyle.Flat };
                Button simpan = new Button { Text = "Simpan", Location = new Point(255, 230), Size = new Size(89, 30), DialogResult = DialogResult.OK, BackColor = Color.FromArgb(30, 58, 138), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                modal.Controls.AddRange(new Control[] { judul, detail, labelKondisi, baik, ringan, rusak, labelCatatan, catatan, batal, simpan });
                modal.AcceptButton = simpan;
                modal.CancelButton = batal;
                if (modal.ShowDialog(this) != DialogResult.OK) return false;
                kondisi = rusak.Checked ? "Rusak" : (ringan.Checked ? "Rusak ringan" : "Baik");
                return true;
            }
        }

        private void SimpanPengembalian(int idPeminjaman, int jumlah, string kondisi)
        {
            // Menyimpan pengembalian, mengembalikan stok, dan mengubah status transaksi.
            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        int idPenerima;
                        using (MySqlCommand penerima = new MySqlCommand("SELECT id_user FROM USER WHERE role = 'pengurus' LIMIT 1", conn, transaction))
                        {
                            object hasil = penerima.ExecuteScalar();
                            if (hasil == null) throw new InvalidOperationException("Tidak ada user pengurus yang dapat menerima pengembalian.");
                            idPenerima = Convert.ToInt32(hasil);
                        }

                        using (MySqlCommand insert = new MySqlCommand("INSERT INTO PENGEMBALIAN (id_peminjaman, tanggal_kembali, kondisi_akhir, id_penerima) VALUES (@id, NOW(), @kondisi, @penerima)", conn, transaction))
                        {
                            insert.Parameters.AddWithValue("@id", idPeminjaman);
                            insert.Parameters.AddWithValue("@kondisi", kondisi);
                            insert.Parameters.AddWithValue("@penerima", idPenerima);
                            insert.ExecuteNonQuery();
                        }

                        using (MySqlCommand updateStok = new MySqlCommand("UPDATE BARANG b JOIN DETAIL_PEMINJAMAN d ON d.id_barang = b.id_barang SET b.jumlah_barang = b.jumlah_barang + @jumlah WHERE d.id_peminjaman = @id", conn, transaction))
                        {
                            updateStok.Parameters.AddWithValue("@jumlah", jumlah);
                            updateStok.Parameters.AddWithValue("@id", idPeminjaman);
                            updateStok.ExecuteNonQuery();
                        }

                        using (MySqlCommand updateStatus = new MySqlCommand("UPDATE PEMINJAMAN SET status_persetujuan = 'Dikembalikan' WHERE id_peminjaman = @id", conn, transaction))
                        {
                            updateStatus.Parameters.AddWithValue("@id", idPeminjaman);
                            updateStatus.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
                MuatData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan pengembalian: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabelPengembalian_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Mewarnai status keterlambatan dan tombol aksi pengembalian.
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string namaKolom = tabelPengembalian.Columns[e.ColumnIndex].Name;
            if (namaKolom == "catat")
            {
                e.CellStyle.BackColor = Color.FromArgb(30, 58, 138);
                e.CellStyle.ForeColor = Color.White;
            }
            else if (namaKolom == "status")
            {
                bool terlambat = Convert.ToString(tabelPengembalian.Rows[e.RowIndex].Cells["status"].Value) == "Terlambat";
                e.CellStyle.BackColor = terlambat ? Color.FromArgb(254, 226, 226) : Color.FromArgb(254, 243, 199);
                e.CellStyle.ForeColor = terlambat ? Color.FromArgb(185, 28, 28) : Color.FromArgb(180, 83, 9);
            }
        }
    }
}
