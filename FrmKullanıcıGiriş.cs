using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmKullanıcıGiriş : Form
    {
        public FrmKullanıcıGiriş()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
        Quit tepki = new Quit();
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıad.Text == "")
            {
                new ErrorProvider().SetError(txtKullanıcıad, "Tc Alanı 11 karakter olmalı Ve boş geçilemez");
            }
            if (txtPaorla.Text == "")
            {
                new ErrorProvider().SetError(txtPaorla, "Parola Boş geçilemez");
            }
            if (txtKullanıcıad.Text!="" && txtPaorla.Text!="")
            {
                SqlCommand kmt = new SqlCommand("select * from KullanıcıTablo where KullanıcıAd=@p1 and KullanıcıParola=@p2", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", txtKullanıcıad.Text);
                kmt.Parameters.AddWithValue("@p2", txtPaorla.Text);
                SqlDataReader dr = kmt.ExecuteReader();
                if (dr.Read())
                {
                    FrmÖgrenciKitap frmÖgrenci = new FrmÖgrenciKitap();
                    frmÖgrenci.Show();
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
            txtPaorla.PasswordChar = '*';
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtPaorla.PasswordChar = '\0';
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKullanıcıKayıt frmKullanıcıKayıt = new FrmKullanıcıKayıt();
            frmKullanıcıKayıt.Show();
        }
    }
}
