using System.Data;
using System.Data.SqlClient;

namespace Muhasebe_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=GULAY;Initial Catalog=MuhasebeDb;Integrated Security=True");


        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblFirma", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        { // EKLE
            String t1 = textBox1.Text; // FirmaID
            String t2 = textBox2.Text; // FirmaAd
            String t3 = textBox3.Text; // FirmaSahibiAd
            String t4 = textBox4.Text; // FirmaSahibiSoyad
            String t5 = textBox5.Text; // Tel
            String t6 = textBox6.Text; // TcNo
            String t7 = textBox7.Text; // FirmaAdres
            String t8 = textBox8.Text; // Mail
            String t9 = textBox9.Text; // IlID
            String t10 = textBox10.Text; // FaturaNo
            String t11= textBox11.Text; // VergiNo

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TblFirma(FirmaID, FirmaAd, FirmaSahibiAd, FirmaSahibiSoyad, Tel, TcNo, FirmaAdres, Mail, IlID, FaturaNo, VergiNo) VALUES('" + t1 + "', '" + t2 + "', '" + t3 + "', '" + t4 + "', '" + t5 + "', '" + t6 + "', '" + t7 + "', '" + t8 + "', '" + t9 + "', '" + t10 + "', '" + t11 + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        { //SÝL
            String t1 = textBox1.Text; // FirmaID
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM TblFirma WHERE FirmaID=('" + t1 + "')" , baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {  //Güncelle  

            String t1 = textBox1.Text; // FirmaID
            String t2 = textBox2.Text; // FirmaAd
            String t3 = textBox3.Text; // FirmaSahibiAd
            String t4 = textBox4.Text; // FirmaSahibiSoyad
            String t5 = textBox5.Text; // Tel
            String t6 = textBox6.Text; // TcNo
            String t7 = textBox7.Text; // FirmaAdres
            String t8 = textBox8.Text; // Mail
            String t9 = textBox9.Text; // IlID
            String t10 = textBox10.Text; // FaturaNo
            String t11 = textBox11.Text; // VergiNo

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TblFirma SET FirmaID='" + t1 + "',FirmaAd='" + t2 + "',FirmaSahibiAd='" + t3 + "',FirmaSahibiSoyad='" + t4 + "',Tel='" + t5 + "',TcNo='" + t6 + "',FirmaAdres='" + t7 + "',Mail='" + t8 + "',IlID='" + t9 + "',FaturaNo='" + t10 + "',VergiNo='" + t11 + "' WHERE FirmaID='" + t1 + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 calisan = new Form3();
            calisan.Show();
            this.Hide();
        }
    }
}