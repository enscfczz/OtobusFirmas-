using Npgsql;
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
    public partial class biletOlusturmaForm : Form
    {
        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port=5432; Database=OtobusFirması; user ID=postgres; password=enesenes1");

        public biletOlusturmaForm()
        {
            InitializeComponent();
        }
        private void biletOlusturmaForm_Load(object sender, EventArgs e)
        {
           
        }
        private void gerigitbiletBtn_Click(object sender, EventArgs e)
        {
            Form1 anarfm = new Form1();
            anarfm.Show();
            this.Hide();
        }
        private void canvasvisibleoff()
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void yolcueklebtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel1.Visible = true;
            string sorgu = "select * from public.\"Yolcu\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            grid1.DataSource = veri.Tables[0];

        }

        private void biletKayıtBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel2.Visible = true;

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand otokomut = new NpgsqlCommand("insert into public.\"Yolcu\" (\"YolcuAdı\",\"YolcuSoyadı\",\"YolcuNumarası\",\"YolcuEmail\") values (@p1,@p2,@p3,@4)", baglantı);
            otokomut.Parameters.AddWithValue("@p1", yolcutextBox1.Text);
            otokomut.Parameters.AddWithValue("@p2", yolcutextBox2.Text);
            otokomut.Parameters.AddWithValue("@p3", yolcutextBox3.Text);
            otokomut.Parameters.AddWithValue("@p4", yolcutextBox4.Text);
            otokomut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Yeni Bir Yolcu başarıyla Kaydedildi");
        }

        private void arabtn2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand command = new NpgsqlCommand("select \"YolcuAdı\" from public.\"Yolcu\" where \"YolcuID\"=" + yolcunotext.Text, baglantı);
            label5.Text = command.ExecuteScalar().ToString();

            NpgsqlCommand command2 = new NpgsqlCommand("select \"YolcuSoyadı\" from public.\"Yolcu\" where \"YolcuID\"=" + yolcunotext.Text, baglantı);
            label6.Text = command2.ExecuteScalar().ToString();
            
            NpgsqlCommand command3 = new NpgsqlCommand("select \"YolcuNumarası\" from public.\"Yolcu\" where \"YolcuID\"=" + yolcunotext.Text, baglantı);
             label7.Text = command3.ExecuteScalar().ToString();
            baglantı.Close();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand command = new NpgsqlCommand("select \"KalkısZamanı\" from public.\"Sefer\" where \"SeferID\"=" + sefernotext.Text, baglantı);
            label1.Text = command.ExecuteScalar().ToString();

            NpgsqlCommand command2 = new NpgsqlCommand("select \"KalkısSehriID\" from public.\"Sefer\" where \"SeferID\"=" + sefernotext.Text, baglantı);
            int otobus2 = Convert.ToInt32(command2.ExecuteScalar());
            NpgsqlCommand command3 = new NpgsqlCommand("select \"SehirAdı\" from public.\"Sehir\" where \"SehirID\"=" + otobus2.ToString(), baglantı);
            label2.Text = command3.ExecuteScalar().ToString();

            NpgsqlCommand command4 = new NpgsqlCommand("select \"FirmaID\" from public.\"Sefer\" where \"SeferID\"=" + sefernotext.Text, baglantı);
            int otobus3 = Convert.ToInt32(command4.ExecuteScalar());
            NpgsqlCommand command5 = new NpgsqlCommand("select \"FirmaAdı\" from public.\"Firma\" where \"FirmaID\"=" + otobus3.ToString(), baglantı);
            label15.Text = command5.ExecuteScalar().ToString();

            NpgsqlCommand command8 = new NpgsqlCommand("select \"VarısSehriID\" from public.\"Sefer\" where \"SeferID\"=" + sefernotext.Text, baglantı);
            int otobus5 = Convert.ToInt32(command8.ExecuteScalar());
            NpgsqlCommand command9 = new NpgsqlCommand("select \"SehirAdı\" from public.\"Sehir\" where \"SehirID\"=" + otobus5.ToString(), baglantı);
            label3.Text = command9.ExecuteScalar().ToString();

          
            baglantı.Close();
            

        }
     

        private void biletkaydetBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand otokomut = new NpgsqlCommand("insert into public.\"Bilet\" (\"KalkısZamanı\",\"KalkısSehriID\",\"VarısSehriID\",\"FirmaID\",\"KoltukNumarası\",\"Ucret\",\"SeferID\",\"YolcuID\") values (@p1,@p2,@p3,@4,@p8,@9,@10,@11)", baglantı);
            NpgsqlCommand getCity = new NpgsqlCommand("select \"SehirID\" from public.\"Sehir\" where \"SehirAdı\" = "+"'" + label2.Text + "'", baglantı);
            int sehirId = (int)getCity.ExecuteScalar();
            NpgsqlCommand getCity1 = new NpgsqlCommand("select \"SehirID\" from public.\"Sehir\" where \"SehirAdı\" = " + "'" + label3.Text + "'", baglantı);
            int sehirId1 = (int)getCity1.ExecuteScalar();
            NpgsqlCommand getCity2 = new NpgsqlCommand("select \"FirmaID\" from public.\"Firma\" where \"FirmaAdı\" = " + "'" + label15.Text + "'", baglantı);
            int sehirId2 = (int)getCity2.ExecuteScalar();

            otokomut.Parameters.AddWithValue("@p1", label1.Text);
            otokomut.Parameters.AddWithValue("@p2", sehirId);
            otokomut.Parameters.AddWithValue("@p3", sehirId1);
            otokomut.Parameters.AddWithValue("@p4", sehirId2);
         
            otokomut.Parameters.AddWithValue("@p8", int.Parse(textBox1.Text));
            otokomut.Parameters.AddWithValue("@p9", int.Parse(tutartextBox4.Text));
            otokomut.Parameters.AddWithValue("@p10", int.Parse(sefernotext.Text));
            otokomut.Parameters.AddWithValue("@p11", int.Parse(yolcunotext.Text));

            otokomut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Yeni Bir Bilet başarıyla oluşturuldu");
        }
    }
}
