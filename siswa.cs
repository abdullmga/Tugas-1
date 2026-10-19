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
            siswa_katalog katalog = new siswa_katalog();

            katalog.MdiParent = this;

            katalog.Show();
            katalog.Dock = DockStyle.Fill;
            katalog.BringToFront();
            katalog.WindowState = FormWindowState.Maximized;
        }

        private void siswa_Load(object sender, EventArgs e)
        {
            siswa_katalog katalog = new siswa_katalog();

            katalog.MdiParent = this;

            katalog.Show();
            katalog.Dock = DockStyle.Fill;
            katalog.BringToFront();
            katalog.WindowState = FormWindowState.Maximized;
        }
    }
}