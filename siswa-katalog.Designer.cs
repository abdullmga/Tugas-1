namespace Tugas_1
{
    partial class siswa_katalog
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
            this.txtsearch_siswa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_siswa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kondisi_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch_siswa
            // 
            this.txtsearch_siswa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch_siswa.ForeColor = System.Drawing.Color.Silver;
            this.txtsearch_siswa.Location = new System.Drawing.Point(35, 94);
            this.txtsearch_siswa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch_siswa.Multiline = true;
            this.txtsearch_siswa.Name = "txtsearch_siswa";
            this.txtsearch_siswa.Size = new System.Drawing.Size(321, 25);
            this.txtsearch_siswa.TabIndex = 0;
            this.txtsearch_siswa.Text = "Cari nama barang...";
            this.txtsearch_siswa.TextChanged += new System.EventHandler(this.txtsearch_siswa_TextChanged);
            this.txtsearch_siswa.Enter += new System.EventHandler(this.txtsearch_siswa_Enter);
            this.txtsearch_siswa.Leave += new System.EventHandler(this.txtsearch_siswa_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 64);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Katalog Barang";
            // 
            // cmb_siswa
            // 
            this.cmb_siswa.FormattingEnabled = true;
            this.cmb_siswa.Items.AddRange(new object[] {
            "Baik",
            "Rusak Ringan",
            "Rusak"});
            this.cmb_siswa.Location = new System.Drawing.Point(392, 94);
            this.cmb_siswa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_siswa.Name = "cmb_siswa";
            this.cmb_siswa.Size = new System.Drawing.Size(160, 24);
            this.cmb_siswa.TabIndex = 2;
            this.cmb_siswa.Text = "Semua kondisi";
            this.cmb_siswa.SelectedIndexChanged += new System.EventHandler(this.cmb_siswa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
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
            this.kondisi_barang,
            this.status_barang,
            this.aksi_barang});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(35, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(915, 385);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting_1);
            // 
            // nama_barang
            // 
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.MinimumWidth = 8;
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.ReadOnly = true;
            // 
            // stok_barang
            // 
            this.stok_barang.HeaderText = "Stok";
            this.stok_barang.MinimumWidth = 8;
            this.stok_barang.Name = "stok_barang";
            this.stok_barang.ReadOnly = true;
            // 
            // kondisi_barang
            // 
            this.kondisi_barang.HeaderText = "Kondisi";
            this.kondisi_barang.MinimumWidth = 8;
            this.kondisi_barang.Name = "kondisi_barang";
            this.kondisi_barang.ReadOnly = true;
            // 
            // status_barang
            // 
            this.status_barang.HeaderText = "Status";
            this.status_barang.MinimumWidth = 8;
            this.status_barang.Name = "status_barang";
            this.status_barang.ReadOnly = true;
            // 
            // aksi_barang
            // 
            this.aksi_barang.HeaderText = "Aksi";
            this.aksi_barang.MinimumWidth = 8;
            this.aksi_barang.Name = "aksi_barang";
            this.aksi_barang.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(866, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // siswa_katalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 705);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_siswa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsearch_siswa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1276, 811);
            this.MinimizeBox = false;
            this.Name = "siswa_katalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siswa_katalog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.siswa_katalog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch_siswa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_siswa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kondisi_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn aksi_barang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}