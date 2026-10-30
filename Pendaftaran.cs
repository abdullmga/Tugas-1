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
using BCrypt.Net;

namespace Tugas_1
{
    public partial class Pendaftaran : Form
    {
        public Pendaftaran()
        {
            InitializeComponent();
        }
        
        private string placeholderNamaLengkap = "Masukkan Nama Lengkap";
        private string placeholderNISN = "Masukkan NISN";
        private string placeholderUsername = "Masukkan Username";
        private string placeholderKataSandi = "Masukkan Kata Sandi";
        private string placeholderUlangKataSandi = "Masukkan Kata Sandi Lagi";

        private void namaLengkap_Enter(object sender, EventArgs e)
        {
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

            UlangiKataSandi.Text = placeholderUlangKataSandi;
            UlangiKataSandi.ForeColor = Color.Silver;
            UlangiKataSandi.PasswordChar = '\0';
            

            imgView.Visible = true;
            imgHide.Visible = false;

            imgView1.Visible = true;
            imgHide1.Visible = false;
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
            string nisn = NISN.Text;
            string username = Username.Text;
            string katasandi = kataSandi.Text;
            string ulangikatasandi = UlangiKataSandi.Text;

                    if (string.IsNullOrWhiteSpace(namalengkap) || namalengkap == placeholderNamaLengkap ||
                    string.IsNullOrWhiteSpace(username) || username == placeholderUsername ||
                    string.IsNullOrWhiteSpace(nisn) || nisn == placeholderNISN ||
                    string.IsNullOrWhiteSpace(katasandi) || katasandi == placeholderKataSandi ||
                    string.IsNullOrWhiteSpace(ulangikatasandi) || ulangikatasandi == placeholderUlangKataSandi)
                    {
                        MessageBox.Show("Harap Isi Seluruh Input Pendaftaran!", 
                            "Peringatan", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information); 
                        return;
                    }
                
            if (nisn.Length != 10)
            {
                MessageBox.Show("NISN wajib terdiri dari 10 digit angka!"); 
                return;
            }
            if (katasandi != ulangikatasandi)
            {
                MessageBox.Show("Password tidak sama!");
                return;
            }
            string katasandiHash = BCrypt.Net.BCrypt.HashPassword(katasandi);

            string query = @"INSERT INTO `USER` (nama_user, nisn, username, password, role) VALUES (@nama_user, @nisn, @username, @password, @role)";
            try
            {
                DatabaseConnection db = new DatabaseConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_user", namalengkap);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@nisn", nisn);
                        cmd.Parameters.AddWithValue("@password", katasandiHash);
                        cmd.Parameters.AddWithValue("@role", "siswa");

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pendaftaran Berhasil!");

                Masuk FormMasuk = new Masuk();

                FormMasuk.FormClosed += FormMasuk_FormClosed;

                FormMasuk.Show();

                this.Hide();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "Username atau NISN sudah digunakan!",
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

        private void NISN_Enter(object sender, EventArgs e)
        {
            if (NISN.Text == placeholderNISN)
            {
                NISN.Text = "";
                NISN.ForeColor = Color.Black;
            }
        }

        private void NISN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NISN.Text))
            {
                NISN.Text = placeholderNISN;
                NISN.ForeColor = Color.Silver;
            }
        }

        private void UlangiKataSandi_Enter(object sender, EventArgs e)
        {
            if (UlangiKataSandi.Text == placeholderUlangKataSandi)
            {
                UlangiKataSandi.Text = "";
                UlangiKataSandi.ForeColor = Color.Black;

                UlangiKataSandi.PasswordChar = '*';
            }
        }

        private void UlangiKataSandi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UlangiKataSandi.Text))
            {
                UlangiKataSandi.Text = placeholderUlangKataSandi;
                UlangiKataSandi.ForeColor = Color.Silver;

                UlangiKataSandi.PasswordChar = '\0';
            }
        }

        private void imgView1_Click(object sender, EventArgs e)
        {
            if (UlangiKataSandi.Text != placeholderUlangKataSandi)
            {
                UlangiKataSandi.PasswordChar = '\0';

                imgHide1.Visible = true;
                imgView1.Visible = false;
            }
        }

        private void imgHide1_Click(object sender, EventArgs e)
        {
            if (UlangiKataSandi.Text != placeholderUlangKataSandi)
            {
                UlangiKataSandi.PasswordChar = '*';

                imgHide1.Visible = false;
                imgView1.Visible = true;
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == placeholderUsername)
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username.Text))
            {
                Username.Text = placeholderUsername;
                Username.ForeColor = Color.Silver;
            }
        }

        private void NISN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
