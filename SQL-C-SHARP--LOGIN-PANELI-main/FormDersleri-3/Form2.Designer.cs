namespace FormDersleri_3
{
    partial class Form2
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
            this.dtg_ogrenci = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.lbl_no = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tasi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ogrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_ogrenci
            // 
            this.dtg_ogrenci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_ogrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ogrenci.Location = new System.Drawing.Point(29, 54);
            this.dtg_ogrenci.Name = "dtg_ogrenci";
            this.dtg_ogrenci.RowHeadersWidth = 51;
            this.dtg_ogrenci.RowTemplate.Height = 29;
            this.dtg_ogrenci.Size = new System.Drawing.Size(723, 224);
            this.dtg_ogrenci.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(91, 316);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(94, 29);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(91, 372);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(94, 29);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Location = new System.Drawing.Point(349, 307);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(154, 20);
            this.lbl_no.TabIndex = 3;
            this.lbl_no.Text = "OGRENCİ NUMARASI ";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(349, 347);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(100, 20);
            this.lbl_Ad.TabIndex = 4;
            this.lbl_Ad.Text = "OGRENCİ ADI";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(349, 393);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(126, 20);
            this.lbl_soyad.TabIndex = 5;
            this.lbl_soyad.Text = "OGRENCİ SOYADI";
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(548, 308);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(171, 27);
            this.txt_no.TabIndex = 6;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(548, 344);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(171, 27);
            this.txt_ad.TabIndex = 7;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(548, 386);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(171, 27);
            this.txt_soyad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "HOŞGELDİNİZ ";
            // 
            // lbl_tasi
            // 
            this.lbl_tasi.AutoSize = true;
            this.lbl_tasi.Location = new System.Drawing.Point(142, 9);
            this.lbl_tasi.Name = "lbl_tasi";
            this.lbl_tasi.Size = new System.Drawing.Size(50, 20);
            this.lbl_tasi.TabIndex = 10;
            this.lbl_tasi.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_tasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.lbl_no);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dtg_ogrenci);
            this.Name = "Form2";
            this.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ogrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_ogrenci;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label lbl_no;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tasi;
    }
}