using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe_Takip
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=GULAY;Initial Catalog=MuhasebeDb;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            
            label1.Hide();
            textBox1.Hide();
            label2.Hide();
            textBox2.Hide();
            label3.Hide();
            textBox3.Hide();
            label4.Hide();
            textBox4.Hide();
            label5.Hide();
            textBox5.Hide();
            label6.Hide();
            textBox6.Hide();
            label7.Hide();
            textBox7.Hide();
            label8.Hide();
            textBox8.Hide();
            label9.Hide();
            textBox9.Hide();
            label10.Hide();
            textBox10.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Çalışan Bilgileri")
            {
                textBox10.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Çalışan Türü")
            {
                textBox10.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }

            if (comboBox1.SelectedItem.ToString() == "Büro Demirbaş Listesi")
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Çalışan Bilgileri")
            {
                label10.Visible = true; // çalışan türü ıd
                textBox10.Visible = true; // çalışan türü ıd
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
                label6.Visible = true;
                textBox6.Visible = true;
                label7.Visible = true;
                textBox7.Visible = true;
                label8.Visible = true;
                textBox8.Visible = true;
                label9.Visible = true;
                textBox9.Visible = true;

                label10.Text = "Çalışan türü ID:";
                label1.Text = "Çalışan ID: ";
                label2.Text = "Adı: ";
                label3.Text = "Soyadı: ";
                label4.Text = "İşe Giriş Tarihi: ";
                label5.Text = "TC Kimlik No: ";
                label6.Text = "Cinsiyet";
                label7.Text = "Meslek Kodu: ";
                label8.Text = "Çalışan Türü: ";
                label9.Text = "SGK Giriş Tarihi: ";
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblCalisann", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }

            if (comboBox1.SelectedItem.ToString() == "Çalışan Türü")
            {
                label10.Visible = true; // çalışan türü ıd
                textBox10.Visible = true; // çalışan türü ıd
                label1.Visible = false;
                textBox1.Visible = false;
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
                label6.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                textBox7.Visible = false;
                label8.Visible = false;
                textBox8.Visible = false;
                label9.Visible = false;
                textBox9.Visible = false;

                label10.Text = "Çalışan Türü ID:";
                label1.Text = "Çalışan ID: ";
                label2.Text = "Normal: ";
                label3.Text = "Kısmi: ";
                label4.Text = "Hükümlü: ";
                label5.Text = "TMY: ";
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblCalisanTuru", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }

            if (comboBox1.SelectedItem.ToString() == "Büro Demirbaş Listesi")
            {
                label10.Visible = false; // çalışan türü ıd
                textBox10.Visible = false; // çalışan türü ıd
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                textBox4.Visible = false;
                label5.Visible = false;
                textBox5.Visible = false;
                label6.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                textBox7.Visible = false;
                label8.Visible = false;
                textBox8.Visible = false;
                label9.Visible = false;
                textBox9.Visible = false;

                label1.Text = "Demirbaş ID: ";
                label2.Text = "Demirbaş Adı: ";
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblDemirbass", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//EKLE

            String t1 = textBox1.Text; // CalisanID
            String t2 = textBox2.Text; // CalisanAd
            String t3 = textBox3.Text; // CalisanSoyad
            String t4 = textBox4.Text; // IseGirisTarihi
            String t5 = textBox5.Text; // TcNo
            String t6 = textBox6.Text; // Cinsiyet
            String t7 = textBox7.Text; // MeslekKodu
            String t8 = textBox8.Text; // CalisanTuru
            String t9 = textBox9.Text; // SgkGiris
            String t10 = textBox10.Text; // CalısanTuruID


            if (comboBox1.SelectedItem.ToString() == "Çalışan Bilgileri")
            { 
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TblCalisann(CalisanTuruID, CalisanID, CalisanAd, CalisanSoyad, IseGirisTarihi, TcNo, Cinsiyet, MeslekKodu, CalisanTuru, SgkGiris) VALUES('" + t10 + "','" + t1 + "', '" + t2 + "', '" + t3 + "', '" + t4 + "', '" + t5 + "', '" + t6 + "', '" + t7 + "', '" + t8 + "', '" + t9 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblCalisann", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Çalışan Türü")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TblCalisanTuru(CalisanTuruID, Normal, Kismi, Hukumlu, Tmy) VALUES('" + t10 + "', '" + t2 + "', '" + t3 + "', '" + t4 + "', '" + t5 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblCalisanTuru", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Büro Demirbaş Listesi")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TblDemirbass(DemirbasID, DemirbasAdi) VALUES('" + t1 + "', '" + t2 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblDemirbass", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        { // SİL

            String t1 = textBox1.Text; // CalisanID
            String t2 = textBox2.Text; // CalisanAd
            String t3 = textBox3.Text; // CalisanSoyad
            String t4 = textBox4.Text; // IseGirisTarihi
            String t5 = textBox5.Text; // TcNo
            String t6 = textBox6.Text; // Cinsiyet
            String t7 = textBox7.Text; // MeslekKodu
            String t8 = textBox8.Text; // CalisanTuru
            String t9 = textBox9.Text; // SgkGiris
            String t10 = textBox10.Text; // CalısanTuruID


            if (comboBox1.SelectedItem.ToString() == "Çalışan Bilgileri")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM TblCalisann WHERE CalisanID=('" + t1 + "')" , baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblCalisann", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Çalışan Türü")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM TblCalisanTuru WHERE CalisanTuruID=('" + t10 + "')" , baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblCalisanTuru", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Büro Demirbaş Listesi")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM TblDemirbass WHERE DemirbasID=('" + t1 + "')", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblDemirbass", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {  //GÜNCELLE

            String t1 = textBox1.Text; // CalisanID
            String t2 = textBox2.Text; // CalisanAd
            String t3 = textBox3.Text; // CalisanSoyad
            String t4 = textBox4.Text; // IseGirisTarihi
            String t5 = textBox5.Text; // TcNo
            String t6 = textBox6.Text; // Cinsiyet
            String t7 = textBox7.Text; // MeslekKodu
            String t8 = textBox8.Text; // CalisanTuru
            String t9 = textBox9.Text; // SgkGiris
            String t10 = textBox10.Text; // CalısanTuruID


            if (comboBox1.SelectedItem.ToString() == "Çalışan Bilgileri")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE TblCalisann SET CalisanTuruID='" + t10 + "' , CalisanID='" + t1 + "' , CalisanAd='" + t2 + "' , CalisanSoyad='" + t3 + "' ,IseGirisTarihi='" + t4 + "' ,TcNo='" + t5 + "' ,Cinsiyet='" + t6 + "' ,MeslekKodu='" + t7 + "' ,CalisanTuru='" + t8 + "' ,SgkGiris='" + t9 + "' WHERE  CalisanID='" + t1 + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblCalisann", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Çalışan Türü")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE TblCalisanTuru SET CalisanTuruID='" + t10 + "' , Normal='" + t2 + "' , Kismi='" + t3 + "' , Hukumlu='" + t4 + "' ,Tmy='" + t5 + "' WHERE CalisanTuruID='" + t10 + "'", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblCalisanTuru", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Büro Demirbaş Listesi")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE TblDemirbass SET DemirbasID='" + t1 + "' , DemirbasAdi='" + t2 + "' WHERE DemirbasID='" + t1 + "'", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblDemirbass", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 evrak = new Form4();
            evrak.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 firma = new Form1();
            firma.Show();
            this.Hide();
        }
    }
}
