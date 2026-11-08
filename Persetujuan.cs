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
    // Menampilkan pengajuan siswa dan menyediakan aksi setujui atau tolak.
    public partial class Persetujuan : Form
    {
        private readonly TextBox txtCari = new TextBox();
        private readonly ComboBox cmbStatus = new ComboBox();
        private readonly DataGridView tabelPersetujuan = new DataGridView();

        public Persetujuan()
        {
            InitializeComponent();
            BangunTampilan();
        }

        private void Persetujuan_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            MuatData();
        }

        private void BangunTampilan()
        {
            // Membuat filter dan tabel persetujuan dengan gaya UI pengurus.
            BackColor = Color.FromArgb(244, 246, 250);
            Padding = new Padding(16, 0, 16, 16);

            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 52,
                BackColor = Color.White
            };
            Label judul = new Label
            {
                Text = "Persetujuan Peminjaman",
                AutoSize = true,
                Location = new Point(16, 16),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 24, 39)
            };
            header.Controls.Add(judul);

            Panel filter = new Panel
            {
                Dock = DockStyle.Top,
                Height = 64,
                BackColor = Color.FromArgb(244, 246, 250)
            };
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
            cmbStatus.Items.AddRange(new object[] { "Status: Semua", "Status: Pending", "Status: Disetujui", "Status: Ditolak" });
            cmbStatus.SelectedIndex = 0;
            cmbStatus.SelectedIndexChanged += delegate { if (IsHandleCreated) MuatData(); };
            filter.Controls.Add(txtCari);
            filter.Controls.Add(cmbStatus);

            tabelPersetujuan.Dock = DockStyle.Fill;
            tabelPersetujuan.AllowUserToAddRows = false;
            tabelPersetujuan.AllowUserToDeleteRows = false;
            tabelPersetujuan.ReadOnly = true;
            tabelPersetujuan.RowHeadersVisible = false;
            tabelPersetujuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelPersetujuan.BackgroundColor = Color.White;
            tabelPersetujuan.BorderStyle = BorderStyle.None;
            tabelPersetujuan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabelPersetujuan.GridColor = Color.FromArgb(229, 231, 235);
            tabelPersetujuan.EnableHeadersVisualStyles = false;
            tabelPersetujuan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            tabelPersetujuan.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(75, 85, 99);
            tabelPersetujuan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            tabelPersetujuan.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
            tabelPersetujuan.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            tabelPersetujuan.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
            tabelPersetujuan.RowTemplate.Height = 34;
            tabelPersetujuan.Columns.Add("id_peminjaman", "ID");
            tabelPersetujuan.Columns.Add("peminjam", "Peminjaman");
            tabelPersetujuan.Columns.Add("barang", "Barang");
            tabelPersetujuan.Columns.Add("jumlah", "Jumlah");
            tabelPersetujuan.Columns.Add("tanggal_pinjam", "Tgl Pinjam");
            tabelPersetujuan.Columns.Add("tanggal_kembali", "Tgl Kembali");
            tabelPersetujuan.Columns.Add("status", "Status");
            tabelPersetujuan.Columns.Add(new DataGridViewButtonColumn { Name = "setujui", HeaderText = "", Text = "Setujui", UseColumnTextForButtonValue = true });
            tabelPersetujuan.Columns.Add(new DataGridViewButtonColumn { Name = "tolak", HeaderText = "", Text = "Tolak", UseColumnTextForButtonValue = true });
            tabelPersetujuan.Columns["id_peminjaman"].Visible = false;
            tabelPersetujuan.CellPainting += tabelPersetujuan_CellPainting;
            tabelPersetujuan.CellClick += tabelPersetujuan_CellClick;

            Controls.Add(tabelPersetujuan);
            Controls.Add(filter);
            Controls.Add(header);
        }

        private void MuatData()
        {
            // Mengambil semua pengajuan dari database untuk ditinjau pengurus.
            if (!IsHandleCreated) return;
            tabelPersetujuan.Rows.Clear();
            string keyword = txtCari.Text == "Cari nama peminjam..." ? string.Empty : txtCari.Text.Trim();
            string status = cmbStatus.Text.Replace("Status: ", string.Empty);
            string query = "SELECT p.id_peminjaman, u.nama_user, b.nama_barang, d.jumlah_pinjam, " +
                "p.tanggal_pinjam, p.rencana_kembali, p.status_persetujuan " +
                "FROM PEMINJAMAN p JOIN USER u ON u.id_user = p.id_user " +
                "JOIN DETAIL_PEMINJAMAN d ON d.id_peminjaman = p.id_peminjaman " +
                "JOIN BARANG b ON b.id_barang = d.id_barang " +
                "WHERE u.nama_user LIKE @keyword AND (@status = 'Semua' OR p.status_persetujuan = @status) " +
                "ORDER BY p.tanggal_pinjam DESC";

            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    cmd.Parameters.AddWithValue("@status", status);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int row = tabelPersetujuan.Rows.Add(
                                reader["id_peminjaman"], reader["nama_user"], reader["nama_barang"],
                                reader["jumlah_pinjam"], Convert.ToDateTime(reader["tanggal_pinjam"]).ToString("dd MMM yyyy"),
                                Convert.ToDateTime(reader["rencana_kembali"]).ToString("dd MMM yyyy"), reader["status_persetujuan"]);
                            bool pending = string.Equals(reader["status_persetujuan"].ToString(), "Pending", StringComparison.OrdinalIgnoreCase);
                            tabelPersetujuan.Rows[row].Cells["setujui"].ReadOnly = !pending;
                            tabelPersetujuan.Rows[row].Cells["tolak"].ReadOnly = !pending;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data persetujuan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabelPersetujuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Memproses persetujuan atau penolakan dari tombol pada baris terpilih.
            if (e.RowIndex < 0 || (e.ColumnIndex != tabelPersetujuan.Columns["setujui"].Index && e.ColumnIndex != tabelPersetujuan.Columns["tolak"].Index)) return;
            string status = tabelPersetujuan.Rows[e.RowIndex].Cells["status"].Value.ToString();
            if (!string.Equals(status, "Pending", StringComparison.OrdinalIgnoreCase)) return;
            string statusBaru = e.ColumnIndex == tabelPersetujuan.Columns["setujui"].Index ? "Disetujui" : "Ditolak";
            int idPeminjaman = Convert.ToInt32(tabelPersetujuan.Rows[e.RowIndex].Cells["id_peminjaman"].Value);
            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        int idBarang;
                        int jumlahPinjam;
                        int stokTersedia;
                        using (MySqlCommand detail = new MySqlCommand(
                            "SELECT d.id_barang, d.jumlah_pinjam, b.jumlah_barang FROM DETAIL_PEMINJAMAN d " +
                            "JOIN BARANG b ON b.id_barang = d.id_barang WHERE d.id_peminjaman = @id FOR UPDATE", conn, transaction))
                        {
                            detail.Parameters.AddWithValue("@id", idPeminjaman);
                            using (MySqlDataReader reader = detail.ExecuteReader())
                            {
                                if (!reader.Read()) throw new InvalidOperationException("Detail barang untuk peminjaman tidak ditemukan.");
                                idBarang = Convert.ToInt32(reader["id_barang"]);
                                jumlahPinjam = Convert.ToInt32(reader["jumlah_pinjam"]);
                                stokTersedia = Convert.ToInt32(reader["jumlah_barang"]);
                            }
                        }

                        if (statusBaru == "Disetujui" && jumlahPinjam > stokTersedia)
                        {
                            throw new InvalidOperationException("Stok barang tidak mencukupi untuk menyetujui pengajuan ini.");
                        }

                        using (MySqlCommand updateStatus = new MySqlCommand(
                            "UPDATE PEMINJAMAN SET status_persetujuan = @status, id_pengurus_approve = @pengurus WHERE id_peminjaman = @id", conn, transaction))
                        {
                            updateStatus.Parameters.AddWithValue("@status", statusBaru);
                            updateStatus.Parameters.AddWithValue("@pengurus", AppSession.CurrentUserId > 0 && statusBaru == "Disetujui" ? (object)AppSession.CurrentUserId : DBNull.Value);
                            updateStatus.Parameters.AddWithValue("@id", idPeminjaman);
                            updateStatus.ExecuteNonQuery();
                        }

                        if (statusBaru == "Disetujui")
                        {
                            using (MySqlCommand updateStok = new MySqlCommand(
                                "UPDATE BARANG SET jumlah_barang = jumlah_barang - @jumlah WHERE id_barang = @barang AND jumlah_barang >= @jumlah", conn, transaction))
                            {
                                updateStok.Parameters.AddWithValue("@jumlah", jumlahPinjam);
                                updateStok.Parameters.AddWithValue("@barang", idBarang);
                                if (updateStok.ExecuteNonQuery() != 1) throw new InvalidOperationException("Stok berubah. Muat ulang data lalu coba lagi.");
                            }
                        }
                        transaction.Commit();
                    }
                }
                MuatData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabelPersetujuan_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Mewarnai status dan tombol agar keputusan mudah dibedakan.
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (tabelPersetujuan.Columns[e.ColumnIndex].Name == "setujui")
            {
                e.CellStyle.BackColor = Color.FromArgb(22, 163, 74);
                e.CellStyle.ForeColor = Color.White;
            }
            else if (tabelPersetujuan.Columns[e.ColumnIndex].Name == "tolak")
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
            }
            else if (tabelPersetujuan.Columns[e.ColumnIndex].Name == "status")
            {
                string status = Convert.ToString(tabelPersetujuan.Rows[e.RowIndex].Cells["status"].Value);
                if (status == "Disetujui")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(21, 87, 36);
                    e.CellStyle.BackColor = Color.FromArgb(212, 237, 218);
                }
                else if (status == "Ditolak")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(114, 28, 36);
                    e.CellStyle.BackColor = Color.FromArgb(248, 215, 218);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(156, 101, 0);
                    e.CellStyle.BackColor = Color.FromArgb(255, 242, 204);
                }
            }
        }
    }
}
