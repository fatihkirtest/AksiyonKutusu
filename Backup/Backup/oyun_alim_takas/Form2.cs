using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace oyun_alim_takas
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=FATIHH\\SQLEXPRESS;Initial Catalog=proje1;Integrated Security=true");
        SqlDataReader oku;
        string resimpath;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = true;
            uzanti.Enabled = false;
            label16.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
            label13.Visible = false;
            Random rnd = new Random();
            label9.Text = rnd.Next(1, 100000).ToString();
            connect.Open();
            string sorgu = "Select il2 From il";
            SqlCommand komut = new SqlCommand(sorgu, connect);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku.GetString(0));
            }
            connect.Close();
            connect.Open();
            string sorgu2 = "Select guvenlik_sorusu From guvenlık";
            SqlCommand komut2 = new SqlCommand(sorgu2, connect);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox2.Items.Add(oku2.GetString(0));
            }
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label9.Text = rnd.Next(1, 100000).ToString();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                label13.Visible = false;
                textBox2.BackColor = Color.Green;
                textBox3.BackColor = Color.Green;
            }
            else if (textBox2.Text != textBox3.Text)
            {
                label13.Visible = true;
                label13.Text = "Şifreler Birbirini Tutmuyor";
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
            }

            if (textBox2.Text == "" && textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                label13.Visible = false;
            }
            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.White;
                label13.Visible = false;
                textBox3.BackColor = Color.White;
            }
            if (textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                label13.Visible = false;
                textBox3.BackColor = Color.White;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                label13.Visible = false;
                textBox2.BackColor = Color.Green;
                textBox3.BackColor = Color.Green;
            }
            else if (textBox2.Text != textBox3.Text)
            {
                label13.Visible = true;
                label13.Text = "Şifreler Birbirini Tutmuyor";
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
            }

            if (textBox2.Text == "" && textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                label13.Visible = false;
            }
            if (textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                label13.Visible = false;
            }
            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                label13.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            connect.Open();
         
            SqlCommand komut = new SqlCommand("", connect);
        
            bool texbox_kontrol = false;
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    if (Controls[i].Text != "" && textBox1.BackColor == Color.Green && textBox2.BackColor == Color.Green && textBox3.BackColor == Color.Green && textBox4.BackColor == Color.Green && textBox5.BackColor == Color.Green && textBox8.BackColor == Color.Green)
                        texbox_kontrol = true;
                    else
                    {
                        texbox_kontrol = false;
                        break;
                    }
                }
            }
            if (texbox_kontrol == true)
            {
               
                bool kayıt_dogrulama=false;
                string sorgu1 = "INSERT INTO yeniuye(kullanici_adi,e_posta,ad,soyad,sifre,il3,guvenlik_sorusu2,cevap) VALUES('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox9.Text + "')";
               
  
                komut.CommandText = sorgu1;
                if (komut.ExecuteNonQuery() == 1)
                    kayıt_dogrulama = true;
                else
                    kayıt_dogrulama = false;
                
                //Resimimizi FileStream metoduyla okuma modunda açıyoruz
                FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
                //BinaryReader ile byte dizisi ile FileStream arasında veri akışı sağlanıyor.
                BinaryReader br = new BinaryReader(fs);
                /*ReadBytes ile FileStreamde belirtilen resim dosyasındaki byte lar
                 byte dizisine aktarılıyor.
                 */
                byte[] resim = br.ReadBytes((int)fs.Length);
               br.Close();
                fs.Close();
                
                string sorgu2 = "insert into foto(resim,uzanti) Values (@resim,@uzanti) ";
          
                SqlCommand kmt = new SqlCommand(sorgu2, connect);
                kmt.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
                kmt.Parameters.Add("@uzanti", SqlDbType.VarChar, 255).Value = uzanti.Text;
                if (kmt.ExecuteNonQuery() == 1)
                {
                    kayıt_dogrulama = true;
                }
                else
                {
                    kayıt_dogrulama = false;
                }
                if (kayıt_dogrulama == true)
                {
                    MessageBox.Show("Aksiyonkutusu'na Hoşgeldiniz Kaydınız Başarıyla Alınmıştır");
                }
                connect.Close();
                this.Close();


            }
            else
                MessageBox.Show("Eksikleri Doldurunuz");

            connect.Close();
        }
      

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox5.Text)
            {
                label14.Visible = false;
                textBox5.BackColor = Color.Green;
                textBox4.BackColor = Color.Green;
            }
            else if (textBox4.Text != textBox5.Text)
            {
                label14.Visible = true;
                label14.Text = "E-Postalar Birbirini Tutmuyor";
                textBox5.BackColor = Color.Red;
                textBox4.BackColor = Color.Red;
            }

            if (textBox4.Text == "" && textBox5.Text == "")
            {
                textBox4.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                label14.Visible = false;
            }
            if (textBox4.Text == "")
            {
                textBox5.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                label14.Visible = false;
            }
            if (textBox5.Text == "")
            {
                textBox5.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                label14.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                SqlCommand komut = new SqlCommand("select kullanici_adi from yeniuye", connect);
                connect.Open();
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (oku.GetString(0) == textBox1.Text)
                    {
                        label15.Visible = true;
                        label15.Text ="Bir Kulanıcı Adı Var Lütfen Başka Kulanıcı Adı Girin";
                        textBox1.BackColor = Color.Red;
                        break;
                    }
                    else
                    {
                        label15.Visible = false;
                        textBox1.BackColor = Color.Green;
                    }

                }
                connect.Close();
            }
            if (textBox1.Text == "")
            {
                label15.Visible = false;
                textBox1.BackColor = Color.White;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == label9.Text)
            {
                textBox8.BackColor = Color.Green;
                label16.Visible = false;
            }
            else
            {
                textBox8.BackColor = Color.Red;
                label16.Text = "Onaylama Kodu Yanlış";
                label16.Visible = true;
            }
            if (textBox8.Text == "")
            {
                label16.Visible = false;
                textBox8.BackColor = Color.White;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox5.Text)
            {
                label14.Visible = false;
                textBox5.BackColor = Color.Green;
                textBox4.BackColor = Color.Green;
            }
            else if (textBox4.Text != textBox5.Text)
            {
                label14.Visible = true;
                label14.Text = "E-Postalar Birbirini Tutmuyor";
                textBox5.BackColor = Color.Red;
                textBox4.BackColor = Color.Red;
            }

            if (textBox4.Text == "" && textBox5.Text == "")
            {
                textBox4.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                label14.Visible = false;
            }
            if (textBox4.Text == "")
            {
                textBox5.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                label14.Visible = false;
            }
            if (textBox5.Text == "")
            {
                textBox5.BackColor = Color.White;
                label14.Visible = false;
                textBox4.BackColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Resim dosyalarımızı openFileDialog nesnesi ile açıyoruz.
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|All Files (*.*)|*.*";//Filtrelemeleri belirledik jpg png gibi.
            openFileDialog1.InitialDirectory = "C://"; //Seçim yapılırken bilgisayarda açılacak ilk yeri belirlememize yarar.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                uzanti.Text = openFileDialog1.FileName.ToString();
                resimpath = openFileDialog1.FileName.ToString();
            }
        }
    }
}
