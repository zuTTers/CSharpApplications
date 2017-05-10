namespace GorselProje
{
    partial class oduncuzat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oduncuzat));
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tabControlOdnc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAlincakTarih = new System.Windows.Forms.Label();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpVerilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.lblUyelikTarihi = new System.Windows.Forms.Label();
            this.txtVKitapBarkod = new System.Windows.Forms.TextBox();
            this.lblKitapBarkod = new System.Windows.Forms.Label();
            this.txtVUyeNo = new System.Windows.Forms.TextBox();
            this.lblUyeNo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCeza = new System.Windows.Forms.Label();
            this.btnCezaKntrl = new System.Windows.Forms.Button();
            this.lblOduncAl = new System.Windows.Forms.Label();
            this.btnOduncAl = new System.Windows.Forms.Button();
            this.txtAKitapBarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAUyeNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblUzat = new System.Windows.Forms.Label();
            this.dtpUzatilacakTarih = new System.Windows.Forms.DateTimePicker();
            this.btnOduncUzat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUKitapBarkod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUUyeNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOduncVer = new System.Windows.Forms.Label();
            this.tabControlOdnc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(15, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(329, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ödünç Kitap Teslim Et/Al/Uzat";
            // 
            // tabControlOdnc
            // 
            this.tabControlOdnc.Controls.Add(this.tabPage1);
            this.tabControlOdnc.Controls.Add(this.tabPage2);
            this.tabControlOdnc.Controls.Add(this.tabPage3);
            this.tabControlOdnc.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlOdnc.Location = new System.Drawing.Point(15, 75);
            this.tabControlOdnc.Name = "tabControlOdnc";
            this.tabControlOdnc.SelectedIndex = 0;
            this.tabControlOdnc.Size = new System.Drawing.Size(820, 460);
            this.tabControlOdnc.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAlincakTarih);
            this.tabPage1.Controls.Add(this.dtpBitisTarihi);
            this.tabPage1.Controls.Add(this.lblOduncVer);
            this.tabPage1.Controls.Add(this.dtpVerilisTarihi);
            this.tabPage1.Controls.Add(this.btnOduncVer);
            this.tabPage1.Controls.Add(this.lblUyelikTarihi);
            this.tabPage1.Controls.Add(this.txtVKitapBarkod);
            this.tabPage1.Controls.Add(this.lblKitapBarkod);
            this.tabPage1.Controls.Add(this.txtVUyeNo);
            this.tabPage1.Controls.Add(this.lblUyeNo);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ödünç Ver";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAlincakTarih
            // 
            this.lblAlincakTarih.AutoSize = true;
            this.lblAlincakTarih.Location = new System.Drawing.Point(32, 138);
            this.lblAlincakTarih.Name = "lblAlincakTarih";
            this.lblAlincakTarih.Size = new System.Drawing.Size(73, 17);
            this.lblAlincakTarih.TabIndex = 55;
            this.lblAlincakTarih.Text = "Bitiş Tarihi";
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitisTarihi.Location = new System.Drawing.Point(220, 131);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(300, 24);
            this.dtpBitisTarihi.TabIndex = 54;
            // 
            // dtpVerilisTarihi
            // 
            this.dtpVerilisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVerilisTarihi.Location = new System.Drawing.Point(220, 101);
            this.dtpVerilisTarihi.Name = "dtpVerilisTarihi";
            this.dtpVerilisTarihi.Size = new System.Drawing.Size(300, 24);
            this.dtpVerilisTarihi.TabIndex = 52;
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.BackColor = System.Drawing.Color.SpringGreen;
            this.btnOduncVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOduncVer.Location = new System.Drawing.Point(35, 161);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(485, 27);
            this.btnOduncVer.TabIndex = 51;
            this.btnOduncVer.Text = "Onayla";
            this.btnOduncVer.UseVisualStyleBackColor = false;
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // lblUyelikTarihi
            // 
            this.lblUyelikTarihi.AutoSize = true;
            this.lblUyelikTarihi.Location = new System.Drawing.Point(32, 108);
            this.lblUyelikTarihi.Name = "lblUyelikTarihi";
            this.lblUyelikTarihi.Size = new System.Drawing.Size(85, 17);
            this.lblUyelikTarihi.TabIndex = 50;
            this.lblUyelikTarihi.Text = "Veriliş Tarihi";
            // 
            // txtVKitapBarkod
            // 
            this.txtVKitapBarkod.Location = new System.Drawing.Point(220, 70);
            this.txtVKitapBarkod.MaxLength = 10;
            this.txtVKitapBarkod.Name = "txtVKitapBarkod";
            this.txtVKitapBarkod.Size = new System.Drawing.Size(300, 24);
            this.txtVKitapBarkod.TabIndex = 35;
            // 
            // lblKitapBarkod
            // 
            this.lblKitapBarkod.AutoSize = true;
            this.lblKitapBarkod.Location = new System.Drawing.Point(32, 77);
            this.lblKitapBarkod.Name = "lblKitapBarkod";
            this.lblKitapBarkod.Size = new System.Drawing.Size(85, 17);
            this.lblKitapBarkod.TabIndex = 34;
            this.lblKitapBarkod.Text = "Kitap Barkod";
            // 
            // txtVUyeNo
            // 
            this.txtVUyeNo.Location = new System.Drawing.Point(220, 40);
            this.txtVUyeNo.MaxLength = 10;
            this.txtVUyeNo.Name = "txtVUyeNo";
            this.txtVUyeNo.Size = new System.Drawing.Size(300, 24);
            this.txtVUyeNo.TabIndex = 9;
            // 
            // lblUyeNo
            // 
            this.lblUyeNo.AutoSize = true;
            this.lblUyeNo.Location = new System.Drawing.Point(32, 47);
            this.lblUyeNo.Name = "lblUyeNo";
            this.lblUyeNo.Size = new System.Drawing.Size(52, 17);
            this.lblUyeNo.TabIndex = 8;
            this.lblUyeNo.Text = "Üye No";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblCeza);
            this.tabPage2.Controls.Add(this.btnCezaKntrl);
            this.tabPage2.Controls.Add(this.lblOduncAl);
            this.tabPage2.Controls.Add(this.btnOduncAl);
            this.tabPage2.Controls.Add(this.txtAKitapBarkod);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtAUyeNo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödünç Al";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "» Kitabın geç teslim durumuna göre günlük 1.25₺ lik ceza değeri öğrenci üzerine b" +
    "orç olarak yazılacak";
            // 
            // lblCeza
            // 
            this.lblCeza.AutoSize = true;
            this.lblCeza.Location = new System.Drawing.Point(38, 157);
            this.lblCeza.Name = "lblCeza";
            this.lblCeza.Size = new System.Drawing.Size(0, 17);
            this.lblCeza.TabIndex = 62;
            // 
            // btnCezaKntrl
            // 
            this.btnCezaKntrl.BackColor = System.Drawing.Color.IndianRed;
            this.btnCezaKntrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCezaKntrl.Location = new System.Drawing.Point(547, 47);
            this.btnCezaKntrl.Name = "btnCezaKntrl";
            this.btnCezaKntrl.Size = new System.Drawing.Size(102, 87);
            this.btnCezaKntrl.TabIndex = 61;
            this.btnCezaKntrl.Text = "Ceza Kontrol";
            this.btnCezaKntrl.UseVisualStyleBackColor = false;
            this.btnCezaKntrl.Click += new System.EventHandler(this.btnCezaKntrl_Click);
            // 
            // lblOduncAl
            // 
            this.lblOduncAl.AutoSize = true;
            this.lblOduncAl.Location = new System.Drawing.Point(38, 137);
            this.lblOduncAl.Name = "lblOduncAl";
            this.lblOduncAl.Size = new System.Drawing.Size(0, 17);
            this.lblOduncAl.TabIndex = 60;
            // 
            // btnOduncAl
            // 
            this.btnOduncAl.BackColor = System.Drawing.Color.SpringGreen;
            this.btnOduncAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOduncAl.Location = new System.Drawing.Point(41, 107);
            this.btnOduncAl.Name = "btnOduncAl";
            this.btnOduncAl.Size = new System.Drawing.Size(485, 27);
            this.btnOduncAl.TabIndex = 58;
            this.btnOduncAl.Text = "Onayla";
            this.btnOduncAl.UseVisualStyleBackColor = false;
            this.btnOduncAl.Click += new System.EventHandler(this.btnOduncAl_Click);
            // 
            // txtAKitapBarkod
            // 
            this.txtAKitapBarkod.Location = new System.Drawing.Point(226, 77);
            this.txtAKitapBarkod.MaxLength = 10;
            this.txtAKitapBarkod.Name = "txtAKitapBarkod";
            this.txtAKitapBarkod.Size = new System.Drawing.Size(300, 24);
            this.txtAKitapBarkod.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Kitap Barkod";
            // 
            // txtAUyeNo
            // 
            this.txtAUyeNo.Location = new System.Drawing.Point(226, 47);
            this.txtAUyeNo.MaxLength = 10;
            this.txtAUyeNo.Name = "txtAUyeNo";
            this.txtAUyeNo.Size = new System.Drawing.Size(300, 24);
            this.txtAUyeNo.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Üye No";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblUzat);
            this.tabPage3.Controls.Add(this.dtpUzatilacakTarih);
            this.tabPage3.Controls.Add(this.btnOduncUzat);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtUKitapBarkod);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtUUyeNo);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(812, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ödünç Uzat";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblUzat
            // 
            this.lblUzat.AutoSize = true;
            this.lblUzat.Location = new System.Drawing.Point(35, 161);
            this.lblUzat.Name = "lblUzat";
            this.lblUzat.Size = new System.Drawing.Size(0, 17);
            this.lblUzat.TabIndex = 60;
            // 
            // dtpUzatilacakTarih
            // 
            this.dtpUzatilacakTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUzatilacakTarih.Location = new System.Drawing.Point(223, 101);
            this.dtpUzatilacakTarih.Name = "dtpUzatilacakTarih";
            this.dtpUzatilacakTarih.Size = new System.Drawing.Size(300, 24);
            this.dtpUzatilacakTarih.TabIndex = 59;
            // 
            // btnOduncUzat
            // 
            this.btnOduncUzat.BackColor = System.Drawing.Color.SpringGreen;
            this.btnOduncUzat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOduncUzat.Location = new System.Drawing.Point(38, 131);
            this.btnOduncUzat.Name = "btnOduncUzat";
            this.btnOduncUzat.Size = new System.Drawing.Size(485, 27);
            this.btnOduncUzat.TabIndex = 58;
            this.btnOduncUzat.Text = "Onayla";
            this.btnOduncUzat.UseVisualStyleBackColor = false;
            this.btnOduncUzat.Click += new System.EventHandler(this.btnOduncUzat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Uzatılcak Tarihi";
            // 
            // txtUKitapBarkod
            // 
            this.txtUKitapBarkod.Location = new System.Drawing.Point(223, 71);
            this.txtUKitapBarkod.MaxLength = 10;
            this.txtUKitapBarkod.Name = "txtUKitapBarkod";
            this.txtUKitapBarkod.Size = new System.Drawing.Size(300, 24);
            this.txtUKitapBarkod.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Kitap Barkod";
            // 
            // txtUUyeNo
            // 
            this.txtUUyeNo.Location = new System.Drawing.Point(223, 41);
            this.txtUUyeNo.MaxLength = 10;
            this.txtUUyeNo.Name = "txtUUyeNo";
            this.txtUUyeNo.Size = new System.Drawing.Size(300, 24);
            this.txtUUyeNo.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Üye No";
            // 
            // lblOduncVer
            // 
            this.lblOduncVer.AutoSize = true;
            this.lblOduncVer.Location = new System.Drawing.Point(32, 191);
            this.lblOduncVer.Name = "lblOduncVer";
            this.lblOduncVer.Size = new System.Drawing.Size(0, 17);
            this.lblOduncVer.TabIndex = 53;
            // 
            // oduncuzat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.tabControlOdnc);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 120);
            this.Name = "oduncuzat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ödünç Uzat";
            this.Load += new System.EventHandler(this.oduncuzat_Load);
            this.tabControlOdnc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TabControl tabControlOdnc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtVUyeNo;
        private System.Windows.Forms.Label lblUyeNo;
        private System.Windows.Forms.TextBox txtVKitapBarkod;
        private System.Windows.Forms.Label lblKitapBarkod;
        private System.Windows.Forms.Label lblUyelikTarihi;
        private System.Windows.Forms.Button btnOduncVer;
        private System.Windows.Forms.Button btnOduncAl;
        private System.Windows.Forms.TextBox txtAKitapBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAUyeNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOduncUzat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUKitapBarkod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUUyeNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpVerilisTarihi;
        private System.Windows.Forms.DateTimePicker dtpUzatilacakTarih;
        private System.Windows.Forms.Label lblOduncAl;
        private System.Windows.Forms.Label lblUzat;
        private System.Windows.Forms.Label lblAlincakTarih;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Button btnCezaKntrl;
        private System.Windows.Forms.Label lblCeza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOduncVer;
    }
}