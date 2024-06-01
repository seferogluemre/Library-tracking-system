using System;
using System.Windows.Forms;
namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmAnasaya : Form
    {
        public FrmAnasaya()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAdminGiriş frmAdminGiriş = new FrmAdminGiriş();
            frmAdminGiriş.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmKullanıcıGiriş frmKullanıcıGiriş = new FrmKullanıcıGiriş();
            frmKullanıcıGiriş.Show();
            this.Hide();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Quit().dialog();
        }
        private void FrmAnasaya_Load(object sender, EventArgs e)
        {
        }
    }
}
