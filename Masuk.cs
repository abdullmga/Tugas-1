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
    // Menangani proses login siswa dan pengurus menggunakan data USER.
    public partial class Masuk : Form
    {
        public Masuk()
        {
            InitializeComponent();
        }

        // Variabel untuk menyimpan teks placeholder pada input Username/NISN dan Kata Sandi
        private string placeholderUsernameatauNISN = "Masukkan Username atau NISN";
        private string placeholderKataSandi = "Masukkan Kata Sandi";

        private void Masuk_Load(object sender, EventArgs e)
        {
            // Menyiapkan placeholder dan kondisi awal input password.
            // Memindahkan fokus awal ke label agar TextBox tidak langsung aktif/menyorot teks
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
            // Memvalidasi kredensial, mengisi session, lalu membuka dashboard sesuai role.
            // Mengambil nilai teks dari kontrol input form
            string usernameataunisn = NISUsername.Text;
            string katasandi = kataSandi.Text;

            // Validasi pengecekan apakah input masih kosong atau masih berisi teks placeholder
            if (string.IsNullOrWhiteSpace(usernameataunisn) || usernameataunisn == placeholderUsernameatauNISN ||
                string.IsNullOrWhiteSpace(katasandi) || katasandi == placeholderKataSandi)
            {
                // Menampilkan pesan peringatan jika input belum lengkap diisi
                MessageBox.Show("Harap Isi Seluruh Input Masuk",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Perintah query SQL untuk mencari data user berdasarkan username atau NISN
            string query = @"SELECT id_user, nama_user, password, role FROM `USER` WHERE username=@username OR nisn=@nisn";

            try
            {

                DatabaseConnection db = new DatabaseConnection();

                // Membuka koneksi database MySQL menggunakan blok using untuk manajemen memori otomatis
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", usernameataunisn);
                        cmd.Parameters.AddWithValue("@nisn", usernameataunisn);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Memeriksa apakah baris data akun ditemukan di dalam database
                            if (reader.Read())
                            {
                                // Mengambil informasi data spesifik dari kolom database yang sesuai
                                int idUser = reader.GetInt32("id_user");
                                string namaUser = reader.GetString("nama_user");
                                string role = reader.GetString("role");
                                string katasandiHashdiDB = reader.GetString("password");

                                // Memverifikasi kecocokan kata sandi teks biasa dengan hash terenkripsi BCrypt di database
                                if (BCrypt.Net.BCrypt.Verify(katasandi, katasandiHashdiDB))
                                {
                                    AppSession.CurrentUserId = idUser;
                                    AppSession.CurrentUserName = namaUser;
                                    AppSession.CurrentUserRole = role;

                                    // Memeriksa hak role dari pengguna yang berhasil login
                                    if (role == "siswa")
                                    {
                                        // Membuka form dashboard siswa dan mengirimkan parameter nama user
                                        siswa FormSiswa = new siswa(namaUser);
                                        FormSiswa.FormClosed += FormSiswa_FormClosed;
                                        FormSiswa.Show();
                                        this.Hide();
                                    }
                                    else if (role == "pengurus")
                                    {
                                        // Membuka form dashboard pengurus dan mengirimkan parameter nama user
                                        pengurus FormPengurus = new pengurus(namaUser);
                                        FormPengurus.FormClosed += FormPengurus_FormClosed;
                                        FormPengurus.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        // Pesan error jika level role di database tidak dikenali
                                        MessageBox.Show("Role tidak valid!");
                                    }
                                }
                                else
                                {
                                    // Pesan peringatan jika kata sandi yang dimasukkan salah
                                    MessageBox.Show("Kata sandi salah!");
                                }
                            }
                            else
                            {
                                // Pesan peringatan jika data username atau NISN tidak terdaftar di sistem
                                MessageBox.Show("Username / NISN tidak ditemukan!");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Menangkap dan menampilkan pesan error apabila terjadi kendala koneksi atau eksekusi database
                MessageBox.Show("Terjadi kesalahan database: " + ex.Message);
            }
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