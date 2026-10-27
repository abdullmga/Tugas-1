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
    public partial class SelamatDatang : Form
    {
        public SelamatDatang()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            Masuk FormMasuk = new Masuk();

            FormMasuk.Show();

            FormMasuk.FormClosed += FormMasuk_FormClosed;

            this.Hide();
        }

        private void FormMasuk_FormClosed(object sender, FormClosedEventArgs e)
        {
           this.Close();
        }

        private void btnPendaftaran_Click(object sender, EventArgs e)
        {
            Pendaftaran FormPendaftaran = new Pendaftaran();

            FormPendaftaran.Show();

            FormPendaftaran.FormClosed += FormPendaftaran_FormClosed;

            this.Hide();
        }

        private void FormPendaftaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection db = new DatabaseConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MessageBox.Show("Berhasil terhubung ke database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database" + ex.Message);
            }
        }
    }
}
