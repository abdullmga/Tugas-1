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
    // Dashboard pembina untuk memantau data inventaris dan laporan.
    public partial class pembina : Form
    {
        public pembina(string namaUser)
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

        private void btnDashboarddanLaporan_Click(object sender, EventArgs e)
        {
            DataBarang();
        }

        private void btnKatalogBarang_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }

            siswa_katalog FormKatalogBarang = new siswa_katalog();

            FormKatalogBarang.MdiParent = this;
            
            FormKatalogBarang.Dock = DockStyle.Fill;

            FormKatalogBarang.Show();

            FormKatalogBarang.BringToFront();
        }

        private void pembina_Load(object sender, EventArgs e)
        {
            DataBarang();
        }
        private void DataBarang()
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
            pembina_dashboard_laporan dashboardAndLaporan = new pembina_dashboard_laporan();

            dashboardAndLaporan.MdiParent = this;

            dashboardAndLaporan.Dock = DockStyle.Fill;

            dashboardAndLaporan.Show();

            dashboardAndLaporan.BringToFront();
        }
    }
}
