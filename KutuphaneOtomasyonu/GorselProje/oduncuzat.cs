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
    public partial class oduncuzat : Form
    {
        public oduncuzat()
        {
            InitializeComponent();
        }
        public string kaynak = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kutuphane.accdb";
        OleDbConnection con;
        DataSet ds = new DataSet();
        OleDbCommand cmd;        
        OleDbDataAdapter adab;
        DataTable dt = new DataTable();

        private void oduncuzat_Load(object sender, EventArgs e)
        {

        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (txtVKitapBarkod.Text=="" && txtVUyeNo.Text=="")
            {
                lblOduncVer.Text = "Lütfen boş alanları doldurunuz.";
            }
            else
            {
                con = new OleDbConnection(kaynak);
                string sorgu = "INSERT INTO Odunc (KitapBarkod,UyeNo,VerilisTarih,AlisTarih) VALUES (@KitapBarkod,@UyeNo,@VerilisTarih,@AlisTarih)";
                cmd = new OleDbCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@KitapBarkod", txtVKitapBarkod.Text);
                cmd.Parameters.AddWithValue("@UyeNo", txtVUyeNo.Text);
                cmd.Parameters.AddWithValue("@VerilisTarih", dtpVerilisTarihi.Text);
                cmd.Parameters.AddWithValue("@AlisTarih", dtpBitisTarihi.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lblOduncVer.Text = "Ödünç verme işlemi başarılı.";
                    con.Close();
                }
                catch (Exception)
                {

                    throw;
                }

                con.Dispose();
                cmd.Dispose();
            }
         
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {

            if (txtAKitapBarkod.Text=="" && txtAUyeNo.Text=="")
            {
                lblOduncAl.Text = "Lütfen boş alanları doldurunuz.";
            }
            else
            {
                con = new OleDbConnection(kaynak);
                string sorgu = "UPDATE Odunc SET KitapBarkod=@KitapBarkod,UyeNo=@UyeNo,TeslimDurum=true,AlisTarih=@BitisTarihi WHERE KitapBarkod=@KitapBarkod AND UyeNo=@UyeNo AND AlisTarih=@BitisTarihi";
                cmd = new OleDbCommand(sorgu, con);

                bool durum = true;
                string buguntarih = DateTime.Now.ToShortDateString();
                int sonuc = 0;

                cmd.Parameters.AddWithValue("@KitapBarkod", txtAKitapBarkod.Text);
                cmd.Parameters.AddWithValue("@UyeNo", txtAUyeNo.Text);
                cmd.Parameters.AddWithValue("@BitisTarihi", buguntarih);
                cmd.Parameters.AddWithValue("@TeslimDurumu", durum);


                try
                {
                    con.Open();
                    sonuc = cmd.ExecuteNonQuery();
                    con.Close();
                    if (sonuc == 1)
                    {
                        lblOduncAl.Text = "Ödünç alma işlemi başarılı.";
                    }
                    else
                    {

                        lblOduncAl.Text = "Ödünç alma işlemi başarısız.";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
        }

        private void btnOduncUzat_Click(object sender, EventArgs e)
        {
            if (txtUUyeNo.Text==""&& txtUKitapBarkod.Text=="")
            {
                lblUzat.Text = "Lütfen boş alanları doldurunuz.";
            }
            else
            {
                con = new OleDbConnection(kaynak);
                string sorgu = "UPDATE Odunc SET KitapBarkod=@KitapBarkod,UyeNo=@UyeNo,TeslimDurum=false,AlisTarih=@UzatTarih WHERE UyeNo=@UyeNo AND KitapBarkod=@KitapBarkod";
                cmd = new OleDbCommand(sorgu, con);

                cmd.Parameters.AddWithValue("@UyeNo", txtUUyeNo.Text);
                cmd.Parameters.AddWithValue("@KitapBarkod", txtUKitapBarkod.Text);
                cmd.Parameters.AddWithValue("@UzatTarih", dtpUzatilacakTarih.Text);

                int sonuc = 0;

                try
                {
                    con.Open();
                    sonuc = cmd.ExecuteNonQuery();
                    con.Close();
                    if (sonuc == 1)
                    {
                        lblUzat.Text = "Ödünç uzatma işlemi başarılı.";
                    }
                    else
                    {
                        lblUzat.Text = "Ödünç uzatma işlemi başarısız.";
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
         
        }

        public DataRow OduncCek(string id)
        {
            string sorgu = "SELECT * FROM Odunc WHERE UyeNo=@UN AND TeslimDurum=" + false + " ";
            OleDbConnection con = new OleDbConnection(kaynak);
            DataTable dt = new DataTable();
            OleDbDataAdapter adaptor = new OleDbDataAdapter(sorgu, con);
            adaptor.SelectCommand.Parameters.AddWithValue("@UN", id);
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

        public DataRow UyeCek(string id)
        {
            string sorgu = "SELECT * FROM Kisiler WHERE UyeNo=@UN";
            OleDbConnection con = new OleDbConnection(kaynak);
            DataTable dt = new DataTable();
            OleDbDataAdapter adaptor = new OleDbDataAdapter(sorgu, con);
            adaptor.SelectCommand.Parameters.AddWithValue("@UN", id);
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

        public DataRow KitapCek(string id)
        {
            string sorgu = "SELECT * FROM Kitaplar WHERE KitapBarkod=@KB";
            OleDbConnection con = new OleDbConnection(kaynak);
            DataTable dt = new DataTable();
            OleDbDataAdapter adaptor = new OleDbDataAdapter(sorgu, con);
            adaptor.SelectCommand.Parameters.AddWithValue("@KB", id);
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

        private void btnCezaKntrl_Click(object sender, EventArgs e)
        {

            string OkulNo = "";
            string BarkodNo = "";
            DateTime VerilisTarihi;
            DateTime NormalTeslimTarihi;
            string Ceza = "";
            string UyeAdi = "";
            string UyeSoyadi = "";
            string UyeBolumu = "";
            string KitapAdi = "";
            string KitapYazari = "";

            DataRow dr = OduncCek(txtAUyeNo.Text);
            OkulNo = dr["UyeNo"].ToString();
            BarkodNo = dr["KitapBarkod"].ToString();
            VerilisTarihi = Convert.ToDateTime(dr["VerilisTarih"]);
            NormalTeslimTarihi = Convert.ToDateTime(dr["AlisTarih"]);
            Ceza = (((Convert.ToInt32(DateTime.Now.Day.ToString())) - (Convert.ToInt32(NormalTeslimTarihi.Date.Day.ToString()))) * (1.25)).ToString();
            
            DataRow dr2 = UyeCek(txtAUyeNo.Text);
            UyeAdi = dr2["UyeAdi"].ToString();
            UyeSoyadi = dr2["UyeSoyadi"].ToString();
            UyeBolumu = dr2["Bolum"].ToString();

            DataRow dr3 = KitapCek(txtAKitapBarkod.Text);
            KitapAdi = dr3["KitapAdi"].ToString();
            KitapYazari = dr3["YazarAdi"].ToString();

            if (Ceza != "" && 0 > (Convert.ToDouble(Ceza)))
            {
                Ceza = "Ceza Bulunmamaktadır.";
            }
            else
            {
            lblCeza.Text = "Ceza Bedeli : " + Ceza.ToString() + "\n" + KitapAdi.ToString() + "\n" + KitapYazari.ToString() + "\n-----------------------\n" + UyeAdi.ToString() + " " + UyeSoyadi.ToString() + "\n" + UyeBolumu.ToString();
            }
            

        }


    }
}
