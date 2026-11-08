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
using MySql.Data.MySqlClient;

namespace Tugas_1
{
    // Menampilkan seluruh status pengajuan milik siswa yang sedang login.
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
            // Mengambil pengajuan dari database agar status mengikuti keputusan pengurus.
            dataGridView1.Rows.Clear();

            if (AppSession.CurrentUserId <= 0)
            {
                return;
            }

            string query = "SELECT u.nama_user, b.nama_barang, d.jumlah_pinjam, p.tanggal_pinjam, " +
                "p.rencana_kembali, p.status_persetujuan " +
                "FROM PEMINJAMAN p JOIN USER u ON u.id_user = p.id_user " +
                "JOIN DETAIL_PEMINJAMAN d ON d.id_peminjaman = p.id_peminjaman " +
                "JOIN BARANG b ON b.id_barang = d.id_barang " +
                "WHERE p.id_user = @user ORDER BY p.tanggal_pinjam DESC";

            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", AppSession.CurrentUserId);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader["status_persetujuan"].ToString();
                            string keterangan = status == "Pending" ? "Menunggu persetujuan" :
                                (status == "Disetujui" ? "Pengajuan disetujui" :
                                (status == "Dikembalikan" ? "Barang sudah dikembalikan" : "Pengajuan ditolak"));
                            int rowIndex = dataGridView1.Rows.Add(
                                reader["nama_barang"], reader["jumlah_pinjam"],
                                Convert.ToDateTime(reader["tanggal_pinjam"]).ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID")),
                                Convert.ToDateTime(reader["rencana_kembali"]).ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID")),
                                status, keterangan);

                            DataGridViewCell statusCell = dataGridView1.Rows[rowIndex].Cells["status_pinjam_barang"];
                            if (status == "Pending")
                            {
                                statusCell.Style.BackColor = Color.FromArgb(255, 242, 204);
                                statusCell.Style.ForeColor = Color.FromArgb(156, 101, 0);
                            }
                            else if (status == "Disetujui")
                            {
                                statusCell.Style.BackColor = Color.FromArgb(212, 237, 218);
                                statusCell.Style.ForeColor = Color.FromArgb(21, 87, 36);
                            }
                            else if (status == "Ditolak")
                            {
                                statusCell.Style.BackColor = Color.FromArgb(248, 215, 218);
                                statusCell.Style.ForeColor = Color.FromArgb(114, 28, 36);
                            }
                            else
                            {
                                statusCell.Style.BackColor = Color.FromArgb(212, 237, 218);
                                statusCell.Style.ForeColor = Color.FromArgb(21, 87, 36);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat pengajuan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilkanPengajuanLokal()
        {
            foreach (DataPengajuan pengajuan in daftarPengajuan)
                {
                    dataGridView1.Rows.Add(pengajuan.Barang, pengajuan.Jumlah,
                        pengajuan.TanggalPinjam.ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID")),
                        pengajuan.TanggalKembali.ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID")),
                        pengajuan.Status, pengajuan.Keterangan);
                }
        }

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
    }
}
