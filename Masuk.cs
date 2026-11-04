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
    public partial class Masuk : Form
    {
        public Masuk()
        {
            InitializeComponent();
        }

        private string placeholderUsernameatauNISN = "Masukkan Username atau NISN";
        private string placeholderKataSandi = "Masukkan Kata Sandi";


        private void Masuk_Load(object sender, EventArgs e)
        {
            label1.Focus();

            kataSandi.Text = placeholderKataSandi;
            kataSandi.ForeColor = Color.Silver;
            kataSandi.PasswordChar = '\0';

            imgView.Visible = true;
            imgHide.Visible = false;

        }

        private void NISUsername_Enter(object sender, EventArgs e)
        {
            if (NISUsername.Text == placeholderUsernameatauNISN)
            {
                NISUsername.Text = "";
                NISUsername.ForeColor = Color.Black;
            }
        }

        private void NISUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NISUsername.Text))
            {
                NISUsername.Text = placeholderUsernameatauNISN;
                NISUsername.ForeColor = Color.Silver;
            }
        }

        private void kataSandi_Enter(object sender, EventArgs e)
        {
            if (kataSandi.Text == placeholderKataSandi)
            {
                kataSandi.Text = "";
                kataSandi.ForeColor = Color.Black;

                kataSandi.PasswordChar = '*';

            }
        }

        private void kataSandi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kataSandi.Text))
            {
                kataSandi.Text = placeholderKataSandi;
                kataSandi.ForeColor = Color.Silver;

                kataSandi.PasswordChar = '\0';
            }
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
                kataSandi.PasswordChar = '*';
            }

            imgHide.Visible = false;
            imgView.Visible = true;
        }

        private void daftar_Click(object sender, EventArgs e)
        {
            Pendaftaran FormPendaftaran = new Pendaftaran();

            FormPendaftaran.FormClosed += FormPendaftaran_FormClosed;

            FormPendaftaran.Show();

            this.Hide();
        }

        private void FormPendaftaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            string usernameataunisn = NISUsername.Text;
            string katasandi = kataSandi.Text;
            

            if (string.IsNullOrWhiteSpace(usernameataunisn) || usernameataunisn == placeholderUsernameatauNISN ||
                string.IsNullOrWhiteSpace(katasandi) || katasandi == placeholderKataSandi)
            {
                MessageBox.Show("Harap Isi Seluruh Input Masuk",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information); 
                return;

            }
            
            string query = @"SELECT id_user, nama_user, password, role FROM `USER` WHERE username=@username OR nisn=@nisn";

            try
            {
                DatabaseConnection db = new DatabaseConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", usernameataunisn);
                        cmd.Parameters.AddWithValue("@nisn", usernameataunisn);

                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            if (reader.Read())
                            {
                                string namaUser = reader.GetString("nama_user");
                                string role = reader.GetString("role");
                                string katasandiHashdiDB = reader.GetString("password");

                                if (BCrypt.Net.BCrypt.Verify(katasandi, katasandiHashdiDB))
                                {
                                    MessageBox.Show("Login berhasil! Selamat datang, " + namaUser);

                                    if (role == "siswa")
                                    {

                                        siswa FormSiswa = new siswa(namaUser);

                                        FormSiswa.FormClosed += FormSiswa_FormClosed;

                                        FormSiswa.Show();

                                        this.Hide();
                                    }
                                    else if (role == "pengurus")
                                    {

                                        pengurus FormPengurus = new pengurus(namaUser);

                                        FormPengurus.FormClosed += FormPengurus_FormClosed;

                                        FormPengurus.Show();

                                        this.Hide();
                                    }
                                    else if (role == "pembina")
                                    {

                                        pembina FormPembina = new pembina(namaUser);

                                        FormPembina.FormClosed += FormPembina_FormClosed;

                                        FormPembina.Show();

                                        this.Hide();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Role tidak valid!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Kata sandi salah!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username / NISN tidak ditemukan!");
                            }
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan database: " + ex.Message);
            }
        }

        private void FormPembina_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FormPengurus_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FormSiswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
