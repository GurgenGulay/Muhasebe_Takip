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
using System.IO;
using System.Drawing.Imaging;

namespace Muhasebe_Takip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=GULAY;Initial Catalog=MuhasebeDb;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Select * From TblKullanici where kadi=@adminadi AND sifre=@adminsifresi ";
            SqlParameter prm1 = new SqlParameter("adminadi", textBox1.Text);
            SqlParameter prm2 = new SqlParameter("adminsifresi", textBox2.Text);
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı! Lütfen Tekrar Deneyin!");
            }
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
