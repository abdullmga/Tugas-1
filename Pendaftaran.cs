using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (string.IsNullOrWhiteSpace(namaLengkap.Text) || namaLengkap.Text == placeholderNamaLengkap ||
                string.IsNullOrWhiteSpace(NISUsername.Text) || NISUsername.Text == placeholderNISUsername ||
                string.IsNullOrWhiteSpace(kataSandi.Text) || kataSandi.Text == placeholderKataSandi)
            {
                MessageBox.Show("Harap Isi Seluruh Input Pendaftaran", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            MessageBox.Show("Pendaftaran Berhasil!");
            

            Masuk FormMasuk = new Masuk();
            FormMasuk.Show();

            this.Close();

        }

        private void imgView_Click(object sender, EventArgs e)
        {
            kataSandi.PasswordChar = '\0';

            imgHide.Visible = true;
            imgView.Visible = false;

            kataSandi.Focus();
            kataSandi.SelectionStart = kataSandi.Text.Length;
        }

        private void imgHide_Click(object sender, EventArgs e)
        {
            kataSandi.PasswordChar = '*';

            imgHide.Visible = false;
            imgView.Visible = true;

            kataSandi.Focus();
            kataSandi.SelectionStart = kataSandi.Text.Length;
        }
    }
}
