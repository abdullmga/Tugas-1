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
    // Dashboard pengurus yang mengatur navigasi pengelolaan barang dan peminjaman.
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
            BukaHalaman(new DataBarang());
        }

        private void btn_pengajuan_barang_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Persetujuan());
        }

        private void btn_pinjam_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Pengembalian());
        }

        private void BukaHalaman(Form halaman)
        {
            // Menutup child MDI lama agar hanya satu halaman pengurus yang aktif.
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }

            halaman.MdiParent = this;
            halaman.FormBorderStyle = FormBorderStyle.None;
            halaman.Dock = DockStyle.Fill;
            halaman.Show();
            halaman.BringToFront();
        }

        private void pengurus_Load(object sender, EventArgs e)
        {
            BukaHalaman(new DataBarang());
        }
    }
}
