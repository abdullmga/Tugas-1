namespace Tugas_1
{
    partial class siswa
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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelKeluar = new System.Windows.Forms.Label();
            this.namaPengguna = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_pinjam = new System.Windows.Forms.Button();
            this.btn_pengajuan_barang = new System.Windows.Forms.Button();
            this.btn_katalog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.labelKeluar);
            this.panel1.Controls.Add(this.namaPengguna);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btn_pinjam);
            this.panel1.Controls.Add(this.btn_pengajuan_barang);
            this.panel1.Controls.Add(this.btn_katalog);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 958);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Notifikasi";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(318, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(286, 80);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // labelKeluar
            // 
            this.labelKeluar.AutoSize = true;
            this.labelKeluar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeluar.ForeColor = System.Drawing.Color.LightCoral;
            this.labelKeluar.Location = new System.Drawing.Point(9, 818);
            this.labelKeluar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeluar.Name = "labelKeluar";
            this.labelKeluar.Size = new System.Drawing.Size(52, 22);
            this.labelKeluar.TabIndex = 9;
            this.labelKeluar.Text = "Keluar";
            this.labelKeluar.Click += new System.EventHandler(this.labelKeluar_Click);
            // 
            // namaPengguna
            // 
            this.namaPengguna.AutoSize = true;
            this.namaPengguna.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaPengguna.ForeColor = System.Drawing.Color.White;
            this.namaPengguna.Location = new System.Drawing.Point(9, 754);
            this.namaPengguna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namaPengguna.Name = "namaPengguna";
            this.namaPengguna.Size = new System.Drawing.Size(293, 23);
            this.namaPengguna.TabIndex = 8;
            this.namaPengguna.Text = "Abdullah Muqbil Ghanim Alghanim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 786);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Siswa";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 737);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(272, 2);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btn_pinjam
            // 
            this.btn_pinjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btn_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pinjam.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pinjam.ForeColor = System.Drawing.Color.White;
            this.btn_pinjam.Location = new System.Drawing.Point(10, 331);
            this.btn_pinjam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pinjam.Name = "btn_pinjam";
            this.btn_pinjam.Size = new System.Drawing.Size(268, 51);
            this.btn_pinjam.TabIndex = 5;
            this.btn_pinjam.Text = "Ajukan Peminjaman";
            this.btn_pinjam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pinjam.UseVisualStyleBackColor = false;
            this.btn_pinjam.Click += new System.EventHandler(this.btn_pinjam_Click);
            // 
            // btn_pengajuan_barang
            // 
            this.btn_pengajuan_barang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btn_pengajuan_barang.FlatAppearance.BorderSize = 0;
            this.btn_pengajuan_barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pengajuan_barang.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pengajuan_barang.ForeColor = System.Drawing.Color.White;
            this.btn_pengajuan_barang.Location = new System.Drawing.Point(10, 271);
            this.btn_pengajuan_barang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pengajuan_barang.Name = "btn_pengajuan_barang";
            this.btn_pengajuan_barang.Size = new System.Drawing.Size(268, 51);
            this.btn_pengajuan_barang.TabIndex = 4;
            this.btn_pengajuan_barang.Text = "Pengajuan Saya";
            this.btn_pengajuan_barang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pengajuan_barang.UseVisualStyleBackColor = false;
            this.btn_pengajuan_barang.Click += new System.EventHandler(this.btn_pengajuan_barang_Click);
            // 
            // btn_katalog
            // 
            this.btn_katalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btn_katalog.FlatAppearance.BorderSize = 0;
            this.btn_katalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_katalog.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_katalog.ForeColor = System.Drawing.Color.White;
            this.btn_katalog.Location = new System.Drawing.Point(10, 211);
            this.btn_katalog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_katalog.Name = "btn_katalog";
            this.btn_katalog.Size = new System.Drawing.Size(268, 51);
            this.btn_katalog.TabIndex = 3;
            this.btn_katalog.Text = "Katalog Barang";
            this.btn_katalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_katalog.UseVisualStyleBackColor = false;
            this.btn_katalog.Click += new System.EventHandler(this.btn_katalog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "SISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "SMKS Bina Kerja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "OSIS Inventaris";
            // 
            // siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1414, 958);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1436, 1014);
            this.MinimizeBox = false;
            this.Name = "siswa";
            this.Text = "dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.siswa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pengajuan_barang;
        private System.Windows.Forms.Button btn_katalog;
        private System.Windows.Forms.Button btn_pinjam;
        private System.Windows.Forms.Label namaPengguna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelKeluar;
        private System.Windows.Forms.Button button1;
    }
}