using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace oyun_alim_takas
{
    public partial class Form3 : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=FATIHH\\SQLEXPRESS;Initial Catalog=proje1;Integrated Security=true");
        string resimpath;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resim dosyalarımızı openFileDialog nesnesi ile açacağız.
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|All Files (*.*)|*.*";//Filtrelemeleri belirledik jpg png gibi.
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                uzanti.Text = openFileDialog1.FileName.ToString();
                resimpath = openFileDialog1.FileName.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Resimimizi FileStream metoduyla okuma modunda açıyoruz.
            FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
            //BinaryReader ile byte dizisi ile FileStream arasında veri akışı sağlanıyor.
            BinaryReader br = new BinaryReader(fs);
            /*ReadBytes ile FileStreamde belirtilen resim dosyasındaki byte lar
             byte dizisine aktarılıyor.
             */
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            SqlCommand kmt = new SqlCommand("update foto set resim=@resim,uzanti=@uzanti where no='"+bilgi.kulanıcı_denetimi.ToString()+"' ", connect);
            kmt.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
            kmt.Parameters.Add("@uzanti", SqlDbType.VarChar, 255).Value = uzanti.Text;
            connect.Open();
            kmt.ExecuteNonQuery();
            timer1.Enabled = true;
            progressBar1.Visible = true;
            linkLabel1.Visible = true;
            connect.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button8.Visible = false;
            connect.Open();
            SqlCommand komuttt = new SqlCommand("Select kullanici_adi From yeniuye where no='" + bilgi.kulanıcı_denetimi.ToString() + "'", connect);
            SqlDataReader okuu = komuttt.ExecuteReader();
            while (okuu.Read())
            {
                if(okuu.GetString(0)=="admin")
                {
                    button8.Visible = true;
                }
            }
            connect.Close();
            progressBar1.Visible = false;
            linkLabel1.Visible = false;
            connect.Open();
            SqlCommand komutt = new SqlCommand("Select ad,soyad,kullanici_adi From yeniuye where no='" + bilgi.kulanıcı_denetimi.ToString() + "'",connect);
            SqlDataReader oku = komutt.ExecuteReader();
            while (oku.Read())
            {
                label14.Text = oku.GetString(0).ToString();
                label15.Text = oku.GetString(1).ToString();
                label17.Text = oku.GetString(2).ToString();
            }
            connect.Close();
            textBox1.UseSystemPasswordChar = true;
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            uzanti.Enabled = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            connect.Open();
            SqlCommand cm = new SqlCommand("select resim from foto where no='"+bilgi.kulanıcı_denetimi.ToString()+"'", connect);
            byte[] dizi = (byte[])cm.ExecuteScalar();
            pictureBox1.Image = Image.FromStream(new MemoryStream(dizi));
            connect.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            string sorgu = "Select sifre From yeniuye where no='"+bilgi.kulanıcı_denetimi.ToString()+"'";
            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku.GetString(0) == textBox1.Text)
                {
                    label8.Visible = false;
                    textBox1.BackColor = Color.Green;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                    label8.Text = "Eski Şifreniz Doğru Değil";
                    label8.Visible = true;
                }
            }
            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.White;
                label8.Visible = false;
            }
            connect.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                label9.Visible = false;
                textBox2.BackColor = Color.Green;
                textBox3.BackColor = Color.Green;
            }
            else if (textBox2.Text != textBox3.Text)
            {
                label9.Visible = true;
                label9.Text = "E-Postalar Birbirini Tutmuyor";
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
            }

            if (textBox2.Text == "" && textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                label9.Visible = false;
            }
            if (textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                label9.Visible = false;
            }
            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.White;
                label9.Visible = false;
                textBox3.BackColor = Color.White;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                label9.Visible = false;
                textBox2.BackColor = Color.Green;
                textBox3.BackColor = Color.Green;
            }
            else if (textBox2.Text != textBox3.Text)
            {
                label9.Visible = true;
                label9.Text = "E-Postalar Birbirini Tutmuyor";
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
            }

            if (textBox2.Text == "" && textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                label9.Visible = false;
            }
            if (textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                label9.Visible = false;
            }
            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.White;
                label9.Visible = false;
                textBox3.BackColor = Color.White;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == textBox5.Text)
            {
                label11.Visible = false;
                textBox5.BackColor = Color.Green;
                textBox6.BackColor = Color.Green;
            }
            else if (textBox6.Text != textBox5.Text)
            {
                label11.Visible = true;
                label11.Text = "E-Postalar Birbirini Tutmuyor";
                textBox5.BackColor = Color.Red;
                textBox6.BackColor = Color.Red;
            }
            
            if (textBox6.Text == "" && textBox5.Text == "")
            {
                textBox6.BackColor = Color.White;
                textBox6.BackColor = Color.White;
                label11.Visible = false;
            }
            if (textBox6.Text == "")
            {
                textBox5.BackColor = Color.White;
                textBox6.BackColor = Color.White;
                label11.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            string sorgu = "Select e_posta From yeniuye where no='"+bilgi.kulanıcı_denetimi.ToString()+"'";
            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku.GetString(0) == textBox4.Text)
                {
                    textBox4.BackColor = Color.Green;
                    label10.Visible = false;
                }
                else
                {
                    label10.Visible = true;
                    label10.Text = "E-Postanız Yanlış";
                    textBox4.BackColor = Color.Red;
                }
            }
            if (textBox4.Text == "")
            {
                textBox4.BackColor = Color.White;
                label10.Visible = false;
            }
            connect.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut2 = new SqlCommand("Update yeniuye Set sifre='" + textBox3.Text + "'where no='" + bilgi.kulanıcı_denetimi.ToString() + "'", connect);
            if (textBox1.BackColor == Color.Green && textBox2.BackColor == Color.Green && textBox3.BackColor == Color.Green)
            {
                komut2.ExecuteNonQuery();
                MessageBox.Show("Şifreniz Değiştirildi");
            }
            connect.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut2 = new SqlCommand("Update yeniuye Set e_posta='" + textBox6.Text + "'where no='" + bilgi.kulanıcı_denetimi.ToString() + "'", connect);
            if (textBox4.BackColor == Color.Green && textBox5.BackColor == Color.Green && textBox6.BackColor == Color.Green)
            {
                komut2.ExecuteNonQuery();
                MessageBox.Show("E-Postanız Değiştirildi");
            }
            connect.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (textBox6.Text == textBox5.Text)
            {
                label11.Visible = false;
                textBox5.BackColor = Color.Green;
                textBox6.BackColor = Color.Green;
            }
            else if (textBox6.Text != textBox5.Text)
            {
                label11.Visible = true;
                label11.Text = "E-Postalar Birbirini Tutmuyor";
                textBox5.BackColor = Color.Red;
                textBox6.BackColor = Color.Red;
            }

            if (textBox6.Text == "" && textBox5.Text == "")
            {
                textBox6.BackColor = Color.White;
                textBox6.BackColor = Color.White;
                label11.Visible = false;
            }
            if (textBox6.Text == "")
            {
                textBox5.BackColor = Color.White;
                textBox6.BackColor = Color.White;
                label11.Visible = false;
            }
            if (textBox5.Text == "")
            {
                textBox5.BackColor = Color.White;
                label11.Visible = false;
                textBox6.BackColor = Color.White;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.UseSystemPasswordChar = false;
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("Update yeniuye Set ad='" + textBox7.Text + "'where no='" + bilgi.kulanıcı_denetimi.ToString() + "'", connect);
            komut.ExecuteNonQuery();
            MessageBox.Show("İsminiz Değiştirildi");
            textBox7.Clear();
            connect.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("Update yeniuye Set soyad='" + textBox8.Text + "'where no='"+bilgi.kulanıcı_denetimi.ToString()+"'", connect);
            komut.ExecuteNonQuery();
            MessageBox.Show("Soyadınız Değiştirildi");
            textBox8.Clear();
            connect.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("Update yeniuye Set kullanici_adi='" + textBox9.Text + "'where no='" + bilgi.kulanıcı_denetimi.ToString() + "'", connect);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı Adınız Değiştirildi");
            textBox9.Clear();
            connect.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            linkLabel1.Text =linkLabel1.Text+".";
            if (linkLabel1.Text == "YÜKLENİYOR..................................")
            {
                linkLabel1.Text = "YÜKLENİYOR";
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                linkLabel1.Text = "YÜKLENDİ.......................................";
                progressBar1.Style = ProgressBarStyle.Continuous;
                MessageBox.Show("Yükleme Tamamlandı.\nDevam Etmek İçin Tamam Butonuna Basınız.", "BİLDİRİ MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
