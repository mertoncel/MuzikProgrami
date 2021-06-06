using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikProgrami
{
    public partial class FormKullanici : Form
    {

        int kullaniciID = 0;
        int takipciID = 0;
        int calmaListesiKullaniciID = 0;
        int calmaListesiID = 0;
        int sarkiID = 0;
        string calmaListesiAdi = "";

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H0GJB3C;Initial Catalog=Prolab;Integrated Security=True");


        public FormKullanici(String kullaniciAdi)
        {
            InitializeComponent();

            baglanti.Open();

            SqlCommand cmd = new SqlCommand("select KullaniciID from Kullanicilar where KullaniciAdi = '"+kullaniciAdi+"'", baglanti);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                takipciID = (int)rd["KullaniciID"];



            }
            baglanti.Close();


        }

        




        private void VeriGoruntule()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select KullaniciID, KullaniciAdi from Kullanicilar where KullaniciAbonelikTur = 'premium'", baglanti);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["KullaniciID"].ToString();
                ekle.SubItems.Add(rd["KullaniciAdi"].ToString());



                lst_kullanici_liste.Items.Add(ekle);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select Kullanicilar.KullaniciID, KullaniciAdi from Kullanicilar inner join Takipciler on Takipciler.KullaniciID = Kullanicilar.KullaniciID where TakipciID = '"+takipciID.ToString()+"'", baglanti);
            SqlDataReader rd2 = cmd2.ExecuteReader();

            while (rd2.Read())
            {
                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = rd2["KullaniciID"].ToString();
                ekle2.SubItems.Add(rd2["KullaniciAdi"].ToString());



                lst_Takip.Items.Add(ekle2);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select CalmalistesiID,CalmalistesiAdi from CalmaListesi where KullaniciID =  '" + calmaListesiKullaniciID.ToString() + "'", baglanti);
            SqlDataReader rd3 = cmd3.ExecuteReader();

            while (rd3.Read())
            {
                ListViewItem ekle3 = new ListViewItem();
                ekle3.Text = rd3["CalmalistesiID"].ToString();
                ekle3.SubItems.Add(rd3["CalmalistesiAdi"].ToString());



                lst_takip_calma_listesi.Items.Add(ekle3);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select CalmaListesiSarki.SarkiID,SarkiAdi from CalmaListesi inner join CalmaListesiSarki on CalmalistesiSarki.CalmaListesiID = CalmaListesi.CalmalistesiID inner join Sarki on Sarki.SarkiID = CalmalistesiSarki.SarkiID where KullaniciID = '" + calmaListesiKullaniciID.ToString() + "' and CalmaListesi.CalmalistesiID = '" + calmaListesiID.ToString() + "'", baglanti);
            SqlDataReader rd4 = cmd4.ExecuteReader();

            while (rd4.Read())
            {
                ListViewItem ekle4 = new ListViewItem();
                ekle4.Text = rd4["SarkiID"].ToString();
                ekle4.SubItems.Add(rd4["SarkiAdi"].ToString());



                lst_calmalistesi_sarkilar.Items.Add(ekle4);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("select CalmalistesiID,CalmalistesiAdi from CalmaListesi where KullaniciID =  '" + takipciID.ToString() + "'", baglanti);
            SqlDataReader rd5 = cmd5.ExecuteReader();

            while (rd5.Read())
            {
                ListViewItem ekle5 = new ListViewItem();
                ekle5.Text = rd5["CalmalistesiID"].ToString();
                ekle5.SubItems.Add(rd5["CalmalistesiAdi"].ToString());



                lst_calma_listem.Items.Add(ekle5);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select CalmaListesiSarki.SarkiID,SarkiAdi from CalmaListesi inner join CalmaListesiSarki on CalmalistesiSarki.CalmaListesiID = CalmaListesi.CalmalistesiID inner join Sarki on Sarki.SarkiID = CalmalistesiSarki.SarkiID where KullaniciID = '" + takipciID.ToString() + "' and CalmaListesi.CalmalistesiID = '" + calmaListesiID.ToString() + "'", baglanti);
            SqlDataReader rd6 = cmd6.ExecuteReader();

            while (rd6.Read())
            {
                ListViewItem ekle6 = new ListViewItem();
                ekle6.Text = rd6["SarkiID"].ToString();
                ekle6.SubItems.Add(rd6["SarkiAdi"].ToString());



                lst_calmalistem_sarkilar.Items.Add(ekle6);
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select CalmaListesiSarki.SarkiID,SarkiAdi, Sanatci.SanatciAdi,Album.AlbumAdi, SarkiDinlenmeSayisi,Sure from CalmaListesi inner join CalmaListesiSarki on CalmalistesiSarki.CalmaListesiID = CalmaListesi.CalmalistesiID inner join Sarki on Sarki.SarkiID = CalmalistesiSarki.SarkiID inner join Sanatci on Sanatci.SanatciID = Sarki.SanatciID inner join Album on Album.AlbumID = Sarki.AlbumID where CalmalistesiAdi = 'pop' order by SarkiDinlenmeSayisi desc", baglanti);
            SqlDataReader rd7= cmd7.ExecuteReader();

            while (rd7.Read())
            {
                ListViewItem ekle7 = new ListViewItem();
                ekle7.Text = rd7["SarkiID"].ToString();
                ekle7.SubItems.Add(rd7["SarkiAdi"].ToString());
                ekle7.SubItems.Add(rd7["SanatciAdi"].ToString());
                ekle7.SubItems.Add(rd7["AlbumAdi"].ToString());
                ekle7.SubItems.Add(rd7["SarkiDinlenmeSayisi"].ToString());
                ekle7.SubItems.Add(rd7["Sure"].ToString());




                lst_encok_dinlenen.Items.Add(ekle7);
            }
            baglanti.Close();


        }

        private void FormKullanici_Load(object sender, EventArgs e)
        {
            VeriGoruntule();

            //comboboxa şarkıları  çekme

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Sarki", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_liste_sarki.ValueMember = "SarkiID";
            cmb_liste_sarki.DisplayMember = "SarkiAdi";
            cmb_liste_sarki.DataSource = dt;


            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select distinct SanatciUlke from Sanatci", baglanti);

            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmb_ulkeler.ValueMember = "SanatciUlke";
            cmb_ulkeler.DisplayMember = "SanatciUlke";
            cmb_ulkeler.DataSource = dt2;


            baglanti.Close();
        }



        private void btn_kul_takip_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Takipciler (KullaniciID,TakipciID) values ('" + kullaniciID.ToString() + "','" + takipciID.ToString() + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();

                VeriGoruntule();
            }
            catch (Exception)
            {

                MessageBox.Show("kullanıcıyı takip ediyorsunuz.");
            }

        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            kullaniciID = int.Parse(lst_kullanici_liste.SelectedItems[0].SubItems[0].Text);


        }

        private void lst_Takip_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            calmaListesiKullaniciID = int.Parse(lst_Takip.SelectedItems[0].SubItems[0].Text);
            verileriKaldir();

            VeriGoruntule();
        }

        private void lst_takip_calma_listesi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            calmaListesiID = int.Parse(lst_takip_calma_listesi.SelectedItems[0].SubItems[0].Text);
            calmaListesiAdi = lst_takip_calma_listesi.SelectedItems[0].SubItems[1].Text;

            verileriKaldir();
            VeriGoruntule();



        }

        private void lst_calma_listem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            calmaListesiID = int.Parse(lst_calma_listem.SelectedItems[0].SubItems[0].Text);
            txt_calmalistesi_adi.Text = lst_calma_listem.SelectedItems[0].SubItems[1].Text;
            lst_calma_listem.Items.Clear();
            lst_calmalistem_sarkilar.Items.Clear();
            lst_kullanici_liste.Items.Clear();

            VeriGoruntule();


        }

        private void lst_calmalistem_sarkilar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sarkiID = int.Parse(lst_calmalistem_sarkilar.SelectedItems[0].SubItems[0].Text);

        }

        private void btn_calmalistesi_sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from CalmaListesi where CalmaListesiID = (" + calmaListesiID.ToString() + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();

                VeriGoruntule();
            }
            catch (Exception)
            {

                MessageBox.Show("silmek için çalma listesi seçin");
            }
        }

        private void btn_calmalistesi_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into CalmaListesi (CalmaListesiAdi,KullaniciID) values ('" + txt_calmalistesi_adi.Text.ToString() + "','" + takipciID.ToString() + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                verileriKaldir();
                VeriGoruntule();

            }
            catch (Exception)
            {

                MessageBox.Show("çalma listesi ekleme hatası");
            }
        }

        private void btn_calmalistesi_guncelle_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update CalmaListesi set CalmaListesiAdi = '" + txt_calmalistesi_adi.Text.ToString() + "' where KullaniciID = " + takipciID + " and CalmaListesiID = " + calmaListesiID + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();
                VeriGoruntule();
            }
            catch (Exception)
            {

                MessageBox.Show("güncellemek için çalma listesi seçin");
            }
        }

        public void verileriKaldir()
        {
            lst_calma_listem.Items.Clear();
            lst_kullanici_liste.Items.Clear();
            lst_Takip.Items.Clear();
            lst_takip_calma_listesi.Items.Clear();
            lst_calmalistesi_sarkilar.Items.Clear();
            lst_calma_listem.Items.Clear();
            lst_calmalistem_sarkilar.Items.Clear();
            txt_calmalistesi_adi.Clear();
        }

        private void btn_liste_sarkilar_sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from CalmaListesiSarki where CalmaListesiID = (" + calmaListesiID.ToString() + ") and SarkiID = (" + sarkiID.ToString() + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();

                VeriGoruntule();
            }
            catch (Exception)
            {

                MessageBox.Show("silmek için çalma listesi seçin");
            }
        }

        private void btn_liste_sarkilar_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into CalmaListesiSarki (CalmaListesiID,SarkiID) values ('" + calmaListesiID.ToString() + "','" + cmb_liste_sarki.SelectedValue.ToString() + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                verileriKaldir();
                VeriGoruntule();

            }
            catch (Exception)
            {

                MessageBox.Show("çalma listesi ekleme hatası");
            }
        }

        private void btn_encok_pop_Click(object sender, EventArgs e)
        {
            lst_encok_dinlenen.Items.Clear();

            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select Sarki.SarkiID,SarkiAdi, Sanatci.SanatciAdi,Album.AlbumAdi, SarkiDinlenmeSayisi,Sure from Sarki inner join MuzikTuru on MuzikTuru.MuzikTurID = Sarki.MuzikTurID inner join Sanatci on Sanatci.SanatciID = Sarki.SanatciID inner join Album on Album.AlbumID = Sarki.AlbumID  where MuzikTurAdi = 'pop' order by SarkiDinlenmeSayisi desc", baglanti);
            SqlDataReader rd7 = cmd7.ExecuteReader();

            while (rd7.Read())
            {
                ListViewItem ekle7 = new ListViewItem();
                ekle7.Text = rd7["SarkiID"].ToString();
                ekle7.SubItems.Add(rd7["SarkiAdi"].ToString());
                ekle7.SubItems.Add(rd7["SanatciAdi"].ToString());
                ekle7.SubItems.Add(rd7["AlbumAdi"].ToString());
                ekle7.SubItems.Add(rd7["SarkiDinlenmeSayisi"].ToString());
                ekle7.SubItems.Add(rd7["Sure"].ToString());




                lst_encok_dinlenen.Items.Add(ekle7);
            }
            baglanti.Close();
        }

        private void btn_encok_klasik_Click(object sender, EventArgs e)
        {
            lst_encok_dinlenen.Items.Clear();

            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select Sarki.SarkiID,SarkiAdi, Sanatci.SanatciAdi,Album.AlbumAdi, SarkiDinlenmeSayisi,Sure from Sarki inner join MuzikTuru on MuzikTuru.MuzikTurID = Sarki.MuzikTurID inner join Sanatci on Sanatci.SanatciID = Sarki.SanatciID inner join Album on Album.AlbumID = Sarki.AlbumID  where MuzikTurAdi = 'klasik' order by SarkiDinlenmeSayisi desc", baglanti);
            SqlDataReader rd7 = cmd7.ExecuteReader();

            while (rd7.Read())
            {
                ListViewItem ekle7 = new ListViewItem();
                ekle7.Text = rd7["SarkiID"].ToString();
                ekle7.SubItems.Add(rd7["SarkiAdi"].ToString());
                ekle7.SubItems.Add(rd7["SanatciAdi"].ToString());
                ekle7.SubItems.Add(rd7["AlbumAdi"].ToString());
                ekle7.SubItems.Add(rd7["SarkiDinlenmeSayisi"].ToString());
                ekle7.SubItems.Add(rd7["Sure"].ToString());




                lst_encok_dinlenen.Items.Add(ekle7);
            }
            baglanti.Close();
        }

        private void btn_encok_jazz_Click(object sender, EventArgs e)
        {
            lst_encok_dinlenen.Items.Clear();

            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select Sarki.SarkiID,SarkiAdi, Sanatci.SanatciAdi,Album.AlbumAdi, SarkiDinlenmeSayisi,Sure from Sarki inner join MuzikTuru on MuzikTuru.MuzikTurID = Sarki.MuzikTurID inner join Sanatci on Sanatci.SanatciID = Sarki.SanatciID inner join Album on Album.AlbumID = Sarki.AlbumID  where MuzikTurAdi = 'jazz' order by SarkiDinlenmeSayisi desc", baglanti);
            SqlDataReader rd7 = cmd7.ExecuteReader();

            while (rd7.Read())
            {
                ListViewItem ekle7 = new ListViewItem();
                ekle7.Text = rd7["SarkiID"].ToString();
                ekle7.SubItems.Add(rd7["SarkiAdi"].ToString());
                ekle7.SubItems.Add(rd7["SanatciAdi"].ToString());
                ekle7.SubItems.Add(rd7["AlbumAdi"].ToString());
                ekle7.SubItems.Add(rd7["SarkiDinlenmeSayisi"].ToString());
                ekle7.SubItems.Add(rd7["Sure"].ToString());




                lst_encok_dinlenen.Items.Add(ekle7);
            }
            baglanti.Close();
        }

        private void btn_encok_genel_Click(object sender, EventArgs e)
        {
            lst_encok_dinlenen.Items.Clear();

            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select Sarki.SarkiID,SarkiAdi, Sanatci.SanatciAdi,Album.AlbumAdi, SarkiDinlenmeSayisi,Sure from Sarki inner join MuzikTuru on MuzikTuru.MuzikTurID = Sarki.MuzikTurID inner join Sanatci on Sanatci.SanatciID = Sarki.SanatciID inner join Album on Album.AlbumID = Sarki.AlbumID   order by SarkiDinlenmeSayisi desc", baglanti);
            SqlDataReader rd7 = cmd7.ExecuteReader();

            while (rd7.Read())
            {
                ListViewItem ekle7 = new ListViewItem();
                ekle7.Text = rd7["SarkiID"].ToString();
                ekle7.SubItems.Add(rd7["SarkiAdi"].ToString());
                ekle7.SubItems.Add(rd7["SanatciAdi"].ToString());
                ekle7.SubItems.Add(rd7["AlbumAdi"].ToString());
                ekle7.SubItems.Add(rd7["SarkiDinlenmeSayisi"].ToString());
                ekle7.SubItems.Add(rd7["Sure"].ToString());




                lst_encok_dinlenen.Items.Add(ekle7);
            }
            baglanti.Close();
        }

        private void btn_encok_ulkeler_Click(object sender, EventArgs e)
        {
            lst_encok_dinlenen.Items.Clear();

            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select Sarki.SarkiID,SarkiAdi, Sanatci.SanatciAdi,Album.AlbumAdi, SarkiDinlenmeSayisi,Sure from Sarki inner join MuzikTuru on MuzikTuru.MuzikTurID = Sarki.MuzikTurID inner join Sanatci on Sanatci.SanatciID = Sarki.SanatciID inner join Album on Album.AlbumID = Sarki.AlbumID where SanatciUlke = '" + cmb_ulkeler.SelectedValue.ToString() + "' order by SarkiDinlenmeSayisi desc", baglanti);
            SqlDataReader rd7 = cmd7.ExecuteReader();

            while (rd7.Read())
            {
                ListViewItem ekle7 = new ListViewItem();
                ekle7.Text = rd7["SarkiID"].ToString();
                ekle7.SubItems.Add(rd7["SarkiAdi"].ToString());
                ekle7.SubItems.Add(rd7["SanatciAdi"].ToString());
                ekle7.SubItems.Add(rd7["AlbumAdi"].ToString());
                ekle7.SubItems.Add(rd7["SarkiDinlenmeSayisi"].ToString());
                ekle7.SubItems.Add(rd7["Sure"].ToString());




                lst_encok_dinlenen.Items.Add(ekle7);
            }
            baglanti.Close();
        }

        private void btn_listeme_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                int calmaListemID = 0;

                baglanti.Open();

                SqlCommand komut2 = new SqlCommand("select distinct Calmalistesi.CalmalistesiID from Calmalistesi  where CalmalistesiAdi = '"+calmaListesiAdi+"' and KullaniciID = '"+takipciID+"'", baglanti);

                SqlDataReader rd2 = komut2.ExecuteReader();

                while (rd2.Read())
                {
                    calmaListemID = int.Parse(rd2["CalmalistesiID"].ToString());



                }
                baglanti.Close();




                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into CalmaListesiSarki (CalmaListesiID,SarkiID) values ('" + calmaListemID.ToString() + "','" + sarkiID.ToString() + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                verileriKaldir();
                VeriGoruntule();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void lst_calmalistesi_sarkilar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sarkiID = int.Parse(lst_calmalistesi_sarkilar.SelectedItems[0].SubItems[0].Text);
        }
    }
}
