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
    public partial class masrafForm : Form
    {
        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port=5432; Database=OtobusFirması; user ID=postgres; password=enesenes1");

        public masrafForm()
        {
            InitializeComponent();
        }

        private void masrafForm_Load(object sender, EventArgs e)
        {    
            string sorgu = "select * from public.\"Sefer\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            sefergrid.DataSource = veri.Tables[0];

            baglantı.Open();
            NpgsqlDataAdapter dataAdapter2 = new NpgsqlDataAdapter("select * from public.\"MasrafTipi\"",baglantı);
            DataTable datatable2 = new DataTable();
            dataAdapter2.Fill(datatable2);
            yapılanmasrafcomboBox1.DisplayMember = "MasrafTipi";
            yapılanmasrafcomboBox1.ValueMember = "MasrafTipiID";
            yapılanmasrafcomboBox1.DataSource = datatable2;

            baglantı.Close();
        }

        private void gerigitmasrafBtn_Click(object sender, EventArgs e)
        {
            Form1 anarfm = new Form1();
            anarfm.Show();
            this.Hide();
        }

        private void masrafaramabtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            sefergrid.Columns.Clear();
            string sorgu = "select * from public.\"Sefer\" where cast(\"SeferID\" as char) like '%" + sefernotext.Text + "%'";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            sefergrid.DataSource = ds.Tables[0];
            NpgsqlCommand command = new NpgsqlCommand("select \"OtobusID\" from public.\"Sefer\" where \"SeferID\"="+sefernotext.Text,baglantı);
            int otobus = Convert.ToInt32(command.ExecuteScalar());
            NpgsqlCommand command1 = new NpgsqlCommand("select \"Plaka\" from public.\"Otobus\" where \"OtobusID\"=" + otobus.ToString(), baglantı);
            label1.Text = command1.ExecuteScalar().ToString();

            NpgsqlCommand command2 = new NpgsqlCommand("select \"SoforID\" from public.\"Sefer\" where \"SeferID\"=" + sefernotext.Text, baglantı);
            int otobus2 = Convert.ToInt32(command2.ExecuteScalar());
            NpgsqlCommand command3 = new NpgsqlCommand("select \"SoforAdı\" from public.\"Sofor\" where \"SoforID\"=" + otobus2.ToString(), baglantı);
            label2.Text = command3.ExecuteScalar().ToString();

            NpgsqlCommand command8 = new NpgsqlCommand("select \"SoforID\" from public.\"Sefer\" where \"SeferID\"=" + sefernotext.Text, baglantı);
            int otobus5 = Convert.ToInt32(command8.ExecuteScalar());
            NpgsqlCommand command9 = new NpgsqlCommand("select \"SoforSoyadı\" from public.\"Sofor\" where \"SoforID\"=" + otobus5.ToString(), baglantı);
            label7.Text = command9.ExecuteScalar().ToString();
            baglantı.Close();

        }

        private void masrafkaydetBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand otokomut = new NpgsqlCommand("insert into public.\"Masraf\"(\"MasrafTipiID\",\"Tutar\",\"SeferID\") values (@p1,@p2,@p3)", baglantı);
            otokomut.Parameters.AddWithValue("@p1", int.Parse(yapılanmasrafcomboBox1.SelectedValue.ToString()));
            otokomut.Parameters.AddWithValue("@p3", int.Parse(sefernotext.Text));
            otokomut.Parameters.AddWithValue("@p2", int.Parse(tutartextBox4.Text));
            otokomut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Yeni Bir Masraf kaydı başarıyla oluşturuldu");
        }

        private void sefernotext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
