using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmKitapEkleme : Form
    {
        public FrmKitapEkleme()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
       

        void KitapListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from KitaplarTablosu", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void AracTemizle()
        {
            txtAd.Clear();
            txtId.Clear();
            txtYazar.Clear();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[seçen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[seçen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[seçen].Cells[2].Value.ToString();
        }
        private void FrmKitapEkleme_Load(object sender, EventArgs e)
        {
            KitapListesi();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sorgu = new SqlCommand("Select COUNT(*) From KitaplarTablosu WHERE KitapId = @ID", bgl.baglantı());
            sorgu.Parameters.AddWithValue("@ID", txtId.Text);
            int count = (int)sorgu.ExecuteScalar();
            if (count == 0)
            {
                if (txtId.Text != "" && txtYazar.Text != "" && txtAd.Text != "")
                {
                    SqlCommand kmt = new SqlCommand("insert into KitaplarTablosu (KitapId,KitapAd,KitapYazar) values (@p1,@p2,@p3)", bgl.baglantı());
                    kmt.Parameters.AddWithValue("@p1", txtId.Text);
                    kmt.Parameters.AddWithValue("@p2", txtAd.Text);
                    kmt.Parameters.AddWithValue("@p3", txtYazar.Text);
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Listeye Kitap Eklendi", "İşlem başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bgl.baglantı().Close();
                    KitapListesi();
                }
            }
            else
            {
                MessageBox.Show("Girilen Id'ye Ait Kitap Bulunuyor Farklı Id girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                SqlCommand kmt = new SqlCommand("Delete from KitaplarTablosu where KitapId=@p1", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", txtId.Text);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Seçilen Kitap Listeden Silindi", "Kitap Kaydı Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglantı().Close();
                KitapListesi();
                AracTemizle();
            }
            else
            {
                MessageBox.Show("Silincek Kitap Seçilmedi", "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                SqlCommand kmt1 = new SqlCommand("Update KitaplarTablosu set KitapYazar=@p3,KitapAd=@p2 where  KitapId=@p1", bgl.baglantı());
                kmt1.Parameters.AddWithValue("@p1", txtId.Text);
                kmt1.Parameters.AddWithValue("@p2", txtAd.Text);
                kmt1.Parameters.AddWithValue("@p3", txtYazar.Text);
                kmt1.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Kitap güncellendi", "YES Kütüphane Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KitapListesi();
            }
            else
            {
                MessageBox.Show("Güncellemek İstediginiz Veriyi Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (txtId2.Text != "")
            {
                listBoxKitaplar.Items.Clear();
                SqlCommand kmt = new SqlCommand("Select * from KitaplarTablosu where KitapId=@p1", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", txtId2.Text);
                SqlDataReader dr = kmt.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBoxKitaplar.Items.Add(dr["KitapAd"].ToString());
                        listBoxKitaplar.Items.Add("---------");
                    }
                }
                else
                {
                    MessageBox.Show("Veri Bulunamadı ):", "Kayıt Bulunmuyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bgl.baglantı().Close();
            }
            else
            {
                MessageBox.Show("Sorgulancak Kitabın Id'Sini Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void checktemizle_CheckedChanged(object sender, EventArgs e)
        {

            if (checktemizle.Checked == true)
            {
                MessageBox.Show("Alan Temizleniyor.....");
                listBoxKitaplar.Items.Clear();
            }
            if (checktemizle.Checked != true)
            {
                listBoxKitaplar.Items.Clear();
                SqlCommand kmt = new SqlCommand("Select * from KitaplarTablosu where KitapId=@p1", bgl.baglantı());
                kmt.Parameters.AddWithValue("@p1", txtId2.Text);
                SqlDataReader dr = kmt.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBoxKitaplar.Items.Add(dr["KitapAd"].ToString());
                        listBoxKitaplar.Items.Add("---------");
                    }
                }
                bgl.baglantı().Close();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                label4.Text = "Yazar";
                txtId2.MaxLength = 30;
                if (txtId2.Text != "")
                {
                    txtId2.Clear();
                    listBoxKitaplar.Items.Clear();
                    SqlCommand kmt = new SqlCommand("Select * from KitaplarTablosu where KitapYazar=@p1", bgl.baglantı());
                    kmt.Parameters.AddWithValue("@p1", txtId2.Text);
                    SqlDataReader dr = kmt.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            listBoxKitaplar.Items.Add(dr["KitapAd"].ToString());
                            listBoxKitaplar.Items.Add("---------");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veri Bulunamadı ):", "Kayıt Bulunmuyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    bgl.baglantı().Close();
                }
            }
            if (checkBox1.Checked != true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                label4.Text = "Kitap-Id";
                txtId2.MaxLength = 4;
                if (txtId2.Text != "")
                {
                    listBoxKitaplar.Items.Clear();
                    SqlCommand kmt = new SqlCommand("Select * from KitaplarTablosu where KitapId=@p1", bgl.baglantı());
                    kmt.Parameters.AddWithValue("@p1", txtId2.Text);
                    SqlDataReader dr = kmt.ExecuteReader();
                    txtId2.Clear();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            listBoxKitaplar.Items.Add(dr["KitapAd"].ToString());
                            listBoxKitaplar.Items.Add("---------");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veri Bulunamadı ):", "Kayıt Bulunmuyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    bgl.baglantı().Close();
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                txtId2.MaxLength = 30;
                if (txtId2.Text != "")
                {
                    listBoxKitaplar.Items.Clear();
                    SqlCommand kmt = new SqlCommand("Select * from KitaplarTablosu where KitapYazar=@p1", bgl.baglantı());
                    kmt.Parameters.AddWithValue("@p1", txtId2.Text);
                    SqlDataReader dr = kmt.ExecuteReader();
                    while (dr.Read())
                    {
                        listBoxKitaplar.Items.Add(dr["KitapAd"].ToString());
                        listBoxKitaplar.Items.Add("---------");
                    }
                    bgl.baglantı().Close();
                }
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label4.Text = "Kitap-Ad";
                txtId2.MaxLength = 40;
                listBoxKitaplar.Items.Clear();
            }
            if (checkBox2.Checked != true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Text = "Kitap-Id";
                txtId2.MaxLength = 4;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (txtId2.Text != "")
                {
                    listBoxKitaplar.Items.Clear();
                    SqlCommand komut = new SqlCommand("Select * from KitaplarTablosu where KitapAd=@p1", bgl.baglantı());
                    komut.Parameters.AddWithValue("@p1", txtId2.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        listBoxKitaplar.Items.Add(dr["KitapId"].ToString());
                        listBoxKitaplar.Items.Add("---------");
                    }
                    bgl.baglantı().Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtYazar.Clear();
            txtId.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==false && checkBox2.Checked==false && label4.Text=="Kitap Id:")
            {
                string IdData = Convert.ToString(txtId2.Text.Trim());
                string query = $"Select * from KitaplarTablosu where KitapId='{IdData}'";
                try
                {
                    SqlCommand Query = new SqlCommand(query, bgl.baglantı());
                    SqlDataReader dataReader = Query.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string Data = dataReader[0].ToString();
                        if (string.IsNullOrEmpty(Data))
                        {
                            MessageBox.Show("Girilen ıd göre kayıt yok", "Veri bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        }
                        else
                        {
                            txtId.Text = dataReader[0].ToString();
                            txtAd.Text = dataReader[1].ToString();
                            txtYazar.Text = dataReader[2].ToString();
                        }
                    }
                    bgl.baglantı().Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

            //Kitaba Göre Data çekme

            if (txtId2.MaxLength==40 && checkBox2.Checked==true)
            {
                string NameData = txtId2.Text.Trim();
                string queryTwo = $"select * from KitaplarTablosu where KitapAd='{NameData}'";
                SqlCommand SelectQuery = new SqlCommand(queryTwo, bgl.baglantı());
                SqlDataReader sqlDataReader = SelectQuery.ExecuteReader();
                if (txtId2.Text!="")
                {
                    while (sqlDataReader.Read())
                    {
                        string DataIndex = sqlDataReader[1].ToString();
                        if (string.IsNullOrEmpty(DataIndex))
                        {
                            MessageBox.Show("Girilen Ada göre kayıt yok", "Veri bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Question); ;
                        }
                        else
                        {
                            txtId.Text = sqlDataReader[0].ToString();
                            txtAd.Text = sqlDataReader[1].ToString();
                            txtYazar.Text = sqlDataReader[2].ToString();
                        }
                    }
                    bgl.baglantı().Close();
                }
            }
        }
    }
}
