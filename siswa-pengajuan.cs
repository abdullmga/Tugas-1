using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_1
{
    public class DataPengajuan
    {
        public string Barang { get; set; }
        public int Jumlah { get; set; }
        public DateTime TanggalPinjam { get; set; }
        public DateTime TanggalKembali { get; set; }
        public string Keperluan { get; set; }
        public string Status { get; set; }
        public string Keterangan { get; set; }
    }

    public partial class siswa_pengajuan : Form
    {
        private static readonly List<DataPengajuan> daftarPengajuan = new List<DataPengajuan>();

        public siswa_pengajuan()
        {
            InitializeComponent();
        }

        private void siswa_pengajuan_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            TampilkanPengajuan();
        }

        public static void TambahPengajuan(DataPengajuan pengajuan)
        {
            daftarPengajuan.Add(pengajuan);
        }

        private void TampilkanPengajuan()
        {
            dataGridView1.Rows.Clear();

            foreach (DataPengajuan pengajuan in daftarPengajuan)
            {
                int rowIndex = dataGridView1.Rows.Add(
                    pengajuan.Barang,
                    pengajuan.Jumlah,
                    pengajuan.TanggalPinjam.ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID")),
                    pengajuan.TanggalKembali.ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID")),
                    pengajuan.Status,
                    pengajuan.Keterangan);

                DataGridViewCell statusCell = dataGridView1.Rows[rowIndex].Cells["status_pinjam_barang"];
                if (pengajuan.Status == "Pending")
                {
                    statusCell.Style.BackColor = Color.FromArgb(255, 242, 204);
                    statusCell.Style.ForeColor = Color.FromArgb(156, 101, 0);
                }
                else if (pengajuan.Status == "Disetujui")
                {
                    statusCell.Style.BackColor = Color.FromArgb(212, 237, 218);
                    statusCell.Style.ForeColor = Color.FromArgb(21, 87, 36);
                }
                else
                {
                    statusCell.Style.BackColor = Color.FromArgb(248, 215, 218);
                    statusCell.Style.ForeColor = Color.FromArgb(114, 28, 36);
                }
            }
        }
    }
}
