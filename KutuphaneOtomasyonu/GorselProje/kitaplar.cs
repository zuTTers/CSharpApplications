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
    public partial class kitaplar : Form
    {
        public kitaplar()
        {
            InitializeComponent();
        }

        public string kaynak = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kutuphane.accdb";
        OleDbConnection con;
        DataSet ds = new DataSet();
        OleDbCommand cmd;
        OleDbDataAdapter adab;
        DataTable dt = new DataTable();
        public void Listele()
        {
            con = new OleDbConnection(kaynak);
            cmd = new OleDbCommand();
            string sorgu = "SELECT * FROM Kitaplar";
            con.Open();
            adab = new OleDbDataAdapter(sorgu, con);
            adab.Fill(ds, "Kitaplar");
            dataGridView1.DataSource = ds.Tables["Kitaplar"];
            con.Close();

            txtBarkodNo.GotFocus += txtBarkodNo_GotFocus;//textbox focus layınca temizleniyor.
        }
        private void kitaplar_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Refresh();//daha önce işlem yapılmış olabilir.bu yüzden gridview i tazeliyoruz.

            Listele();
            //txtBarkodNo.LostFocus += txtBarkodNo_LostFocus; //textbox focus layınca placeholder ile dolduruyor.sorgumu bozdugu için kullanamadım.
                        
        }
        //dataseti gridview ile doldur sonra sorguya gore cek
        public void goster()
        {
            con.Open();
            ds.Clear();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Kitaplar WHERE KitapAdi like '%" + txtBarkodNo.Text + "%'  OR  KitapBarkod like '%" + txtBarkodNo.Text + "%' ", con);
            da.Fill(ds, "Kutuphane");
            dataGridView1.DataSource = ds.Tables["Kutuphane"];
            con.Close();
            
        }
      
        private void btnIncele_Click(object sender, EventArgs e)
        {
            
            goster();
        }

        void txtBarkodNo_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBarkodNo.Text))
                txtBarkodNo.Text = "Kitap Adi ya da Barkod No giriniz.";
            
        }

        private void txtBarkodNo_GotFocus(object sender, EventArgs e)
        {
            txtBarkodNo.Text = "";
        }


        private void txtBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox boşsa
            if (Convert.ToInt32(e.KeyChar) == 13)
                goster();
            
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
