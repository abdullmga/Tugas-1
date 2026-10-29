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
    public partial class Pendaftaran : Form
    {
        public Pendaftaran()
        {
            InitializeComponent();
        }
        
        private string placeholderNamaLengkap = "Masukkan Nama Lengkap";
        private string placeholderNISUsername = "Masukkan NIS atau Username";
        private string placeholderKataSandi = "Masukkan Kata Sandi";

        private void namaLengkap_Enter(object sender, EventArgs e)
        {
            string namalengkap = namaLengkap.Text;

            if (namaLengkap.Text == placeholderNamaLengkap)
            {
                namaLengkap.Text = "";
                namaLengkap.ForeColor = Color.Black;
            }
        }

        private void namaLengkap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaLengkap.Text))
            {
                namaLengkap.Text = placeholderNamaLengkap;
                namaLengkap.ForeColor = Color.Silver;
            }
        }

        private void Pendaftaran_Load(object sender, EventArgs e)
        {
            label1.Focus();

            kataSandi.Text = placeholderKataSandi;
            kataSandi.ForeColor = Color.Silver;
            kataSandi.PasswordChar = '\0';

            imgView.Visible = true;
            imgHide.Visible = false;
        }

        private void NISUsername_Enter_1(object sender, EventArgs e)
        {
            if (NISUsername.Text == placeholderNISUsername)
            {
                NISUsername.Text = "";
                NISUsername.ForeColor = Color.Black;
            }
        }

        private void NISUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NISUsername.Text))
            {
                NISUsername.Text = placeholderNISUsername;
                NISUsername.ForeColor = Color.Silver;
            }
        }

        private void kataSandi_Enter_1(object sender, EventArgs e)
        {
            if (kataSandi.Text == placeholderKataSandi)
            {
                kataSandi.Text = "";
                kataSandi.ForeColor = Color.Black;

                kataSandi.PasswordChar = '*';

            }
        }

        private void kataSandi_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kataSandi.Text))
            {
                kataSandi.Text = placeholderKataSandi;
                kataSandi.ForeColor = Color.Silver;

                kataSandi.PasswordChar = '\0';
            }
        }



        private void btnLanjutkan_Click(object sender, EventArgs e)
        {
            string namalengkap = namaLengkap.Text;
            string nisusername = NISUsername.Text;
            string katasandi = kataSandi.Text;


            if (string.IsNullOrWhiteSpace(namalengkap) || namalengkap == placeholderNamaLengkap ||
                string.IsNullOrWhiteSpace(nisusername) || nisusername == placeholderNISUsername ||
                string.IsNullOrWhiteSpace(katasandi) || katasandi == placeholderKataSandi)
            {
                MessageBox.Show("Harap Isi Seluruh Input Pendaftaran", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            string query = @"INSERT INTO `USER` (nama_user, username, password, role) VALUES (@nama_user, @username, @password, @role)";
            try
            {
                DatabaseConnection db = new DatabaseConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_user", namalengkap);
                        cmd.Parameters.AddWithValue("@username", nisusername);
                        cmd.Parameters.AddWithValue("@password", katasandi);
                        cmd.Parameters.AddWithValue("@role", "pengurus");

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pendaftaran Berhasil!");

                Masuk FormMasuk = new Masuk();

                FormMasuk.Show();

                FormMasuk.FormClosed += FormMasuk_FormClosed;

                this.Hide();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "Username sudah digunakan! Silakan pilih username lain.",
                        "Pendaftaran Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Pendaftaran gagal: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                return;
            }
        }

        private void FormMasuk_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void imgView_Click(object sender, EventArgs e)
        {
            if (kataSandi.Text != placeholderKataSandi)
            {
                kataSandi.PasswordChar = '\0';
            }

            imgHide.Visible = true;
            imgView.Visible = false;
        }

        private void imgHide_Click(object sender, EventArgs e)
        {
            if (kataSandi.Text != placeholderKataSandi)
            {
                kataSandi.PasswordChar= '*';
            }
            

            imgHide.Visible = false;
            imgView.Visible = true;
        }
    }
}
