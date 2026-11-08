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
    // Menampilkan dan mengelola daftar barang inventaris untuk pengurus.
    public partial class DataBarang : Form
    {
        public DataBarang()
        {
            InitializeComponent();
            txtsearch_siswa.Enter += txtsearch_siswa_Enter;
            txtsearch_siswa.Leave += txtsearch_siswa_Leave;
            txtsearch_siswa.TextChanged += txtsearch_siswa_TextChanged;
            cmb_siswa.SelectedIndexChanged += cmb_siswa_SelectedIndexChanged;
            dataGridView1.Columns.Insert(0, new DataGridViewTextBoxColumn
            {
                Name = "id_barang",
                HeaderText = "ID",
                Visible = false,
                ReadOnly = true
            });
        }

        private void DataBarang_Load(object sender, EventArgs e)
        {
            TerapkanTampilan();
            LoadDataBarang();
        }

        public void LoadDataBarang()
        {
            // Mengambil barang dari database berdasarkan kata kunci dan kondisi.
            string keyword = txtsearch_siswa.Text == "Cari nama barang..." ? string.Empty : txtsearch_siswa.Text.Trim();
            string filterKondisi = cmb_siswa.Text == "Semua kondisi" ? string.Empty : cmb_siswa.Text;

            dataGridView1.Rows.Clear();

            this.FormBorderStyle = FormBorderStyle.None;

            string query = "SELECT id_barang, nama_barang, jumlah_barang, nominal_harga, keadaan_barang FROM BARANG " +
                "WHERE nama_barang LIKE @keyword AND (@kondisi = '' OR keadaan_barang = @kondisi) " +
                "ORDER BY nama_barang";

            DatabaseConnection db = new DatabaseConnection();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        cmd.Parameters.AddWithValue("@kondisi", filterKondisi);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    string nama = reader["nama_barang"].ToString();
                                    string jumlah = reader["jumlah_barang"].ToString();
                                    decimal hargaDecimal = Convert.ToDecimal(reader["nominal_harga"]);
                                    string harga = "Rp " + hargaDecimal.ToString("N0");
                                    string kondisiBarang = reader["keadaan_barang"].ToString();
                                    string statusBarang = Convert.ToInt32(reader["jumlah_barang"]) > 0 ? "Tersedia" : "Habis";

                                    dataGridView1.Rows.Add(reader["id_barang"], nama, jumlah, harga, kondisiBarang, statusBarang, "Edit");
                                }

                                label4.Visible = false;
                                dataGridView1.Visible = true;
                            }
                            else
                            {
                                label4.Visible = true;
                                dataGridView1.Visible = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data barang: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TerapkanTampilan()
        {
            // Mengatur warna, font, dan gaya tabel agar sesuai rancangan UI.
            BackColor = Color.FromArgb(244, 246, 250);
            panel1.BackColor = Color.White;
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTambahBarang.BackColor = Color.FromArgb(30, 58, 138);
            btnTambahBarang.FlatAppearance.BorderSize = 0;
            btnTambahBarang.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnTambahBarang.Cursor = Cursors.Hand;

            txtsearch_siswa.Font = new Font("Segoe UI", 8.5F);
            txtsearch_siswa.BorderStyle = BorderStyle.FixedSingle;
            cmb_siswa.Font = new Font("Segoe UI", 8.5F);
            cmb_siswa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_siswa.SelectedIndex = 0;

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.FromArgb(229, 231, 235);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(75, 85, 99);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
            dataGridView1.RowTemplate.Height = 34;
        }

        private void txtsearch_siswa_Enter(object sender, EventArgs e)
        {
            if (txtsearch_siswa.Text == "Cari nama barang...")
            {
                txtsearch_siswa.Clear();
                txtsearch_siswa.ForeColor = Color.FromArgb(31, 41, 55);
            }
        }

        private void txtsearch_siswa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearch_siswa.Text))
            {
                txtsearch_siswa.Text = "Cari nama barang...";
                txtsearch_siswa.ForeColor = Color.Silver;
            }
        }

        private void txtsearch_siswa_TextChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated && txtsearch_siswa.Text != "Cari nama barang...")
            {
                LoadDataBarang();
            }
        }

        private void cmb_siswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                LoadDataBarang();
            }
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            BukaPopupBarang(0);
        }

        private void FormPopUpTambahBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDataBarang();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string namaKolom = dataGridView1.Columns[e.ColumnIndex].Name;

            if (namaKolom == "edit_barang")
            {
                int idBarang = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_barang"].Value);
                BukaPopupBarang(idBarang);
            }
        }

        private void BukaPopupBarang(int idBarang)
        {
            // Membuka popup tambah atau edit berdasarkan ID barang.
            PopUpTambahBarang popup = new PopUpTambahBarang(idBarang);
            popup.FormClosed += FormPopUpTambahBarang_FormClosed;
            popup.ShowDialog(this);
        }
    }
}
