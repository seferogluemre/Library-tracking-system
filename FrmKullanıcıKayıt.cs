using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmKullanıcıKayıt : Form
    {
        public FrmKullanıcıKayıt()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdsoyad.Text == "")
            {
                errorProvider1.SetError(txtAdsoyad, "Alan boş geçilmez");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtAdsoyad.Text != "" && txtKulanıcıAd.Text != "" && txtParola.Text != "")
            {
                SqlCommand kmt = new SqlCommand("insert into KullanıcıTablo (KullanıcıAd,KullanıcıAdSoyad,KullanıcıParola) values(@p1,@p2,@p3)", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", txtKulanıcıAd.Text);
                kmt.Parameters.AddWithValue("@p2", txtAdsoyad.Text);
                kmt.Parameters.AddWithValue("@p3", txtParola.Text);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Yapıldı" + txtAdsoyad.Text, "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglantı().Close();
            }
        }
        private void FrmKullanıcıKayıt_Load(object sender, EventArgs e)
        {
        }
    }
}
