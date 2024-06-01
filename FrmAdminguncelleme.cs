using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmAdminguncelleme : Form
    {
        public FrmAdminguncelleme()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
        void temizle()
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }
        private void btnKayıt_Click(object sender, EventArgs e)
        {

            //Yönetici Bilgi güncelleme
            if (txtAdsoyad.Text != "" && txtTc.Text != "")
            {
                SqlCommand kmt1 = new SqlCommand("Update AdminTablo set AdminParola=@p3,AdminAdSoyad=@p2 where  AdminTc=@p1", bgl.baglantı());
                kmt1.Parameters.AddWithValue("@p1", txtTc.Text);
                kmt1.Parameters.AddWithValue("@p2", txtAdsoyad.Text);
                kmt1.Parameters.AddWithValue("@p3", txtParola.Text);
                kmt1.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Yönetici güncellendi", "YES Kütüphane Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncellemek İstediginiz veriyi Bulunuz", "Kütüphane Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void FrmAdminguncelleme_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCommand kmt = new SqlCommand("select * from AdminTablo where AdminTc=@p1", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", textBox1.Text);
                SqlDataReader dr = kmt.ExecuteReader();
                while (dr.Read())
                { 
                    MessageBox.Show("Sorgu Bulundu", "İşlem başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTc.Text = dr[0].ToString();
                    txtAdsoyad.Text = dr[1].ToString();
                    txtParola.Text = dr[2].ToString();
                    listBox1.Items.Add("----------");
                    listBox1.Items.Add(dr["AdminTc"].ToString());
                    listBox1.Items.Add(dr["AdminAdSoyad"].ToString());
                    listBox1.Items.Add(dr["AdminParola"].ToString());
                    listBox1.Items.Add("----------");
                }
                bgl.baglantı().Close();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void checkbxSorgu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxSorgu.Checked == true)
            {
                temizle();
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                label5.Text = "Ad-Soyad:";
                textBox1.MaxLength = 50;
            }
            if (checkbxSorgu.Checked != true)
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                label5.Text = "Tc No:";
                textBox1.MaxLength = 11;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCommand kmt = new SqlCommand("select * from AdminTablo where AdminAdSoyad=@p1", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", textBox1.Text);
                SqlDataReader dr = kmt.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show("Sorgu Bulundu", "İşlem başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTc.Text = dr[0].ToString();
                    txtAdsoyad.Text = dr[1].ToString();
                    txtParola.Text = dr[2].ToString();
                    listBox1.Items.Add("----------");
                    listBox1.Items.Add(dr["AdminTc"].ToString());
                    listBox1.Items.Add(dr["AdminAdSoyad"].ToString());
                    listBox1.Items.Add(dr["AdminParola"].ToString());
                    listBox1.Items.Add("----------");
                }
                bgl.baglantı().Close();
            }
        }
        private void btnKayıtsil_Click(object sender, EventArgs e)
        {
            if (txtTc.Text != "")
            {
                SqlCommand kmt = new SqlCommand("Delete from AdminTablo where AdminTc=@p1", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", txtTc.Text);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Seçilen Yönetici Listeden Silindi", "Kitap Kaydı Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglantı().Close();
            }
            else
            {
                MessageBox.Show("Silincek Yönetici Seçilmedi", "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTc.Clear();
            txtParola.Clear();
            txtAdsoyad.Clear();
        }
    }
}
