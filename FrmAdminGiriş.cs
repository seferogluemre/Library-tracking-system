using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmAdminGiriş : Form
    {
        public FrmAdminGiriş()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
        Quit tepki = new Quit();
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminpanel frmAdminpanel = new FrmAdminpanel();
            if (txtTckmlik.Text=="")
            {
                new ErrorProvider().SetError(txtTckmlik, "Tc Alanı 11 karakter olmalı Ve boş geçilemez");
            }
            if (txtParola.Text=="")
            {
                new ErrorProvider().SetError(txtParola, "Parola Boş geçilemez");
            }
            if (txtParola.Text!="" && txtTckmlik.Text!="")
            {
                SqlCommand kmt = new SqlCommand("Select * from AdminTablo where AdminTc=@p1 and AdminParola=@p2", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", txtTckmlik.Text);
                kmt.Parameters.AddWithValue("@p2", txtParola.Text);
                SqlDataReader dr = kmt.ExecuteReader();
                if (dr.Read())
                {
                    frmAdminpanel.AdminTc = txtTckmlik.Text;
                    MessageBox.Show("Hoşgeldiniz : " + dr["AdminAdSoyad"].ToString(), "Girişiniz Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAdminpanel.Show();
                    this.Hide();
                }
                bgl.baglantı().Close();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAnasaya anasaya = new FrmAnasaya();
            anasaya.Show();
            this.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tepki.dialog();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtParola.PasswordChar = '*';
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtParola.PasswordChar = '\0';
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
        }
        private void FrmAdminGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
