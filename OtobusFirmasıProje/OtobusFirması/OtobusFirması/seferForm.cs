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
    public partial class seferForm : Form
    {
        public seferForm()
        {
            InitializeComponent();
        }

        private void seferForm_Load(object sender, EventArgs e)
        {
            DatabaseConnect.ConnectDatabase();
            DatabaseConnect.Connection.Open();

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter("select * from public.\"Sehir\"", DatabaseConnect.Connection);
            DataTable datatable1 = new DataTable();
            dataAdapter1.Fill(datatable1);
            comboBox1.DisplayMember = "SehirAdı";
            comboBox1.ValueMember = "SehirID";
            comboBox1.DataSource = datatable1;

            NpgsqlDataAdapter dataAdapter2 = new NpgsqlDataAdapter("select * from public.\"Sehir\"", DatabaseConnect.Connection);
            DataTable datatable2 = new DataTable();
            dataAdapter2.Fill(datatable2);
            comboBox2.DisplayMember = "SehirAdı";
            comboBox2.ValueMember = "SehirID";
            comboBox2.DataSource = datatable2;
     
            DatabaseConnect.Connection.Close();

        }
        private void gerigitseferBtn_Click(object sender, EventArgs e)
        {
            Form1 anarfm = new Form1();
            anarfm.Show();
            this.Hide();
        }
        private void seferkaydetBtn_Click(object sender, EventArgs e)
        {
            DatabaseConnect.Connection.Open();
            NpgsqlCommand otokomut = new NpgsqlCommand("insert into public.\"Sefer\" (\"KalkısSehriID\",\"VarısSehriID\",\"OtobusID\",\"SoforID\",\"MuavinID\",\"FirmaID\",\"KalkısZamanı\") values (@p1,@p2,@p3,@4,@5,@p8,@p9)", DatabaseConnect.Connection);
            
            NpgsqlCommand getCity2 = new NpgsqlCommand("select \"OtobusID\" from public.\"Otobus\" where \"Plaka\" = " + "'" + comboBox3.Text+ "'", DatabaseConnect.Connection);
            int sehirId2 = (int)getCity2.ExecuteScalar();

            NpgsqlCommand getCity3 = new NpgsqlCommand("select \"SoforID\" from public.\"Sofor\" where \"SoforAdı\" = " + "'" + comboBox4.Text + "'", DatabaseConnect.Connection);
            int sehirId3 = (int)getCity3.ExecuteScalar();
            NpgsqlCommand getCity4 = new NpgsqlCommand("select \"MuavinID\" from public.\"Muavin\" where \"MuavinAdı\" = " + "'" + comboBox5.Text + "'", DatabaseConnect.Connection);
            int sehirId4 = (int)getCity4.ExecuteScalar();
            NpgsqlCommand getCity5 = new NpgsqlCommand("select \"FirmaID\" from public.\"Firma\" where \"FirmaAdı\" = " + "'" + comboBox6.Text + "'", DatabaseConnect.Connection);
            int sehirId5 = (int)getCity5.ExecuteScalar();





            otokomut.Parameters.AddWithValue("@p1", int.Parse(comboBox1.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p2", int.Parse(comboBox2.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p3", sehirId2);
            otokomut.Parameters.AddWithValue("@p4", sehirId3);
            otokomut.Parameters.AddWithValue("@p5", sehirId4);
            otokomut.Parameters.AddWithValue("@p8", sehirId5);
            otokomut.Parameters.AddWithValue("@p9", textBox1.Text);
            otokomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("Yeni Bir Sefer başarıyla oluşturuldu");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DatabaseConnect.Connection.State != ConnectionState.Open) DatabaseConnect.Connection.Open();
            NpgsqlCommand command62 = new NpgsqlCommand("select \"SehirID\" from public.\"Sehir\"where \"SehirAdı\"=" +"'"+comboBox1.Text+"'",DatabaseConnect.Connection);
            int secim1 = Convert.ToInt32(command62.ExecuteScalar());
            NpgsqlCommand command63 = new NpgsqlCommand("select \"OtogarID\" from public.\"Otogar\"where \"SehirID\"=" +secim1, DatabaseConnect.Connection);
            int secim2 = Convert.ToInt32(command63.ExecuteScalar());
            NpgsqlDataAdapter dataAdapter6 = new NpgsqlDataAdapter("select \"FirmaAdı\" from public.\"Firma\"where \"OtogarID\"=" +secim2, DatabaseConnect.Connection);
            DataTable datatable6 = new DataTable();
            dataAdapter6.Fill(datatable6);
            comboBox6.DisplayMember = "FirmaAdı";
            comboBox6.ValueMember = "FirmaID";
            comboBox6.DataSource = datatable6;
           
            DatabaseConnect.Connection.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DatabaseConnect.Connection.State != ConnectionState.Open) DatabaseConnect.Connection.Open();
            NpgsqlCommand command64 = new NpgsqlCommand("select \"FirmaID\" from public.\"Firma\"where \"FirmaAdı\"=" + "'" + comboBox6.Text + "'", DatabaseConnect.Connection);
            int secim3 = Convert.ToInt32(command64.ExecuteScalar()); 
            NpgsqlDataAdapter dataAdapter3 = new NpgsqlDataAdapter("select \"Plaka\" from public.\"Otobus\"where \"FirmaID\"=" + secim3, DatabaseConnect.Connection);

            DataTable datatable3 = new DataTable();
            dataAdapter3.Fill(datatable3);
            comboBox3.DisplayMember = "Plaka";
            comboBox3.ValueMember = "OtobusID";
            comboBox3.DataSource = datatable3;

            NpgsqlCommand command65 = new NpgsqlCommand("select \"FirmaID\" from public.\"Firma\"where \"FirmaAdı\"=" + "'" + comboBox6.Text + "'", DatabaseConnect.Connection);
            int secim4 = Convert.ToInt32(command65.ExecuteScalar());
            NpgsqlDataAdapter dataAdapter4 = new NpgsqlDataAdapter("select \"SoforAdı\",\"SoforSoyadı\" from public.\"Sofor\"where \"FirmaID\"=" + secim4, DatabaseConnect.Connection);

            DataTable datatable4 = new DataTable();
            dataAdapter4.Fill(datatable4);
            DataColumn dataColumn1 = new DataColumn("AdSoyad1");
            dataColumn1.Expression = string.Format("{0}+' '+{1}", "SoforAdı", "SoforSoyadı");
            datatable4.Columns.Add(dataColumn1);
            comboBox4.DisplayMember = "AdSoyad1";
            comboBox4.ValueMember = "SoforID";
            comboBox4.DataSource = datatable4;

            NpgsqlCommand command66 = new NpgsqlCommand("select \"FirmaID\" from public.\"Firma\"where \"FirmaAdı\"=" + "'" + comboBox6.Text + "'", DatabaseConnect.Connection);
            int secim5 = Convert.ToInt32(command66.ExecuteScalar());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select \"MuavinAdı\",\"MuavinSoyadı\" from public.\"Muavin\"where \"FirmaID\"=" + secim5, DatabaseConnect.Connection);


            DataTable dt = new DataTable();
            da.Fill(dt);
            DataColumn dataColumn = new DataColumn("AdSoyad");
            dataColumn.Expression = string.Format("{0}+' '+{1}", "MuavinAdı", "MuavinSoyadı");
            dt.Columns.Add(dataColumn);
            comboBox5.DisplayMember = "AdSoyad";
            comboBox5.ValueMember = "MuavinID";
            comboBox5.DataSource = dt;
            DatabaseConnect.Connection.Close();
        }
    }
}



