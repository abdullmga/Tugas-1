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
    public partial class SelamatDatang : Form
    {
        public SelamatDatang()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            Masuk FormMasuk = new Masuk();

            FormMasuk.Show();

            this.Hide();
        }

        private void btnPendaftaran_Click(object sender, EventArgs e)
        {
            Pendaftaran FormPendaftaran = new Pendaftaran();

            FormPendaftaran.Show();

            this.Hide();
        }
    }
}
