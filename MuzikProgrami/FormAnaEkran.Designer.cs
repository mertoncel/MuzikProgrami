
namespace MuzikProgrami
{
    partial class FormAnaEkran
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
            this.lst_sarkilar = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_sarki_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_sanatci = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sarki_kaydet = new System.Windows.Forms.Button();
            this.cmb_sarki_sanatci = new System.Windows.Forms.ComboBox();
            this.cmb_sarki_album = new System.Windows.Forms.ComboBox();
            this.cmb_sarki_tur = new System.Windows.Forms.ComboBox();
            this.btn_sarki_sil = new System.Windows.Forms.Button();
            this.btn_sarki_guncelle = new System.Windows.Forms.Button();
            this.nmb_sarki_tarih = new System.Windows.Forms.NumericUpDown();
            this.nmb_sarki_dinlenme = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ŞARKILAR = new System.Windows.Forms.TabPage();
            this.nmb_sarki_sure = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.SANATÇILAR = new System.Windows.Forms.TabPage();
            this.txt_sanatci_ulke = new System.Windows.Forms.TextBox();
            this.lst_sanatcilar = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SANATÇI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_sanatci_kaydet = new System.Windows.Forms.Button();
            this.btn_sanatci_guncelle = new System.Windows.Forms.Button();
            this.btn_sanatci_sil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sanatci_adi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ALBÜMLER = new System.Windows.Forms.TabPage();
            this.nmb_album_tarih = new System.Windows.Forms.NumericUpDown();
            this.lst_albumler = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_album_kaydet = new System.Windows.Forms.Button();
            this.cmb_album_tur = new System.Windows.Forms.ComboBox();
            this.btn_album_guncelle = new System.Windows.Forms.Button();
            this.btn_album_sil = new System.Windows.Forms.Button();
            this.cmb_album_sanatci = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_album_adi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_sarki_tarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_sarki_dinlenme)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ŞARKILAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_sarki_sure)).BeginInit();
            this.SANATÇILAR.SuspendLayout();
            this.ALBÜMLER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_album_tarih)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_sarkilar
            // 
            this.lst_sarkilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader15});
            this.lst_sarkilar.HideSelection = false;
            this.lst_sarkilar.Location = new System.Drawing.Point(21, 33);
            this.lst_sarkilar.Name = "lst_sarkilar";
            this.lst_sarkilar.Size = new System.Drawing.Size(814, 203);
            this.lst_sarkilar.TabIndex = 0;
            this.lst_sarkilar.UseCompatibleStateImageBehavior = false;
            this.lst_sarkilar.View = System.Windows.Forms.View.Details;
            this.lst_sarkilar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ŞARKI";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TARİH";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DİNLENME SAYISI";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SANATÇI";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ALBÜM";
            this.columnHeader5.Width = 142;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TÜR";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "SÜRE";
            // 
            // txt_sarki_adi
            // 
            this.txt_sarki_adi.Location = new System.Drawing.Point(123, 304);
            this.txt_sarki_adi.Name = "txt_sarki_adi";
            this.txt_sarki_adi.Size = new System.Drawing.Size(151, 20);
            this.txt_sarki_adi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ŞARKI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TARİH";
            // 
            // lbl_sanatci
            // 
            this.lbl_sanatci.AutoSize = true;
            this.lbl_sanatci.Location = new System.Drawing.Point(60, 359);
            this.lbl_sanatci.Name = "lbl_sanatci";
            this.lbl_sanatci.Size = new System.Drawing.Size(53, 13);
            this.lbl_sanatci.TabIndex = 3;
            this.lbl_sanatci.Text = "SANATÇI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ALBÜM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "TÜR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "DİNLENME";
            // 
            // btn_sarki_kaydet
            // 
            this.btn_sarki_kaydet.Location = new System.Drawing.Point(21, 243);
            this.btn_sarki_kaydet.Name = "btn_sarki_kaydet";
            this.btn_sarki_kaydet.Size = new System.Drawing.Size(163, 23);
            this.btn_sarki_kaydet.TabIndex = 1;
            this.btn_sarki_kaydet.Text = "KAYDET";
            this.btn_sarki_kaydet.UseVisualStyleBackColor = true;
            this.btn_sarki_kaydet.Click += new System.EventHandler(this.btn_sarkiekle_Click);
            // 
            // cmb_sarki_sanatci
            // 
            this.cmb_sarki_sanatci.FormattingEnabled = true;
            this.cmb_sarki_sanatci.Location = new System.Drawing.Point(123, 356);
            this.cmb_sarki_sanatci.Name = "cmb_sarki_sanatci";
            this.cmb_sarki_sanatci.Size = new System.Drawing.Size(151, 21);
            this.cmb_sarki_sanatci.TabIndex = 4;
            // 
            // cmb_sarki_album
            // 
            this.cmb_sarki_album.FormattingEnabled = true;
            this.cmb_sarki_album.Location = new System.Drawing.Point(123, 382);
            this.cmb_sarki_album.Name = "cmb_sarki_album";
            this.cmb_sarki_album.Size = new System.Drawing.Size(151, 21);
            this.cmb_sarki_album.TabIndex = 4;
            // 
            // cmb_sarki_tur
            // 
            this.cmb_sarki_tur.FormattingEnabled = true;
            this.cmb_sarki_tur.Location = new System.Drawing.Point(123, 409);
            this.cmb_sarki_tur.Name = "cmb_sarki_tur";
            this.cmb_sarki_tur.Size = new System.Drawing.Size(151, 21);
            this.cmb_sarki_tur.TabIndex = 4;
            // 
            // btn_sarki_sil
            // 
            this.btn_sarki_sil.Location = new System.Drawing.Point(199, 243);
            this.btn_sarki_sil.Name = "btn_sarki_sil";
            this.btn_sarki_sil.Size = new System.Drawing.Size(175, 23);
            this.btn_sarki_sil.TabIndex = 5;
            this.btn_sarki_sil.Text = "SİL";
            this.btn_sarki_sil.UseVisualStyleBackColor = true;
            this.btn_sarki_sil.Click += new System.EventHandler(this.btn_sarkisil_Click);
            // 
            // btn_sarki_guncelle
            // 
            this.btn_sarki_guncelle.Location = new System.Drawing.Point(380, 243);
            this.btn_sarki_guncelle.Name = "btn_sarki_guncelle";
            this.btn_sarki_guncelle.Size = new System.Drawing.Size(157, 23);
            this.btn_sarki_guncelle.TabIndex = 6;
            this.btn_sarki_guncelle.Text = "GÜNCELLE";
            this.btn_sarki_guncelle.UseVisualStyleBackColor = true;
            this.btn_sarki_guncelle.Click += new System.EventHandler(this.btn_sarki_guncelle_Click);
            // 
            // nmb_sarki_tarih
            // 
            this.nmb_sarki_tarih.Location = new System.Drawing.Point(123, 333);
            this.nmb_sarki_tarih.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nmb_sarki_tarih.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nmb_sarki_tarih.Name = "nmb_sarki_tarih";
            this.nmb_sarki_tarih.Size = new System.Drawing.Size(151, 20);
            this.nmb_sarki_tarih.TabIndex = 7;
            this.nmb_sarki_tarih.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // nmb_sarki_dinlenme
            // 
            this.nmb_sarki_dinlenme.Location = new System.Drawing.Point(123, 435);
            this.nmb_sarki_dinlenme.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nmb_sarki_dinlenme.Name = "nmb_sarki_dinlenme";
            this.nmb_sarki_dinlenme.Size = new System.Drawing.Size(151, 20);
            this.nmb_sarki_dinlenme.TabIndex = 8;
            this.nmb_sarki_dinlenme.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ŞARKILAR);
            this.tabControl1.Controls.Add(this.SANATÇILAR);
            this.tabControl1.Controls.Add(this.ALBÜMLER);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 641);
            this.tabControl1.TabIndex = 9;
            // 
            // ŞARKILAR
            // 
            this.ŞARKILAR.Controls.Add(this.lst_sarkilar);
            this.ŞARKILAR.Controls.Add(this.nmb_sarki_sure);
            this.ŞARKILAR.Controls.Add(this.nmb_sarki_dinlenme);
            this.ŞARKILAR.Controls.Add(this.nmb_sarki_tarih);
            this.ŞARKILAR.Controls.Add(this.btn_sarki_kaydet);
            this.ŞARKILAR.Controls.Add(this.cmb_sarki_tur);
            this.ŞARKILAR.Controls.Add(this.btn_sarki_guncelle);
            this.ŞARKILAR.Controls.Add(this.cmb_sarki_album);
            this.ŞARKILAR.Controls.Add(this.btn_sarki_sil);
            this.ŞARKILAR.Controls.Add(this.cmb_sarki_sanatci);
            this.ŞARKILAR.Controls.Add(this.label1);
            this.ŞARKILAR.Controls.Add(this.label8);
            this.ŞARKILAR.Controls.Add(this.label6);
            this.ŞARKILAR.Controls.Add(this.txt_sarki_adi);
            this.ŞARKILAR.Controls.Add(this.label5);
            this.ŞARKILAR.Controls.Add(this.label2);
            this.ŞARKILAR.Controls.Add(this.label4);
            this.ŞARKILAR.Controls.Add(this.lbl_sanatci);
            this.ŞARKILAR.Location = new System.Drawing.Point(4, 22);
            this.ŞARKILAR.Name = "ŞARKILAR";
            this.ŞARKILAR.Padding = new System.Windows.Forms.Padding(3);
            this.ŞARKILAR.Size = new System.Drawing.Size(987, 615);
            this.ŞARKILAR.TabIndex = 0;
            this.ŞARKILAR.Text = "ŞARKILAR";
            this.ŞARKILAR.UseVisualStyleBackColor = true;
            // 
            // nmb_sarki_sure
            // 
            this.nmb_sarki_sure.Location = new System.Drawing.Point(123, 464);
            this.nmb_sarki_sure.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nmb_sarki_sure.Name = "nmb_sarki_sure";
            this.nmb_sarki_sure.Size = new System.Drawing.Size(151, 20);
            this.nmb_sarki_sure.TabIndex = 8;
            this.nmb_sarki_sure.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "SÜRE";
            // 
            // SANATÇILAR
            // 
            this.SANATÇILAR.Controls.Add(this.txt_sanatci_ulke);
            this.SANATÇILAR.Controls.Add(this.lst_sanatcilar);
            this.SANATÇILAR.Controls.Add(this.btn_sanatci_kaydet);
            this.SANATÇILAR.Controls.Add(this.btn_sanatci_guncelle);
            this.SANATÇILAR.Controls.Add(this.btn_sanatci_sil);
            this.SANATÇILAR.Controls.Add(this.label3);
            this.SANATÇILAR.Controls.Add(this.txt_sanatci_adi);
            this.SANATÇILAR.Controls.Add(this.label9);
            this.SANATÇILAR.Location = new System.Drawing.Point(4, 22);
            this.SANATÇILAR.Name = "SANATÇILAR";
            this.SANATÇILAR.Padding = new System.Windows.Forms.Padding(3);
            this.SANATÇILAR.Size = new System.Drawing.Size(987, 615);
            this.SANATÇILAR.TabIndex = 1;
            this.SANATÇILAR.Text = "SANATÇILAR";
            this.SANATÇILAR.UseVisualStyleBackColor = true;
            // 
            // txt_sanatci_ulke
            // 
            this.txt_sanatci_ulke.Location = new System.Drawing.Point(124, 313);
            this.txt_sanatci_ulke.Name = "txt_sanatci_ulke";
            this.txt_sanatci_ulke.Size = new System.Drawing.Size(151, 20);
            this.txt_sanatci_ulke.TabIndex = 24;
            // 
            // lst_sanatcilar
            // 
            this.lst_sanatcilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.SANATÇI,
            this.columnHeader23});
            this.lst_sanatcilar.HideSelection = false;
            this.lst_sanatcilar.Location = new System.Drawing.Point(19, 21);
            this.lst_sanatcilar.Name = "lst_sanatcilar";
            this.lst_sanatcilar.Size = new System.Drawing.Size(428, 203);
            this.lst_sanatcilar.TabIndex = 9;
            this.lst_sanatcilar.UseCompatibleStateImageBehavior = false;
            this.lst_sanatcilar.View = System.Windows.Forms.View.Details;
            this.lst_sanatcilar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 68;
            // 
            // SANATÇI
            // 
            this.SANATÇI.Text = "ADI";
            this.SANATÇI.Width = 184;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "ÜLKESİ";
            this.columnHeader23.Width = 130;
            // 
            // btn_sanatci_kaydet
            // 
            this.btn_sanatci_kaydet.Location = new System.Drawing.Point(44, 231);
            this.btn_sanatci_kaydet.Name = "btn_sanatci_kaydet";
            this.btn_sanatci_kaydet.Size = new System.Drawing.Size(127, 23);
            this.btn_sanatci_kaydet.TabIndex = 11;
            this.btn_sanatci_kaydet.Text = "KAYDET";
            this.btn_sanatci_kaydet.UseVisualStyleBackColor = true;
            this.btn_sanatci_kaydet.Click += new System.EventHandler(this.btn_sanatci_kaydet_Click);
            // 
            // btn_sanatci_guncelle
            // 
            this.btn_sanatci_guncelle.Location = new System.Drawing.Point(320, 231);
            this.btn_sanatci_guncelle.Name = "btn_sanatci_guncelle";
            this.btn_sanatci_guncelle.Size = new System.Drawing.Size(83, 23);
            this.btn_sanatci_guncelle.TabIndex = 23;
            this.btn_sanatci_guncelle.Text = "GÜNCELLE";
            this.btn_sanatci_guncelle.UseVisualStyleBackColor = true;
            this.btn_sanatci_guncelle.Click += new System.EventHandler(this.btn_sanatci_guncelle_Click);
            // 
            // btn_sanatci_sil
            // 
            this.btn_sanatci_sil.Location = new System.Drawing.Point(197, 231);
            this.btn_sanatci_sil.Name = "btn_sanatci_sil";
            this.btn_sanatci_sil.Size = new System.Drawing.Size(101, 23);
            this.btn_sanatci_sil.TabIndex = 22;
            this.btn_sanatci_sil.Text = "SİL";
            this.btn_sanatci_sil.UseVisualStyleBackColor = true;
            this.btn_sanatci_sil.Click += new System.EventHandler(this.btn_sanatci_sil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "SANATÇI  ADI";
            // 
            // txt_sanatci_adi
            // 
            this.txt_sanatci_adi.Location = new System.Drawing.Point(124, 285);
            this.txt_sanatci_adi.Name = "txt_sanatci_adi";
            this.txt_sanatci_adi.Size = new System.Drawing.Size(151, 20);
            this.txt_sanatci_adi.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "ÜLKESİ";
            // 
            // ALBÜMLER
            // 
            this.ALBÜMLER.Controls.Add(this.nmb_album_tarih);
            this.ALBÜMLER.Controls.Add(this.lst_albumler);
            this.ALBÜMLER.Controls.Add(this.btn_album_kaydet);
            this.ALBÜMLER.Controls.Add(this.cmb_album_tur);
            this.ALBÜMLER.Controls.Add(this.btn_album_guncelle);
            this.ALBÜMLER.Controls.Add(this.btn_album_sil);
            this.ALBÜMLER.Controls.Add(this.cmb_album_sanatci);
            this.ALBÜMLER.Controls.Add(this.label12);
            this.ALBÜMLER.Controls.Add(this.txt_album_adi);
            this.ALBÜMLER.Controls.Add(this.label14);
            this.ALBÜMLER.Controls.Add(this.label15);
            this.ALBÜMLER.Controls.Add(this.label16);
            this.ALBÜMLER.Location = new System.Drawing.Point(4, 22);
            this.ALBÜMLER.Name = "ALBÜMLER";
            this.ALBÜMLER.Size = new System.Drawing.Size(987, 615);
            this.ALBÜMLER.TabIndex = 2;
            this.ALBÜMLER.Text = "ALBÜMLER";
            this.ALBÜMLER.UseVisualStyleBackColor = true;
            // 
            // nmb_album_tarih
            // 
            this.nmb_album_tarih.Location = new System.Drawing.Point(117, 346);
            this.nmb_album_tarih.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nmb_album_tarih.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nmb_album_tarih.Name = "nmb_album_tarih";
            this.nmb_album_tarih.Size = new System.Drawing.Size(151, 20);
            this.nmb_album_tarih.TabIndex = 25;
            this.nmb_album_tarih.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // lst_albumler
            // 
            this.lst_albumler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader13,
            this.columnHeader14});
            this.lst_albumler.HideSelection = false;
            this.lst_albumler.Location = new System.Drawing.Point(16, 18);
            this.lst_albumler.Name = "lst_albumler";
            this.lst_albumler.Size = new System.Drawing.Size(653, 203);
            this.lst_albumler.TabIndex = 24;
            this.lst_albumler.UseCompatibleStateImageBehavior = false;
            this.lst_albumler.View = System.Windows.Forms.View.Details;
            this.lst_albumler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView3_MouseDoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 68;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ADI";
            this.columnHeader10.Width = 184;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "SANATÇI";
            this.columnHeader11.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "TARİH";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "TÜR";
            // 
            // btn_album_kaydet
            // 
            this.btn_album_kaydet.Location = new System.Drawing.Point(144, 227);
            this.btn_album_kaydet.Name = "btn_album_kaydet";
            this.btn_album_kaydet.Size = new System.Drawing.Size(163, 23);
            this.btn_album_kaydet.TabIndex = 11;
            this.btn_album_kaydet.Text = "KAYDET";
            this.btn_album_kaydet.UseVisualStyleBackColor = true;
            this.btn_album_kaydet.Click += new System.EventHandler(this.btn_album_kaydet_Click);
            // 
            // cmb_album_tur
            // 
            this.cmb_album_tur.FormattingEnabled = true;
            this.cmb_album_tur.Location = new System.Drawing.Point(117, 371);
            this.cmb_album_tur.Name = "cmb_album_tur";
            this.cmb_album_tur.Size = new System.Drawing.Size(151, 21);
            this.cmb_album_tur.TabIndex = 21;
            // 
            // btn_album_guncelle
            // 
            this.btn_album_guncelle.Location = new System.Drawing.Point(407, 228);
            this.btn_album_guncelle.Name = "btn_album_guncelle";
            this.btn_album_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_album_guncelle.TabIndex = 23;
            this.btn_album_guncelle.Text = "GÜNCELLE";
            this.btn_album_guncelle.UseVisualStyleBackColor = true;
            this.btn_album_guncelle.Click += new System.EventHandler(this.btn_album_guncelle_Click);
            // 
            // btn_album_sil
            // 
            this.btn_album_sil.Location = new System.Drawing.Point(325, 227);
            this.btn_album_sil.Name = "btn_album_sil";
            this.btn_album_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_album_sil.TabIndex = 22;
            this.btn_album_sil.Text = "SİL";
            this.btn_album_sil.UseVisualStyleBackColor = true;
            this.btn_album_sil.Click += new System.EventHandler(this.btn_album_sil_Click);
            // 
            // cmb_album_sanatci
            // 
            this.cmb_album_sanatci.FormattingEnabled = true;
            this.cmb_album_sanatci.Location = new System.Drawing.Point(117, 315);
            this.cmb_album_sanatci.Name = "cmb_album_sanatci";
            this.cmb_album_sanatci.Size = new System.Drawing.Size(151, 21);
            this.cmb_album_sanatci.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "ALBÜM";
            // 
            // txt_album_adi
            // 
            this.txt_album_adi.Location = new System.Drawing.Point(117, 289);
            this.txt_album_adi.Name = "txt_album_adi";
            this.txt_album_adi.Size = new System.Drawing.Size(151, 20);
            this.txt_album_adi.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "TÜR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "SANATÇI";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 347);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "TARİH";
            // 
            // FormAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAnaEkran";
            this.Text = "FormAnaEkran";
            this.Load += new System.EventHandler(this.FormAnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmb_sarki_tarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_sarki_dinlenme)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ŞARKILAR.ResumeLayout(false);
            this.ŞARKILAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_sarki_sure)).EndInit();
            this.SANATÇILAR.ResumeLayout(false);
            this.SANATÇILAR.PerformLayout();
            this.ALBÜMLER.ResumeLayout(false);
            this.ALBÜMLER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_album_tarih)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_sarkilar;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txt_sarki_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_sanatci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sarki_kaydet;
        private System.Windows.Forms.ComboBox cmb_sarki_sanatci;
        private System.Windows.Forms.ComboBox cmb_sarki_album;
        private System.Windows.Forms.ComboBox cmb_sarki_tur;
        private System.Windows.Forms.Button btn_sarki_sil;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_sarki_guncelle;
        private System.Windows.Forms.NumericUpDown nmb_sarki_tarih;
        private System.Windows.Forms.NumericUpDown nmb_sarki_dinlenme;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ŞARKILAR;
        private System.Windows.Forms.TabPage SANATÇILAR;
        private System.Windows.Forms.ListView lst_sanatcilar;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_sanatci_kaydet;
        private System.Windows.Forms.Button btn_sanatci_guncelle;
        private System.Windows.Forms.Button btn_sanatci_sil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sanatci_adi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage ALBÜMLER;
        private System.Windows.Forms.Button btn_album_kaydet;
        private System.Windows.Forms.ComboBox cmb_album_tur;
        private System.Windows.Forms.Button btn_album_guncelle;
        private System.Windows.Forms.Button btn_album_sil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_album_adi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_sanatci_ulke;
        private System.Windows.Forms.ColumnHeader SANATÇI;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ComboBox cmb_album_sanatci;
        private System.Windows.Forms.ListView lst_albumler;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.NumericUpDown nmb_album_tarih;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.NumericUpDown nmb_sarki_sure;
        private System.Windows.Forms.Label label8;
    }
}