namespace GorselProje
{
    partial class ogrenciler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciler));
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIncele = new System.Windows.Forms.Button();
            this.txtUyeNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(15, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(173, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Tüm Öğrenciler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 483);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnIncele
            // 
            this.btnIncele.Location = new System.Drawing.Point(738, 18);
            this.btnIncele.Name = "btnIncele";
            this.btnIncele.Size = new System.Drawing.Size(100, 22);
            this.btnIncele.TabIndex = 5;
            this.btnIncele.Text = "İncele";
            this.btnIncele.UseVisualStyleBackColor = true;
            this.btnIncele.Click += new System.EventHandler(this.btnIncele_Click);
            // 
            // txtUyeNo
            // 
            this.txtUyeNo.Location = new System.Drawing.Point(507, 19);
            this.txtUyeNo.Name = "txtUyeNo";
            this.txtUyeNo.Size = new System.Drawing.Size(225, 20);
            this.txtUyeNo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Üye no ya da üye adı girin:";
            // 
            // ogrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIncele);
            this.Controls.Add(this.txtUyeNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 120);
            this.Name = "ogrenciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.ogrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIncele;
        private System.Windows.Forms.TextBox txtUyeNo;
        private System.Windows.Forms.Label label1;
    }
}