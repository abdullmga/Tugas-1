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
    public partial class Pendaftaran : Form
    {
        public Pendaftaran()
        {
            InitializeComponent();
        }

        private string placeholderText = "Masukkan Nama Lengkap";
        private void namaLengkap_Enter(object sender, EventArgs e)
        {
            if (namaLengkap.Text == placeholderText)
            {
                namaLengkap.Text = "";
                namaLengkap.ForeColor = Color.Black;
            }
        }

        private void namaLengkap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaLengkap.Text))
            {
                namaLengkap.Text = placeholderText;
                namaLengkap.ForeColor = Color.Gray;
            }
        }

        private void Pendaftaran_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }
    }
}
