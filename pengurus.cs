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

        private void btn_data_barang_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }

            pengurus_data_barang dataBarang = new pengurus_data_barang();

            dataBarang.MdiParent = this;
            dataBarang.FormBorderStyle = FormBorderStyle.None;
            dataBarang.Dock = DockStyle.Fill;

            dataBarang.Show();
            dataBarang.BringToFront();
        }

        private void pengurus_Load(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }

            pengurus_data_barang dataBarang = new pengurus_data_barang();

            dataBarang.MdiParent = this;
            dataBarang.FormBorderStyle = FormBorderStyle.None;
            dataBarang.Dock = DockStyle.Fill;

            dataBarang.Show();
            dataBarang.BringToFront();
        }
    }
}
