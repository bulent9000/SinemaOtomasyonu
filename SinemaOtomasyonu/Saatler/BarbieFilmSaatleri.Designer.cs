﻿namespace SinemaOtomasyonu.Saatler
{
    partial class BarbieFilmSaatleri
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
            this.btn_aslanKralKoltukEkrani = new System.Windows.Forms.Button();
            this.cmb_salonlar = new System.Windows.Forms.ComboBox();
            this.cmb_saatler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_aslanKralKoltukEkrani
            // 
            this.btn_aslanKralKoltukEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_aslanKralKoltukEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aslanKralKoltukEkrani.ForeColor = System.Drawing.Color.White;
            this.btn_aslanKralKoltukEkrani.Location = new System.Drawing.Point(65, 131);
            this.btn_aslanKralKoltukEkrani.Name = "btn_aslanKralKoltukEkrani";
            this.btn_aslanKralKoltukEkrani.Size = new System.Drawing.Size(671, 95);
            this.btn_aslanKralKoltukEkrani.TabIndex = 5;
            this.btn_aslanKralKoltukEkrani.Text = "       KOLTUK EKRANI İÇİN \r\n     \r\n       DEVAM ET";
            this.btn_aslanKralKoltukEkrani.UseVisualStyleBackColor = false;
            this.btn_aslanKralKoltukEkrani.Click += new System.EventHandler(this.btn_aslanKralKoltukEkrani_Click);
            // 
            // cmb_salonlar
            // 
            this.cmb_salonlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_salonlar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_salonlar.FormattingEnabled = true;
            this.cmb_salonlar.Items.AddRange(new object[] {
            "2",
            "4"});
            this.cmb_salonlar.Location = new System.Drawing.Point(65, 50);
            this.cmb_salonlar.Name = "cmb_salonlar";
            this.cmb_salonlar.Size = new System.Drawing.Size(284, 33);
            this.cmb_salonlar.TabIndex = 4;
            this.cmb_salonlar.Text = "Salon seçiniz...";
            this.cmb_salonlar.SelectedIndexChanged += new System.EventHandler(this.cmb_salonlar_SelectedIndexChanged);
            // 
            // cmb_saatler
            // 
            this.cmb_saatler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_saatler.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_saatler.FormattingEnabled = true;
            this.cmb_saatler.Items.AddRange(new object[] {
            "",
            "11:30",
            "13:00",
            "14:00",
            "15:00",
            "16:30",
            "18:00",
            "19:00",
            "20:30",
            "21:30"});
            this.cmb_saatler.Location = new System.Drawing.Point(452, 50);
            this.cmb_saatler.Name = "cmb_saatler";
            this.cmb_saatler.Size = new System.Drawing.Size(284, 33);
            this.cmb_saatler.TabIndex = 3;
            this.cmb_saatler.Text = "Saat seçiniz...";
            // 
            // BarbieFilmSaatleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.btn_aslanKralKoltukEkrani);
            this.Controls.Add(this.cmb_salonlar);
            this.Controls.Add(this.cmb_saatler);
            this.Name = "BarbieFilmSaatleri";
            this.Text = "Barbie Film Saatleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_aslanKralKoltukEkrani;
        private System.Windows.Forms.ComboBox cmb_salonlar;
        private System.Windows.Forms.ComboBox cmb_saatler;
    }
}