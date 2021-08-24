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
    public partial class eklentiForm : Form
    {
        public eklentiForm()
        {
            InitializeComponent();
        }
        private void eklentiForm_Load(object sender, EventArgs e)
        {
            DatabaseConnect.ConnectDatabase();
            DatabaseConnect.Connection.Open();

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter("select * from public.\"Otogar\"", DatabaseConnect.Connection);
            DataTable datatable1 = new DataTable();
            dataAdapter1.Fill(datatable1);
            firmaotogareklecomboBox1.DisplayMember = "OtogarAdı";
            firmaotogareklecomboBox1.ValueMember = "OtogarID";
            firmaotogareklecomboBox1.DataSource = datatable1;

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select * from public.\"Sehir\"", DatabaseConnect.Connection);
            DataTable datatable = new DataTable();
            dataAdapter.Fill(datatable);
            otogarsehireklecomboBox1.DisplayMember ="SehirAdı";
            otogarsehireklecomboBox1.ValueMember = "SehirID";
            otogarsehireklecomboBox1.DataSource = datatable;

            NpgsqlDataAdapter dataAdapter2 = new NpgsqlDataAdapter("select * from public.\"Firma\"", DatabaseConnect.Connection);
            DataTable datatable2 = new DataTable();
            dataAdapter2.Fill(datatable2);
            otobusfirmaacomboBox2.DisplayMember ="FirmaAdı";
            otobusfirmaacomboBox2.ValueMember = "FirmaID";
            otobusfirmaacomboBox2.DataSource = datatable2;

            NpgsqlDataAdapter dataAdapter3 = new NpgsqlDataAdapter("select * from public.\"IslemTipi\"", DatabaseConnect.Connection);
            DataTable datatable3 = new DataTable();
            dataAdapter3.Fill(datatable3);
            comboBox2.DisplayMember = "IslemTipiAdı";
            comboBox2.ValueMember = "IslemTipiID";
            comboBox2.DataSource = datatable3;

            NpgsqlDataAdapter dataAdapter4 = new NpgsqlDataAdapter("select * from public.\"Personel\"", DatabaseConnect.Connection);
            DataTable datatable4 = new DataTable();
            dataAdapter4.Fill(datatable4);
            comboBox1.DisplayMember = "PersonelID";
            comboBox1.ValueMember = "PersonelID";
            comboBox1.DataSource = datatable4;

            DatabaseConnect.Connection.Close();


        }
        private void canvasvisibleoff()
        {
            sehireklepanel.Visible = false;
            otogareklepanel1.Visible = false;
            firmaadıeklepanel.Visible = false;
            calıstıgıkonumpanel1.Visible = false;
            masraftipieklepanel.Visible = false;
            otobuseklepanel.Visible = false;
            panel1.Visible = false;
        }
        private void sehireklentiBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            sehireklepanel.Visible = true;
        }

        private void otogareklentiBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            otogareklepanel1.Visible = true;
        }
        private void firmaEkleBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            firmaadıeklepanel.Visible = true;

        }


        private void masrafEkleBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            masraftipieklepanel.Visible = true;
        }

        private void calısılankonumEkleBtn_Click(object sender, EventArgs e)
        {
        
             canvasvisibleoff();
             calıstıgıkonumpanel1.Visible = true;
           
        }

        private void otobusekleBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            otobuseklepanel.Visible = true;
        }

        private void gerigiteklentiBtn_Click(object sender, EventArgs e)
        {
            Form1 anarfm = new Form1();
            anarfm.Show();
            this.Hide();
        }
        private void masraftipieklebtn_Click(object sender, EventArgs e)
        {
            DatabaseConnect.Connection.Open();
            NpgsqlCommand masrafkomut = new NpgsqlCommand("insert into public.\"MasrafTipi\" (\"MasrafTipi\") values (@p1)", DatabaseConnect.Connection);
            masrafkomut.Parameters.AddWithValue("@p1", masraftipitextBox2.Text);
            masrafkomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("Yeni Bir Masraf Tipi başarıyla eklendi");
        }

        private void otogarekleKaydetbtn_Click(object sender, EventArgs e)
        {
            DatabaseConnect.Connection.Open();
            NpgsqlCommand otogkomut = new NpgsqlCommand("insert into public.\"Otogar\" (\"OtogarAdı\",\"OtogarAdresi\",\"OtogarNumarası\",\"SehirID\") values (@p1,@p2,@p3,@p4)", DatabaseConnect.Connection);
            otogkomut.Parameters.AddWithValue("@p1", otogaradıtextBox1.Text);
            otogkomut.Parameters.AddWithValue("@p2", otogaradresitextBox1.Text);
            otogkomut.Parameters.AddWithValue("@p3", otogarnumarasıtextBox2.Text);
            otogkomut.Parameters.AddWithValue("@p4", int.Parse(otogarsehireklecomboBox1.SelectedValue.ToString()));
            otogkomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("Yeni Bir Otogar başarıyla eklendi");
        }
        private void otobuseklekaydedtBtn_Click(object sender, EventArgs e)
        {
            DatabaseConnect.Connection.Open();
            NpgsqlCommand otokomut = new NpgsqlCommand("insert into public.\"Otobus\" (\"Plaka\",\"KoltukSayısı\",\"FirmaID\") values (@p1,@p2,@p3)", DatabaseConnect.Connection);
            otokomut.Parameters.AddWithValue("@p1", plakasıtextBox4.Text);
            otokomut.Parameters.AddWithValue("@p2", int.Parse(koltuksayısıtextBox5.Text));
            otokomut.Parameters.AddWithValue("@p3", int.Parse(otobusfirmaacomboBox2.SelectedValue.ToString()));
            otokomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("Yeni Bir Otobüs başarıyla eklendi");

        }

        private void calıstıgıKonumekleBtn_Click(object sender, EventArgs e)
        {
            DatabaseConnect.Connection.Open();
            NpgsqlCommand konumkomut = new NpgsqlCommand("insert into public.\"PersonelGorevi\" (\"GorevAdı\") values (@p1)", DatabaseConnect.Connection);
            konumkomut.Parameters.AddWithValue("@p1", calıstıgıkonumtextBox3.Text);
            konumkomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("Yeni Bir Çalışma Alanı başarıyla eklendi");

        }


        private void sehireklekaydetBtn_Click(object sender, EventArgs e)
        {
            DatabaseConnect.Connection.Open();
            NpgsqlCommand sehirkomut = new NpgsqlCommand("insert into public.\"Sehir\" (\"SehirAdı\") values (@p1)", DatabaseConnect.Connection);
            sehirkomut.Parameters.AddWithValue("@p1", sehiradıtext.Text);
            sehirkomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("Yeni Bir Şehir başarıyla eklendi");
        }

        private void firmaaddıekleBtn_Click(object sender, EventArgs e)
        {
             DatabaseConnect.Connection.Open();
            NpgsqlCommand firmakomut = new NpgsqlCommand("insert into public.\"Firma\" (\"FirmaAdı\",\"FirmaNumarası\",\"OtogarID\") values (@p1,@p2,@p3)", DatabaseConnect.Connection);
            firmakomut.Parameters.AddWithValue("@p1", firmaadıtextBox1.Text);
            firmakomut.Parameters.AddWithValue("@p2", firmanumarasıtextBox1.Text);
            firmakomut.Parameters.AddWithValue("@p3", int.Parse(firmaotogareklecomboBox1.SelectedValue.ToString()));
            firmakomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("Yeni Bir Firma başarıyla eklendi");
        }

        private void islemekleButton1_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel1.Visible = true;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            DatabaseConnect.Connection.Open();
            NpgsqlCommand firmakomut = new NpgsqlCommand("insert into public.\"Islem\" (\"IslemTipiID\",\"IslemZamanı\",\"PersonelID\") values (@p1,@p2,@p3)", DatabaseConnect.Connection);
            firmakomut.Parameters.AddWithValue("@p1", int.Parse(comboBox2.SelectedValue.ToString()));
            firmakomut.Parameters.AddWithValue("@p2", DateTime.Now);
            firmakomut.Parameters.AddWithValue("@p3", int.Parse(comboBox1.SelectedValue.ToString()));
            firmakomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("İşlem Kaydı Tutuldu");

        }
    }
}
