namespace GorselProje
{
    partial class raporlar
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
            this.components = new System.ComponentModel.Container();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tabControlRpr = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOduncIncele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOduncUyeNo = new System.Windows.Forms.TextBox();
            this.tabControlRpr.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(15, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(102, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Raporlar";
            // 
            // tabControlRpr
            // 
            this.tabControlRpr.Controls.Add(this.tabPage2);
            this.tabControlRpr.Controls.Add(this.tabPage3);
            this.tabControlRpr.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlRpr.Location = new System.Drawing.Point(20, 75);
            this.tabControlRpr.Name = "tabControlRpr";
            this.tabControlRpr.SelectedIndex = 0;
            this.tabControlRpr.Size = new System.Drawing.Size(820, 460);
            this.tabControlRpr.TabIndex = 5;
            this.tabControlRpr.Click += new System.EventHandler(this.tabControlRpr_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraphControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İstatistik";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = true;
            this.zedGraphControl1.IsSynchronizeXAxes = true;
            this.zedGraphControl1.IsSynchronizeYAxes = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(21, 27);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(756, 381);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.ZoomButtons2 = System.Windows.Forms.MouseButtons.Right;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnOduncIncele);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.txtOduncUyeNo);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(812, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ödünç Listesi";
            this.tabPage3.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Üye no ya da kitap barkod girin:";
            // 
            // btnOduncIncele
            // 
            this.btnOduncIncele.Location = new System.Drawing.Point(579, 27);
            this.btnOduncIncele.Name = "btnOduncIncele";
            this.btnOduncIncele.Size = new System.Drawing.Size(100, 25);
            this.btnOduncIncele.TabIndex = 7;
            this.btnOduncIncele.Text = "İncele";
            this.btnOduncIncele.UseVisualStyleBackColor = true;
            this.btnOduncIncele.Click += new System.EventHandler(this.btnOduncIncele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 366);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtOduncUyeNo
            // 
            this.txtOduncUyeNo.Location = new System.Drawing.Point(235, 28);
            this.txtOduncUyeNo.Name = "txtOduncUyeNo";
            this.txtOduncUyeNo.Size = new System.Drawing.Size(336, 24);
            this.txtOduncUyeNo.TabIndex = 6;
            // 
            // raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.tabControlRpr);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 120);
            this.Name = "raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tüm Öğrenciler";
            this.Load += new System.EventHandler(this.raporlar_Load);
            this.tabControlRpr.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TabControl tabControlRpr;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOduncIncele;
        private System.Windows.Forms.TextBox txtOduncUyeNo;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        
    }
}