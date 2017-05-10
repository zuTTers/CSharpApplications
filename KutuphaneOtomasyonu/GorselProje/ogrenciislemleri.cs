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
    public partial class ogrenciislemleri : Form
    {
        public ogrenciislemleri()
        {
            InitializeComponent();
        }
        public string kaynak = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kutuphane.accdb";
        OleDbConnection con;
        DataSet ds = new DataSet();
        OleDbCommand cmd;
        OleDbDataAdapter adab;
        DataTable dt = new DataTable();


        private void ogrenciislemleri_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUyeEkle_Click_1(object sender, EventArgs e)
        {
            //textboxlar boşsa btnuyeekleme işlemi yapılmaz
            if (txtUyeAdi.Text =="" && txtUyeSoyadi.Text =="" && txtBolum.Text=="")
            {
                lblEkleSonuc.Text = "Boşluklar mevcut. Lütfen boşlukları doldurunuz.";
            }
            else
            {
                //Kisiler tablosuna uye ekleme
                con = new OleDbConnection(kaynak);
                string sorgu = "INSERT INTO Kisiler (UyeAdi,UyeSoyadi,Cinsiyet,DogumTarihi,Telefon,Eposta,Sınıf,Bolum,UyelikTarihi)" +
                               "VALUES (@UyeAdi,@UyeSoyadi,@Cinsiyet,@DogumTarihi,@Telefon,@Eposta,@Sınıf,@Bolum,@UyelikTarihi)";

                cmd = new OleDbCommand(sorgu, con);
                string cinsiyet = "";
                if (radioButton2.Checked == true)
                {
                    cinsiyet = "Bay";
                }
                else
                {
                    cinsiyet = "Bayan";
                }
                //parametreler
                cmd.Parameters.AddWithValue("@UyeAdi", txtUyeAdi.Text);
                cmd.Parameters.AddWithValue("@UyeSoyadi", txtUyeSoyadi.Text);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@DogumTarihi", dtpDogumTarih.Text);
                cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@Eposta", txtEposta.Text);
                cmd.Parameters.AddWithValue("@Sınıf", comboBoxSinif.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Bolum", txtBolum.Text);
                cmd.Parameters.AddWithValue("@UyelikTarihi", dtpUyelikTarih.Text);
                int sonuc = 0;
                try
                {
                    con.Open();
                    sonuc = cmd.ExecuteNonQuery();
                    con.Close();
                    if (sonuc == 1)
                    {
                        lblEkleSonuc.Text = "Üye ekleme işlemi başarılı.";
                        txtUyeAdi.Text = "";
                        txtTelefon.Text = "";
                        txtEposta.Text = "";
                        txtUyeSoyadi.Text = "";
                        txtBolum.Text = "";
                        comboBoxSinif.SelectedIndex = 0;
                    }
                    else
                    {
                        lblEkleSonuc.Text = "Üye ekleme işlemi başarısız.";
                    }


                }
                catch (Exception)
                {

                    throw;
                }
            }      
            
        }

        private void btnUyeDuzenle_Click_1(object sender, EventArgs e)
        {

            if (txtDUyeAdi.Text == "" && txtDUyeSoyad.Text == "" && txtDBolum.Text == "")
            {
                lblDuzenleSonuc.Text = "Boşluklar mevcut. Lütfen boşlukları doldurunuz.";
            }
            else
            {
                string cinsiyet = "";
                if (radioButton2.Checked == true)
                {
                    cinsiyet = "Bay";
                }
                else
                {
                    cinsiyet = "Bayan";
                }
                con = new OleDbConnection(kaynak);
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE  Kisiler  SET UyeAdi=@UyeAdi,UyeSoyadi=@UyeSoyadi,Cinsiyet=@Cinsiyet,DogumTarihi=@DogumTarihi,Telefon=@Telefon,Eposta=@Eposta,Sınıf=@Sınıf,Bolum=@Bolum,UyelikTarihi=@UyelikTarihi WHERE UyeNo=@UyeNo";
                if (radioButton1.Checked == true)
                {
                    cinsiyet = "Bay";
                }
                else
                {
                    cinsiyet = "Bayan";
                }

                cmd.Parameters.AddWithValue("@UyeAdi", txtDUyeAdi.Text);
                cmd.Parameters.AddWithValue("@UyeSoyadi", txtDUyeSoyad.Text);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(dtpDDogumTarih.Text));
                cmd.Parameters.AddWithValue("@Telefon", txtDTelefon.Text);
                cmd.Parameters.AddWithValue("@Eposta", txtDEposta.Text);
                cmd.Parameters.AddWithValue("@Sınıf", comboBoxDSinif.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Bolum", txtDBolum.Text);
                cmd.Parameters.AddWithValue("@UyelikTarihi", Convert.ToDateTime(dtpDUyelikTarih.Text));
                cmd.Parameters.AddWithValue("@UyeNo", Convert.ToInt32(txtDUyeNo.Text));
                int sonuc = 0;
                try
                {
                    con.Open();
                    sonuc = cmd.ExecuteNonQuery();
                    con.Close();
                    if (sonuc == 1)
                    {
                        lblDuzenleSonuc.Text = "Düzenleme işlemi başarılı.";
                    }
                    else
                    {
                        lblDuzenleSonuc.Text = "Düzenleme işlemi başarısız.";
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        
            
        }

        private void btnUyeSil_Click_1(object sender, EventArgs e)
        {
            if (txtUyeNoSil.Text=="")
            {
                lblSilSonuc.Text = "Üye numarasını giriniz!";
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
                    cmd.CommandText = "DELETE * FROM Kisiler WHERE UyeNo=@UyeNo";
                    cmd.Parameters.AddWithValue("@UyeNo", Convert.ToInt32(txtUyeNoSil.Text));
                    int sonuc = 0;
                    try
                    {
                        con.Open();
                        sonuc = cmd.ExecuteNonQuery();
                        con.Close();
                        if (sonuc == 1)
                        {
                            lblSilSonuc.Text = "Silme işlemi başarılı.";
                            txtUyeNoSil.Text = "";
                        }
                        else
                        {
                            lblSilSonuc.Text = "Silme işlemi başarısız.";
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
                    
        }

        public DataRow UyeListeCek(int id)
        {
            con = new OleDbConnection(kaynak);
            cmd = new OleDbCommand();
            string sorgu = "SELECT * FROM Kisiler WHERE UyeNo=@UyeNo";
            cmd.Connection = con;
            DataTable dt = new DataTable();
            OleDbDataAdapter adaptor = new OleDbDataAdapter(sorgu, con);
            adaptor.SelectCommand.Parameters.AddWithValue("@UyeNo",id);
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
            if (txtDUyeNo.Text == "")
            {
                MessageBox.Show("Üye numarası giriniz!");
            }
            else
            {
                DataRow dr = UyeListeCek(Convert.ToInt32(txtDUyeNo.Text));
            
                txtDUyeAdi.Text = dr["UyeAdi"].ToString();
                txtDUyeSoyad.Text = dr["UyeSoyadi"].ToString();
                dtpDDogumTarih.Text = dr["DogumTarihi"].ToString();
                txtDTelefon.Text = dr["Telefon"].ToString();
                txtDEposta.Text = dr["Eposta"].ToString();
                comboBoxDSinif.SelectedItem = dr["Sınıf"].ToString();
                txtDBolum.Text = dr["Bolum"].ToString();
                dtpDUyelikTarih.Text = dr["UyelikTarihi"].ToString();
            }
            
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDUyeAdi.Text = "";
            txtDUyeSoyad.Text = "";
            dtpDDogumTarih.Text = "";
            txtDTelefon.Text = "";
            txtDEposta.Text = "";
            comboBoxDSinif.SelectedIndex = -1;
            txtDBolum.Text = "";
            dtpDUyelikTarih.Text = "";
        }



    }
}
