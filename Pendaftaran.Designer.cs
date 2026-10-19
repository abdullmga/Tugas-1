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
            this.NISUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imgHide = new System.Windows.Forms.PictureBox();
            this.imgView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(423, 298);
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
            this.btnLanjutkan.Location = new System.Drawing.Point(428, 683);
            this.btnLanjutkan.Name = "btnLanjutkan";
            this.btnLanjutkan.Size = new System.Drawing.Size(579, 57);
            this.btnLanjutkan.TabIndex = 25;
            this.btnLanjutkan.Text = "Lanjutkan";
            this.btnLanjutkan.UseVisualStyleBackColor = false;
            this.btnLanjutkan.Click += new System.EventHandler(this.btnLanjutkan_Click);
            // 
            // kataSandi
            // 
            this.kataSandi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kataSandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kataSandi.Location = new System.Drawing.Point(428, 594);
            this.kataSandi.Multiline = true;
            this.kataSandi.Name = "kataSandi";
            this.kataSandi.PasswordChar = '*';
            this.kataSandi.Size = new System.Drawing.Size(579, 43);
            this.kataSandi.TabIndex = 22;
            this.kataSandi.Tag = "";
            this.kataSandi.Text = "Masukkan Kata Sandi";
            this.kataSandi.Enter += new System.EventHandler(this.kataSandi_Enter_1);
            this.kataSandi.Leave += new System.EventHandler(this.kataSandi_Leave_1);
            // 
            // namaLengkap
            // 
            this.namaLengkap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namaLengkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaLengkap.ForeColor = System.Drawing.Color.Silver;
            this.namaLengkap.Location = new System.Drawing.Point(428, 383);
            this.namaLengkap.Multiline = true;
            this.namaLengkap.Name = "namaLengkap";
            this.namaLengkap.Size = new System.Drawing.Size(579, 43);
            this.namaLengkap.TabIndex = 21;
            this.namaLengkap.Text = "Masukkan Nama Lengkap";
            this.namaLengkap.Enter += new System.EventHandler(this.namaLengkap_Enter);
            this.namaLengkap.Leave += new System.EventHandler(this.namaLengkap_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kata Sandi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nama Lengkap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 91);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pendaftaran";
            // 
            // NISUsername
            // 
            this.NISUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NISUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NISUsername.ForeColor = System.Drawing.Color.Silver;
            this.NISUsername.Location = new System.Drawing.Point(428, 489);
            this.NISUsername.Multiline = true;
            this.NISUsername.Name = "NISUsername";
            this.NISUsername.Size = new System.Drawing.Size(579, 43);
            this.NISUsername.TabIndex = 28;
            this.NISUsername.Text = "Masukkan NIS atau Username";
            this.NISUsername.Enter += new System.EventHandler(this.NISUsername_Enter_1);
            this.NISUsername.Leave += new System.EventHandler(this.NISUsername_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "NIS / Username";
            // 
            // imgHide
            // 
            this.imgHide.Image = global::Tugas_1.Properties.Resources.hide;
            this.imgHide.Location = new System.Drawing.Point(955, 601);
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
            this.imgView.Location = new System.Drawing.Point(955, 601);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(45, 30);
            this.imgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgView.TabIndex = 37;
            this.imgView.TabStop = false;
            this.imgView.Click += new System.EventHandler(this.imgView_Click);
            // 
            // Pendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.NISUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLanjutkan);
            this.Controls.Add(this.namaLengkap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgHide);
            this.Controls.Add(this.imgView);
            this.Controls.Add(this.kataSandi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 1024);
            this.MinimizeBox = false;
            this.Name = "Pendaftaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendaftaran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pendaftaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
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
        private System.Windows.Forms.TextBox NISUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imgHide;
        private System.Windows.Forms.PictureBox imgView;
    }
}