using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusFirması
{
    public partial class otogarekleBtn : Form
    {

        public otogarekleBtn()
        {
            InitializeComponent();
        }
        private void panelsvisibleoff()
        {
            sehireklepanel.Visible = false;
            otogareklepanel1.Visible = false;
        
        }
        private void sehireklentiBtn_Click(object sender, EventArgs e)
        {
            panelsvisibleoff();
            sehireklepanel.Visible = true;
        }

        private void otogareklentiBtn_Click(object sender, EventArgs e)
        {
            panelsvisibleoff();
            otogareklepanel1.Visible = true;

            
        }
    }
}
