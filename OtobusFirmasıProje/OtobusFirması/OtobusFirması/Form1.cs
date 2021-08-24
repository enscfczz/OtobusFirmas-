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
    public partial class Form1 : Form
    {
        
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void biletOlusturBtn_Click(object sender, EventArgs e)
        {
            biletOlusturmaForm bltfrm = new biletOlusturmaForm();
            bltfrm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void masrafKayıtBtn_Click(object sender, EventArgs e)
        {
            masrafForm msrffrm = new masrafForm();
            msrffrm.Show();
            this.Hide();
        }

        private void personelIslemBtn_Click(object sender, EventArgs e)
        {
            personelKayıtForm prsnlfrm = new personelKayıtForm();
            prsnlfrm.Show();
            this.Hide();
        }

        private void bilgiBtn_Click(object sender, EventArgs e)
        {
            bilgilerFormcs blgfrm = new bilgilerFormcs();
            blgfrm.Show();
            this.Hide();
        }

        private void eklentiBtn_Click(object sender, EventArgs e)
        {
            eklentiForm ekfrm = new eklentiForm();
            ekfrm.Show();
            this.Hide();
        }

        private void seferOlusturBtn_Click_1(object sender, EventArgs e)
        {
            seferForm sfrfrm = new seferForm();
            sfrfrm.Show();
            this.Hide();
        }
    }
}
