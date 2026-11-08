namespace Tugas_1
{
    partial class DataBarang
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTambahBarang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch_siswa = new System.Windows.Forms.TextBox();
            this.cmb_siswa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kondisi_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
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
            this.nama_barang,
            this.stok_barang,
            this.harga_barang,
            this.kondisi_barang,
            this.status_barang,
            this.edit_barang});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(26, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(915, 385);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTambahBarang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 64);
            this.panel1.TabIndex = 9;
            // 
            // btnTambahBarang
            // 
            this.btnTambahBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnTambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTambahBarang.ForeColor = System.Drawing.Color.White;
            this.btnTambahBarang.Location = new System.Drawing.Point(751, 8);
            this.btnTambahBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambahBarang.Name = "btnTambahBarang";
            this.btnTambahBarang.Size = new System.Drawing.Size(208, 46);
            this.btnTambahBarang.TabIndex = 26;
            this.btnTambahBarang.Text = "+ Tambah Barang";
            this.btnTambahBarang.UseVisualStyleBackColor = false;
            this.btnTambahBarang.Click += new System.EventHandler(this.btnTambahBarang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Barang";
            // 
            // txtsearch_siswa
            // 
            this.txtsearch_siswa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch_siswa.ForeColor = System.Drawing.Color.Silver;
            this.txtsearch_siswa.Location = new System.Drawing.Point(26, 92);
            this.txtsearch_siswa.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch_siswa.Multiline = true;
            this.txtsearch_siswa.Name = "txtsearch_siswa";
            this.txtsearch_siswa.Size = new System.Drawing.Size(321, 25);
            this.txtsearch_siswa.TabIndex = 8;
            this.txtsearch_siswa.Text = "Cari nama barang...";
            // 
            // cmb_siswa
            // 
            this.cmb_siswa.FormattingEnabled = true;
            this.cmb_siswa.Items.AddRange(new object[] {
            "Baik",
            "Rusak Ringan",
            "Rusak"});
            this.cmb_siswa.Location = new System.Drawing.Point(395, 92);
            this.cmb_siswa.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_siswa.Name = "cmb_siswa";
            this.cmb_siswa.Size = new System.Drawing.Size(160, 24);
            this.cmb_siswa.TabIndex = 12;
            this.cmb_siswa.Text = "Semua kondisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(285, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Belum ada data barang di database!";
            // 
            // nama_barang
            // 
            this.nama_barang.FillWeight = 92.73962F;
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.MinimumWidth = 8;
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.ReadOnly = true;
            // 
            // stok_barang
            // 
            this.stok_barang.FillWeight = 92.73962F;
            this.stok_barang.HeaderText = "Jumlah";
            this.stok_barang.MinimumWidth = 8;
            this.stok_barang.Name = "stok_barang";
            this.stok_barang.ReadOnly = true;
            // 
            // harga_barang
            // 
            this.harga_barang.HeaderText = "Harga";
            this.harga_barang.MinimumWidth = 6;
            this.harga_barang.Name = "harga_barang";
            this.harga_barang.ReadOnly = true;
            // 
            // kondisi_barang
            // 
            this.kondisi_barang.FillWeight = 92.73962F;
            this.kondisi_barang.HeaderText = "Kondisi";
            this.kondisi_barang.MinimumWidth = 8;
            this.kondisi_barang.Name = "kondisi_barang";
            this.kondisi_barang.ReadOnly = true;
            // 
            // status_barang
            // 
            this.status_barang.FillWeight = 92.73962F;
            this.status_barang.HeaderText = "Status";
            this.status_barang.MinimumWidth = 8;
            this.status_barang.Name = "status_barang";
            this.status_barang.ReadOnly = true;
            // 
            // edit_barang
            // 
            this.edit_barang.HeaderText = "Edit";
            this.edit_barang.MinimumWidth = 6;
            this.edit_barang.Name = "edit_barang";
            this.edit_barang.ReadOnly = true;
            // 
            // DataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 658);
            this.Controls.Add(this.cmb_siswa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsearch_siswa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "DataBarang";
            this.Text = "DataBarang";
            this.Load += new System.EventHandler(this.DataBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsearch_siswa;
        private System.Windows.Forms.ComboBox cmb_siswa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTambahBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kondisi_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn edit_barang;
    }
}