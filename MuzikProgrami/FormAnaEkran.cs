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
    public partial class FormAnaEkran : Form
    {
        public FormAnaEkran()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H0GJB3C;Initial Catalog=Prolab;Integrated Security=True");



        private void VeriGoruntule()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select Sarki.SarkiID,SarkiAdi,SarkiTarih,SarkiDinlenmeSayisi,SanatciAdi, AlbumAdi, MuzikTurAdi,Sure from Sarki inner join Sanatci on Sanatci.SanatciID = Sarki.SanatciID inner join Album on Album.AlbumID = Sarki.AlbumID inner join MuzikTuru on MuzikTuru.MuzikTurID = Sarki.MuzikTurID", baglanti);
            SqlDataReader rd = cmd.ExecuteReader();

            while(rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["SarkiID"].ToString();
                ekle.SubItems.Add(rd["SarkiAdi"].ToString());
                ekle.SubItems.Add(rd["SarkiTarih"].ToString());
                ekle.SubItems.Add(rd["SarkiDinlenmeSayisi"].ToString());
                ekle.SubItems.Add(rd["SanatciAdi"].ToString());
                ekle.SubItems.Add(rd["AlbumAdi"].ToString());
                ekle.SubItems.Add(rd["MuzikTurAdi"].ToString());
                ekle.SubItems.Add(rd["Sure"].ToString());


                lst_sarkilar.Items.Add(ekle);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select SanatciID,SanatciAdi,SanatciUlke from Sanatci", baglanti);
            SqlDataReader rd2 = cmd2.ExecuteReader();

            while (rd2.Read())
            {
                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = rd2["SanatciID"].ToString();
                ekle2.SubItems.Add(rd2["SanatciAdi"].ToString());
                ekle2.SubItems.Add(rd2["SanatciUlke"].ToString());


                lst_sanatcilar.Items.Add(ekle2);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select Album.AlbumID,AlbumAdi,SanatciAdi,AlbumTarih, MuzikTurAdi from Album inner join Sanatci on Sanatci.SanatciID = Album.SanatciID  inner join MuzikTuru on MuzikTuru.MuzikTurID = Album.MuzikTurID", baglanti);
            SqlDataReader rd3 = cmd3.ExecuteReader();

            while (rd3.Read())
            {
                ListViewItem ekle3 = new ListViewItem();
                ekle3.Text = rd3["AlbumID"].ToString();
                ekle3.SubItems.Add(rd3["AlbumAdi"].ToString());
                ekle3.SubItems.Add(rd3["SanatciAdi"].ToString());
                ekle3.SubItems.Add(rd3["AlbumTarih"].ToString());
                ekle3.SubItems.Add(rd3["MuzikTurAdi"].ToString());



                lst_albumler.Items.Add(ekle3);
            }
            baglanti.Close();

            //comboboxa albümleri çekme
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select * from Album", baglanti);

            SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            cmb_sarki_album.ValueMember = "AlbumID";
            cmb_sarki_album.DisplayMember = "AlbumAdi";
            cmb_sarki_album.DataSource = dt6;


            baglanti.Close();

            //comboboxa sanatçıları çekme

            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select * from Sanatci", baglanti);

            SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            cmb_sarki_sanatci.ValueMember = "SanatciID";
            cmb_sarki_sanatci.DisplayMember = "SanatciAdi";
            cmb_sarki_sanatci.DataSource = dt7;
            cmb_album_sanatci.ValueMember = "SanatciID";
            cmb_album_sanatci.DisplayMember = "SanatciAdi";
            cmb_album_sanatci.DataSource = dt7;


            baglanti.Close();

            //comboboxa türleri çekme

            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("select * from MuzikTuru", baglanti);

            SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            cmb_sarki_tur.ValueMember = "MuzikTurID";
            cmb_sarki_tur.DisplayMember = "MuzikTurAdi";
            cmb_sarki_tur.DataSource = dt8;
            cmb_album_tur.ValueMember = "MuzikTurID";
            cmb_album_tur.DisplayMember = "MuzikTurAdi";
            cmb_album_tur.DataSource = dt8;

            baglanti.Close();




        }





        private void FormAnaEkran_Load(object sender, EventArgs e)
        {
            VeriGoruntule();


           

            



        }

        private void btn_sarkiekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Sarki (SarkiAdi,SarkiTarih,SanatciID,AlbumID,MuzikTurID,SarkiDinlenmeSayisi,Sure) values ('" + txt_sarki_adi.Text.ToString() + "','" + nmb_sarki_tarih.Text.ToString() + "','" + cmb_sarki_sanatci.SelectedValue.ToString() + "','" + cmb_sarki_album.SelectedValue.ToString() + "','" + cmb_sarki_tur.SelectedValue.ToString() + "','" + nmb_sarki_dinlenme.Text.ToString() + "','" + nmb_sarki_sure.Text.ToString() + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();

                int eklenensarkiID = 0;
                baglanti.Open();
                SqlCommand cmd3 = new SqlCommand("select SarkiID from Sarki where SarkiAdi = '"+txt_sarki_adi.Text.ToString()+"'", baglanti);
                SqlDataReader rd3 = cmd3.ExecuteReader();

                while (rd3.Read())
                {
                    eklenensarkiID = int.Parse(rd3["SarkiID"].ToString());



                }
                baglanti.Close();

                baglanti.Open();

                SqlCommand komut2 = new SqlCommand("insert into AlbumSarki (AlbumID,SarkiID) values ('" + cmb_sarki_album.SelectedValue.ToString() + "','" + eklenensarkiID.ToString() + "')", baglanti);

                komut2.ExecuteNonQuery();
                baglanti.Close();

                verileriKaldir();
                VeriGoruntule();
                txt_sarki_adi.Clear();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }



        }

        int id = 0;

        private void btn_sarkisil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Sarki where SarkiID = (" + id + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();
                VeriGoruntule();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }


        }



        private void btn_sarki_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(lst_sarkilar.SelectedItems[0].SubItems[0].Text);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Sarki set SarkiAdi = '" + txt_sarki_adi.Text.ToString() + "', SarkiTarih = '" + nmb_sarki_tarih.Text.ToString() + "',SanatciID = '" + cmb_sarki_sanatci.SelectedValue.ToString() + "',AlbumID = '" + cmb_sarki_album.SelectedValue.ToString() + "',MuzikTurID = '" + cmb_sarki_tur.SelectedValue.ToString() + "',SarkiDinlenmeSayisi = '" + nmb_sarki_dinlenme.Text.ToString() + "', Sure = '" + nmb_sarki_sure.Text.ToString() + "' where SarkiID = " + id + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();
                VeriGoruntule();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }



        }

        private void btn_sanatci_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Sanatci (SanatciAdi,SanatciUlke) values ('" + txt_sanatci_adi.Text.ToString() + "','" + txt_sanatci_ulke.Text.ToString() + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();
                VeriGoruntule();
                txt_sanatci_adi.Clear();
                txt_sanatci_ulke.Clear();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }



        }

        private void btn_sanatci_sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Sanatci where SanatciID = (" + id + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();
                VeriGoruntule();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }

        private void btn_sanatci_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(lst_sanatcilar.SelectedItems[0].SubItems[0].Text);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Sanatci set SanatciAdi = '" + txt_sanatci_adi.Text.ToString() + "', SanatciUlke = '" + txt_sanatci_ulke.Text.ToString() + "' where SanatciID = " + id + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();
                VeriGoruntule();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(lst_sarkilar.SelectedItems[0].SubItems[0].Text);
            txt_sarki_adi.Text = lst_sarkilar.SelectedItems[0].SubItems[1].Text;
            nmb_sarki_tarih.Text = lst_sarkilar.SelectedItems[0].SubItems[2].Text;
            nmb_sarki_dinlenme.Text = lst_sarkilar.SelectedItems[0].SubItems[3].Text;
            cmb_sarki_sanatci.Text = lst_sarkilar.SelectedItems[0].SubItems[4].Text;
            cmb_sarki_album.Text = lst_sarkilar.SelectedItems[0].SubItems[5].Text;
            cmb_sarki_tur.Text = lst_sarkilar.SelectedItems[0].SubItems[6].Text;


        }
        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(lst_sanatcilar.SelectedItems[0].SubItems[0].Text);
            txt_sanatci_adi.Text = lst_sanatcilar.SelectedItems[0].SubItems[1].Text;
            txt_sanatci_ulke.Text = lst_sanatcilar.SelectedItems[0].SubItems[2].Text;

        }

        private void listView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(lst_albumler.SelectedItems[0].SubItems[0].Text);
            txt_album_adi.Text = lst_albumler.SelectedItems[0].SubItems[1].Text;
            cmb_album_sanatci.Text = lst_albumler.SelectedItems[0].SubItems[2].Text;
            nmb_album_tarih.Text = lst_albumler.SelectedItems[0].SubItems[3].Text;
            cmb_album_tur.Text = lst_albumler.SelectedItems[0].SubItems[4].Text;
        }

        private void btn_album_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Album (AlbumAdi,SanatciID,AlbumTarih,MuzikTurID) values ('" + txt_album_adi.Text.ToString() + "','" + cmb_album_sanatci.SelectedValue.ToString() + "','" + nmb_album_tarih.Text.ToString() + "','" + cmb_album_tur.SelectedValue.ToString() + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();
                VeriGoruntule();
                txt_album_adi.Clear();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }

        private void btn_album_sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Album where AlbumID = (" + id + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();
                VeriGoruntule();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }

        private void btn_album_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(lst_albumler.SelectedItems[0].SubItems[0].Text);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Album set AlbumAdi = '" + txt_album_adi.Text.ToString() + "', AlbumTarih = '" + nmb_album_tarih.Text.ToString() + "',SanatciID = '" + cmb_album_sanatci.SelectedValue.ToString() + "',MuzikTurID = '" + cmb_album_tur.SelectedValue.ToString() + "' where AlbumID = " + id + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriKaldir();
                VeriGoruntule();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }


        }

        public void verileriKaldir()
        {
            lst_albumler.Items.Clear();
            lst_sanatcilar.Items.Clear();
            lst_sarkilar.Items.Clear();

        }


    }
}
