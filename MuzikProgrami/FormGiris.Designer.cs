
namespace MuzikProgrami
{
    partial class FormGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_abonelik = new System.Windows.Forms.ComboBox();
            this.txt_ulke = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_giris_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_giris_sifre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_admin_giris = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_admin_kullanici = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_admin_sifre = new System.Windows.Forms.TextBox();
            this.btn_Kayitol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici Adi";
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(76, 28);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(164, 20);
            this.txt_kullaniciadi.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(76, 54);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(164, 20);
            this.txt_sifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Kayitol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_abonelik);
            this.groupBox1.Controls.Add(this.txt_kullaniciadi);
            this.groupBox1.Controls.Add(this.txt_ulke);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Location = new System.Drawing.Point(48, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 251);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KAYIT OL";
            // 
            // cmb_abonelik
            // 
            this.cmb_abonelik.FormattingEnabled = true;
            this.cmb_abonelik.Items.AddRange(new object[] {
            "Normal",
            "Premium"});
            this.cmb_abonelik.Location = new System.Drawing.Point(76, 107);
            this.cmb_abonelik.Name = "cmb_abonelik";
            this.cmb_abonelik.Size = new System.Drawing.Size(164, 21);
            this.cmb_abonelik.TabIndex = 4;
            // 
            // txt_ulke
            // 
            this.txt_ulke.Location = new System.Drawing.Point(76, 137);
            this.txt_ulke.Name = "txt_ulke";
            this.txt_ulke.Size = new System.Drawing.Size(164, 20);
            this.txt_ulke.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ülke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Abonelik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(76, 80);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 20);
            this.txt_email.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_giris);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_giris_kullaniciadi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_giris_sifre);
            this.groupBox2.Location = new System.Drawing.Point(337, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜYE MİSİN?";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(7, 71);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(233, 34);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "GİRİŞ YAP";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kullanici Adi";
            // 
            // txt_giris_kullaniciadi
            // 
            this.txt_giris_kullaniciadi.Location = new System.Drawing.Point(76, 19);
            this.txt_giris_kullaniciadi.Name = "txt_giris_kullaniciadi";
            this.txt_giris_kullaniciadi.Size = new System.Drawing.Size(164, 20);
            this.txt_giris_kullaniciadi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Şifre";
            // 
            // txt_giris_sifre
            // 
            this.txt_giris_sifre.Location = new System.Drawing.Point(76, 45);
            this.txt_giris_sifre.Name = "txt_giris_sifre";
            this.txt_giris_sifre.PasswordChar = '*';
            this.txt_giris_sifre.Size = new System.Drawing.Size(164, 20);
            this.txt_giris_sifre.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_admin_giris);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_admin_kullanici);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_admin_sifre);
            this.groupBox3.Location = new System.Drawing.Point(337, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 114);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ADMİN";
            // 
            // btn_admin_giris
            // 
            this.btn_admin_giris.Location = new System.Drawing.Point(7, 71);
            this.btn_admin_giris.Name = "btn_admin_giris";
            this.btn_admin_giris.Size = new System.Drawing.Size(233, 34);
            this.btn_admin_giris.TabIndex = 5;
            this.btn_admin_giris.Text = "ADMİN GİRİŞİ";
            this.btn_admin_giris.UseVisualStyleBackColor = true;
            this.btn_admin_giris.Click += new System.EventHandler(this.btn_admin_giris_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kullanici Adi";
            // 
            // txt_admin_kullanici
            // 
            this.txt_admin_kullanici.Location = new System.Drawing.Point(76, 19);
            this.txt_admin_kullanici.Name = "txt_admin_kullanici";
            this.txt_admin_kullanici.Size = new System.Drawing.Size(164, 20);
            this.txt_admin_kullanici.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Şifre";
            // 
            // txt_admin_sifre
            // 
            this.txt_admin_sifre.Location = new System.Drawing.Point(76, 45);
            this.txt_admin_sifre.Name = "txt_admin_sifre";
            this.txt_admin_sifre.PasswordChar = '*';
            this.txt_admin_sifre.Size = new System.Drawing.Size(164, 20);
            this.txt_admin_sifre.TabIndex = 3;
            // 
            // btn_Kayitol
            // 
            this.btn_Kayitol.Location = new System.Drawing.Point(10, 174);
            this.btn_Kayitol.Name = "btn_Kayitol";
            this.btn_Kayitol.Size = new System.Drawing.Size(230, 39);
            this.btn_Kayitol.TabIndex = 5;
            this.btn_Kayitol.Text = "KAYIT OL";
            this.btn_Kayitol.UseVisualStyleBackColor = true;
            this.btn_Kayitol.Click += new System.EventHandler(this.btn_Kayitol_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 301);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_abonelik;
        private System.Windows.Forms.TextBox txt_ulke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_giris_kullaniciadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_giris_sifre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_admin_giris;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_admin_kullanici;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_admin_sifre;
        private System.Windows.Forms.Button btn_Kayitol;
    }
}

