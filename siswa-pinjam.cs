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
    // Form untuk membuat pengajuan peminjaman barang oleh siswa.
    public partial class siswa_pinjam : Form
    {
        public siswa_pinjam()
        {
            InitializeComponent();
            SiapkanForm(null);
        }

        private void siswa_pinjam_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public siswa_pinjam(string namaBarang)
        {
            InitializeComponent();
            SiapkanForm(namaBarang);
        }

        private void SiapkanForm(string namaBarang)
        {
            MuatDaftarBarang();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.Black;

            domainUpDown1.Items.Clear();
            for (int jumlah = 1; jumlah <= 30; jumlah++)
            {
                domainUpDown1.Items.Add(jumlah.ToString());
            }
            domainUpDown1.SelectedIndex = 0;
            domainUpDown1.ForeColor = Color.Black;

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
            dateTimePicker2.Value = DateTime.Today.AddDays(1);

            if (!string.IsNullOrEmpty(namaBarang) && comboBox1.Items.Contains(namaBarang))
            {
                comboBox1.SelectedItem = namaBarang;
            }
            else if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void MuatDaftarBarang()
        {
            // Mengisi pilihan barang dari database dan memilih item pertama secara otomatis.
            comboBox1.Items.Clear();
            bool databaseTerhubung = false;
            bool adaDataDatabase = false;

            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("SELECT nama_barang FROM BARANG WHERE jumlah_barang > 0 ORDER BY nama_barang", conn))
                {
                    conn.Open();
                    databaseTerhubung = true;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            adaDataDatabase = true;
                            comboBox1.Items.Add(reader["nama_barang"].ToString());
                        }
                    }

                    if (!adaDataDatabase)
                    {
                        TambahkanDataBarangAwal(conn);
                        comboBox1.Items.AddRange(new object[]
                        {
                            "Mic Wireless",
                            "Kursi Lipat",
                            "Megaphone",
                            "Speaker Portable",
                            "Kabel Roll 10 m",
                            "Proyektor",
                            "Bendera OSIS"
                        });
                    }
                }
            }
            catch (Exception)
            {
                databaseTerhubung = false;
                comboBox1.Items.Clear();
            }

            if (!databaseTerhubung)
            {
                comboBox1.Items.AddRange(new object[]
                {
                    "Mic Wireless",
                    "Kursi Lipat",
                    "Megaphone",
                    "Speaker Portable",
                    "Kabel Roll 10 m",
                    "Proyektor",
                    "Bendera OSIS"
                });
            }
        }

        private void TambahkanDataBarangAwal(MySqlConnection conn)
        {
            // Menambahkan data inventaris awal ketika tabel BARANG masih kosong.
            string[,] barangAwal =
            {
                { "Mic Wireless", "4", "450000", "Baik" },
                { "Kursi Lipat", "30", "120000", "Rusak Ringan" },
                { "Megaphone", "3", "300000", "Baik" },
                { "Speaker Portable", "2", "1200000", "Baik" },
                { "Kabel Roll 10 m", "5", "85000", "Baik" },
                { "Proyektor", "1", "3500000", "Baik" },
                { "Bendera OSIS", "3", "150000", "Baik" }
            };

            for (int i = 0; i < barangAwal.GetLength(0); i++)
            {
                using (MySqlCommand insert = new MySqlCommand(
                    "INSERT INTO BARANG (nama_barang, jumlah_barang, nominal_harga, keadaan_barang) VALUES (@nama, @jumlah, @harga, @kondisi)", conn))
                {
                    insert.Parameters.AddWithValue("@nama", barangAwal[i, 0]);
                    insert.Parameters.AddWithValue("@jumlah", Convert.ToInt32(barangAwal[i, 1]));
                    insert.Parameters.AddWithValue("@harga", Convert.ToDecimal(barangAwal[i, 2]));
                    insert.Parameters.AddWithValue("@kondisi", barangAwal[i, 3]);
                    insert.ExecuteNonQuery();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tanggalMinimum = dateTimePicker1.Value.Date.AddDays(1);
            dateTimePicker2.MinDate = tanggalMinimum;

            if (dateTimePicker2.Value.Date < tanggalMinimum)
            {
                dateTimePicker2.Value = tanggalMinimum;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Memvalidasi form lalu menyimpan pengajuan siswa ke dua tabel peminjaman.
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Silakan pilih barang yang ingin dipinjam.", "Data belum lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            int jumlah;
            if (!int.TryParse(domainUpDown1.Text, out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah peminjaman harus lebih dari 0.", "Data belum lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                domainUpDown1.Focus();
                return;
            }

            if (dateTimePicker2.Value.Date <= dateTimePicker1.Value.Date)
            {
                MessageBox.Show("Tanggal kembali harus setelah tanggal pinjam.", "Data belum lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Silakan isi keperluan peminjaman.", "Data belum lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (AppSession.CurrentUserId <= 0)
            {
                MessageBox.Show("Sesi siswa tidak ditemukan. Silakan login kembali.", "Sesi berakhir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!SimpanPengajuan(comboBox1.SelectedItem.ToString(), jumlah, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date))
            {
                return;
            }

            BukaHalaman(new siswa_pengajuan());
        }

        private bool SimpanPengajuan(string namaBarang, int jumlah, DateTime tanggalPinjam, DateTime tanggalKembali)
        {
            // Menyimpan header peminjaman dan detail barang dalam satu transaksi.
            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        int idBarang;
                        int stok;
                        using (MySqlCommand cariBarang = new MySqlCommand("SELECT id_barang, jumlah_barang FROM BARANG WHERE nama_barang = @nama LIMIT 1", conn, transaction))
                        {
                            cariBarang.Parameters.AddWithValue("@nama", namaBarang);
                            using (MySqlDataReader reader = cariBarang.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    MessageBox.Show("Barang tidak ditemukan di database.", "Pengajuan gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }
                                idBarang = Convert.ToInt32(reader["id_barang"]);
                                stok = Convert.ToInt32(reader["jumlah_barang"]);
                            }
                        }

                        if (jumlah > stok)
                        {
                            MessageBox.Show("Jumlah pengajuan melebihi stok barang yang tersedia.", "Stok tidak cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        long idPeminjaman;
                        using (MySqlCommand insertPeminjaman = new MySqlCommand(
                            "INSERT INTO PEMINJAMAN (id_user, tanggal_pinjam, rencana_kembali, status_persetujuan, id_pengurus_approve) " +
                            "VALUES (@user, @pinjam, @kembali, 'Pending', NULL)", conn, transaction))
                        {
                            insertPeminjaman.Parameters.AddWithValue("@user", AppSession.CurrentUserId);
                            insertPeminjaman.Parameters.AddWithValue("@pinjam", tanggalPinjam);
                            insertPeminjaman.Parameters.AddWithValue("@kembali", tanggalKembali);
                            insertPeminjaman.ExecuteNonQuery();
                            idPeminjaman = insertPeminjaman.LastInsertedId;
                        }

                        using (MySqlCommand insertDetail = new MySqlCommand(
                            "INSERT INTO DETAIL_PEMINJAMAN (id_peminjaman, id_barang, jumlah_pinjam) VALUES (@peminjaman, @barang, @jumlah)", conn, transaction))
                        {
                            insertDetail.Parameters.AddWithValue("@peminjaman", idPeminjaman);
                            insertDetail.Parameters.AddWithValue("@barang", idBarang);
                            insertDetail.Parameters.AddWithValue("@jumlah", jumlah);
                            insertDetail.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }

                MessageBox.Show("Pengajuan berhasil dikirim dan menunggu persetujuan pengurus.", "Pengajuan berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan pengajuan: " + ex.Message, "Pengajuan gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BukaHalaman(new siswa_katalog());
        }

        private void BukaHalaman(Form halaman)
        {
            Form formUtama = MdiParent;
            if (formUtama == null)
            {
                halaman.Show();
                Close();
                return;
            }

            halaman.MdiParent = formUtama;
            halaman.FormBorderStyle = FormBorderStyle.None;
            halaman.Dock = DockStyle.Fill;

            Close();
            halaman.Show();
            halaman.BringToFront();
        }
    }
}
