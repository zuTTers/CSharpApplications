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
    public partial class ogrenciler : Form
    {
        public ogrenciler()
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
            string sorgu = "SELECT * FROM Kisiler";
            con.Open();
            adab = new OleDbDataAdapter(sorgu,con);
            adab.Fill(ds,"Kisiler");
            dataGridView1.DataSource = ds.Tables["Kisiler"];
            con.Close();

            txtUyeNo.GotFocus += txtUyeNo_GotFocus;//textbox focuslayınca temizlenir

        }

        void txtUyeNo_GotFocus(object sender, EventArgs e)
        {
            txtUyeNo.Text = "";
        }

        private void ogrenciler_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Refresh();//daha önce işlem yapılmış olabilir.bu yüzden gridview i tazeliyoruz.

            Listele();
        }

        public void goster()
        {
            //UyeAdina göre ya uyenoya göre gridviewde arama yapma işlemi
            con.Open();
            ds.Clear();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Kisiler WHERE UyeAdi like '%" + txtUyeNo.Text + "%'  OR  UyeNo like '%" + txtUyeNo.Text + "%' ", con);
            da.Fill(ds, "Kutuphane");
            dataGridView1.DataSource = ds.Tables["Kutuphane"];
            con.Close();

        }

        

        private void btnIncele_Click(object sender, EventArgs e)
        {
            goster();
        }

    }
}
