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

            NpgsqlDataAdapter dataAdapter3 = new NpgsqlDataAdapter("select * from public.\"Otobus\"", DatabaseConnect.Connection);
            DataTable datatable3 = new DataTable();
            dataAdapter3.Fill(datatable3);
            comboBox3.DisplayMember = "Plaka";
            comboBox3.ValueMember = "OtobusID";
            comboBox3.DataSource = datatable3;

            NpgsqlDataAdapter dataAdapter4 = new NpgsqlDataAdapter("select * from public.\"Sofor\"", DatabaseConnect.Connection);
            DataTable datatable4 = new DataTable();
            dataAdapter4.Fill(datatable4);
            comboBox4.DisplayMember = "SoforAdı";
            comboBox4.ValueMember = "SoforID";
            comboBox4.DataSource = datatable4;
            NpgsqlDataAdapter dataAdapter5 = new NpgsqlDataAdapter("select * from public.\"Muavin\"", DatabaseConnect.Connection);
            DataTable datatable5 = new DataTable();
            dataAdapter5.Fill(datatable5);
            comboBox5.DisplayMember = "MuavinAdı";
            comboBox5.ValueMember = "MuavinID";
            comboBox5.DataSource = datatable5;
            NpgsqlDataAdapter dataAdapter6 = new NpgsqlDataAdapter("select * from public.\"Firma\"", DatabaseConnect.Connection);
            DataTable datatable6 = new DataTable();
            dataAdapter6.Fill(datatable6);
            comboBox6.DisplayMember = "FirmaAdı";
            comboBox6.ValueMember = "FirmaID";
            comboBox6.DataSource = datatable6;
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

            otokomut.Parameters.AddWithValue("@p1", int.Parse(comboBox1.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p2", int.Parse(comboBox2.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p3", int.Parse(comboBox3.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p4", int.Parse(comboBox4.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p5", int.Parse(comboBox5.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p8", int.Parse(comboBox6.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p9", textBox1.Text);
            otokomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("Yeni Bir Sefer başarıyla oluşturuldu");

        }

    }
}



