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
                                    string kondisi = reader["keadaan_barang"].ToString();
                                    decimal hargaDecimal = Convert.ToDecimal(reader["nominal_harga"]);
                                    string harga = "Rp " + hargaDecimal.ToString();
                                    dataGridView1.Rows.Add(nama, jumlah, harga, kondisi, "Edit", "Hapus");
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

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string namaKolom = dataGridView1.Columns[e.ColumnIndex].Name;

            string namaBarang = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (namaKolom == "hapus_barang")
            {
                DialogResult tanya = MessageBox.Show($"Apakah kamu yakin ingin menghapus barang '{namaBarang}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (tanya == DialogResult.Yes)
                {
                    HapusDataDatabase(namaBarang);
                    LoadDataBarang();
                }
            }
            else if (namaKolom == "edit_barang")
            {
                string jumlahBarang = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string kondisiBarang = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                MessageBox.Show($"Membuka form edit untuk barang: {namaBarang}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

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
    }
}
