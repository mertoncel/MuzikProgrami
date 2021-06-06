using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MuzikProgrami
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H0GJB3C;Initial Catalog=Prolab;Integrated Security=True");


        private void FormGiris_Load(object sender, EventArgs e)
        {

            
        }

        private void btn_Kayitol_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmdKayitOl = new SqlCommand("insert into Kullanicilar (KullaniciAdi,KullaniciEmail,KullaniciSifre,KullaniciAbonelikTur, KullaniciUlke) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                cmdKayitOl.Parameters.AddWithValue("@p1", txt_kullaniciadi.Text);
                cmdKayitOl.Parameters.AddWithValue("@p2", txt_email.Text);
                cmdKayitOl.Parameters.AddWithValue("@p3", txt_sifre.Text);
                cmdKayitOl.Parameters.AddWithValue("@p4", cmb_abonelik.SelectedItem);
                cmdKayitOl.Parameters.AddWithValue("@p5", txt_ulke.Text);
                cmdKayitOl.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt başarılı");

            }
            catch (Exception)
            {
                MessageBox.Show("Hata");

                
            }

            int kullaniciID = 0;
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select KullaniciID from Kullanicilar", baglanti);
            SqlDataReader rd2 = cmd2.ExecuteReader();

            while (rd2.Read())
            {
                kullaniciID = int.Parse(rd2["KullaniciID"].ToString());
                


            }
            baglanti.Close();

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into CalmaListesi (CalmaListesiAdi,KullaniciID) values ('pop','"+ kullaniciID+ "'),('jazz','" + kullaniciID + "'),('klasik','" + kullaniciID + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

            

            }
            catch (Exception)
            {

                MessageBox.Show("çalma listesi ekleme hatası");
            }

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string queryGirisYap = "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @username AND KullaniciSifre = @password";
                SqlParameter prm1 = new SqlParameter("username", txt_giris_kullaniciadi.Text);
                SqlParameter prm2 = new SqlParameter("password", txt_giris_sifre.Text);
                SqlCommand cmdGirisYap = new SqlCommand(queryGirisYap,baglanti);
                cmdGirisYap.Parameters.Add(prm1);
                cmdGirisYap.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdGirisYap);
                dataAdapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    FormKullanici frm = new FormKullanici(txt_giris_kullaniciadi.Text.ToString());
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre hatalı");
                }
                baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata");

                
            }
        }

        private void btn_admin_giris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string queryGirisYap = "SELECT * FROM Admin WHERE AdminAdi = @username AND AdminSifre = @password";
                SqlParameter prm1 = new SqlParameter("username", txt_admin_kullanici.Text);
                SqlParameter prm2 = new SqlParameter("password", txt_admin_sifre.Text);
                SqlCommand cmdGirisYap = new SqlCommand(queryGirisYap, baglanti);
                cmdGirisYap.Parameters.Add(prm1);
                cmdGirisYap.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdGirisYap);
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FormAnaEkran frm = new FormAnaEkran();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre hatalı");
                }
                baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata");

               
            }
        }
    }
}


