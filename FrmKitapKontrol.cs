using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmKitapKontrol : Form
    {

        public FrmKitapKontrol()
        {
            InitializeComponent();
            LoadRecordDetails();
        }
        Sql bgl = new Sql();

        private void FrmKitapKontrol_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Teslim Etmeyen Ögrenciler");
        }    
        private void LoadRecordDetails()
        {
            try
            {
                // 15 günü aşan kayıtların detaylarını alacak SQL sorgusu
                string query = "SELECT ÖgrenciKitapTablosu.ÖgrAdSoyad, ÖgrenciKitapTablosu.KitapAd, ÖgrenciKitapTablosu.VerilişTarihi " +
                               "FROM ÖgrenciKitapTablosu " +
                               "WHERE ÖgrenciKitapTablosu.AlınışTarihi='' AND DATEDIFF(day, ÖgrenciKitapTablosu.VerilişTarihi, GETDATE()) > 15";
                SqlCommand command = new SqlCommand(query, bgl.baglantı());
                SqlDataReader reader = command.ExecuteReader();

                listBox1.Items.Clear();  // ListBox'ı temizle

                while (reader.Read())
                {
                    string ogrenciAdi = reader.GetString(reader.GetOrdinal("ÖgrAdSoyad"));
                    string kitapAdi = reader.GetString(reader.GetOrdinal("KitapAd"));
                    DateTime verilisTarihi = reader.GetDateTime(reader.GetOrdinal("VerilişTarihi"));

                    listBox1.Items.Add($"Öğrenci Adı :{ogrenciAdi}");
                    listBox1.Items.Add($"Kitap Adı :{kitapAdi}");
                    listBox1.Items.Add($"Veriliş Tarihi :{verilisTarihi.ToShortDateString()}");
                    listBox1.Items.Add("---------");
                }
                reader.Close();
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
        private void LoadData()
        {
            string query = "SELECT VerilişTarihi FROM ÖgrenciKitapTablosu WHERE AlınışTarihi=''";
            SqlCommand command = new SqlCommand(query, bgl.baglantı());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        // Check if VerilisTarihi is not null
                        if (!reader.IsDBNull(reader.GetOrdinal("VerilişTarihi")))
                        {
                            DateTime verilisTarihi = reader.GetDateTime(reader.GetOrdinal("VerilişTarihi"));
                            int daysPassed = (DateTime.Now - verilisTarihi).Days;
                            listBox2.Items.Add($"Geçen Gün: {daysPassed}");
                            listBox2.Items.Add("--------");
                        }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Teslim Etmeyen Ögrenciler")
            {
                listBox1.Items.Clear();
                SqlCommand sorgu = new SqlCommand("select * from ÖgrenciKitapTablosu where AlınışTarihi = '' ", bgl.baglantı());
                SqlDataReader sqlData = sorgu.ExecuteReader();
                while (sqlData.Read())
                {
                    listBox1.Items.Add(sqlData[0].ToString());
                    listBox1.Items.Add(sqlData[1].ToString());
                    listBox1.Items.Add(sqlData[2].ToString());
                    listBox1.Items.Add(sqlData[3].ToString());
                    listBox1.Items.Add(sqlData[4].ToString());
                    listBox1.Items.Add("Teslim Edilmedi");
                    listBox1.Items.Add("-------------");
                }
                bgl.baglantı().Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
    