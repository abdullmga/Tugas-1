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
    // Menampilkan katalog barang yang bersumber dari stok database.
    public partial class siswa_katalog : Form
    {
        public siswa_katalog()
        {
            InitializeComponent();
        }

        private void siswa_katalog_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            dataGridView1.Rows.Clear();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (!MuatBarangDatabase())
            {
                TambahBarang("Mic Wireless", 4, 450000, "Baik");
                TambahBarang("Kursi Lipat", 30, 120000, "Rusak Ringan");
                TambahBarang("Megaphone", 0, 300000, "Rusak");
            }
        }

        private bool MuatBarangDatabase()
        {
            // Membaca barang terbaru agar katalog siswa sama dengan data pengurus.
            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("SELECT nama_barang, jumlah_barang, nominal_harga, keadaan_barang FROM BARANG ORDER BY nama_barang", conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool adaData = false;
                        while (reader.Read())
                        {
                            adaData = true;
                            TambahBarang(reader["nama_barang"].ToString(), Convert.ToInt32(reader["jumlah_barang"]), Convert.ToDecimal(reader["nominal_harga"]), reader["keadaan_barang"].ToString());
                        }
                        return adaData;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Katalog menggunakan data contoh karena database tidak dapat diakses: " + ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void TambahBarang(string namaBarang, int stok, decimal harga, string kondisi)
        {
            // Menambahkan satu baris barang ke tabel katalog siswa.
            string status;
            string teksTombol;

            if (stok > 0)
            {
                status = "Tersedia";
                teksTombol = "Pinjam";
            }
            else
            {
                status = "Habis";
                teksTombol = "Pinjam";
            }

            dataGridView1.Rows.Add(namaBarang, stok, "Rp " + harga.ToString("N0"), kondisi, teksTombol);
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["aksi_barang"].Index && e.RowIndex >= 0)
            {
                int stok = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["jumlah_barang"].Value);

                if (stok <= 0)
                {
                    e.CellStyle.BackColor = Color.FromArgb(230, 232, 235);
                    e.CellStyle.ForeColor = Color.FromArgb(170, 175, 185);
                    e.CellStyle.SelectionBackColor = Color.FromArgb(230, 232, 235);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(170, 175, 185);
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(24, 43, 114);
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.SelectionBackColor = Color.FromArgb(24, 43, 114);
                    e.CellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Membuka form pengajuan ketika siswa memilih tombol Pinjam.
            if (e.ColumnIndex == dataGridView1.Columns["aksi_barang"].Index && e.RowIndex >= 0)
            {
                int stok = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["jumlah_barang"].Value);
                string namaBarang = dataGridView1.Rows[e.RowIndex].Cells["nama_barang"].Value?.ToString();

                if (stok <= 0)
                {
                    MessageBox.Show($"Maaf, barang '{namaBarang}' sedang habis!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Form formUtama = this.MdiParent;
                if (formUtama == null)
                {
                    return;
                }
                siswa_pinjam formPinjam = new siswa_pinjam(namaBarang);
                formPinjam.MdiParent = formUtama;
                formPinjam.FormBorderStyle = FormBorderStyle.None;
                formPinjam.Dock = DockStyle.Fill;

                this.Close();
                formPinjam.Show();
                formPinjam.BringToFront();
            }
        }

        private void FilterData()
        {
            string keyword = txtsearch_siswa.Text.Trim();
            string kondisiPilihan = cmb_siswa.SelectedItem?.ToString();

            if (keyword == "Cari nama barang...")
            {
                keyword = string.Empty;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string namaBarang = row.Cells["nama_barang"].Value?.ToString() ?? string.Empty;
                string kondisiBarang = row.Cells["kondisi_barang"].Value?.ToString() ?? string.Empty;

                bool cocokNama = string.IsNullOrEmpty(keyword)
                    || namaBarang.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
                bool cocokKondisi = string.IsNullOrEmpty(kondisiPilihan)
                    || kondisiPilihan == "Semua kondisi"
                    || kondisiBarang == kondisiPilihan;

                row.Visible = cocokNama && cocokKondisi;
            }
        }

        private void txtsearch_siswa_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cmb_siswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtsearch_siswa_Enter(object sender, EventArgs e)
        {
            if (txtsearch_siswa.Text == "Cari nama barang...")
            {
                txtsearch_siswa.Text = "";
                txtsearch_siswa.ForeColor = Color.Black;
            }
        }

        private void txtsearch_siswa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearch_siswa.Text))
            {
                txtsearch_siswa.Text = "Cari nama barang...";
                txtsearch_siswa.ForeColor = Color.Gray;
            }
        }
    }
}