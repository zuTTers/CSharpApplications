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
using ZedGraph;


namespace GorselProje
{
    public partial class raporlar : Form
    {
         

        public raporlar()
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
        GraphPane KitapsayisiGrafik, UyesayisiGrafik, KBKitapSayisiGrafik, KOKitapSayisiGrafik;

        public void IstatistikGoster()
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kutuphane.accdb");
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;

            // grafik gösterilecek grafikler tanımlanıyor          
            int toplamKitap = 0;
            int toplamUye = 0;
            int kbulunanK = 0;
            int kOlmayanK = 0;

            // sorgular yapılıyor
            string Kitapsayisi = "select count(*) as say from Kitaplar";
            string UyeSayisi = "select count(*) as say from Kisiler";
            string KBKitapSayisi = "select count(*) as say from Odunc WHERE TeslimDurum=" + true + "";
            string KOKitapSayisi = "select count(*) as say from Odunc WHERE TeslimDurum=" + false + "";

            // kitap sayısı hesaplanıyor
            cmd.CommandText = Kitapsayisi;
            IDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                toplamKitap = Convert.ToInt32(dr["say"]);
            }
            KitapsayisiGrafik = zedGraphControl1.GraphPane;
            double[] x = new double[1];
            double[] y = new double[100];
            for (int i = 0; i < x.Length; i++)
            {

                x[i] = i;
                y[i] = Convert.ToDouble(toplamKitap);
            }

            PointPairList grf = new PointPairList(x, y);
            LineItem egim = KitapsayisiGrafik.AddCurve("Kitap Sayısı", grf, Color.Red, SymbolType.Star);
            egim.Line.Width = 10.0F;

            dr.Dispose();
            dr.Close();

            //---------------------------------------
            // uye sayısı hesaplanıyor
            cmd.CommandText = UyeSayisi;
            IDataReader dr2 = cmd.ExecuteReader();

            while (dr2.Read())
            {
                toplamUye = Convert.ToInt32(dr2["say"]);
            }
            UyesayisiGrafik = zedGraphControl1.GraphPane;

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                y[i] = Convert.ToDouble(toplamUye);
            }

            PointPairList grf1 = new PointPairList(x, y);
            LineItem egim1 = UyesayisiGrafik.AddCurve("Üye Sayısı", grf1, Color.Green, SymbolType.Square);
            egim1.Line.Width = 10.0F;

            dr2.Dispose();
            dr2.Close();
            //---------------------------------------

            cmd.CommandText = KBKitapSayisi;
            IDataReader dr3 = cmd.ExecuteReader();
            while (dr3.Read())
            {
                kbulunanK = Convert.ToInt32(dr3["say"]);
            }

            KBKitapSayisiGrafik = zedGraphControl1.GraphPane;

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                y[i] = Convert.ToDouble(kbulunanK);
            }
            PointPairList grf2 = new PointPairList(x, y);
            LineItem egim2 = KBKitapSayisiGrafik.AddCurve("Kütütüphanedeki Kitap Sayısı", grf2, Color.Sienna, SymbolType.Circle);
            egim2.Line.Width = 10.0F;


            dr3.Dispose();
            dr3.Close();
            //---------------------------------------
            cmd.CommandText = KOKitapSayisi;
            IDataReader dr4 = cmd.ExecuteReader();

            while (dr4.Read())
            {
                kOlmayanK = Convert.ToInt32(dr4["say"]);
            }
            KOKitapSayisiGrafik = zedGraphControl1.GraphPane;

            for (int i = 0; i < x.Length; i++)
            {

                x[i] = i;
                y[i] = Convert.ToDouble(kOlmayanK);
            }

            PointPairList grf3 = new PointPairList(x, y);
            LineItem egim3 = KOKitapSayisiGrafik.AddCurve("Kütüphanede Olmayan Kitap Sayısı", grf3, Color.Aqua, SymbolType.Diamond);
            egim3.Line.Width = 10.0F;

            KitapsayisiGrafik.Title.Text = "Kütüphane İstatistikleri";
            KitapsayisiGrafik.XAxis.Title.Text = "";
            KitapsayisiGrafik.YAxis.Title.Text = "Toplam Miktar";
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }

        public void Listele()
        {
            con = new OleDbConnection(kaynak);
            cmd = new OleDbCommand();
            string sorgu = "SELECT * FROM Odunc";
            con.Open();
            adab = new OleDbDataAdapter(sorgu, con);
            adab.Fill(ds, "Odunc");
            dataGridView1.DataSource = ds.Tables["Odunc"];
            con.Close();
            //Data GridView Renklendirmesi
            DateTime NormalTeslimTarihi = DateTime.Now;
            bool teslimDurum = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                NormalTeslimTarihi = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                teslimDurum = Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value);
                int gun = (((Convert.ToInt32(DateTime.Now.Day.ToString())) - (Convert.ToInt32(NormalTeslimTarihi.Date.Day.ToString()))));
                Application.DoEvents();
                DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                //Teslim Edilmemişse
                if (gun < -1 && teslimDurum == false)
                {
                    rowColor.BackColor = Color.Red;
                }
                else if (gun > -1 && gun < 2 && teslimDurum == false)
                {
                    rowColor.BackColor = Color.Blue;
                }
                else if (gun > 2 && teslimDurum == false)
                {
                    rowColor.BackColor = Color.Yellow;
                }
                //Teslim edilmişse
                else if (teslimDurum == true)
                {
                    rowColor.BackColor = Color.Green;
                }
                else
                {
                    rowColor.BackColor = Color.White;
                }

                dataGridView1.Rows[i].DefaultCellStyle = rowColor;
                

            }
           
            
        }

        void txtOduncUyeNo_GotFocus(object sender, EventArgs e)
        {
            txtOduncUyeNo.Text = "";
        }
        //Üye no ile arama ya da kitap barkod ile arama
        public void Goster()
        {
            con.Open();
            ds.Clear();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Odunc WHERE UyeNo like '%" + txtOduncUyeNo.Text + "%'  OR  KitapBarkod like '%" + txtOduncUyeNo.Text + "%' ", con);
            da.Fill(ds, "Kutuphane");
            dataGridView1.DataSource = ds.Tables["Kutuphane"];
            con.Close();

        }
        

        private void raporlar_Load(object sender, EventArgs e)
        {   
            IstatistikGoster();     
        }

        private void btnOduncIncele_Click(object sender, EventArgs e)
        {
            Goster();
        }
        public bool grafikgoster = false;
        private void tabControlRpr_Click(object sender, EventArgs e)
        {
            if (grafikgoster == false)
            {
                Listele();
            }
            grafikgoster = true;
            dataGridView1.Refresh();
            
        }

        
    }
}
