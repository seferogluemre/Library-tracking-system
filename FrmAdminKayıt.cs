using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmAdminKayıt : Form
    {
        public FrmAdminKayıt()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
        private void FrmAdminKayıt_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtTc.Text == "")
            {
                label1.ForeColor = Color.Red;
                MessageBox.Show("Boş Alan Bırakmayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTc.Text != "" && txtAdsoyad.Text != "" && txtParola.Text != "")
            {
                SqlCommand kmt = new SqlCommand("insert into AdminTablo (AdminTc,AdminAdSoyad,AdminParola) values (@p1,@p2,@p3)", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", txtTc.Text);
                kmt.Parameters.AddWithValue("@p2", txtAdsoyad.Text);
                kmt.Parameters.AddWithValue("@p3", txtParola.Text);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Yapıldı : " + txtAdsoyad.Text, "İşlem Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglantı().Close();
            }
        }
    }
}
