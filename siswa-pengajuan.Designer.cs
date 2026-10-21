namespace Tugas_1
{
    partial class siswa_pengajuan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_pinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_kembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_pinjam_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan_pinjam_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 52);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pengajuan Saya";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barang,
            this.jumlah_barang,
            this.tanggal_pinjam,
            this.tanggal_kembali,
            this.status_pinjam_barang,
            this.keterangan_pinjam_barang});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(25, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(686, 313);
            this.dataGridView1.TabIndex = 9;
            // 
            // barang
            // 
            this.barang.HeaderText = "Barang";
            this.barang.Name = "barang";
            // 
            // jumlah_barang
            // 
            this.jumlah_barang.HeaderText = "Jumlah";
            this.jumlah_barang.Name = "jumlah_barang";
            // 
            // tanggal_pinjam
            // 
            this.tanggal_pinjam.HeaderText = "Tgl Pinjam";
            this.tanggal_pinjam.Name = "tanggal_pinjam";
            // 
            // tanggal_kembali
            // 
            this.tanggal_kembali.HeaderText = "Tgl Kembali";
            this.tanggal_kembali.Name = "tanggal_kembali";
            // 
            // status_pinjam_barang
            // 
            this.status_pinjam_barang.HeaderText = "Aksi";
            this.status_pinjam_barang.Name = "status_pinjam_barang";
            // 
            // keterangan_pinjam_barang
            // 
            this.keterangan_pinjam_barang.HeaderText = "Keterangan";
            this.keterangan_pinjam_barang.Name = "keterangan_pinjam_barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // siswa_pengajuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 573);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "siswa_pengajuan";
            this.Text = "siswa_pengajuan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_pinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_kembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_pinjam_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn keterangan_pinjam_barang;
    }
}