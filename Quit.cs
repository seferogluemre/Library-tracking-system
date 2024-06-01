using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Takip_Sistemi
{
    class Quit
    {
        public DialogResult dialog()
        {
            DialogResult tepki = new DialogResult();
            tepki = MessageBox.Show("Uygulamadan Ayrılıyorsunuz", "Emin Misiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tepki==DialogResult.Yes)
            {
                Application.Exit();
            }
            return tepki;
        }
    }
}
