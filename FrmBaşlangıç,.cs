using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Takip_Sistemi
{
    public partial class FrmBaşlangıç_ : Form
    {

        bool islem = false;

        public FrmBaşlangıç_()
        {
            InitializeComponent();

        }
        private void FrmBaşlangıç__Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!islem)
            {
                this.Opacity += 0.002;
            }
            if (this.Opacity == 1.0)
            {
                islem = true;
            }
            if (islem)
            {
                this.Opacity -= 0.012;
                if (this.Opacity == 0)
                {
                    FrmAnasaya fr = new FrmAnasaya();
                    fr.Show();
                    this.Hide();
                    timer1.Enabled = false;
                }
            }
        }
    }
}
