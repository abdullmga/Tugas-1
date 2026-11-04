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
    public partial class siswa_pinjam : Form
    {
        public siswa_pinjam()
        {
            InitializeComponent();
            SiapkanForm(null);
        }

        private void siswa_pinjam_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public siswa_pinjam(string namaBarang)
        {
            InitializeComponent();
            SiapkanForm(namaBarang);
        }

        private void SiapkanForm(string namaBarang)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[]
            {
                "Mic Wireless",
                "Kursi Lipat",
                "Megaphone",
                "Speaker Portable",
                "Kabel Roll 10 m",
                "Proyektor",
                "Bendera OSIS"
            });
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.Black;

            domainUpDown1.Items.Clear();
            for (int jumlah = 1; jumlah <= 30; jumlah++)
            {
                domainUpDown1.Items.Add(jumlah.ToString());
            }
            domainUpDown1.SelectedIndex = 0;
            domainUpDown1.ForeColor = Color.Black;

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
            dateTimePicker2.Value = DateTime.Today.AddDays(1);

            if (!string.IsNullOrEmpty(namaBarang) && comboBox1.Items.Contains(namaBarang))
            {
                comboBox1.SelectedItem = namaBarang;
            }

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tanggalMinimum = dateTimePicker1.Value.Date.AddDays(1);
            dateTimePicker2.MinDate = tanggalMinimum;

            if (dateTimePicker2.Value.Date < tanggalMinimum)
            {
                dateTimePicker2.Value = tanggalMinimum;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Silakan pilih barang yang ingin dipinjam.", "Data belum lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            int jumlah;
            if (!int.TryParse(domainUpDown1.Text, out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah peminjaman harus lebih dari 0.", "Data belum lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                domainUpDown1.Focus();
                return;
            }

            if (dateTimePicker2.Value.Date <= dateTimePicker1.Value.Date)
            {
                MessageBox.Show("Tanggal kembali harus setelah tanggal pinjam.", "Data belum lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Silakan isi keperluan peminjaman.", "Data belum lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            siswa_pengajuan.TambahPengajuan(new DataPengajuan
            {
                Barang = comboBox1.SelectedItem.ToString(),
                Jumlah = jumlah,
                TanggalPinjam = dateTimePicker1.Value.Date,
                TanggalKembali = dateTimePicker2.Value.Date,
                Keperluan = textBox1.Text.Trim(),
                Status = "Pending",
                Keterangan = "Menunggu persetujuan"
            });

            BukaHalaman(new siswa_pengajuan());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BukaHalaman(new siswa_katalog());
        }

        private void BukaHalaman(Form halaman)
        {
            Form formUtama = MdiParent;
            if (formUtama == null)
            {
                halaman.Show();
                Close();
                return;
            }

            halaman.MdiParent = formUtama;
            halaman.FormBorderStyle = FormBorderStyle.None;
            halaman.Dock = DockStyle.Fill;

            Close();
            halaman.Show();
            halaman.BringToFront();
        }
    }
}
