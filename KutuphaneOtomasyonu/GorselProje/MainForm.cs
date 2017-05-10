using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GorselProje
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //konrolun bulundugu formu kapatır
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //form pencresini küçültür
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            //burda eger form penceresi normal boyuttaysa büyüt dedim değilse normala getir dedim
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        //pencereyi sürüklemek için oluşturduğumuz değişkenler. pencereyi sürekleme kodlarını pnlEnUst kontrolune yazdım.
        bool dragging;
        Point offset;
        //x ve Y ekseninde hesalamaya göre hareket ettir.
        private void pnlEnUst_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            { 
                Point SuankiEkranKonumu = PointToScreen(e.Location);
                Location = new Point(SuankiEkranKonumu.X - offset.X, SuankiEkranKonumu.Y - offset.Y);
            }
        }
        //mouse tıklanmamıssa surekleme pasif
        private void pnlEnUst_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //mouse tıklanmıssa(basılı) surukleme aktif ve konumunu offset degiskenine kaydet
        private void pnlEnUst_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }
        public bool Adurum, Bdurum, Cdurum, Ddurum, Edurum, Fdurum;
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Formlar 2. defa açılmaması için herbir forma anahtar birdeğişken belirledim. Tüm kilitler açık suan.
            Adurum = false;
            Bdurum = false;
            Cdurum = false;
            Ddurum = false;
            Edurum = false;
            Fdurum = false;
            
        }
        ogrenciler TmOgrenciler = new ogrenciler();
        private void btnTumOgrenciler_Click(object sender, EventArgs e)
        {
            pbHomeImage.Visible = false;
            if (Adurum == false)
            {
                Adurum = true;
                Bdurum = false;
                Cdurum = false;
                Ddurum = false;
                Edurum = false;
                Fdurum = false;
                TmOgrenciler.MdiParent = this;
                TmOgrenciler.Show();

                /*
                kitaplar form1 = new kitaplar();

                pnlGovdeIslem.Controls.Add(form1);
                pnlGovdeIslem.Controls.Remove(btnTumOgrenciler);
                pnlGovdeIslem.Controls.Remove(btnRaporlar);
                pnlGovdeIslem.Controls.Remove(btnKitapIslem);
                pnlGovdeIslem.Controls.Remove(btnOgrenciIslem);
                pnlGovdeIslem.Controls.Remove(btnOdunUzat);*/

                
                
            }
            //Açık olan diğer formlar gizleniyor
            OgrenciIslemleri.Hide();
            Raporlar.Hide();
            KitapIslemleri.Hide();
            OduncUzat.Hide();
            TmKitaplar.Hide();

        }
        ogrenciislemleri OgrenciIslemleri = new ogrenciislemleri();
        private void btnOgrenciIslem_Click(object sender, EventArgs e)
        {
            pbHomeImage.Visible = false;
            if (Bdurum == false)
            {
                Bdurum = true;
                Adurum = false;
                Cdurum = false;
                Ddurum = false;
                Edurum = false;
                Fdurum = false;
                OgrenciIslemleri.MdiParent = this;
                OgrenciIslemleri.Show();
            }
            //Açık olan diğer formlar gizleniyor
            Raporlar.Hide();
            TmOgrenciler.Hide();
            KitapIslemleri.Hide();
            OduncUzat.Hide();
            TmKitaplar.Hide();
                        
        }
        raporlar Raporlar = new raporlar();
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            pbHomeImage.Visible = false;
            if (Cdurum == false)
            {
                Cdurum = true;
                Adurum = false;
                Bdurum = false;
                Ddurum = false;
                Edurum = false;
                Fdurum = false;
                Raporlar.MdiParent = this;
                Raporlar.Show();    
            }
            //Açık olan diğer formlar gizleniyor
            TmOgrenciler.Hide();
            OgrenciIslemleri.Hide();
            KitapIslemleri.Hide();
            OduncUzat.Hide();
            TmKitaplar.Hide();
        }
        kitapislemleri KitapIslemleri = new kitapislemleri();
        private void btnKitapIslem_Click(object sender, EventArgs e)
        {
            pbHomeImage.Visible = false;
            if (Ddurum == false)
            {
                Ddurum = true;
                Adurum = false;
                Bdurum = false;
                Cdurum = false;
                Edurum = false;
                Fdurum = false;
                KitapIslemleri.MdiParent = this;
                KitapIslemleri.Show();
            }
            //Açık olan diğer formlar gizleniyor
            TmOgrenciler.Hide();
            OgrenciIslemleri.Hide();
            Raporlar.Hide();
            TmKitaplar.Hide();
            OduncUzat.Hide();
        }
        kitaplar TmKitaplar = new kitaplar();
        private void btnTumKitaplar_Click(object sender, EventArgs e)
        {
            pbHomeImage.Visible = false;
            if (Edurum == false)
            {
                Ddurum = false;
                Adurum = false;
                Bdurum = false;
                Cdurum = false;
                Edurum = true;
                Fdurum = false;
                TmKitaplar.MdiParent = this;
                TmKitaplar.Show();
            }
            //Açık olan diğer formlar gizleniyor
            TmOgrenciler.Hide();
            OgrenciIslemleri.Hide();
            Raporlar.Hide();
            KitapIslemleri.Hide();
            OduncUzat.Hide();
        }
        oduncuzat OduncUzat = new oduncuzat();
        private void btnOdunUzat_Click(object sender, EventArgs e)
        {
            pbHomeImage.Visible = false;
            if (Fdurum == false)
            {
                Adurum = false;
                Bdurum = false;
                Cdurum = false;
                Ddurum = false;
                Edurum = false;
                Fdurum = true;
                OduncUzat.MdiParent = this;
                OduncUzat.Show();
            }
            //Açık olan diğer formlar gizleniyor
            TmOgrenciler.Hide();
            OgrenciIslemleri.Hide();
            Raporlar.Hide();
            KitapIslemleri.Hide();
            TmKitaplar.Hide();
        }

        private void linkLabelHazirlayan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            calldevelopersxd DEV = new calldevelopersxd();
            DialogResult sonuc = MessageBox.Show("Gerçekten merak ediyor musun?","Hazırlayanlar",MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                DEV.Show();
            }

        }

        //mouse buttonun üzerine gelince arka plan rengi değişiyor
        private void btnOgrenciIslem_MouseHover(object sender, EventArgs e)
        {
            btnOgrenciIslem.BackColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }
        //mouse buttonun üzerine kalkınca arka plan rengi eski duruma getiriyor
        private void btnOgrenciIslem_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciIslem.BackColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void btnKitapIslem_MouseHover(object sender, EventArgs e)
        {
            btnKitapIslem.BackColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void btnKitapIslem_MouseLeave(object sender, EventArgs e)
        {
            btnKitapIslem.BackColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void pictureTopIcon_MouseDown(object sender, MouseEventArgs e)
        {
            pbHomeImage.Visible = true;
        }

        private void btnOdunUzat_MouseHover(object sender, EventArgs e)
        {
            btnOdunUzat.BackColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void btnOdunUzat_MouseLeave(object sender, EventArgs e)
        {
            btnOdunUzat.BackColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void btnTumOgrenciler_MouseHover(object sender, EventArgs e)
        {
            btnTumOgrenciler.BackColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void btnTumOgrenciler_MouseLeave(object sender, EventArgs e)
        {
            btnTumOgrenciler.BackColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void btnTumKitaplar_MouseHover(object sender, EventArgs e)
        {
            btnTumKitaplar.BackColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void btnTumKitaplar_MouseLeave(object sender, EventArgs e)
        {
            btnTumKitaplar.BackColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void btnRaporlar_MouseHover(object sender, EventArgs e)
        {
            btnRaporlar.BackColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }

        private void btnRaporlar_MouseLeave(object sender, EventArgs e)
        {
            btnRaporlar.BackColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
        }




    }
}
