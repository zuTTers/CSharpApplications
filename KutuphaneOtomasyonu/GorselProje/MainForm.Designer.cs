namespace GorselProje
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlEnUst = new System.Windows.Forms.Panel();
            this.pictureTopIcon = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblBaslikAdi = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlEnAlt = new System.Windows.Forms.Panel();
            this.linkLabelHazirlayan = new System.Windows.Forms.LinkLabel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlEnUst2 = new System.Windows.Forms.Panel();
            this.btnKitapIslem = new System.Windows.Forms.Button();
            this.btnOgrenciIslem = new System.Windows.Forms.Button();
            this.btnOdunUzat = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnTumOgrenciler = new System.Windows.Forms.Button();
            this.btnTumKitaplar = new System.Windows.Forms.Button();
            this.lblOzluSoz = new System.Windows.Forms.Label();
            this.pbHomeImage = new System.Windows.Forms.PictureBox();
            this.pnlEnUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTopIcon)).BeginInit();
            this.pnlEnAlt.SuspendLayout();
            this.pnlEnUst2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEnUst
            // 
            this.pnlEnUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.pnlEnUst.Controls.Add(this.pictureTopIcon);
            this.pnlEnUst.Controls.Add(this.btnMinimize);
            this.pnlEnUst.Controls.Add(this.btnRestore);
            this.pnlEnUst.Controls.Add(this.lblBaslikAdi);
            this.pnlEnUst.Controls.Add(this.btnExit);
            this.pnlEnUst.Location = new System.Drawing.Point(0, -1);
            this.pnlEnUst.Name = "pnlEnUst";
            this.pnlEnUst.Size = new System.Drawing.Size(872, 41);
            this.pnlEnUst.TabIndex = 1;
            this.pnlEnUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlEnUst_MouseDown);
            this.pnlEnUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlEnUst_MouseMove);
            this.pnlEnUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlEnUst_MouseUp);
            // 
            // pictureTopIcon
            // 
            this.pictureTopIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTopIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureTopIcon.Image = global::GorselProje.Properties.Resources.study_icon_7852__32_x_32_1;
            this.pictureTopIcon.Location = new System.Drawing.Point(35, 3);
            this.pictureTopIcon.Name = "pictureTopIcon";
            this.pictureTopIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureTopIcon.TabIndex = 3;
            this.pictureTopIcon.TabStop = false;
            this.pictureTopIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureTopIcon_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(758, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.Location = new System.Drawing.Point(796, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(32, 32);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblBaslikAdi
            // 
            this.lblBaslikAdi.AutoSize = true;
            this.lblBaslikAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslikAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblBaslikAdi.Location = new System.Drawing.Point(73, 6);
            this.lblBaslikAdi.Name = "lblBaslikAdi";
            this.lblBaslikAdi.Size = new System.Drawing.Size(253, 29);
            this.lblBaslikAdi.TabIndex = 0;
            this.lblBaslikAdi.Text = "Kütüphanem Programı";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(834, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlEnAlt
            // 
            this.pnlEnAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.pnlEnAlt.Controls.Add(this.linkLabelHazirlayan);
            this.pnlEnAlt.Controls.Add(this.lblCopyright);
            this.pnlEnAlt.Location = new System.Drawing.Point(0, 685);
            this.pnlEnAlt.Name = "pnlEnAlt";
            this.pnlEnAlt.Size = new System.Drawing.Size(875, 50);
            this.pnlEnAlt.TabIndex = 2;
            // 
            // linkLabelHazirlayan
            // 
            this.linkLabelHazirlayan.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabelHazirlayan.AutoSize = true;
            this.linkLabelHazirlayan.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabelHazirlayan.LinkColor = System.Drawing.Color.White;
            this.linkLabelHazirlayan.Location = new System.Drawing.Point(723, 25);
            this.linkLabelHazirlayan.Name = "linkLabelHazirlayan";
            this.linkLabelHazirlayan.Size = new System.Drawing.Size(91, 18);
            this.linkLabelHazirlayan.TabIndex = 1;
            this.linkLabelHazirlayan.TabStop = true;
            this.linkLabelHazirlayan.Text = "Hazırlayanlar";
            this.linkLabelHazirlayan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHazirlayan_LinkClicked);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.ForeColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Location = new System.Drawing.Point(87, 25);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(276, 13);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "2016 Copyright © zuTTers Company Tüm Hakları Saklıdır";
            // 
            // pnlEnUst2
            // 
            this.pnlEnUst2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(114)))));
            this.pnlEnUst2.Controls.Add(this.btnKitapIslem);
            this.pnlEnUst2.Controls.Add(this.btnOgrenciIslem);
            this.pnlEnUst2.Controls.Add(this.btnOdunUzat);
            this.pnlEnUst2.Controls.Add(this.btnRaporlar);
            this.pnlEnUst2.Controls.Add(this.btnTumOgrenciler);
            this.pnlEnUst2.Controls.Add(this.btnTumKitaplar);
            this.pnlEnUst2.Location = new System.Drawing.Point(0, 40);
            this.pnlEnUst2.Name = "pnlEnUst2";
            this.pnlEnUst2.Size = new System.Drawing.Size(872, 67);
            this.pnlEnUst2.TabIndex = 3;
            // 
            // btnKitapIslem
            // 
            this.btnKitapIslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnKitapIslem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitapIslem.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapIslem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnKitapIslem.Location = new System.Drawing.Point(145, 14);
            this.btnKitapIslem.Name = "btnKitapIslem";
            this.btnKitapIslem.Size = new System.Drawing.Size(145, 40);
            this.btnKitapIslem.TabIndex = 5;
            this.btnKitapIslem.Text = "Kitap İşlemleri";
            this.btnKitapIslem.UseVisualStyleBackColor = false;
            this.btnKitapIslem.Click += new System.EventHandler(this.btnKitapIslem_Click);
            this.btnKitapIslem.MouseLeave += new System.EventHandler(this.btnKitapIslem_MouseLeave);
            this.btnKitapIslem.MouseHover += new System.EventHandler(this.btnKitapIslem_MouseHover);
            // 
            // btnOgrenciIslem
            // 
            this.btnOgrenciIslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOgrenciIslem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOgrenciIslem.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciIslem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnOgrenciIslem.Location = new System.Drawing.Point(0, 14);
            this.btnOgrenciIslem.Name = "btnOgrenciIslem";
            this.btnOgrenciIslem.Size = new System.Drawing.Size(145, 40);
            this.btnOgrenciIslem.TabIndex = 4;
            this.btnOgrenciIslem.Text = "Öğrenci İşlemleri";
            this.btnOgrenciIslem.UseVisualStyleBackColor = false;
            this.btnOgrenciIslem.Click += new System.EventHandler(this.btnOgrenciIslem_Click);
            this.btnOgrenciIslem.MouseLeave += new System.EventHandler(this.btnOgrenciIslem_MouseLeave);
            this.btnOgrenciIslem.MouseHover += new System.EventHandler(this.btnOgrenciIslem_MouseHover);
            // 
            // btnOdunUzat
            // 
            this.btnOdunUzat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOdunUzat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdunUzat.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdunUzat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnOdunUzat.Location = new System.Drawing.Point(290, 14);
            this.btnOdunUzat.Name = "btnOdunUzat";
            this.btnOdunUzat.Size = new System.Drawing.Size(145, 40);
            this.btnOdunUzat.TabIndex = 3;
            this.btnOdunUzat.Text = "Ödünç İşlemleri";
            this.btnOdunUzat.UseVisualStyleBackColor = false;
            this.btnOdunUzat.Click += new System.EventHandler(this.btnOdunUzat_Click);
            this.btnOdunUzat.MouseLeave += new System.EventHandler(this.btnOdunUzat_MouseLeave);
            this.btnOdunUzat.MouseHover += new System.EventHandler(this.btnOdunUzat_MouseHover);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaporlar.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRaporlar.Location = new System.Drawing.Point(725, 14);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(145, 40);
            this.btnRaporlar.TabIndex = 2;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            this.btnRaporlar.MouseLeave += new System.EventHandler(this.btnRaporlar_MouseLeave);
            this.btnRaporlar.MouseHover += new System.EventHandler(this.btnRaporlar_MouseHover);
            // 
            // btnTumOgrenciler
            // 
            this.btnTumOgrenciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnTumOgrenciler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTumOgrenciler.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumOgrenciler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnTumOgrenciler.Location = new System.Drawing.Point(435, 14);
            this.btnTumOgrenciler.Name = "btnTumOgrenciler";
            this.btnTumOgrenciler.Size = new System.Drawing.Size(145, 40);
            this.btnTumOgrenciler.TabIndex = 0;
            this.btnTumOgrenciler.Text = "Tüm Öğrenciler";
            this.btnTumOgrenciler.UseVisualStyleBackColor = false;
            this.btnTumOgrenciler.Click += new System.EventHandler(this.btnTumOgrenciler_Click);
            this.btnTumOgrenciler.MouseLeave += new System.EventHandler(this.btnTumOgrenciler_MouseLeave);
            this.btnTumOgrenciler.MouseHover += new System.EventHandler(this.btnTumOgrenciler_MouseHover);
            // 
            // btnTumKitaplar
            // 
            this.btnTumKitaplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnTumKitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTumKitaplar.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumKitaplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnTumKitaplar.Location = new System.Drawing.Point(580, 14);
            this.btnTumKitaplar.Name = "btnTumKitaplar";
            this.btnTumKitaplar.Size = new System.Drawing.Size(145, 40);
            this.btnTumKitaplar.TabIndex = 1;
            this.btnTumKitaplar.Text = "Tüm Kitaplar";
            this.btnTumKitaplar.UseVisualStyleBackColor = false;
            this.btnTumKitaplar.Click += new System.EventHandler(this.btnTumKitaplar_Click);
            this.btnTumKitaplar.MouseLeave += new System.EventHandler(this.btnTumKitaplar_MouseLeave);
            this.btnTumKitaplar.MouseHover += new System.EventHandler(this.btnTumKitaplar_MouseHover);
            // 
            // lblOzluSoz
            // 
            this.lblOzluSoz.AutoSize = true;
            this.lblOzluSoz.BackColor = System.Drawing.SystemColors.Control;
            this.lblOzluSoz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOzluSoz.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzluSoz.Location = new System.Drawing.Point(307, 125);
            this.lblOzluSoz.Name = "lblOzluSoz";
            this.lblOzluSoz.Size = new System.Drawing.Size(542, 16);
            this.lblOzluSoz.TabIndex = 7;
            this.lblOzluSoz.Text = "Güzel gören güzel düşünür. Güzel düşünen hayatından lezzet alır. (Mektubat)";
            this.lblOzluSoz.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbHomeImage
            // 
            this.pbHomeImage.BackColor = System.Drawing.Color.DarkGray;
            this.pbHomeImage.Image = global::GorselProje.Properties.Resources.Library__700_x_400_;
            this.pbHomeImage.Location = new System.Drawing.Point(-11, 100);
            this.pbHomeImage.Name = "pbHomeImage";
            this.pbHomeImage.Size = new System.Drawing.Size(886, 586);
            this.pbHomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomeImage.TabIndex = 5;
            this.pbHomeImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 735);
            this.Controls.Add(this.lblOzluSoz);
            this.Controls.Add(this.pbHomeImage);
            this.Controls.Add(this.pnlEnUst2);
            this.Controls.Add(this.pnlEnAlt);
            this.Controls.Add(this.pnlEnUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphanem";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlEnUst.ResumeLayout(false);
            this.pnlEnUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTopIcon)).EndInit();
            this.pnlEnAlt.ResumeLayout(false);
            this.pnlEnAlt.PerformLayout();
            this.pnlEnUst2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlEnUst;
        private System.Windows.Forms.Label lblBaslikAdi;
        private System.Windows.Forms.Panel pnlEnAlt;
        private System.Windows.Forms.Panel pnlEnUst2;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnTumOgrenciler;
        private System.Windows.Forms.Button btnKitapIslem;
        private System.Windows.Forms.Button btnOgrenciIslem;
        private System.Windows.Forms.Button btnOdunUzat;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnTumKitaplar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.PictureBox pbHomeImage;
        private System.Windows.Forms.Label lblOzluSoz;
        private System.Windows.Forms.PictureBox pictureTopIcon;
        private System.Windows.Forms.LinkLabel linkLabelHazirlayan;
    }
}

