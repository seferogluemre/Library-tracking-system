using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmAdminpanel : Form
    {
        public FrmAdminpanel()
        {
            InitializeComponent();
            LoadData();
        }
        Sql bgl = new Sql();
        Quit tepki = new Quit();
        public string AdminTc;
        public string AdminAdSoyad;

        private void LoadData()
        {
            try
            {
                // Veriliş tarihi 15 günü aşan kayıtların sayısını alacak SQL sorgusu
                string countQuery = "SELECT COUNT(*) AS KayıtSayısı " +
                                    "FROM ÖgrenciKitapTablosu " +
                                    "WHERE AlınışTarihi='' AND DATEDIFF(day, VerilişTarihi, GETDATE()) > 15";
                SqlCommand countCommand = new SqlCommand(countQuery, bgl.baglantı());
                int kayıtSayısı = (int)countCommand.ExecuteScalar();  // Tek bir değer döndürdüğümüz için ExecuteScalar kullanıyoruz

                // LinkLabel üzerinde kayıt sayısını göster
                linkLabel3.Text = $"Veriliş tarihi 15 günü aşan {kayıtSayısı} kayıt bulunmaktadır.";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void LoadData2()
        {
            //Tıklama oldugunda labele Kontolde aşan ögrenci datalarını forma aktarma
            //     listBox1.Items.Add($"Kitap Adı: {kitapAdi}, Veriliş Tarihi: {verilisTarihi.ToShortDateString()}, Geçen Gün: {daysPassed}");

            try
            {
                // Veriliş tarihi 15 günü aşan kayıtların sayısını alacak SQL sorgusu
                string countQuery = "SELECT COUNT(*) AS KayıtSayısı " +
                                    "FROM ÖgrenciKitapTablosu " +
                                    "WHERE AlınışTarihi=''  AND DATEDIFF(day, VerilişTarihi, GETDATE()) > 15";
                SqlCommand countCommand = new SqlCommand(countQuery, bgl.baglantı());
                int kayıtSayısı = (int)countCommand.ExecuteScalar();  // Tek bir değer döndürdüğümüz için ExecuteScalar kullanıyoruz

                // 15 günü aşan kayıtları listeleyecek SQL sorgusu
                string selectQuery = "SELECT ÖgrAdSoyad,VerilişTarihi,KitapAd " +
                                     "FROM ÖgrenciKitapTablosu " +
                                     "WHERE AlınışTarihi='' AND DATEDIFF(day, VerilişTarihi, GETDATE()) > 15";
                SqlCommand selectCommand = new SqlCommand(selectQuery, bgl.baglantı());
                SqlDataReader reader = selectCommand.ExecuteReader();

                // Kayıtları ListBox'a ekleyin
                while (reader.Read())
                {
                    try
                    {
                        string kitapAdi = reader.GetString(reader.GetOrdinal("KitapAd"));
                        DateTime verilisTarihi = reader.GetDateTime(reader.GetOrdinal("VerilişTarihi"));
                        int daysPassed = (DateTime.Now - verilisTarihi).Days;
                    }
                    catch (InvalidCastException ex)
                    {
                        MessageBox.Show("Veri türü hatası: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
                reader.Close();

                // Kayıt sayısını ListBox'a ekleyin
                linkLabel3.Text = $"Toplam 15 günü aşan kayıt sayısı: {kayıtSayısı}";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
   
        private void FrmAdminpanel_Load(object sender, EventArgs e)
        {
            LoadData2();
            lblAdminTc.Text = AdminTc;
            SqlCommand kmt = new SqlCommand("select * from AdminTablo where AdminTc='" + lblAdminTc.Text + "'", bgl.baglantı());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                lblAdminAdsoyad.Text = dr["AdminAdSoyad"].ToString();
            }
            bgl.baglantı().Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmÖgrenciKitap frmÖgrenciKitap = new FrmÖgrenciKitap();
            frmÖgrenciKitap.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmKitapEkleme frmKitapEkleme = new FrmKitapEkleme();
            frmKitapEkleme.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tepki.dialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdminguncelleme frmAdminguncelleme = new FrmAdminguncelleme();
            frmAdminguncelleme.Show();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdminKayıt frmAdminKayıt = new FrmAdminKayıt();
            frmAdminKayıt.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmÖgrenciSorgu frmÖgrenciSorgu = new FrmÖgrenciSorgu();
            frmÖgrenciSorgu.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmAyrıntılıSorgular ayrıntılıSorgular = new FrmAyrıntılıSorgular();
            ayrıntılıSorgular.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmKitapKontrol control = new FrmKitapKontrol();
            control.listBox1.Items.Clear();
            control.Show();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmKitapKontrol().Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            new  FrmAdminpanel().Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Start();
        }
    }
}
