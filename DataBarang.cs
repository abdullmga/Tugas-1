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
    public partial class DataBarang : Form
    {
        public DataBarang()
        {
            InitializeComponent();
        }

        private void DataBarang_Load(object sender, EventArgs e)
        {
            LoadDataBarang();
        }

        public void LoadDataBarang()
        {
            dataGridView1.Rows.Clear();

            this.FormBorderStyle = FormBorderStyle.None;

            string query = "SELECT nama_barang, jumlah_barang, nominal_harga, keadaan_barang FROM BARANG";

            DatabaseConnection db = new DatabaseConnection();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    string nama = reader["nama_barang"].ToString();
                                    string jumlah = reader["jumlah_barang"].ToString();
                                    decimal hargaDecimal = Convert.ToDecimal(reader["nominal_harga"]);
                                    string harga = "Rp " + hargaDecimal.ToString();
                                    string kondisi = reader["keadaan_barang"].ToString();
                                    
                                    dataGridView1.Rows.Add(nama, jumlah, harga, kondisi, "Dipinjam", "Edit");
                                }

                                label4.Visible = false;
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

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            PopUpTambahBarang FormPopUpTambahBarang = new PopUpTambahBarang();

            FormPopUpTambahBarang.FormClosed += FormPopUpTambahBarang_FormClosed;

            FormPopUpTambahBarang.Show();

        }

        private void FormPopUpTambahBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopUpTambahBarang FormPopUpTambahBarang = new PopUpTambahBarang();
            FormPopUpTambahBarang.Close();
        }

        private void HapusDataDatabase(string namaBarang)
        {
            string query = "DELETE FROM BARANG WHERE nama_barang = @nama";
            DatabaseConnection db = new DatabaseConnection();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", namaBarang);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil dihapus dari database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string namaKolom = dataGridView1.Columns[e.ColumnIndex].Name;

            if (namaKolom == "edit_barang")
            {
                PopUpTambahBarang FormPopUpTambahBarang = new PopUpTambahBarang();

                FormPopUpTambahBarang.FormClosed += FormPopUpTambahBarang_FormClosed;

                FormPopUpTambahBarang.Show();
            }
        }
    }
}
