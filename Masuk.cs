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
    public partial class Masuk : Form
    {
        public Masuk()
        {
            InitializeComponent();
        }

        private string placeholderNISUsername = "Masukkan NIS atau Username";
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

            FormPendaftaran.Show();

            FormPendaftaran.FormClosed += FormPendaftaran_FormClosed;

            this.Hide();
        }

        private void FormPendaftaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
