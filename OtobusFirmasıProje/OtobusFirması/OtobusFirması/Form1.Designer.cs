
namespace OtobusFirması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.biletOlusturBtn = new ns1.BunifuTileButton();
            this.personelIslemBtn = new ns1.BunifuTileButton();
            this.masrafKayıtBtn = new ns1.BunifuTileButton();
            this.KapaBtn = new ns1.BunifuThinButton2();
            this.AltIndırBtn = new ns1.BunifuThinButton2();
            this.seferOlusturBtn = new ns1.BunifuTileButton();
            this.bilgiBtn = new ns1.BunifuTileButton();
            this.eklentiBtn = new ns1.BunifuTileButton();
            this.SuspendLayout();
            // 
            // biletOlusturBtn
            // 
            this.biletOlusturBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.biletOlusturBtn.color = System.Drawing.Color.PaleGoldenrod;
            this.biletOlusturBtn.colorActive = System.Drawing.Color.Wheat;
            this.biletOlusturBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biletOlusturBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.biletOlusturBtn.ForeColor = System.Drawing.Color.White;
            this.biletOlusturBtn.Image = ((System.Drawing.Image)(resources.GetObject("biletOlusturBtn.Image")));
            this.biletOlusturBtn.ImagePosition = 15;
            this.biletOlusturBtn.ImageZoom = 30;
            this.biletOlusturBtn.LabelPosition = 41;
            this.biletOlusturBtn.LabelText = "Bilet Oluştur";
            this.biletOlusturBtn.Location = new System.Drawing.Point(66, 81);
            this.biletOlusturBtn.Margin = new System.Windows.Forms.Padding(6);
            this.biletOlusturBtn.Name = "biletOlusturBtn";
            this.biletOlusturBtn.Size = new System.Drawing.Size(201, 113);
            this.biletOlusturBtn.TabIndex = 2;
            this.biletOlusturBtn.Click += new System.EventHandler(this.biletOlusturBtn_Click);
            // 
            // personelIslemBtn
            // 
            this.personelIslemBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.personelIslemBtn.color = System.Drawing.Color.PaleGoldenrod;
            this.personelIslemBtn.colorActive = System.Drawing.Color.Wheat;
            this.personelIslemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personelIslemBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.personelIslemBtn.ForeColor = System.Drawing.Color.White;
            this.personelIslemBtn.Image = ((System.Drawing.Image)(resources.GetObject("personelIslemBtn.Image")));
            this.personelIslemBtn.ImagePosition = 2;
            this.personelIslemBtn.ImageZoom = 38;
            this.personelIslemBtn.LabelPosition = 41;
            this.personelIslemBtn.LabelText = "Personel Kayıt";
            this.personelIslemBtn.Location = new System.Drawing.Point(66, 223);
            this.personelIslemBtn.Margin = new System.Windows.Forms.Padding(6);
            this.personelIslemBtn.Name = "personelIslemBtn";
            this.personelIslemBtn.Size = new System.Drawing.Size(201, 113);
            this.personelIslemBtn.TabIndex = 3;
            this.personelIslemBtn.Click += new System.EventHandler(this.personelIslemBtn_Click);
            // 
            // masrafKayıtBtn
            // 
            this.masrafKayıtBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.masrafKayıtBtn.color = System.Drawing.Color.PaleGoldenrod;
            this.masrafKayıtBtn.colorActive = System.Drawing.Color.Wheat;
            this.masrafKayıtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masrafKayıtBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.masrafKayıtBtn.ForeColor = System.Drawing.Color.White;
            this.masrafKayıtBtn.Image = ((System.Drawing.Image)(resources.GetObject("masrafKayıtBtn.Image")));
            this.masrafKayıtBtn.ImagePosition = 2;
            this.masrafKayıtBtn.ImageZoom = 38;
            this.masrafKayıtBtn.LabelPosition = 41;
            this.masrafKayıtBtn.LabelText = "Masraf Kayıt";
            this.masrafKayıtBtn.Location = new System.Drawing.Point(66, 366);
            this.masrafKayıtBtn.Margin = new System.Windows.Forms.Padding(6);
            this.masrafKayıtBtn.Name = "masrafKayıtBtn";
            this.masrafKayıtBtn.Size = new System.Drawing.Size(201, 113);
            this.masrafKayıtBtn.TabIndex = 4;
            this.masrafKayıtBtn.Click += new System.EventHandler(this.masrafKayıtBtn_Click);
            // 
            // KapaBtn
            // 
            this.KapaBtn.ActiveBorderThickness = 1;
            this.KapaBtn.ActiveCornerRadius = 1;
            this.KapaBtn.ActiveFillColor = System.Drawing.Color.PaleGoldenrod;
            this.KapaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.KapaBtn.ActiveLineColor = System.Drawing.Color.PaleGoldenrod;
            this.KapaBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.KapaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KapaBtn.BackgroundImage")));
            this.KapaBtn.ButtonText = "X";
            this.KapaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KapaBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KapaBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.KapaBtn.IdleBorderThickness = 1;
            this.KapaBtn.IdleCornerRadius = 1;
            this.KapaBtn.IdleFillColor = System.Drawing.Color.White;
            this.KapaBtn.IdleForecolor = System.Drawing.Color.PaleGoldenrod;
            this.KapaBtn.IdleLineColor = System.Drawing.Color.PaleGoldenrod;
            this.KapaBtn.Location = new System.Drawing.Point(572, 14);
            this.KapaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.KapaBtn.Name = "KapaBtn";
            this.KapaBtn.Size = new System.Drawing.Size(40, 48);
            this.KapaBtn.TabIndex = 5;
            this.KapaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AltIndırBtn
            // 
            this.AltIndırBtn.ActiveBorderThickness = 1;
            this.AltIndırBtn.ActiveCornerRadius = 1;
            this.AltIndırBtn.ActiveFillColor = System.Drawing.Color.PaleGoldenrod;
            this.AltIndırBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AltIndırBtn.ActiveLineColor = System.Drawing.Color.PaleGoldenrod;
            this.AltIndırBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AltIndırBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AltIndırBtn.BackgroundImage")));
            this.AltIndırBtn.ButtonText = "-";
            this.AltIndırBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AltIndırBtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AltIndırBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AltIndırBtn.IdleBorderThickness = 1;
            this.AltIndırBtn.IdleCornerRadius = 1;
            this.AltIndırBtn.IdleFillColor = System.Drawing.Color.White;
            this.AltIndırBtn.IdleForecolor = System.Drawing.Color.PaleGoldenrod;
            this.AltIndırBtn.IdleLineColor = System.Drawing.Color.PaleGoldenrod;
            this.AltIndırBtn.Location = new System.Drawing.Point(522, 14);
            this.AltIndırBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AltIndırBtn.Name = "AltIndırBtn";
            this.AltIndırBtn.Size = new System.Drawing.Size(40, 48);
            this.AltIndırBtn.TabIndex = 6;
            this.AltIndırBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seferOlusturBtn
            // 
            this.seferOlusturBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.seferOlusturBtn.color = System.Drawing.Color.PaleGoldenrod;
            this.seferOlusturBtn.colorActive = System.Drawing.Color.Wheat;
            this.seferOlusturBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seferOlusturBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.seferOlusturBtn.ForeColor = System.Drawing.Color.White;
            this.seferOlusturBtn.Image = ((System.Drawing.Image)(resources.GetObject("seferOlusturBtn.Image")));
            this.seferOlusturBtn.ImagePosition = 2;
            this.seferOlusturBtn.ImageZoom = 38;
            this.seferOlusturBtn.LabelPosition = 41;
            this.seferOlusturBtn.LabelText = "Sefer Oluştur";
            this.seferOlusturBtn.Location = new System.Drawing.Point(361, 81);
            this.seferOlusturBtn.Margin = new System.Windows.Forms.Padding(6);
            this.seferOlusturBtn.Name = "seferOlusturBtn";
            this.seferOlusturBtn.Size = new System.Drawing.Size(201, 113);
            this.seferOlusturBtn.TabIndex = 7;
            this.seferOlusturBtn.Click += new System.EventHandler(this.seferOlusturBtn_Click_1);
            // 
            // bilgiBtn
            // 
            this.bilgiBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.bilgiBtn.color = System.Drawing.Color.PaleGoldenrod;
            this.bilgiBtn.colorActive = System.Drawing.Color.Wheat;
            this.bilgiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bilgiBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bilgiBtn.ForeColor = System.Drawing.Color.White;
            this.bilgiBtn.Image = ((System.Drawing.Image)(resources.GetObject("bilgiBtn.Image")));
            this.bilgiBtn.ImagePosition = 2;
            this.bilgiBtn.ImageZoom = 38;
            this.bilgiBtn.LabelPosition = 41;
            this.bilgiBtn.LabelText = "Kayıtlı Bilgiler";
            this.bilgiBtn.Location = new System.Drawing.Point(361, 366);
            this.bilgiBtn.Margin = new System.Windows.Forms.Padding(6);
            this.bilgiBtn.Name = "bilgiBtn";
            this.bilgiBtn.Size = new System.Drawing.Size(201, 113);
            this.bilgiBtn.TabIndex = 10;
            this.bilgiBtn.Click += new System.EventHandler(this.bilgiBtn_Click);
            // 
            // eklentiBtn
            // 
            this.eklentiBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.eklentiBtn.color = System.Drawing.Color.PaleGoldenrod;
            this.eklentiBtn.colorActive = System.Drawing.Color.Wheat;
            this.eklentiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eklentiBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.eklentiBtn.ForeColor = System.Drawing.Color.White;
            this.eklentiBtn.Image = ((System.Drawing.Image)(resources.GetObject("eklentiBtn.Image")));
            this.eklentiBtn.ImagePosition = 2;
            this.eklentiBtn.ImageZoom = 38;
            this.eklentiBtn.LabelPosition = 41;
            this.eklentiBtn.LabelText = "Eklentiler";
            this.eklentiBtn.Location = new System.Drawing.Point(361, 223);
            this.eklentiBtn.Margin = new System.Windows.Forms.Padding(6);
            this.eklentiBtn.Name = "eklentiBtn";
            this.eklentiBtn.Size = new System.Drawing.Size(201, 113);
            this.eklentiBtn.TabIndex = 11;
            this.eklentiBtn.Click += new System.EventHandler(this.eklentiBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(645, 537);
            this.Controls.Add(this.eklentiBtn);
            this.Controls.Add(this.bilgiBtn);
            this.Controls.Add(this.seferOlusturBtn);
            this.Controls.Add(this.AltIndırBtn);
            this.Controls.Add(this.KapaBtn);
            this.Controls.Add(this.masrafKayıtBtn);
            this.Controls.Add(this.personelIslemBtn);
            this.Controls.Add(this.biletOlusturBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuTileButton biletOlusturBtn;
        private ns1.BunifuTileButton personelIslemBtn;
        private ns1.BunifuTileButton masrafKayıtBtn;
        private ns1.BunifuThinButton2 KapaBtn;
        private ns1.BunifuThinButton2 AltIndırBtn;
        private ns1.BunifuTileButton seferOlusturBtn;
        private ns1.BunifuTileButton bilgiBtn;
        private ns1.BunifuTileButton eklentiBtn;
    }
}

