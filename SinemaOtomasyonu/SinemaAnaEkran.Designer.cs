namespace SinemaOtomasyonu
{
    partial class SinemaAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinemaAnaEkran));
            this.cmb_sehirler = new System.Windows.Forms.ComboBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.cmb_filmTürü = new System.Windows.Forms.ComboBox();
            this.cmb_mekanlar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cruella = new SinemaOtomasyonu.roundButton();
            this.btn_suikastcilar = new SinemaOtomasyonu.roundButton();
            this.btn_periliKösk = new SinemaOtomasyonu.roundButton();
            this.btn_katiliYakalamak = new SinemaOtomasyonu.roundButton();
            this.btn_granTourismo = new SinemaOtomasyonu.roundButton();
            this.btn_gelecegeDönüs = new SinemaOtomasyonu.roundButton();
            this.btn_doru = new SinemaOtomasyonu.roundButton();
            this.btn_openheimer = new SinemaOtomasyonu.roundButton();
            this.btn_meg2 = new SinemaOtomasyonu.roundButton();
            this.btn_barbie = new SinemaOtomasyonu.roundButton();
            this.rbtn_ninjaKaplumbaga = new SinemaOtomasyonu.roundButton();
            this.btn_dracula = new SinemaOtomasyonu.roundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_sehirler
            // 
            this.cmb_sehirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_sehirler.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmb_sehirler.FormattingEnabled = true;
            this.cmb_sehirler.Items.AddRange(new object[] {
            "İstanbul Avrupa",
            "İstanbul Anadolu",
            "Antalya",
            "Bursa",
            "Ankara"});
            this.cmb_sehirler.Location = new System.Drawing.Point(137, 45);
            this.cmb_sehirler.Name = "cmb_sehirler";
            this.cmb_sehirler.Size = new System.Drawing.Size(340, 32);
            this.cmb_sehirler.TabIndex = 0;
            this.cmb_sehirler.Text = "Şehir seçiniz...";
            this.cmb_sehirler.SelectedIndexChanged += new System.EventHandler(this.cmb_sehirler_SelectedIndexChanged);
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtp_tarih.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtp_tarih.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtp_tarih.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtp_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_tarih.Location = new System.Drawing.Point(747, 105);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(340, 29);
            this.dtp_tarih.TabIndex = 2;
            this.dtp_tarih.Value = new System.DateTime(2023, 8, 24, 0, 0, 0, 0);
            // 
            // cmb_filmTürü
            // 
            this.cmb_filmTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_filmTürü.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmb_filmTürü.FormattingEnabled = true;
            this.cmb_filmTürü.Items.AddRange(new object[] {
            "Aile",
            "Aksiyon",
            "Bilimkurgu",
            "Drama",
            "Gerilim-Korku",
            "Komedi"});
            this.cmb_filmTürü.Location = new System.Drawing.Point(137, 98);
            this.cmb_filmTürü.Name = "cmb_filmTürü";
            this.cmb_filmTürü.Size = new System.Drawing.Size(340, 32);
            this.cmb_filmTürü.TabIndex = 3;
            this.cmb_filmTürü.Text = "Film türü seçiniz...";
            this.cmb_filmTürü.SelectedIndexChanged += new System.EventHandler(this.cmb_filmTürü_SelectedIndexChanged);
            // 
            // cmb_mekanlar
            // 
            this.cmb_mekanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_mekanlar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmb_mekanlar.FormattingEnabled = true;
            this.cmb_mekanlar.Location = new System.Drawing.Point(747, 47);
            this.cmb_mekanlar.Name = "cmb_mekanlar";
            this.cmb_mekanlar.Size = new System.Drawing.Size(340, 32);
            this.cmb_mekanlar.TabIndex = 1;
            this.cmb_mekanlar.Text = "Mekan seçiniz...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(554, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Etkinlik Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(-171, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(554, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mekanlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(-171, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Şehirler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(23, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Şehirler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(23, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tür";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btn_cruella);
            this.panel1.Controls.Add(this.btn_suikastcilar);
            this.panel1.Controls.Add(this.btn_periliKösk);
            this.panel1.Controls.Add(this.btn_katiliYakalamak);
            this.panel1.Controls.Add(this.btn_granTourismo);
            this.panel1.Controls.Add(this.btn_gelecegeDönüs);
            this.panel1.Controls.Add(this.btn_doru);
            this.panel1.Controls.Add(this.btn_openheimer);
            this.panel1.Controls.Add(this.btn_meg2);
            this.panel1.Controls.Add(this.btn_barbie);
            this.panel1.Controls.Add(this.rbtn_ninjaKaplumbaga);
            this.panel1.Controls.Add(this.btn_dracula);
            this.panel1.Location = new System.Drawing.Point(4, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 545);
            this.panel1.TabIndex = 24;
            // 
            // btn_cruella
            // 
            this.btn_cruella.BackColor = System.Drawing.Color.Lime;
            this.btn_cruella.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cruella.BackgroundImage")));
            this.btn_cruella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cruella.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cruella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cruella.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cruella.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cruella.Location = new System.Drawing.Point(1132, 278);
            this.btn_cruella.Name = "btn_cruella";
            this.btn_cruella.Size = new System.Drawing.Size(200, 248);
            this.btn_cruella.TabIndex = 14;
            this.btn_cruella.UseVisualStyleBackColor = false;
            this.btn_cruella.Click += new System.EventHandler(this.btn_cruella_Click);
            // 
            // btn_suikastcilar
            // 
            this.btn_suikastcilar.BackColor = System.Drawing.Color.Lime;
            this.btn_suikastcilar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suikastcilar.BackgroundImage")));
            this.btn_suikastcilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_suikastcilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suikastcilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suikastcilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_suikastcilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_suikastcilar.Location = new System.Drawing.Point(915, 278);
            this.btn_suikastcilar.Name = "btn_suikastcilar";
            this.btn_suikastcilar.Size = new System.Drawing.Size(200, 248);
            this.btn_suikastcilar.TabIndex = 13;
            this.btn_suikastcilar.UseVisualStyleBackColor = false;
            this.btn_suikastcilar.Click += new System.EventHandler(this.btn_suikastcilar_Click);
            // 
            // btn_periliKösk
            // 
            this.btn_periliKösk.BackColor = System.Drawing.Color.Lime;
            this.btn_periliKösk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_periliKösk.BackgroundImage")));
            this.btn_periliKösk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_periliKösk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_periliKösk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_periliKösk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_periliKösk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_periliKösk.Location = new System.Drawing.Point(697, 275);
            this.btn_periliKösk.Name = "btn_periliKösk";
            this.btn_periliKösk.Size = new System.Drawing.Size(200, 248);
            this.btn_periliKösk.TabIndex = 12;
            this.btn_periliKösk.UseVisualStyleBackColor = false;
            this.btn_periliKösk.Click += new System.EventHandler(this.btn_periliKösk_Click);
            // 
            // btn_katiliYakalamak
            // 
            this.btn_katiliYakalamak.BackColor = System.Drawing.Color.Lime;
            this.btn_katiliYakalamak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_katiliYakalamak.BackgroundImage")));
            this.btn_katiliYakalamak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_katiliYakalamak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_katiliYakalamak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_katiliYakalamak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_katiliYakalamak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_katiliYakalamak.Location = new System.Drawing.Point(467, 275);
            this.btn_katiliYakalamak.Name = "btn_katiliYakalamak";
            this.btn_katiliYakalamak.Size = new System.Drawing.Size(200, 248);
            this.btn_katiliYakalamak.TabIndex = 11;
            this.btn_katiliYakalamak.UseVisualStyleBackColor = false;
            this.btn_katiliYakalamak.Click += new System.EventHandler(this.btn_katiliYakalamak_Click);
            // 
            // btn_granTourismo
            // 
            this.btn_granTourismo.BackColor = System.Drawing.Color.Lime;
            this.btn_granTourismo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_granTourismo.BackgroundImage")));
            this.btn_granTourismo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_granTourismo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_granTourismo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_granTourismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_granTourismo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_granTourismo.Location = new System.Drawing.Point(246, 264);
            this.btn_granTourismo.Name = "btn_granTourismo";
            this.btn_granTourismo.Size = new System.Drawing.Size(200, 248);
            this.btn_granTourismo.TabIndex = 10;
            this.btn_granTourismo.UseVisualStyleBackColor = false;
            this.btn_granTourismo.Click += new System.EventHandler(this.btn_granTourismo_Click);
            // 
            // btn_gelecegeDönüs
            // 
            this.btn_gelecegeDönüs.BackColor = System.Drawing.Color.Lime;
            this.btn_gelecegeDönüs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gelecegeDönüs.BackgroundImage")));
            this.btn_gelecegeDönüs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gelecegeDönüs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gelecegeDönüs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gelecegeDönüs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gelecegeDönüs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_gelecegeDönüs.Location = new System.Drawing.Point(24, 264);
            this.btn_gelecegeDönüs.Name = "btn_gelecegeDönüs";
            this.btn_gelecegeDönüs.Size = new System.Drawing.Size(200, 248);
            this.btn_gelecegeDönüs.TabIndex = 9;
            this.btn_gelecegeDönüs.UseVisualStyleBackColor = false;
            this.btn_gelecegeDönüs.Click += new System.EventHandler(this.btn_gelecegeDönüs_Click);
            // 
            // btn_doru
            // 
            this.btn_doru.BackColor = System.Drawing.Color.Lime;
            this.btn_doru.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doru.BackgroundImage")));
            this.btn_doru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_doru.Location = new System.Drawing.Point(1132, 24);
            this.btn_doru.Name = "btn_doru";
            this.btn_doru.Size = new System.Drawing.Size(200, 248);
            this.btn_doru.TabIndex = 8;
            this.btn_doru.UseVisualStyleBackColor = false;
            this.btn_doru.Click += new System.EventHandler(this.btn_doru_Click);
            // 
            // btn_openheimer
            // 
            this.btn_openheimer.BackColor = System.Drawing.Color.Lime;
            this.btn_openheimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_openheimer.BackgroundImage")));
            this.btn_openheimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_openheimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_openheimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openheimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_openheimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_openheimer.Location = new System.Drawing.Point(915, 24);
            this.btn_openheimer.Name = "btn_openheimer";
            this.btn_openheimer.Size = new System.Drawing.Size(200, 248);
            this.btn_openheimer.TabIndex = 7;
            this.btn_openheimer.UseVisualStyleBackColor = false;
            this.btn_openheimer.Click += new System.EventHandler(this.btn_openheimer_Click);
            // 
            // btn_meg2
            // 
            this.btn_meg2.BackColor = System.Drawing.Color.Lime;
            this.btn_meg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_meg2.BackgroundImage")));
            this.btn_meg2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_meg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_meg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_meg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_meg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_meg2.Location = new System.Drawing.Point(685, 12);
            this.btn_meg2.Name = "btn_meg2";
            this.btn_meg2.Size = new System.Drawing.Size(212, 246);
            this.btn_meg2.TabIndex = 6;
            this.btn_meg2.UseVisualStyleBackColor = false;
            this.btn_meg2.Click += new System.EventHandler(this.btn_meg2_Click);
            // 
            // btn_barbie
            // 
            this.btn_barbie.BackColor = System.Drawing.Color.Lime;
            this.btn_barbie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_barbie.BackgroundImage")));
            this.btn_barbie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_barbie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_barbie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barbie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_barbie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_barbie.Location = new System.Drawing.Point(467, 12);
            this.btn_barbie.Name = "btn_barbie";
            this.btn_barbie.Size = new System.Drawing.Size(212, 246);
            this.btn_barbie.TabIndex = 5;
            this.btn_barbie.UseVisualStyleBackColor = false;
            this.btn_barbie.Click += new System.EventHandler(this.btn_barbie_Click);
            // 
            // rbtn_ninjaKaplumbaga
            // 
            this.rbtn_ninjaKaplumbaga.BackColor = System.Drawing.Color.Lime;
            this.rbtn_ninjaKaplumbaga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtn_ninjaKaplumbaga.BackgroundImage")));
            this.rbtn_ninjaKaplumbaga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtn_ninjaKaplumbaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_ninjaKaplumbaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_ninjaKaplumbaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn_ninjaKaplumbaga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_ninjaKaplumbaga.Location = new System.Drawing.Point(234, 12);
            this.rbtn_ninjaKaplumbaga.Name = "rbtn_ninjaKaplumbaga";
            this.rbtn_ninjaKaplumbaga.Size = new System.Drawing.Size(212, 246);
            this.rbtn_ninjaKaplumbaga.TabIndex = 1;
            this.rbtn_ninjaKaplumbaga.UseVisualStyleBackColor = false;
            this.rbtn_ninjaKaplumbaga.Click += new System.EventHandler(this.rbtn_ninjaKaplumbaga_Click);
            // 
            // btn_dracula
            // 
            this.btn_dracula.BackColor = System.Drawing.Color.Lime;
            this.btn_dracula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dracula.BackgroundImage")));
            this.btn_dracula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dracula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dracula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dracula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dracula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_dracula.Location = new System.Drawing.Point(8, 12);
            this.btn_dracula.Name = "btn_dracula";
            this.btn_dracula.Size = new System.Drawing.Size(212, 246);
            this.btn_dracula.TabIndex = 0;
            this.btn_dracula.UseVisualStyleBackColor = false;
            this.btn_dracula.Click += new System.EventHandler(this.btn_dracula_Click);
            // 
            // SinemaAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_sehirler);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.cmb_filmTürü);
            this.Controls.Add(this.cmb_mekanlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SinemaAnaEkran";
            this.Text = "SinemaAnaEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_sehirler;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.ComboBox cmb_filmTürü;
        private System.Windows.Forms.ComboBox cmb_mekanlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private roundButton rbtn_ninjaKaplumbaga;
        private roundButton btn_dracula;
        private roundButton btn_barbie;
        private roundButton btn_meg2;
        private roundButton btn_openheimer;
        private roundButton btn_cruella;
        private roundButton btn_suikastcilar;
        private roundButton btn_periliKösk;
        private roundButton btn_katiliYakalamak;
        private roundButton btn_granTourismo;
        private roundButton btn_gelecegeDönüs;
        private roundButton btn_doru;
    }
}