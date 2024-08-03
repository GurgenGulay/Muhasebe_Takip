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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=GULAY;Initial Catalog=MuhasebeDb;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
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
            label11.Hide();
            textBox11.Hide();
            label12.Hide();
            textBox12.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Evrak Kontrol")
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
                textBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Poşet Beyannamesi")
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            }

            if (comboBox1.SelectedItem.ToString() == "BaBs Beyannamesi")
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            }
            if (comboBox1.SelectedItem.ToString() == "Muhtasar")
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
                textBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            }
            if (comboBox1.SelectedItem.ToString() == "Damga Vergisi")
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Evrak Kontrol")
            {

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
                label10.Visible = true;
                textBox10.Visible = true;
                label11.Visible = true;
                textBox11.Visible = true;
                label12.Visible = true;
                textBox12.Visible = true;


                label1.Text = "Evrak Kontrol ID: ";
                label2.Text = "e-Arşiv Fatura Sogulama: ";
                label3.Text = "Kdv Öncesi Kontrol: ";
                label4.Text = "Babs Kontrol: ";
                label5.Text = "Poşet Vergisi Kontrol: ";
                label6.Text = "Damga Vergisi Kontrol";
                label7.Text = "Muhtasar Kontrol: ";
                label8.Text = "İşkur Gücü Çizelgesi Kontrol: ";
                label9.Text = "BaBs ID: ";
                label10.Text = "Poşet ID:";
                label11.Text = "Muhtasar ID:";
                label12.Text = "İş gücü ID:";
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblEvrakKontrol", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }

            if (comboBox1.SelectedItem.ToString() == "Poşet Beyannamesi")
            {

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
                label7.Visible = false;
                textBox7.Visible = false;
                label8.Visible = false;
                textBox8.Visible = false;
                label9.Visible = false;
                textBox9.Visible = false;
                label10.Visible = false;
                textBox10.Visible = false;
                label11.Visible = false;
                textBox11.Visible = false;
                label12.Visible = false;
                textBox12.Visible = false;


                label1.Text = "Poşet ID: ";
                label2.Text = "Stokta Olan Poşet: ";
                label3.Text = "Birimin Alış Fiyatı ";
                label4.Text = "Temin Bedeli: ";
                label5.Text = "Alım Yeri Adresi: ";
                label6.Text = "A.Y. Vergi Numarası: ";

                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblPosetBeyannamesi", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }

            if (comboBox1.SelectedItem.ToString() == "BaBs Beyannamesi")
            {

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
                label8.Visible = false;
                textBox8.Visible = false;
                label9.Visible = false;
                textBox9.Visible = false;
                label10.Visible = false;
                textBox10.Visible = false;
                label11.Visible = false;
                textBox11.Visible = false;
                label12.Visible = false;
                textBox12.Visible = false;


                label1.Text = "BaBs ID: ";
                label2.Text = "Mal Alış: ";
                label3.Text = "Mal Satış ";
                label4.Text = "Mal Alış İadesi: ";
                label5.Text = "Mal Satış iadesi: ";
                label6.Text = "Demirbaş Kontrolü: ";
                label7.Text = "Gider: ";

                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblBaBs", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }

            if (comboBox1.SelectedItem.ToString() == "Muhtasar")
            {

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
                label10.Visible = true;
                textBox10.Visible = true;
                label11.Visible = true;
                textBox11.Visible = true;
                label12.Visible = true;
                textBox12.Visible = true;


                label1.Text = "Muhtasar ID: ";
                label2.Text = "Çalışan Sayısı: ";
                label3.Text = "işyeri Kira Bedeli :";
                label4.Text = "Asgeri Ücretli Sayısı: ";
                label5.Text = "Diğer Ücretli Sayısı: ";
                label6.Text = "Kira Brüt: ";
                label7.Text = "Stopaj Tutarı: ";
                label8.Text = "Birinci Dönem: ";
                label9.Text = "İkinci Dönem: ";
                label10.Text = "Üçüncü Dönem: ";
                label11.Text = "Dördüncü Dönem: ";
                label12.Text = "Kod: ";

                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblMuhtasarHesaplama", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            if (comboBox1.SelectedItem.ToString() == "Damga Vergisi")
            {

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
                label6.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                textBox7.Visible = false;
                label8.Visible = false;
                textBox8.Visible = false;
                label9.Visible = false;
                textBox9.Visible = false;
                label10.Visible = false;
                textBox10.Visible = false;
                label11.Visible = false;
                textBox11.Visible = false;
                label12.Visible = false;
                textBox12.Visible = false;


                label1.Text = "Damga ID: ";
                label2.Text = "Yıl. Değ. Çarp. Gereken Yüzdelik: ";
                label3.Text = "Sözleşme Yıllık Değer :";
                label4.Text = "Ödenmesi Gereken Değer: ";
                label5.Text = "Damga Bilgi ID: ";

                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblDamgaVergisiHesaplamaa", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { //EKLE
            String t1 = textBox1.Text; // EvrakKontrolID
            String t2 = textBox2.Text; // EArsivFaturaSorgKontr
            String t3 = textBox3.Text; // KdvOncesiKontr
            String t4 = textBox4.Text; // BaBsKontr
            String t5 = textBox5.Text; // PosetVergisiKontr
            String t6 = textBox6.Text; // DamgaVergisiKontr
            String t7 = textBox7.Text; // MuhtasarKontr
            String t8 = textBox8.Text; // IskurIsGucuCizelgesiKontr
            String t9 = textBox9.Text; // BaBsID
            String t10 = textBox10.Text; // PosetID
            String t11 = textBox10.Text; // DamgaID
            String t12 = textBox10.Text; // MuhtasarID


            if (comboBox1.SelectedItem.ToString() == "Evrak Kontrol")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TblEvrakKontrol(EvrakKontrolID, EArsivFaturaSorgKontr, KdvOncesiKontr, BaBsKontr, PosetVergisiKontr, DamgaVergisiKontr, MuhtasarKontr, IskurIsGucuCizelgesiKontr) VALUES('" + t1 + "', '" + t2 + "', '" + t3 + "', '" + t4 + "', '" + t5 + "', '" + t6 + "', '" + t7 + "', '" + t8 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblEvrakKontrol", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Poşet Beyannamesi")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TblPosetBeyannamesi(PosetID, StoktaPosetSayisi, BirimAlisFiyati, AlinanYerinVergiNo) VALUES('" + t1 + "', '" + t2 + "', '" + t3 + "', '" + t5 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblPosetBeyannamesi", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "BaBs Beyannamesi")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TblBaBs(BaBsID, MalAlis, MalSatis, MalAlisIadesi,MalSatisIadesi,DemirBasKontrolu,Gider) VALUES('" + t1 + "', '" + t2 + "', '" + t3 + "', '" + t4 + "', '" + t5 + "', '" + t6 + "', '" + t7 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblBaBs", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Muhtasar")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TblMuhtasarHesaplama(MuhtasarID,CalisanSayisi,IsYeriKiraBedeli,AsgeriUcretliSayisi,DigerUcretliSayisi,KiraBrut,StopajTutari,BirinciDonem,IkinciDonem,UcuncuDonem,DorduncuDonem) VALUES('" + t1 + "', '" + t2 + "', '" + t3 + "', '" + t4 + "', '" + t5 + "', '" + t6 + "', '" + t7 + "', '" + t8 + "', '" + t9 + "', '" + t10 + "', '" + t11 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblMuhtasarHesaplama", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Damga Vergisi")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TblDamgaVergisiHesaplamaa(DamgaID,YillikDegerinCarpilmasiGerekenYuzdelik,SozlesmeYillikDeger,OdenmessiGerekenDeger) VALUES('" + t1 + "', '" + t2 + "', '" + t3 + "', '" + t4 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblDamgaVergisiHesaplamaa", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String t1 = textBox1.Text; // EvrakKontrolID
            String t2 = textBox2.Text; // EArsivFaturaSorgKontr
            String t3 = textBox3.Text; // KdvOncesiKontr
            String t4 = textBox4.Text; // BaBsKontr
            String t5 = textBox5.Text; // PosetVergisiKontr
            String t6 = textBox6.Text; // DamgaVergisiKontr
            String t7 = textBox7.Text; // MuhtasarKontr
            String t8 = textBox8.Text; // IskurIsGucuCizelgesiKontr
            String t9 = textBox9.Text; // BaBsID
            String t10 = textBox10.Text; // PosetID
            String t11 = textBox10.Text; // DamgaID
            String t12 = textBox10.Text; // MuhtasarID


            if (comboBox1.SelectedItem.ToString() == "Evrak Kontrol")
            {  //SİL
                baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM TblEvrakKontrol WHERE EvrakKontrolID=('" + t1 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblEvrakKontrol", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Poşet Beyannamesi")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM TblPosetBeyannamesi WHERE PosetID=('" + t1 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblPosetBeyannamesi", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "BaBs Beyannamesi")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM TblBaBs WHERE BaBsID=('" + t1 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblBaBs", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Muhtasar")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM TblMuhtasarHesaplama WHERE MuhtasarID=('" + t1 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblMuhtasarHesaplama", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }

            if (comboBox1.SelectedItem.ToString() == "Damga Vergisi")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM TblDamgaVergisiHesaplamaa WHERE DamgaID=('" + t1 + "') ", baglanti);
                komut.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TblDamgaVergisiHesaplamaa", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {  //GÜNCELLE

            String t1 = textBox1.Text; // EvrakKontrolID
            String t2 = textBox2.Text; // EArsivFaturaSorgKontr
            String t3 = textBox3.Text; // KdvOncesiKontr
            String t4 = textBox4.Text; // BaBsKontr
            String t5 = textBox5.Text; // PosetVergisiKontr
            String t6 = textBox6.Text; // DamgaVergisiKontr
            String t7 = textBox7.Text; // MuhtasarKontr
            String t8 = textBox8.Text; // IskurIsGucuCizelgesiKontr
            String t9 = textBox9.Text; // BaBsID
            String t10 = textBox10.Text; // PosetID
            String t11 = textBox10.Text; // DamgaID
            String t12 = textBox10.Text; // MuhtasarID


            if (comboBox1.SelectedItem.ToString() == "Evrak Kontrol")
            {

                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE TblEvrakKontrol SET EvrakKontrolID='" + t1 + "' , EArsivFaturaSorgKontr='" + t2 + "' , KdvOncesiKontr='" + t3 + "' , BaBsKontr='" + t4 + "' ,PosetVergisiKontr='" + t5 + "' ,DamgaVergisiKontr='" + t6 + "' ,MuhtasarKontr='" + t7 + "' ,IskurIsGucuCizelgesiKontr='" + t8 + "' WHERE  EvrakKontrolID='" + t1 + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblEvrakKontrol", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }



            if (comboBox1.SelectedItem.ToString() == "Poşet Beyannamesi")
            {


                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE TblPosetBeyannamesi SET PosetID='" + t1 + "' , StoktaPosetSayisi='" + t2 + "' , BirimAlisFiyati='" + t3 + "' , TeminBedeli='" + t4 + "' ,AlimYeriAdresi='" + t5 + "' ,alinanYerinVergiNo='" + t6 + "'  WHERE  PosetID='" + t1 + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblPosetBeyannamesi", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }


            if (comboBox1.SelectedItem.ToString() == "BaBs Beyannamesi")
            {


                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE TblBaBs SET BaBsID='" + t1 + "' , MalAlis='" + t2 + "' , MalSatis='" + t3 + "' , MalAlisIadesi='" + t4 + "' ,MalSatisIadesi='" + t5 + "', DemirbasKontrolu='" + t7 + "'  WHERE  BaBsID='" + t1 + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblBaBs", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }


            if (comboBox1.SelectedItem.ToString() == "Muhtasar")
            {

                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE TblMuhtasarHesaplama SET MuhtasarID='" + t1 + "' , CalisanSayisi='" + t2 + "' , IsYeriKiraBedeli='" + t3 + "' , AsgeriUcretliSayisi='" + t4 + "' ,DigerUcretliSayisi='" + t5 + "' ,KiraBrut='" + t6 + "' ,StopajTutari='" + t7 + "' ,BirinciDonem='" + t8 + "',IkinciDonem='" + t9 + "',UcuncuDonem='" + t10 + "',DorduncuDonem='" + t11 + "' WHERE  MuhtasarID='" + t1 + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblMuhtasarHesaplama", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }


            if (comboBox1.SelectedItem.ToString() == "Damga Vergisi")
            {


                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE TblDamgaVergisiHesaplamaa SET DamgaID='" + t1 + "' , YillikDegerinCarpilmasiGerekenYuzdelik='" + t2 + "' , SozlesmeYillikDeger='" + t3 + "' , OdenmessiGerekenDeger='" + t4 + "'  WHERE  DamgaID='" + t1 + "'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblDamgaVergisiHesaplamaa", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 firma = new Form3();
            firma.Show();
            this.Hide();
        }
    }
}
