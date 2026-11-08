using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Tugas_1
{
    // Form popup untuk tambah, edit, dan hapus data BARANG.
    public partial class PopUpTambahBarang : Form
    {
        private readonly int idBarang;

        public PopUpTambahBarang() : this(0)
        {
        }

        public PopUpTambahBarang(int idBarang)
        {
            InitializeComponent();
            this.idBarang = idBarang;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        private void PopUpTambahBarang_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Baik", "Rusak Ringan", "Rusak" });
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 1000000;
            textBox2.ReadOnly = true;
            textBox2.Text = "Aktif";

            if (idBarang > 0)
            {
                Text = "Edit Barang";
                button1.Text = "UPDATE";
                button2.Text = "HAPUS";
                MuatBarang();
            }
            else
            {
                Text = "Tambah Barang";
                button2.Text = "BATAL";
                comboBox1.SelectedIndex = 0;
            }
        }

        private void MuatBarang()
        {
            // Mengisi kontrol popup dengan data barang yang sedang diedit.
            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("SELECT nama_barang, jumlah_barang, nominal_harga, keadaan_barang FROM BARANG WHERE id_barang = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idBarang);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return;
                        textBox1.Text = reader["nama_barang"].ToString();
                        numericUpDown1.Value = Convert.ToDecimal(reader["jumlah_barang"]);
                        textBox3.Text = Convert.ToDecimal(reader["nominal_harga"]).ToString("0.##", CultureInfo.InvariantCulture);
                        comboBox1.SelectedItem = reader["keadaan_barang"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat barang: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Memvalidasi input lalu menjalankan INSERT atau UPDATE barang.
            string nama = textBox1.Text.Trim();
            decimal harga;
            if (string.IsNullOrWhiteSpace(nama) || numericUpDown1.Value < 0 ||
                !decimal.TryParse(textBox3.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out harga) || harga < 0 ||
                comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Lengkapi nama, jumlah, harga, dan kondisi barang dengan benar.", "Data belum lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = idBarang > 0
                ? "UPDATE BARANG SET nama_barang = @nama, jumlah_barang = @jumlah, nominal_harga = @harga, keadaan_barang = @kondisi WHERE id_barang = @id"
                : "INSERT INTO BARANG (nama_barang, jumlah_barang, nominal_harga, keadaan_barang) VALUES (@nama, @jumlah, @harga, @kondisi)";
            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@jumlah", Convert.ToInt32(numericUpDown1.Value));
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@kondisi", comboBox1.SelectedItem.ToString());
                    if (idBarang > 0) cmd.Parameters.AddWithValue("@id", idBarang);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show(idBarang > 0 ? "Data barang berhasil diperbarui." : "Barang berhasil ditambahkan.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan barang: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Membatalkan tambah atau menghapus barang saat mode edit.
            if (idBarang <= 0)
            {
                Close();
                return;
            }

            if (MessageBox.Show("Hapus barang ini? Riwayat peminjaman barang tidak boleh sedang menggunakannya.", "Konfirmasi hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM BARANG WHERE id_barang = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idBarang);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Barang berhasil dihapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Barang tidak dapat dihapus karena sudah memiliki riwayat peminjaman atau masih digunakan. " + ex.Message, "Hapus gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus barang: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
