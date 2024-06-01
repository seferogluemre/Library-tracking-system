using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmÖgrenciSorgu : Form
    {
        public FrmÖgrenciSorgu()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
        private void checkAdsorgu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAdsorgu.Checked == true)
            {
                txtÖgr.MaxLength = 30;
                txtÖgr.Clear();
                labelSorgu.Text = "Ad-Soyad:";
                btnFetchData.Visible = false;
                button1.Visible = true;
                listboxKayıtlar.Items.Clear();
                checkSnfSorgu.Checked = false;
            }
            else
            {
                button1.Visible = false;
                btnFetchData.Visible = true;
                txtÖgr.MaxLength = 5;
                labelSorgu.Text = "Ögrenci No:";
                txtÖgr.Clear();
                listboxKayıtlar.Items.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string StudentName = txtÖgr.Text; // Kullanıcı tarafından girilen No
            string query = $"SELECT * FROM ÖgrenciKitapTablosu WHERE ÖgrAdSoyad = '{StudentName}'"; // No'ya göre veri çekme sorgusu
            SqlCommand command = new SqlCommand(query, bgl.baglantı());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listboxKayıtlar.Items.Clear();
                    string alinisTarihi = reader["AlınışTarihi"].ToString();
                    if (string.IsNullOrEmpty(alinisTarihi)) // Alınış Tarihi boş ise
                    {
                        listboxKayıtlar.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxKayıtlar.Items.Add(reader["KitapAd"].ToString());
                        listboxKayıtlar.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxKayıtlar.Items.Add("Teslim Edilmedi");
                        listboxKayıtlar.Items.Add("------------");
                    }
                    else // Alınış Tarihi dolu ise
                    {
                        listboxKayıtlar.Items.Clear();
                        listboxKayıtlar.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxKayıtlar.Items.Add(reader["KitapAd"].ToString());
                        listboxKayıtlar.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxKayıtlar.Items.Add(reader["AlınışTarihi"].ToString());
                        listboxKayıtlar.Items.Add("------------");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void checkSnfSorgu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSnfSorgu.Checked == true)
            {
                txtÖgr.Clear();
                txtÖgr.MaxLength = 5;
                labelSorgu.Text = "Sınıf :";
                btnFetchData.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                listboxKayıtlar.Items.Clear();
                checkAdsorgu.Checked = false;
            }
            else
            {
                txtÖgr.MaxLength = 5;
                labelSorgu.Text = "Ögrenci No:";
                btnFetchData.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                txtÖgr.Clear();
                listboxKayıtlar.Items.Clear();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listboxKayıtlar.Items.Clear();
            string SınıfNo = txtÖgr.Text; // Kullanıcı tarafından girilen No
            string query = $"SELECT * FROM ÖgrenciKitapTablosu WHERE ÖgrSınıf = '{SınıfNo}'"; // No'ya göre veri çekme sorgusu
            SqlCommand command = new SqlCommand(query, bgl.baglantı());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {    
                    string alinisTarihi = reader["AlınışTarihi"].ToString();
                    if (string.IsNullOrEmpty(alinisTarihi)) // Alınış Tarihi boş ise
                    {
                        listboxKayıtlar.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxKayıtlar.Items.Add(reader["KitapAd"].ToString());
                        listboxKayıtlar.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxKayıtlar.Items.Add("Teslim Edilmedi");
                        listboxKayıtlar.Items.Add("------------");
                    }
                    else // Alınış Tarihi dolu ise
                    {
                        listboxKayıtlar.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxKayıtlar.Items.Add(reader["KitapAd"].ToString());
                        listboxKayıtlar.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxKayıtlar.Items.Add(reader["AlınışTarihi"].ToString());
                        listboxKayıtlar.Items.Add("------------");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            listboxKayıtlar.Items.Clear();
        }
        private void FrmÖgrenciSorgu_Load(object sender, EventArgs e)
        {

        }
        private void btnFetchData_Click_1(object sender, EventArgs e)
        {
            string no = txtÖgr.Text; // Kullanıcı tarafından girilen No
            string query = $"SELECT * FROM ÖgrenciKitapTablosu WHERE ÖgrNumara = '{no}'"; // No'ya göre veri çekme sorgusu

            SqlCommand command = new SqlCommand(query, bgl.baglantı());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listboxKayıtlar.Items.Clear();
                    string alinisTarihi = reader["AlınışTarihi"].ToString();

                    if (string.IsNullOrEmpty(alinisTarihi)) // Alınış Tarihi boş ise
                    {
                        listboxKayıtlar.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxKayıtlar.Items.Add(reader["KitapAd"].ToString());
                        listboxKayıtlar.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxKayıtlar.Items.Add("Teslim Edilmedi");
                        listboxKayıtlar.Items.Add("------------");
                    }
                    else // Alınış Tarihi dolu ise
                    {
                        listboxKayıtlar.Items.Clear();
                        listboxKayıtlar.Items.Add(reader["ÖgrAdSoyad"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrNumara"].ToString());
                        listboxKayıtlar.Items.Add(reader["ÖgrSınıf"].ToString());
                        listboxKayıtlar.Items.Add(reader["KitapAd"].ToString());
                        listboxKayıtlar.Items.Add(reader["VerilişTarihi"].ToString());
                        listboxKayıtlar.Items.Add(reader["AlınışTarihi"].ToString());
                        listboxKayıtlar.Items.Add("------------");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
