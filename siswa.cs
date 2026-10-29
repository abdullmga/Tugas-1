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
    public partial class siswa : Form
    {

        public siswa(string namaUser)
        {
            InitializeComponent();

            namaPengguna.Text = namaUser;
        }

        private void btn_katalog_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }

            siswa_katalog katalog = new siswa_katalog();

            katalog.MdiParent = this;
            katalog.FormBorderStyle = FormBorderStyle.None; 
            katalog.Dock = DockStyle.Fill;                  

            katalog.Show();
            katalog.BringToFront();
        }

        private void siswa_Load(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }

            siswa_katalog katalog = new siswa_katalog();

            katalog.MdiParent = this;
            katalog.FormBorderStyle = FormBorderStyle.None;
            katalog.Dock = DockStyle.Fill;

            katalog.Show();
            katalog.BringToFront();
        }

        private void btn_pengajuan_barang_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
            siswa_pengajuan pengajuan = new siswa_pengajuan();

            pengajuan.MdiParent = this;
            pengajuan.FormBorderStyle = FormBorderStyle.None;
            pengajuan.Dock = DockStyle.Fill;

            pengajuan.Show();
            pengajuan.BringToFront();
            
        }

        private void btn_pinjam_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
            siswa_pinjam pinjam = new siswa_pinjam();

            pinjam.MdiParent = this;
            pinjam.FormBorderStyle = FormBorderStyle.None;
            pinjam.Dock = DockStyle.Fill;

            pinjam.Show();
            pinjam.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }

            notifikasi notif = new notifikasi();

            notif.MdiParent = this;
            notif.FormBorderStyle = FormBorderStyle.None;
            notif.Dock = DockStyle.Fill;

            notif.Show();
            notif.BringToFront();

        }

        private void labelKeluar_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show
                ("Apakah yakin kamu mau kelauar?",
                "Konfirmasi keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                Masuk FormMasuk = new Masuk();

                FormMasuk.FormClosed += KembaliKeFormMasuk_FormClosed;

                FormMasuk.Show();

                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void KembaliKeFormMasuk_FormClosed(object sender, FormClosedEventArgs e)
        {            
            this.Close();
        }
    }
}