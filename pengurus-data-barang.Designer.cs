namespace Tugas_1
{
    partial class pengurus_data_barang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch_siswa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_siswa = new System.Windows.Forms.ComboBox();
            this.nama_data_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_data_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_satuan_data_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kondisi_data_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi_data_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_data_barang,
            this.jumlah_data_barang,
            this.harga_satuan_data_barang,
            this.kondisi_data_barang,
            this.aksi_data_barang});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(17, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(686, 313);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-9, 0);
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
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Barang";
            // 
            // txtsearch_siswa
            // 
            this.txtsearch_siswa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch_siswa.ForeColor = System.Drawing.Color.Silver;
            this.txtsearch_siswa.Location = new System.Drawing.Point(17, 76);
            this.txtsearch_siswa.Multiline = true;
            this.txtsearch_siswa.Name = "txtsearch_siswa";
            this.txtsearch_siswa.Size = new System.Drawing.Size(241, 21);
            this.txtsearch_siswa.TabIndex = 5;
            this.txtsearch_siswa.Text = "Cari nama barang...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // cmb_siswa
            // 
            this.cmb_siswa.FormattingEnabled = true;
            this.cmb_siswa.Items.AddRange(new object[] {
            "Baik",
            "Rusak Ringan",
            "Rusak"});
            this.cmb_siswa.Location = new System.Drawing.Point(285, 76);
            this.cmb_siswa.Name = "cmb_siswa";
            this.cmb_siswa.Size = new System.Drawing.Size(121, 21);
            this.cmb_siswa.TabIndex = 7;
            this.cmb_siswa.Text = "Semua kondisi";
            // 
            // nama_data_barang
            // 
            this.nama_data_barang.HeaderText = "Nama Barang";
            this.nama_data_barang.MinimumWidth = 8;
            this.nama_data_barang.Name = "nama_data_barang";
            this.nama_data_barang.ReadOnly = true;
            // 
            // jumlah_data_barang
            // 
            this.jumlah_data_barang.HeaderText = "Jumlah";
            this.jumlah_data_barang.MinimumWidth = 8;
            this.jumlah_data_barang.Name = "jumlah_data_barang";
            this.jumlah_data_barang.ReadOnly = true;
            // 
            // harga_satuan_data_barang
            // 
            this.harga_satuan_data_barang.HeaderText = "Harga Satuan";
            this.harga_satuan_data_barang.MinimumWidth = 8;
            this.harga_satuan_data_barang.Name = "harga_satuan_data_barang";
            this.harga_satuan_data_barang.ReadOnly = true;
            // 
            // kondisi_data_barang
            // 
            this.kondisi_data_barang.HeaderText = "Kondisi";
            this.kondisi_data_barang.MinimumWidth = 8;
            this.kondisi_data_barang.Name = "kondisi_data_barang";
            this.kondisi_data_barang.ReadOnly = true;
            // 
            // aksi_data_barang
            // 
            this.aksi_data_barang.HeaderText = "Aksi";
            this.aksi_data_barang.MinimumWidth = 8;
            this.aksi_data_barang.Name = "aksi_data_barang";
            this.aksi_data_barang.ReadOnly = true;
            // 
            // pengurus_data_barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 534);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsearch_siswa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_siswa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pengurus_data_barang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pengurus_data_barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pengurus_data_barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch_siswa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_siswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_data_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_data_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_satuan_data_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kondisi_data_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn aksi_data_barang;
    }
}