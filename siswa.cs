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
    public partial class siswa : Form
    {

        public siswa()
        {
            InitializeComponent();
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
    }
}