namespace Tugas_1
{
    partial class Pendaftaran
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnLanjutkan = new System.Windows.Forms.Button();
            this.kataSandi = new System.Windows.Forms.TextBox();
            this.namaLengkap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NISN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imgHide = new System.Windows.Forms.PictureBox();
            this.imgView = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.UlangiKataSandi = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imgView1 = new System.Windows.Forms.PictureBox();
            this.imgHide1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHide1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(423, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Buat akun baru";
            // 
            // btnLanjutkan
            // 
            this.btnLanjutkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnLanjutkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanjutkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLanjutkan.ForeColor = System.Drawing.Color.White;
            this.btnLanjutkan.Location = new System.Drawing.Point(428, 851);
            this.btnLanjutkan.Name = "btnLanjutkan";
            this.btnLanjutkan.Size = new System.Drawing.Size(579, 57);
            this.btnLanjutkan.TabIndex = 25;
            this.btnLanjutkan.Text = "Lanjutkan";
            this.btnLanjutkan.UseVisualStyleBackColor = false;
            this.btnLanjutkan.Click += new System.EventHandler(this.btnLanjutkan_Click);
            // 
            // kataSandi
            // 
            this.kataSandi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kataSandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kataSandi.Location = new System.Drawing.Point(441, 651);
            this.kataSandi.Multiline = true;
            this.kataSandi.Name = "kataSandi";
            this.kataSandi.PasswordChar = '*';
            this.kataSandi.Size = new System.Drawing.Size(502, 39);
            this.kataSandi.TabIndex = 22;
            this.kataSandi.Tag = "";
            this.kataSandi.Text = "Masukkan Kata Sandi";
            this.kataSandi.Enter += new System.EventHandler(this.kataSandi_Enter_1);
            this.kataSandi.Leave += new System.EventHandler(this.kataSandi_Leave_1);
            // 
            // namaLengkap
            // 
            this.namaLengkap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namaLengkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaLengkap.ForeColor = System.Drawing.Color.Silver;
            this.namaLengkap.Location = new System.Drawing.Point(12, 9);
            this.namaLengkap.Multiline = true;
            this.namaLengkap.Name = "namaLengkap";
            this.namaLengkap.Size = new System.Drawing.Size(546, 39);
            this.namaLengkap.TabIndex = 21;
            this.namaLengkap.Text = "Masukkan Nama Lengkap";
            this.namaLengkap.Enter += new System.EventHandler(this.namaLengkap_Enter);
            this.namaLengkap.Leave += new System.EventHandler(this.namaLengkap_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 609);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kata Sandi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nama Lengkap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 91);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pendaftaran";
            // 
            // NISN
            // 
            this.NISN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NISN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NISN.ForeColor = System.Drawing.Color.Silver;
            this.NISN.Location = new System.Drawing.Point(10, 11);
            this.NISN.Multiline = true;
            this.NISN.Name = "NISN";
            this.NISN.Size = new System.Drawing.Size(551, 44);
            this.NISN.TabIndex = 28;
            this.NISN.Text = "Masukkan NISN";
            this.NISN.Enter += new System.EventHandler(this.NISN_Enter);
            this.NISN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NISN_KeyPress);
            this.NISN.Leave += new System.EventHandler(this.NISN_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "NISN";
            // 
            // imgHide
            // 
            this.imgHide.Image = global::Tugas_1.Properties.Resources.hide;
            this.imgHide.Location = new System.Drawing.Point(520, 13);
            this.imgHide.Name = "imgHide";
            this.imgHide.Size = new System.Drawing.Size(45, 30);
            this.imgHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHide.TabIndex = 36;
            this.imgHide.TabStop = false;
            this.imgHide.Click += new System.EventHandler(this.imgHide_Click);
            // 
            // imgView
            // 
            this.imgView.Image = global::Tugas_1.Properties.Resources.view;
            this.imgView.Location = new System.Drawing.Point(520, 13);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(45, 30);
            this.imgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgView.TabIndex = 37;
            this.imgView.TabStop = false;
            this.imgView.Click += new System.EventHandler(this.imgView_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.namaLengkap);
            this.panel3.Location = new System.Drawing.Point(428, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 56);
            this.panel3.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NISN);
            this.panel1.Location = new System.Drawing.Point(428, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 56);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.imgView);
            this.panel2.Controls.Add(this.imgHide);
            this.panel2.Location = new System.Drawing.Point(428, 641);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 56);
            this.panel2.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 713);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Konfirmasi Kata Sandi";
            // 
            // UlangiKataSandi
            // 
            this.UlangiKataSandi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UlangiKataSandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlangiKataSandi.Location = new System.Drawing.Point(441, 755);
            this.UlangiKataSandi.Multiline = true;
            this.UlangiKataSandi.Name = "UlangiKataSandi";
            this.UlangiKataSandi.PasswordChar = '*';
            this.UlangiKataSandi.Size = new System.Drawing.Size(502, 39);
            this.UlangiKataSandi.TabIndex = 43;
            this.UlangiKataSandi.Tag = "";
            this.UlangiKataSandi.Text = "Masukkan Kata Sandi Lagi";
            this.UlangiKataSandi.Enter += new System.EventHandler(this.UlangiKataSandi_Enter);
            this.UlangiKataSandi.Leave += new System.EventHandler(this.UlangiKataSandi_Leave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.imgView1);
            this.panel4.Controls.Add(this.imgHide1);
            this.panel4.Location = new System.Drawing.Point(428, 745);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 56);
            this.panel4.TabIndex = 44;
            // 
            // imgView1
            // 
            this.imgView1.Image = global::Tugas_1.Properties.Resources.view;
            this.imgView1.Location = new System.Drawing.Point(520, 13);
            this.imgView1.Name = "imgView1";
            this.imgView1.Size = new System.Drawing.Size(45, 30);
            this.imgView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgView1.TabIndex = 37;
            this.imgView1.TabStop = false;
            this.imgView1.Click += new System.EventHandler(this.imgView1_Click);
            // 
            // imgHide1
            // 
            this.imgHide1.Image = global::Tugas_1.Properties.Resources.hide;
            this.imgHide1.Location = new System.Drawing.Point(520, 13);
            this.imgHide1.Name = "imgHide1";
            this.imgHide1.Size = new System.Drawing.Size(45, 30);
            this.imgHide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHide1.TabIndex = 36;
            this.imgHide1.TabStop = false;
            this.imgHide1.Click += new System.EventHandler(this.imgHide1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 45;
            this.label5.Text = "Username";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Username);
            this.panel5.Location = new System.Drawing.Point(427, 529);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(579, 56);
            this.panel5.TabIndex = 46;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Silver;
            this.Username.Location = new System.Drawing.Point(10, 11);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(551, 44);
            this.Username.TabIndex = 28;
            this.Username.Text = "Masukkan Username";
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Pendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UlangiKataSandi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLanjutkan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kataSandi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 1024);
            this.MinimizeBox = false;
            this.Name = "Pendaftaran";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendaftaran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pendaftaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHide1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLanjutkan;
        private System.Windows.Forms.TextBox kataSandi;
        private System.Windows.Forms.TextBox namaLengkap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NISN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imgHide;
        private System.Windows.Forms.PictureBox imgView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UlangiKataSandi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox imgView1;
        private System.Windows.Forms.PictureBox imgHide1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Username;
    }
}