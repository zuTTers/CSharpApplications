using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace GorselProje
{
    public partial class kitapislemleri : Form
    {
        public kitapislemleri()
        {
            InitializeComponent();
        }
        //Data değişkenleri tanımlamaları
        public string kaynak = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kutuphane.accdb";
        OleDbConnection con;
        DataSet ds = new DataSet();
        OleDbCommand cmd;
        OleDbDataAdapter adab;
        DataTable dt = new DataTable();

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            //textboxlar boşsa btnkitapekle çalışmaz uyarı verir
            if (txtKitapAdi.Text =="" && txtYazarAdi.Text=="" && txtYynEviAdi.Text=="")
            {
                lblKitapEkleSonuc.Text = "Boş alanlar mevcut. Lütfen boşlukları doldurunuz!";
            }
            else
            {
                //kitap ekleme işlemi
                con = new OleDbConnection(kaynak);
                string sorgu = "INSERT INTO Kitaplar (KitapAdi,KitapTuru,YazarAdi,YayineviAdi,YayinTarihi,SayfaSayisi,KitapDurumu,EklemeTarihi)" +
                               "VALUES (@KitapAdi,@KitapTuru,@YazarAdi,@YayineviAdi,@YayinTarihi,@SayfaSayisi,@KitapDurumu,@EklemeTarihi)";
                cmd = new OleDbCommand(sorgu, con);

                string kitapdurum = "";
                if (radioBtnDHasarlii.Checked == true)
                {
                    kitapdurum = "Hasarlı";
                }
                else if (radioBtnTemiz.Checked == true)
                {
                    kitapdurum = "Temiz";
                }
                else
                {
                    kitapdurum = "Kullanılamaz";
                }
                //parametreler
                cmd.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
                cmd.Parameters.AddWithValue("@KitapTuru", comboBoxKtpTur.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@YazarAdi", txtYazarAdi);
                cmd.Parameters.AddWithValue("@YayineviAdi", txtYynEviAdi.Text);
                cmd.Parameters.AddWithValue("@YayinTarihi", dtpYayinTarihi.Text);
                cmd.Parameters.AddWithValue("@SayfaSayisi", txtSayfaSayisi.Text);
                cmd.Parameters.AddWithValue("@KitapDurumu", kitapdurum);
                cmd.Parameters.AddWithValue("@EklemeTarihi", dtpEklemeTarihi.Text);

                try
                {
                   
                    con.Open();
                    cmd.ExecuteNonQuery(); //komutu çalıştırma
                    con.Close();
                    lblKitapEkleSonuc.Text = "Kitap ekleme başarılı.";
                    txtKitapAdi.Text = "";
                    txtSayfaSayisi.Text = "";
                    txtYazarAdi.Text = "";
                    txtYynEviAdi.Text = "";
                    comboBoxKtpTur.SelectedIndex = -1;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            
        }

        private void btnKitapDuzenle_Click(object sender, EventArgs e)
        {
            if (txtDKitapAdi.Text == "" && txtDYazarAdi.Text == "" && txtDYayinEvi.Text == "")
            {
                lblKitapDuzenleSonuc.Text = "Boş alanlar mevcut. Lütfen boşlukları doldurunuz!";
            }
            else
            {
                con = new OleDbConnection(kaynak);
                string sorgu = "UPDATE Kitaplar SET KitapAdi=@KitapAdi,KitapTuru=@KitapTuru,YazarAdi=@YazarAdi,YayineviAdi=@YayineviAdi,YayinTarihi=@YayinTarihi,SayfaSayisi=@SayfaSayisi,KitapDurumu=@KitapDurumu,EklemeTarihi=@EklemeTarihi WHERE KitapBarkod=@KitapBarkod";
                cmd = new OleDbCommand(sorgu, con);

                string Dkitapdurum = "";
                if (radioBtnDHasarlii.Checked == true)
                {
                    Dkitapdurum = "Hasarlı";
                }
                else if (radioBtnTemiz.Checked == true)
                {
                    Dkitapdurum = "Temiz";
                }
                else
                {
                    Dkitapdurum = "Kullanılamaz";
                }


                cmd.Parameters.AddWithValue("@KitapAdi", txtDKitapAdi.Text);
                cmd.Parameters.AddWithValue("@KitapTuru", comboBoxDKitapTur.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@YazarAdi", txtDYazarAdi);
                cmd.Parameters.AddWithValue("@YayineviAdi", txtDYayinEvi.Text);
                cmd.Parameters.AddWithValue("@YayinTarihi", dtpDYayinTarihi.Text);
                cmd.Parameters.AddWithValue("@SayfaSayisi", txtDSayfaSayisi.Text);
                cmd.Parameters.AddWithValue("@KitapDurumu", Dkitapdurum);
                cmd.Parameters.AddWithValue("@EklemeTarihi", dtpDEklemeTarihi.Text);
                cmd.Parameters.AddWithValue("@KitapBarkod", Convert.ToInt32(txtDKitapBarkod.Text));

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    lblKitapDuzenleSonuc.Text = "Kitap düzenleme başarılı.";
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        private void btnKitapSilSonuc_Click(object sender, EventArgs e)
        {
            if (txtSKitapBarkod.Text == "")
            {
                lblSilSonuc.Text = "Kitap barkod numarısını giriniz!";
            }
            else
            {
                string message = "Silmek istediğinize emin misiniz?";
                string caption = "Hata";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                con = new OleDbConnection(kaynak);
                cmd = new OleDbCommand();

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    cmd.Connection = con;
                    cmd.CommandText = "DELETE * FROM Kitaplar WHERE KitapBarkod=@KitapBarkod";
                    cmd.Parameters.AddWithValue("@KitapBarkod", Convert.ToInt32(txtSKitapBarkod.Text));
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        lblSilSonuc.Text = "Kitap silme işlemi başarılı.";
                        txtSKitapBarkod.Text = "";
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            
        }

        public DataRow KitapListeCek(int id)
        {
            //DataRow'a Kitaplar tablosundan verileri çekme
            con = new OleDbConnection(kaynak);
            cmd = new OleDbCommand();
            string sorgu = "SELECT * FROM Kitaplar WHERE KitapBarkod=@KitapBarkod";
            cmd.Connection = con;
            DataTable dt = new DataTable();
            OleDbDataAdapter adaptor = new OleDbDataAdapter(sorgu, con);
            adaptor.SelectCommand.Parameters.AddWithValue("@KitapBarkod", id);
            DataRow dr;
            try
            {
                adaptor.Fill(dt);
                dr = dt.Rows[0];
            }
            catch (Exception)
            {

                throw;
            }
            adaptor.Dispose();
            con.Close();
            return dr;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //textbox boşsa çalıştırmama şartı
            if (txtDKitapBarkod.Text == "")
            {
                MessageBox.Show("Kitap barkod numarası giriniz!");
            }
            else
            {
                DataRow dr = KitapListeCek(Convert.ToInt32(txtDKitapBarkod.Text));
                //textboxlara verileri çekme
                txtDKitapAdi.Text = dr["KitapAdi"].ToString();
                comboBoxDKitapTur.SelectedItem = dr["KitapTuru"].ToString();
                txtDYazarAdi.Text = dr["YazarAdi"].ToString();
                txtDYayinEvi.Text = dr["YayineviAdi"].ToString();
                dtpDYayinTarihi.Text = dr["YayinTarihi"].ToString();
                txtDSayfaSayisi.Text = dr["SayfaSayisi"].ToString();
                dtpDEklemeTarihi.Text = dr["EklemeTarihi"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDKitapAdi.Text = "";
            comboBoxDKitapTur.SelectedIndex = -1;
            txtDYazarAdi.Text = "";
            txtDYayinEvi.Text = "";
            dtpDYayinTarihi.Text = "";
            txtDSayfaSayisi.Text = "";
            dtpDEklemeTarihi.Text = "";
        }

        private void kitapislemleri_Load(object sender, EventArgs e)
        {
            radioBtnDTemiz.Checked = true;
        }




    }
}
