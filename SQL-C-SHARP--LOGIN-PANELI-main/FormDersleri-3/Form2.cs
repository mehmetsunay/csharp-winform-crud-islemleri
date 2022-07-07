using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;
using DataSet = System.Data.DataSet;

namespace FormDersleri_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds; 

        void vericek()
        {
           
            //baglantımı actım 
            //ogrencı tablomdan verılerımı sectım 
            //dataset olusturup kopru gorevı yapan adaptorumle bu datasetın ıcını dold.
        
            con = new SqlConnection("server=DESKTOP-UDMLI44\\SQLEXPRESS; Initial Catalog=dbLogin; Integrated Security=True");
            da = new SqlDataAdapter("Select *From ogrenci", con);
           
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            //dtgmın içerisine veri setimi yerleştiriyorum
            dtg_ogrenci.DataSource = ds.Tables["ogrenci"];
            con.Close();
        }
        public string mesaj;
        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_tasi.Text = mesaj;

            vericek();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ogrenci(ogrnci_no,ogrnci_isim,ogrnci_soyisim) values (" + txt_no.Text + ",'" + txt_ad.Text + "','" + txt_soyad.Text + "')";
            cmd.ExecuteNonQuery(); 
            con.Close();
            vericek();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from ogrenci where ogrnci_no=" + txt_no.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            vericek();
        }
    }
}
