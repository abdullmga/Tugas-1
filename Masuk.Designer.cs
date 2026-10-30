namespace Tugas_1
{
    partial class Masuk
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
            this.btnMasuk = new System.Windows.Forms.Button();
            this.kataSandi = new System.Windows.Forms.TextBox();
            this.NISUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daftar = new System.Windows.Forms.Label();
            this.imgView = new System.Windows.Forms.PictureBox();
            this.imgHide = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.object_ded74cf8_2cb6_45a0_a735_0ffb90702273 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHide)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMasuk.ForeColor = System.Drawing.Color.White;
            this.btnMasuk.Location = new System.Drawing.Point(418, 542);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(583, 57);
            this.btnMasuk.TabIndex = 0;
            this.btnMasuk.Text = "Masuk";
            this.btnMasuk.UseVisualStyleBackColor = false;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // kataSandi
            // 
            this.kataSandi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kataSandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kataSandi.Location = new System.Drawing.Point(20, 15);
            this.kataSandi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kataSandi.Multiline = true;
            this.kataSandi.Name = "kataSandi";
            this.kataSandi.PasswordChar = '*';
            this.kataSandi.Size = new System.Drawing.Size(492, 51);
            this.kataSandi.TabIndex = 0;
            this.kataSandi.Tag = "";
            this.kataSandi.Text = "Masukkan Kata Sandi";
            this.kataSandi.Enter += new System.EventHandler(this.kataSandi_Enter);
            this.kataSandi.Leave += new System.EventHandler(this.kataSandi_Leave);
            // 
            // NISUsername
            // 
            this.NISUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NISUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NISUsername.ForeColor = System.Drawing.Color.Silver;
            this.NISUsername.Location = new System.Drawing.Point(15, 15);
            this.NISUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NISUsername.Multiline = true;
            this.NISUsername.Name = "NISUsername";
            this.NISUsername.Size = new System.Drawing.Size(552, 42);
            this.NISUsername.TabIndex = 0;
            this.NISUsername.Text = "Masukkan Username atau NISN";
            this.NISUsername.Enter += new System.EventHandler(this.NISUsername_Enter);
            this.NISUsername.Leave += new System.EventHandler(this.NISUsername_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kata Sandi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username / NISN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 91);
            this.label1.TabIndex = 9;
            this.label1.Text = "Masuk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(417, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(551, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gunakan akun yang diberikan Pengurus Inventaris.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Belum punya akun? Daftar";
            // 
            // daftar
            // 
            this.daftar.AutoSize = true;
            this.daftar.BackColor = System.Drawing.Color.Transparent;
            this.daftar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.daftar.Location = new System.Drawing.Point(768, 616);
            this.daftar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.daftar.Name = "daftar";
            this.daftar.Size = new System.Drawing.Size(76, 29);
            this.daftar.TabIndex = 33;
            this.daftar.Text = "Daftar";
            this.daftar.Click += new System.EventHandler(this.daftar_Click);
            // 
            // imgView
            // 
            this.imgView.Image = global::Tugas_1.Properties.Resources.view;
            this.imgView.Location = new System.Drawing.Point(516, 15);
            this.imgView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(51, 32);
            this.imgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgView.TabIndex = 34;
            this.imgView.TabStop = false;
            this.imgView.Click += new System.EventHandler(this.imgView_Click);
            // 
            // imgHide
            // 
            this.imgHide.Image = global::Tugas_1.Properties.Resources.hide;
            this.imgHide.Location = new System.Drawing.Point(516, 15);
            this.imgHide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgHide.Name = "imgHide";
            this.imgHide.Size = new System.Drawing.Size(51, 32);
            this.imgHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHide.TabIndex = 35;
            this.imgHide.TabStop = false;
            this.imgHide.Click += new System.EventHandler(this.imgHide_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NISUsername);
            this.panel1.Location = new System.Drawing.Point(418, 316);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 64);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.kataSandi);
            this.panel2.Controls.Add(this.imgView);
            this.panel2.Controls.Add(this.imgHide);
            this.panel2.Location = new System.Drawing.Point(418, 434);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 68);
            this.panel2.TabIndex = 37;
            // 
            // object_ded74cf8_2cb6_45a0_a735_0ffb90702273
            // 
            this.object_ded74cf8_2cb6_45a0_a735_0ffb90702273.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.object_ded74cf8_2cb6_45a0_a735_0ffb90702273.Location = new System.Drawing.Point(422, 445);
            this.object_ded74cf8_2cb6_45a0_a735_0ffb90702273.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.object_ded74cf8_2cb6_45a0_a735_0ffb90702273.Name = "object_ded74cf8_2cb6_45a0_a735_0ffb90702273";
            this.object_ded74cf8_2cb6_45a0_a735_0ffb90702273.Size = new System.Drawing.Size(813, 61);
            this.object_ded74cf8_2cb6_45a0_a735_0ffb90702273.TabIndex = 37;
            this.object_ded74cf8_2cb6_45a0_a735_0ffb90702273.Visible = false;
            // 
            // Masuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1414, 958);
            this.Controls.Add(this.daftar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMasuk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1436, 1014);
            this.MinimizeBox = false;
            this.Name = "Masuk";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masuk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Masuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.TextBox kataSandi;
        private System.Windows.Forms.TextBox NISUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label daftar;
        private System.Windows.Forms.PictureBox imgView;
        private System.Windows.Forms.PictureBox imgHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel object_ded74cf8_2cb6_45a0_a735_0ffb90702273;
    }
}