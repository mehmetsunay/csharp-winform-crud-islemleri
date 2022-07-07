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


namespace FormDersleri_3
{
    public partial class Form1 : Form
    {
        /*
         Logın ıslemlerımın gerceklesebılmesı ıcın 
         baglantımın acılması 
        sql ve tsql konutlarımın kullanılması
        ve bu sorgulardan donen degerlerın alınıp execute 
        edılmesı gerekıyor

        İşte tüm bu sebeplerden dolayı 
        aşağıdaki veri türlerini ve onlardan türeyen nesneleri 
        kullanıyorum
       */

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
      

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {  //select komutula tablomdaki ilgili alanlarımdan seçim hazırlıgı yaptım
            string sorgu = "SELECT * FROM tblUser where usr=@user AND psw=@pass";
            //açacagım baglantının ayarlarını yapıyorum
            con = new SqlConnection("server=DESKTOP-UDMLI44\\SQLEXPRESS; Initial Catalog=dbLogin; Integrated Security=True");
            //ne demiştik sql komutlarımı kullanabılmem ıcın sqlcommanda ıhtıyacım
            //oldugundan bahsetmıstık aşağıda bu işlemi gerçekleştiriyorum
            cmd = new SqlCommand(sorgu, con);
            //kullanıcıdan usernameı ve pass al başta tanımladıgım tsql
            //değişkenlerine ata
            cmd.Parameters.AddWithValue("@user", txt_kadi.Text);
            cmd.Parameters.AddWithValue("@pass", txt_sifre.Text);

             //bağlantımı actım 
            con.Open();
            // sorgulardan donen degerlere bakmama yarıyordu reader.
            dr = cmd.ExecuteReader();
            //eğer dönen değerim kolnlarda mevcutsa , değilse .....
            if(dr.Read())

           {
                MessageBox.Show("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız");

                Form2 frm = new Form2();
                frm.mesaj = txt_kadi.Text;
                frm.Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz");

            }


            con.Close();


        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
           
        }
    }
}
