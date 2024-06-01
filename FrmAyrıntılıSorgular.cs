using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmAyrıntılıSorgular : Form
    {
        public FrmAyrıntılıSorgular()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
        private void FrmAyrıntılıSorgular_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Teslim Eden Ögrenciler");
            comboBox1.Items.Add("Teslim Etmeyen Ögrenciler");
        }
        private void BtnSorgu_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                //Teslim Eden Ögrencileri Listeleme 
                if (comboBox1.Text == "Teslim Eden Ögrenciler")
                {
                    listBox1.Items.Clear();
                    SqlCommand komut = new SqlCommand("SELECT * FROM ÖgrenciKitapTablosu WHERE AlınışTarihi IS NOT NULL AND AlınışTarihi <> '';", bgl.baglantı());
                    SqlDataReader dataReader = komut.ExecuteReader();
                    while (dataReader.Read())
                    {
                        listBox1.Items.Add(dataReader[0].ToString());
                        listBox1.Items.Add(dataReader[1].ToString());
                        listBox1.Items.Add(dataReader[2].ToString());
                        listBox1.Items.Add(dataReader[3].ToString());
                        listBox1.Items.Add(dataReader[4].ToString());
                        listBox1.Items.Add(dataReader[5].ToString());
                        listBox1.Items.Add("-----------");
                    }
                    bgl.baglantı().Close();
                }
                //Teslim Etmeyenleri Listeleme
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
            else
            {
                MessageBox.Show("Seçim Yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                comboBox1.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ÖgrenciKitapTablosu WHERE ÖgrAdSoyad LIKE @prefix + '%'";
            // TextBox'a girilen değeri al
            string prefix = textBox1.Text.Trim();
            if (prefix.Length != 1 || !char.IsLetter(prefix[0]))
            {
                MessageBox.Show("Lütfen tek bir harf girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox1.Text != "" && textBox1.MaxLength == 1)
            {
                listBox2.Items.Clear();
                SqlCommand command = new SqlCommand(query, bgl.baglantı());
                command.Parameters.AddWithValue("@prefix", prefix);
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    listBox2.Items.Add(data["ÖgrAdSoyad"].ToString());
                    listBox2.Items.Add("-------------");
                }
                bgl.baglantı().Close();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            textBox1.Clear();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int MinValue = int.Parse(TxtSayı1.Text.Trim());
            int MaxValue = int.Parse(TxtSayı2.Text.Trim());

            if (TxtSayı1.Text != "" && TxtSayı2.Text != "")
            {
                listBox3.Items.Clear();
                SqlCommand sqlCommand = new SqlCommand("Select ÖgrAdSoyad,ÖgrNumara from ÖgrenciKitapTablosu where ÖgrNumara between @MinValue And @MaxValue", bgl.baglantı());
                sqlCommand.Parameters.AddWithValue("@MinValue", MinValue);
                sqlCommand.Parameters.AddWithValue("@MaxValue", MaxValue);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listBox3.Items.Add(dataReader[0].ToString());
                    listBox3.Items.Add(dataReader[1].ToString());
                    listBox3.Items.Add("-------------");
                }
                bgl.baglantı().Close();
            }
            else
            {
                MessageBox.Show("Alanları Uygun Şekilde Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Excel Word Oluşturup 1.satır indexine Sırayla Listbox aktarma 
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            int row = 1;
            foreach (var item in listBox1.Items)
            {
                Excel.Range cell = excelApp.Cells[row, 1];
                cell.Value = item.ToString();
                cell.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                row++;
            }
            excelApp.Visible = true;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
