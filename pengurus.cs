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
    public partial class pengurus : Form
    {
        public pengurus(string namaUser)
        {
            InitializeComponent();

            
            namaPengguna.Text = namaUser;
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

                FormMasuk.FormClosed += FormMasuk_FormClosed;

                FormMasuk.Show();

                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void FormMasuk_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            foreach (Form MdiChild in this.MdiChildren)
            {
                MdiChild.Close();
            }
            DataBarang FormDataBarang = new DataBarang();

            FormDataBarang.MdiParent = this;
            FormDataBarang.FormBorderStyle = FormBorderStyle.None;
            FormDataBarang.Dock = DockStyle.Fill;

            FormDataBarang.Show();
            FormDataBarang.BringToFront();
        }

        private void btnPersetujuan_Click(object sender, EventArgs e)
        {
            foreach (Form MdiChild in this.MdiChildren)
            {
                MdiChild.Close();
            }
            Persetujuan FormPersetujuan = new Persetujuan();

            FormPersetujuan.MdiParent = this;
            FormPersetujuan.FormBorderStyle = FormBorderStyle.None;
            FormPersetujuan.Dock = DockStyle.Fill;

            FormPersetujuan.Show();
            FormPersetujuan.BringToFront();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            foreach (Form MdiChild in this.MdiChildren)
            {
                MdiChild.Close();
            }
            Pengembalian FormPengembalian = new Pengembalian();

            FormPengembalian.MdiParent = this;
            FormPengembalian.FormBorderStyle = FormBorderStyle.None;
            FormPengembalian.Dock = DockStyle.Fill;

            FormPengembalian.Show();
            FormPengembalian.BringToFront();
        }
    }
}
