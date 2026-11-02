using Mysqlx.Resultset;
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
    public partial class pembina_dashboard_laporan : Form
    {
        public pembina_dashboard_laporan()
        {
            InitializeComponent();
        }

        private void pembina_dashboard_laporan_Load(object sender, EventArgs e)
        {
            int totaljenisbarang = 0;
            int sedangdipinjam = 0;
            int menunggupersetujuan = 0;
            int barangrusak = 0;

            // Baris pertama (Dipinjam)

            dataGridView1.Rows.Add("Rina Analia", "Speaker Portable", "14-10-2026", "Dipinjam");
            dataGridView1.Rows.Add("Budi Santoso", "Proyektor Epson", "12-10-2026", "Terlambat");
            dataGridView1.Rows.Add("Siti Rahma", "Kabel HDMI", "15-10-2026", "Dipinjam");
            dataGridView1.Rows.Add("Ahmad Dani", "Laptop ASUS", "10-10-2026", "Terlambat");
            dataGridView1.Rows.Add("Dewi Lestari", "Mic Wireless", "16-10-2026", "Dipinjam");

            foreach (DataGridViewRow row in dataGridView1.Rows) {

                if (!row.IsNewRow && row.Cells[3].Value != null) {

                    totaljenisbarang++;
                    string status = row.Cells[3].Value.ToString();
                    if (status == "Dipinjam")
                    {
                        sedangdipinjam++;
                        row.Cells[3].Style.BackColor = Color.Coral;
                        row.Cells[3].Style.ForeColor = Color.White;

                    } else if(status == "Terlambat")
                    {
                        sedangdipinjam++;
                        row.Cells[3].Style.BackColor = Color.Red;
                        row.Cells[3].Style.ForeColor = Color.White;
                    }
                    

                }
            }

            totalJenisBarang.Text = totaljenisbarang.ToString();
            sedangDipinjam.Text = sedangdipinjam.ToString();
            
        }
    }
}
