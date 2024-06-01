using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmÖgrenciKitap : Form
    {
        public FrmÖgrenciKitap()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
        void DataTool()
        {
            SqlCommand kmt = new SqlCommand("select * from ÖgrenciKitapTablosu where ÖgrNumara=@p1", bgl.baglantı());
            kmt.Parameters.AddWithValue("@p1", txtSorgu.Text);
            SqlDataReader dataReader = kmt.ExecuteReader();
            while (dataReader.Read())
            {
                txtÖgradsoyad.Text = dataReader[0].ToString();
                txtokulno.Text = dataReader[1].ToString();
                textBox1.Text = dataReader[2].ToString();
                cmbboxKitaplar.Text= dataReader[3].ToString();
                maskVeriliştarihi.Text = dataReader[4].ToString();
                maskalınıştarih.Text = dataReader[5].ToString();
                bgl.baglantı().Close();
            }
        }
        void DataToolQueryName()
        {
            SqlCommand kmt = new SqlCommand("select * from ÖgrenciKitapTablosu where ÖgrAdSoyad=@p1", bgl.baglantı());
            kmt.Parameters.AddWithValue("@p1", txtSorgu.Text);
            SqlDataReader dataReader = kmt.ExecuteReader();
            while (dataReader.Read())
            {
                txtÖgradsoyad.Text = dataReader[0].ToString();
                txtokulno.Text = dataReader[1].ToString();
                textBox1.Text = dataReader[2].ToString();
                cmbboxKitaplar.Text = dataReader[3].ToString();
                maskVeriliştarihi.Text = dataReader[4].ToString();
                maskalınıştarih.Text = dataReader[5].ToString();
                bgl.baglantı().Close();
            }
        }
        void KayıtTablosu()
        {
            //Datagrid aracına ÖgrenciTablosunu aktarma
            SqlDataAdapter da = new SqlDataAdapter("Select * from ÖgrenciKitapTablosu", bgl.baglantı());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmÖgrenciKitap_Load(object sender, EventArgs e)
        {
            //ComboBoxa Sistemdeki Bulunan kitapları aktarma
            SqlCommand kmt = new SqlCommand("SELECT KitapAd FROM KitaplarTablosu ORDER BY KitapAd ASC", bgl.baglantı());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmbboxKitaplar.Items.Add(dr[0].ToString());
            }
            bgl.baglantı().Close();
            //Ögrenci Kitap Tablo methodu
            KayıtTablosu();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KayıtTablosu();
            listboxSorgu.Items.Clear();
            string StudentNo = txtSorgu.Text; 
            string query = $"SELECT * FROM ÖgrenciKitapTablosu WHERE ÖgrNumara = '{StudentNo}'"; // No'ya göre veri çekme sorgusu
            SqlCommand command = new SqlCommand(query, bgl.baglantı());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listboxSorgu.Items.Clear();
                    string alinisTarihi = reader["AlınışTarihi"].ToString();
                    if (string.IsNullOrEmpty(alinisTarihi)) // Alınış Tarihi boş ise
                    {
                        listboxSorgu.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxSorgu.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxSorgu.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxSorgu.Items.Add(reader["KitapAd"].ToString());
                        listboxSorgu.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxSorgu.Items.Add("Teslim Edilmedi");
                        listboxSorgu.Items.Add("------------");
                        DataTool();
                    }
                    else // Alınış Tarihi dolu ise
                    {
                        listboxSorgu.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxSorgu.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxSorgu.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxSorgu.Items.Add(reader["KitapAd"].ToString());
                        listboxSorgu.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxSorgu.Items.Add(reader["AlınışTarihi"].ToString());
                        listboxSorgu.Items.Add("------------");
                        DataTool();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void checkbxSorgu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxSorgu.Checked == true)
            {
                lblSorgutxt.Text = "Ad-Soyad:";
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                txtSorgu.MaxLength = 25;
                txtSorgu.Clear();
                listboxSorgu.Items.Clear();
                AracTemizle();
            }
            if (checkbxSorgu.Checked != true)
            {
                listboxSorgu.Items.Clear();
                lblSorgutxt.Text = "Okul Numarası:";
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                txtSorgu.MaxLength = 4;
                txtSorgu.Clear();
                AracTemizle();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KayıtTablosu();
            listboxSorgu.Items.Clear();
            string StudentName = txtSorgu.Text; 
            string query = $"SELECT * FROM ÖgrenciKitapTablosu WHERE ÖgrAdSoyad = '{StudentName}'"; // Ad Soyada göre veri çekme sorgusu
            SqlCommand command = new SqlCommand(query, bgl.baglantı());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listboxSorgu.Items.Clear();
                    string alinisTarihi = reader["AlınışTarihi"].ToString();
                    if (string.IsNullOrEmpty(alinisTarihi)) // Alınış Tarihi boş ise
                    {
                        listboxSorgu.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxSorgu.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxSorgu.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxSorgu.Items.Add(reader["KitapAd"].ToString());
                        listboxSorgu.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxSorgu.Items.Add("Teslim Edilmedi");
                        listboxSorgu.Items.Add("------------");
                        DataToolQueryName();
                    }
                    else // Alınış Tarihi dolu ise
                    {
                        listboxSorgu.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxSorgu.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxSorgu.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxSorgu.Items.Add(reader["KitapAd"].ToString());
                        listboxSorgu.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxSorgu.Items.Add(reader["AlınışTarihi"].ToString());
                        listboxSorgu.Items.Add("------------");
                        DataToolQueryName();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        //Kayıt İşlemleri
        private void KayitEkle(string numara)
        {
            //Kontrollerden Geçer İse tabloya başarılı şekilde ekleme işlemi
            string AdSoyad = txtÖgradsoyad.Text.Trim();
            string Sınıf = textBox1.Text.Trim();
            int OkulNo = Convert.ToInt32(txtokulno.Text.Trim());
            if (txtÖgradsoyad.Text!="" && txtokulno.Text!=""  && maskVeriliştarihi.Text!="")
            {
                SqlCommand kmt = new SqlCommand("insert into ÖgrenciKitapTablosu (ÖgrAdSoyad,ÖgrNumara,ÖgrSınıf,KitapAd,VerilişTarihi,AlınışTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", AdSoyad);
                kmt.Parameters.AddWithValue("@p2", OkulNo);
                kmt.Parameters.AddWithValue("@p3", Sınıf);
                kmt.Parameters.AddWithValue("@p4", cmbboxKitaplar.Text);
                kmt.Parameters.AddWithValue("@p5", maskVeriliştarihi.Text);
                kmt.Parameters.AddWithValue("@p6", maskalınıştarih.Text);
                kmt.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
        }
        private bool NumaraVarMi(string numara)
        {
            //girilen numara eger var ise Kayıt ekleme butonunda kontrole girer ve İF Else bloguyla İşlemler yapılır
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM ÖgrenciKitapTablosu WHERE ÖgrNumara = @Numara", bgl.baglantı());
            komut.Parameters.AddWithValue("@Numara", numara);
            int kayitSayisi = (int)komut.ExecuteScalar();
            bgl.baglantı().Close();
            return kayitSayisi > 0;
        }
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            //Kontrollerden Geçer İse tabloya başarılı şekilde ekleme işlemi
            string girilenNumara = txtokulno.Text;
            if (NumaraVarMi(girilenNumara))
            {
                MessageBox.Show("Girilen Numaraya Ait ögrenci Bulunuyor", "Farklı Numara Giriniz", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                KayitEkle(girilenNumara);
                MessageBox.Show("Kayıt Yapıldı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KayıtTablosu();
            }
        }
        void AracTemizle()
        {
            txtÖgradsoyad.Clear();
            txtokulno.Clear();
            textBox1.Clear();
            cmbboxKitaplar.Text = "";
            maskalınıştarih.Clear();
            maskVeriliştarihi.Clear();
            listboxSorgu.Items.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AracTemizle();
        }
        private void btnGüncel_Click(object sender, EventArgs e)
        {
            if (txtokulno.Text != "" && txtÖgradsoyad.Text != "")
            {
                SqlCommand komut = new SqlCommand("Update ÖgrenciKitapTablosu set KitapAd=@p1,VerilişTarihi=@p2,AlınışTarihi=@p3 where ÖgrAdSoyad=@p4", bgl.baglantı());
                komut.Parameters.AddWithValue("@p1", cmbboxKitaplar.Text);
                komut.Parameters.AddWithValue("@p2", maskVeriliştarihi.Text);
                komut.Parameters.AddWithValue("@p3", maskalınıştarih.Text);
                komut.Parameters.AddWithValue("@p4", txtÖgradsoyad.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Güncellendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglantı().Close();
                KayıtTablosu();
            }
        }
        private void Btnsilme_Click(object sender, EventArgs e)
        {
            if (txtÖgradsoyad.Text != "" && txtokulno.Text != "")
            {
                SqlCommand kmt = new SqlCommand("Delete from ÖgrenciKitapTablosu where ÖgrAdSoyad=@p1", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", txtÖgradsoyad.Text);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Ögrenciye Ait Bilgiler Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglantı().Close();
                KayıtTablosu();
                AracTemizle();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBoxKayıtlıKitaplar.Items.Clear();
            string BookName = TxtKitabAd.Text; 
            string query = $"SELECT * FROM ÖgrenciKitapTablosu WHERE KitapAd = '{BookName}'"; 
            SqlCommand command = new SqlCommand(query, bgl.baglantı());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                { 
                    string alinisTarihi = reader["AlınışTarihi"].ToString();
                    if (string.IsNullOrEmpty(alinisTarihi)) // Alınış Tarihi boş ise
                    {
                        listBoxKayıtlıKitaplar.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add(reader["ÖgrNumara"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add(reader["ÖgrSınıf"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add(reader["KitapAd"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add(reader["VerilişTarihi"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add("Teslim Edilmedi");
                        listBoxKayıtlıKitaplar.Items.Add("------------");
                    }
                    else // Alınış Tarihi dolu ise
                    {
                        listBoxKayıtlıKitaplar.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add(reader["ÖgrNumara"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add(reader["ÖgrSınıf"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add(reader["KitapAd"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add(reader["VerilişTarihi"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add(reader["AlınışTarihi"].ToString());
                        listBoxKayıtlıKitaplar.Items.Add("------------");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBoxKayıtlıKitaplar.Items.Clear();
            TxtKitabAd.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmÖgrenciSorgu frmÖgrenciSorgu = new FrmÖgrenciSorgu();
            frmÖgrenciSorgu.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listboxSorgu.Items.Clear();
            txtSorgu.Clear();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            new FrmÖgrenciKitap().Show();
            this.Close(); // Mevcut formu kapatıyoruz.
        }
    }
}
