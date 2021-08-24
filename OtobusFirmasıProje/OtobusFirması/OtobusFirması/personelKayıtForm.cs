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
    public partial class personelKayıtForm : Form
    {
        public personelKayıtForm()
        {
            InitializeComponent();
        }

        private void gerigitpersonelBtn_Click(object sender, EventArgs e)
        {
            Form1 anarfm = new Form1();
            anarfm.Show();
            this.Hide();
        }

        private void personelKayıtForm_Load(object sender, EventArgs e)
        {
            DatabaseConnect.ConnectDatabase();
            DatabaseConnect.Connection.Open();

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter("select * from public.\"PersonelGorevi\"", DatabaseConnect.Connection);
            DataTable datatable1 = new DataTable();
            dataAdapter1.Fill(datatable1);
            personelcomboBox5.DisplayMember = "GorevAdı";
            personelcomboBox5.ValueMember = "GorevID";
            personelcomboBox5.DataSource = datatable1;

            NpgsqlDataAdapter dataAdapter2 = new NpgsqlDataAdapter("select * from public.\"Firma\"", DatabaseConnect.Connection);
            DataTable datatable2 = new DataTable();
            dataAdapter2.Fill(datatable2);
            personelfirmasıcomboBox1.DisplayMember = "FirmaAdı";
            personelfirmasıcomboBox1.ValueMember = "FirmaID";
            personelfirmasıcomboBox1.DataSource = datatable2;

            DatabaseConnect.Connection.Close();
        }

        private void personelkaydetBtn_Click(object sender, EventArgs e)
        {
            DatabaseConnect.Connection.Open();
            NpgsqlCommand otokomut = new NpgsqlCommand("insert into public.\"Personel\" (\"PersonelAdı\",\"PersonelSoyadı\",\"PersonelNumarası\",\"GorevID\",\"FirmaID\",\"Maası\") values (@p1,@p2,@p3,@4,@6,@p7)", DatabaseConnect.Connection);
            otokomut.Parameters.AddWithValue("@p1", personeltextBox1.Text);
            otokomut.Parameters.AddWithValue("@p2", personeltextBox2.Text);
            otokomut.Parameters.AddWithValue("@p3", personeltextBox4.Text);
            otokomut.Parameters.AddWithValue("@p7", int.Parse(textBox1.Text));
            otokomut.Parameters.AddWithValue("@p4", int.Parse(personelcomboBox5.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p6", int.Parse(personelfirmasıcomboBox1.SelectedValue.ToString()));
            otokomut.ExecuteNonQuery();
            DatabaseConnect.Connection.Close();
            MessageBox.Show("Yeni Bir Çalışan başarıyla eklendi");
        }
    }
}
