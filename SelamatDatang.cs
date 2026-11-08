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
    // Menampilkan halaman pembuka dan menyediakan akses login atau pendaftaran.
    public partial class SelamatDatang : Form
    {
        public SelamatDatang()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            // Membuka form login dan menyembunyikan halaman pembuka.
            // Membuat objek baru dari class Masuk ke variabel FormMasuk
            Masuk FormMasuk = new Masuk();

            // Saat FormMasuk di close kita tutup juga form yang terbuka saat ini 
            FormMasuk.FormClosed += FormMasuk_FormClosed;

            // tampilkan form masuk ke layar
            FormMasuk.Show();

            // sembunyikan form yang terbuka saat ini (tetapi form masih aktif di belakang layar)
            this.Hide();
        }

        private void FormMasuk_FormClosed(object sender, FormClosedEventArgs e)
        {
           // tutup form yang pertama kali di buka yang di sembunyikan yaitu Form SelamatDatang
           this.Close();
        }

        private void btnPendaftaran_Click(object sender, EventArgs e)
        {
            // Membuka form pendaftaran akun siswa baru.
            Pendaftaran FormPendaftaran = new Pendaftaran();

            FormPendaftaran.FormClosed += FormPendaftaran_FormClosed;

            FormPendaftaran.Show();

            this.Hide();
        }

        private void FormPendaftaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
