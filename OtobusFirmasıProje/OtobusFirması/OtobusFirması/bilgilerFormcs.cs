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
    public partial class bilgilerFormcs : Form
    {
        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port=5432; Database=OtobusFirması; user ID=postgres; password=enesenes1");
        public bilgilerFormcs()
        {
            InitializeComponent();
        }

        private void sehirbilgiBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel1.Visible = true;
            string sorgu = "select * from public.\"Sehir\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu,baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void otogarbilgiBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel2.Visible = true;
            string sorgu = "select * from public.\"Otogar\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void firmabilgiBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel3.Visible = true;
            string sorgu = "select * from public.\"Firma\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void calısılankonumbilgiBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel4.Visible = true;
            string sorgu = "select * from public.\"PersonelGorevi\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void masrafbilgiBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel5.Visible = true;
            string sorgu = "select * from public.\"Masraf\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void calısanbilgibtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel6.Visible = true;
            string sorgu = "select * from public.\"Personel\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void otobusBilgileriBtn_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel7.Visible = true;
            string sorgu = "select * from public.\"Otobus\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void bilgilerFormcs_Load(object sender, EventArgs e)
        {

        }

        private void gerigitbilgiBtn_Click(object sender, EventArgs e)
        {
            Form1 anarfm = new Form1();
            anarfm.Show();
            this.Hide();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"Sehir\" where \"SehirID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1",int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Şehir Kaydı Başarıyla Silindi");
        }

        private void otosil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"Otogar\" where \"OtogarID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Otogor Kaydı Başarıyla Silindi");
        }

        private void firmasil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"Firma\" where \"FirmaID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Firma Kaydı Başarıyla Silindi");
        }

        private void konumsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"PersonelGorevi\" where \"GorevID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Konum Kaydı Başarıyla Silindi");
        }

        private void masrafsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"Masraf\" where \"MasrafID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Başarıyla Silindi");
        }

        private void calısansil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"Personel\" where \"PersonelID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Masraf Kaydı Başarıyla Silindi");
        }

        private void otobussil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"Otobus\" where \"OtobusID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Otobüs Kaydı Başarıyla Silindi");
        }
        private void canvasvisibleoff()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;


        }

        private void g3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("update public.\"Firma\" set \"FirmaAdı\"=@p1,\"FirmaNumarası\" = @p2 where \"FirmaID\" = @p3", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", textBox8.Text);
            npgsqlCommand.Parameters.AddWithValue("@p2", textBox7.Text);
            npgsqlCommand.Parameters.AddWithValue("@p3", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncellendi");
        }

        private void g1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("update public.\"Sehir\" set \"SehirAdı\"=@p1 where \"SehirID\" = @p3", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", textBox10.Text);
            npgsqlCommand.Parameters.AddWithValue("@p3", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncellendi");
        }

        private void g4_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("update public.\"PersonelGorevi\" set \"GorevAdı\"=@p1 where \"GorevID\" = @p3", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", textBox9.Text);
            npgsqlCommand.Parameters.AddWithValue("@p3", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncellendi");

        }

        private void g7_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("update public.\"Otobus\" set \"Plaka\"=@p1,\"KoltukSayısı\" = @p2 where \"OtobusID\" = @p3", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", textBox2.Text);
            npgsqlCommand.Parameters.AddWithValue("@p2", int.Parse(textBox1.Text));
            npgsqlCommand.Parameters.AddWithValue("@p3", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncellendi");
        }

        private void g2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("update public.\"Otogar\" set \"OtogarAdı\"=@p1,\"OtogarAdresi\" = @p4,\"OtogarNumarası\" = @p2 where \"OtogarID\" = @p3", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", textBox5.Text);
            npgsqlCommand.Parameters.AddWithValue("@p2", textBox3.Text);
            npgsqlCommand.Parameters.AddWithValue("@p4", textBox4.Text);
            npgsqlCommand.Parameters.AddWithValue("@p3", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncellendi");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("update public.\"Personel\" set \"PersonelAdı\"=@p1,\"PersonelSoyadı\" = @p4,\"PersonelNumarası\" = @p2,\"Maası\" = @p5 where \"PersonelID\" = @p3", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", textBox11.Text);
            npgsqlCommand.Parameters.AddWithValue("@p2", textBox6.Text);
            npgsqlCommand.Parameters.AddWithValue("@p4", textBox12.Text);
            npgsqlCommand.Parameters.AddWithValue("@p3", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.Parameters.AddWithValue("@p5", int.Parse(textBox17.Text));
            npgsqlCommand.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncellendi");
        }

        private void bilgidatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"Sefer\" where \"SeferID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Sefer Kaydı Başarıyla Silindi");
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"Bilet\" where \"BiletID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Bilet Kaydı Başarıyla Silindi");
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("update public.\"Yolcu\" set \"YolcuAdı\"=@p1,\"YolcuSoyadı\" = @p4,\"YolcuNumarası\" = @p2,\"YolcuEmail\" = @p5 where \"YolcuID\" = @p3", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", textBox14.Text);
            npgsqlCommand.Parameters.AddWithValue("@p2", textBox15.Text);
            npgsqlCommand.Parameters.AddWithValue("@p4", textBox13.Text);
            npgsqlCommand.Parameters.AddWithValue("@p5", textBox16.Text);
            npgsqlCommand.Parameters.AddWithValue("@p3", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncellendi");
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Delete from public.\"Yolcu\" where \"YolcuID\"=@p1", baglantı);
            npgsqlCommand.Parameters.AddWithValue("@p1", int.Parse(silmeislemitextBox3.Text));
            npgsqlCommand.ExecuteReader();
            baglantı.Close();
            MessageBox.Show("Yolcu Kaydı Başarıyla Silindi");
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel8.Visible = true;
            string sorgu = "select * from public.\"Sefer\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel9.Visible = true;
            string sorgu = "select * from public.\"Yolcu\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel10.Visible = true;
            string sorgu = "select * from public.\"Bilet\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            canvasvisibleoff();
            panel11.Visible = true;
            string sorgu = "select * from public.\"Islem\"";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet veri = new DataSet();
            adapter.Fill(veri);
            bilgidatagrid.DataSource = veri.Tables[0];
        }
    }
}
