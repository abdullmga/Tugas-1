namespace Tugas_1
{
    partial class pembina_dashboard_laporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalJenisBarang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sedangDipinjam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peminjamColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jatuhTempoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.totalJenisBarang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 100);
            this.panel1.TabIndex = 0;
            // 
            // totalJenisBarang
            // 
            this.totalJenisBarang.AutoSize = true;
            this.totalJenisBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.totalJenisBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.totalJenisBarang.Location = new System.Drawing.Point(5, 47);
            this.totalJenisBarang.Name = "totalJenisBarang";
            this.totalJenisBarang.Size = new System.Drawing.Size(43, 46);
            this.totalJenisBarang.TabIndex = 2;
            this.totalJenisBarang.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Jenis Barang";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sedangDipinjam);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(506, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 100);
            this.panel2.TabIndex = 3;
            // 
            // sedangDipinjam
            // 
            this.sedangDipinjam.AutoSize = true;
            this.sedangDipinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.sedangDipinjam.ForeColor = System.Drawing.Color.Coral;
            this.sedangDipinjam.Location = new System.Drawing.Point(4, 48);
            this.sedangDipinjam.Name = "sedangDipinjam";
            this.sedangDipinjam.Size = new System.Drawing.Size(43, 46);
            this.sedangDipinjam.TabIndex = 2;
            this.sedangDipinjam.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(-1, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sedang Dipinjam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Peminjaman Terbaru";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peminjamColumn,
            this.barangColumn,
            this.jatuhTempoColumn,
            this.statusColumn});
            this.dataGridView1.Location = new System.Drawing.Point(13, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(944, 494);
            this.dataGridView1.TabIndex = 7;
            // 
            // peminjamColumn
            // 
            this.peminjamColumn.HeaderText = "Peminjam";
            this.peminjamColumn.MinimumWidth = 8;
            this.peminjamColumn.Name = "peminjamColumn";
            this.peminjamColumn.ReadOnly = true;
            // 
            // barangColumn
            // 
            this.barangColumn.HeaderText = "Barang";
            this.barangColumn.MinimumWidth = 8;
            this.barangColumn.Name = "barangColumn";
            this.barangColumn.ReadOnly = true;
            // 
            // jatuhTempoColumn
            // 
            this.jatuhTempoColumn.HeaderText = "Jatuh Tempo";
            this.jatuhTempoColumn.MinimumWidth = 8;
            this.jatuhTempoColumn.Name = "jatuhTempoColumn";
            this.jatuhTempoColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 8;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // pembina_dashboard_laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pembina_dashboard_laporan";
            this.ShowIcon = false;
            this.Text = "pembina_dashboard_laporan";
            this.Load += new System.EventHandler(this.pembina_dashboard_laporan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalJenisBarang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sedangDipinjam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn peminjamColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jatuhTempoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
    }
}