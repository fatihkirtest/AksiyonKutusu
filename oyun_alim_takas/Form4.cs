using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oyun_alim_takas
{
    public partial class Form4 : Form
    {
        //SqlConnection connect = new SqlConnection("Data Source=FATIH-DELL\\SQLEXPRESS;Initial Catalog=proje1;Integrated Security=true");
        SqlConnection connect = new SqlConnection("Data Source=FATIH-DELL;Initial Catalog=proje1;Integrated Security=true");
        public Form4()
        {
            InitializeComponent();
        }



        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            connect.Open();
            SqlCommand komut = new SqlCommand("Select oyunlar.oyunlar From oyunlar", connect);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku.GetString(0));
                comboBox3.Items.Add(oku.GetString(0));
                comboBox4.Items.Add(oku.GetString(0));
                comboBox5.Items.Add(oku.GetString(0));
                comboBox6.Items.Add(oku.GetString(0));
                comboBox7.Items.Add(oku.GetString(0));
                comboBox8.Items.Add(oku.GetString(0));
                comboBox9.Items.Add(oku.GetString(0));
                comboBox10.Items.Add(oku.GetString(0));
                comboBox11.Items.Add(oku.GetString(0));
            }
            connect.Close();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        int g1combo1 = -1, g1combo2 = -1, g2combo1 = -1, g2combo2 = -1, g3combo1 = -1, g3combo2 = -1, g4combo1 = -1, g4combo2 = -1, g5combo1 = -1, g5combo2 = -1;

        string c1strign = "-1";
        private void button2_Click(object sender, EventArgs e)
        {
            int oyun1f = 0;
            int oyun2f = 0;

            if (c1strign == "-1")
            {
                MessageBox.Show("Taskasta Verilecek Oyun Sayısını Seciniz");
            }
            else if (c1strign == "1")
            {
                if (g1combo1 != -1 && g1combo2 != -1)
                {
                    SqlCommand komut = new SqlCommand("select fiyati from oyunlar where no='" + g1combo1 + "' ", connect);
                    connect.Open();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun1f += oku.GetInt32(0);
                    }
                    komut.CommandText = "select fiyati from oyunlar where no='" + g1combo2+ "' ";
                    oku.Dispose();
                    oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun2f += oku.GetInt32(0);
                    }
                    connect.Close();

                    bool esitmi = oyun1f == oyun2f;
                    bool buyuk_kucuk = oyun1f < oyun2f;

                    if (esitmi == true)
                    {
                        label12.Text="Ödeyeceğiniz Miktar =  15TL";
                    }
                    else
                    {
                        if (buyuk_kucuk == true)
                        {
                            int snc = ((oyun1f - oyun2f) - 15);
                            string a = snc.ToString();
                            string sonuc = "";
                            int i = 0;
                            while (i < a.Length)
                            {
                                if ((i + 1) == a.Length)
                                    break;

                                char x = a[i + 1];
                                sonuc += x;
                                i++;
                            }

                            label12.Text="Ödeyeceğiniz Miktar = " + (sonuc) + " TL";
                        }
                        else
                        {
                            int dogrulama = ((oyun1f - oyun2f) - 15);
                            if (dogrulama > 0)
                            {
                                label12.Text="Alacağınız Miktar = " + dogrulama + " TL";
                            }
                            else if (dogrulama == 0)
                            {
                                label12.Text="Ödeyeceğiniz Miktar =  0TL";
                            }
                            else
                            {
                                string a = dogrulama.ToString();
                                string sonuc = "";
                                int i = 0;

                                while (i < a.Length)
                                {
                                    if ((i + 1) == a.Length)//i +1 a nın legthth tine esitse keser..
                                        break;

                                    char x = a[i + 1];// eger yukardaki break calışmazsa  a nın i+ 1 indexindeki degeri sonuca aktarır..ÖR(-45) sonuca dondurucegi deger(45) dir. 
                                    sonuc += x;
                                    i++;
                                }
                                label12.Text="Ödeyeceğiniz Miktar = " + sonuc + " TL";
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Doldurulması Gereken Alnalar Var");

            }


            else if (c1strign == "2")
            {
                if (g2combo1 != -1 && g1combo2 != -1 && g2combo1 != -1 && g2combo2 != -1)
                {
                    SqlCommand komut = new SqlCommand("select o1.fiyati ,o2.fiyati from oyunlar o1,oyunlar o2 where o1.no='" + g1combo1 + "'and o2.no='" + g2combo1 + "' ", connect);
                    connect.Open();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun1f += oku.GetInt32(0);
                        oyun1f += oku.GetInt32(1);
                    }
                    komut.CommandText = "select o1.fiyati ,o2.fiyati from oyunlar o1,oyunlar o2 where o1.no='" + g1combo2 + "'and o2.no='" + g2combo2 + "' ";
                    oku.Dispose();
                    oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun2f += oku.GetInt32(0);
                        oyun2f += oku.GetInt32(1);
                    }
                    connect.Close();

                    bool esitmi = oyun1f == oyun2f;
                    bool buyuk_kucuk = oyun1f < oyun2f;

                    if (esitmi == true)
                    {
                        label12.Text="Ödeyeceğiniz Miktar =  30TL";
                    }
                    else
                    {
                        if (buyuk_kucuk == true)
                        {
                            int snc = ((oyun1f - oyun2f) - 30);
                            string a = snc.ToString();
                            string sonuc = "";
                            int i = 0;
                            while (i < a.Length)
                            {
                                if ((i + 1) == a.Length)
                                    break;

                                char x = a[i + 1];
                                sonuc += x;
                                i++;
                            }

                            label12.Text="Ödeyeceğiniz Miktar = " + (sonuc) + " TL";
                        }
                        else
                        {
                            int dogrulama = ((oyun1f - oyun2f) - 30);
                            if (dogrulama > 0)
                            {
                                label12.Text="Alacağınız Miktar = " + dogrulama + " TL";
                            }
                            else if (dogrulama == 0)
                            {
                                label12.Text="Ödeyeceğiniz Miktar 0TL";
                            }
                            else
                            {
                                string a = dogrulama.ToString();
                                string sonuc = "";
                                int i = 0;

                                while (i < a.Length)
                                {
                                    if ((i + 1) == a.Length)//i +1 a nın legthth tine esitse keser..
                                        break;

                                    char x = a[i + 1];// eger yukardaki break calışmazsa  a nın i+ 1 indexindeki degeri sonuca aktarır..ÖR(-45) sonuca dondurucegi deger(45) dir. 
                                    sonuc += x;
                                    i++;
                                }
                                label12.Text="Ödeyeceğiniz< Miktar = " + sonuc + " TL";
                            }
                        }
                    }
                }
            }
            else if (c1strign == "3")
            {
                if (g3combo1 != -1 && g3combo2 != -1 && g2combo1 != -1 && g2combo2 != -1 && g1combo1 != -1 && g1combo2 != -1)
                {
                    SqlCommand komut = new SqlCommand("select o1.fiyati ,o2.fiyati,o3.fiyati from oyunlar o1,oyunlar o2,oyunlar o3 where o1.no='" + g1combo1 + "'and o2.no='" + g2combo1 + "' and o3.no='" + g3combo1 + "' ", connect);
                    connect.Open();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun1f += oku.GetInt32(0);
                        oyun1f += oku.GetInt32(1);
                        oyun1f += oku.GetInt32(2);
                    }
                    komut.CommandText = "select o1.fiyati ,o2.fiyati,o3.fiyati from oyunlar o1,oyunlar o2,oyunlar o3 where o1.no='" + g1combo2 + "'and o2.no='" + g2combo2 + "' and o3.no='" + g3combo2 + "' ";
                    oku.Dispose();
                    oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun2f += oku.GetInt32(0);
                        oyun2f += oku.GetInt32(1);
                        oyun2f += oku.GetInt32(2);
                    }
                    connect.Close();

                    bool esitmi = oyun1f == oyun2f;
                    bool buyuk_kucuk = oyun1f < oyun2f;

                    if (esitmi == true)
                    {
                        label12.Text="Ödeyeceğiniz Miktar =  15TL";
                    }
                    else
                    {
                        if (buyuk_kucuk == true)
                        {
                            int snc = ((oyun1f - oyun2f) - 45);
                            string a = snc.ToString();
                            string sonuc = "";
                            int i = 0;
                            while (i < a.Length)
                            {
                                if ((i + 1) == a.Length)
                                    break;

                                char x = a[i + 1];
                                sonuc += x;
                                i++;
                            }

                            label12.Text="Ödeyeceğiniz Miktar = " + (sonuc) + " TL";
                        }
                        else
                        {
                            int dogrulama = ((oyun1f - oyun2f) - 45);
                            if (dogrulama > 0)
                            {
                                label12.Text="Alacağınız Miktar = " + dogrulama + " TL";
                            }
                            else if (dogrulama == 0)
                            {
                                label12.Text="Ödeyeceğiniz Miktar =  0TL";
                            }
                            else
                            {
                                string a = dogrulama.ToString();
                                string sonuc = "";
                                int i = 0;

                                while (i < a.Length)
                                {
                                    if ((i + 1) == a.Length)//i +1 a nın legthth tine esitse keser..
                                        break;

                                    char x = a[i + 1];// eger yukardaki break calışmazsa  a nın i+ 1 indexindeki degeri sonuca aktarır..ÖR(-45) sonuca dondurucegi deger(45) dir. 
                                    sonuc += x;
                                    i++;
                                }
                                label12.Text="Ödeyeceğiniz Miktar = " + sonuc + " TL";
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Alacagınız Oyunu Ve Vereceginiz Oyunu Secin");
            }

            else if (c1strign == "4")
            {
                if (g4combo1 != -1 && g4combo2 != -1 && g3combo1 != -1 && g3combo2 != -1 && g2combo1 != -1 && g2combo2 != -1 && g1combo1 != -1 && g1combo2 != -1)
                {
                    SqlCommand komut = new SqlCommand("select o1.fiyati ,o2.fiyati,o3.fiyati,o4.fiyati from oyunlar o1,oyunlar o2,oyunlar o3,oyunlar o4 where o1.no='" + g1combo1 + "'and o2.no='" + g2combo1 + "' and o3.no='" + g3combo1 + "'and o4.no='" + g4combo1 + "' ", connect);
                    connect.Open();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun1f += oku.GetInt32(0);
                        oyun1f += oku.GetInt32(1);
                        oyun1f += oku.GetInt32(2);
                        oyun1f += oku.GetInt32(3);
                    }
                    komut.CommandText = "select o1.fiyati ,o2.fiyati,o3.fiyati,o4.fiyati from oyunlar o1,oyunlar o2,oyunlar o3,oyunlar o4 where o1.no='" + g1combo2 + "'and o2.no='" + g2combo2 + "' and o3.no='" + g3combo2 + "'and o4.no='" + g4combo2 + "' ";
                    oku.Dispose();
                    oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun2f += oku.GetInt32(0);
                        oyun2f += oku.GetInt32(1);
                        oyun2f += oku.GetInt32(2);
                        oyun2f += oku.GetInt32(3);
                    }
                    connect.Close();

                    bool esitmi = oyun1f == oyun2f;
                    bool buyuk_kucuk = oyun1f < oyun2f;

                    if (esitmi == true)
                    {
                        label12.Text="Ödeyeceğiniz Miktar =  15TL";
                    }
                    else
                    {
                        if (buyuk_kucuk == true)
                        {
                            int snc = ((oyun1f - oyun2f) - 60);
                            string a = snc.ToString();
                            string sonuc = "";
                            int i = 0;
                            while (i < a.Length)
                            {
                                if ((i + 1) == a.Length)
                                    break;

                                char x = a[i + 1];
                                sonuc += x;
                                i++;
                            }

                            label12.Text="Ödeyeceğiniz Miktar = " + (sonuc) + " TL";
                        }
                        else
                        {
                            int dogrulama = ((oyun1f - oyun2f) - 60);
                            if (dogrulama > 0)
                            {
                                label12.Text="Alacağınız Miktar = " + dogrulama + " TL";
                            }
                            else if (dogrulama == 0)
                            {
                                label12.Text="Ödeyeceğiniz Miktar =  0TL";
                            }
                            else
                            {
                                string a = dogrulama.ToString();
                                string sonuc = "";
                                int i = 0;

                                while (i < a.Length)
                                {
                                    if ((i + 1) == a.Length)//i +1 a nın legthth tine esitse keser..
                                        break;

                                    char x = a[i + 1];// eger yukardaki break calışmazsa  a nın i+ 1 indexindeki degeri sonuca aktarır..ÖR(-45) sonuca dondurucegi deger(45) dir. 
                                    sonuc += x;
                                    i++;
                                }
                                label12.Text="Ödeyeceğiniz Miktar = " + sonuc + " TL";
                            }
                        }
                    }

                }
                else
                    MessageBox.Show("Alacagınız Oyunu Ve Vereceginiz Oyunu Secin");
            }
            else if (c1strign == "5")
            {
                if (g1combo1 != -1 && g1combo2 != -1 && g4combo1 != -1 && g4combo2 != -1 && g3combo1 != -1 && g3combo2 != -1 && g2combo1 != -1 && g2combo2 != -1 && g1combo1 != -1 && g1combo2 != -1)
                {
                    SqlCommand komut = new SqlCommand("select o1.fiyati ,o2.fiyati,o3.fiyati,o4.fiyati,o5.fiyati from oyunlar o1,oyunlar o2,oyunlar o3,oyunlar o4,oyunlar o5 where o1.no='" + g1combo1 + "'and o2.no='" + g2combo1 + "' and o3.no='" + g3combo1 + "'and o4.no='" + g4combo1 + "'and o5.no='" + g5combo1 + "' ", connect);
                    connect.Open();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun1f += oku.GetInt32(0);
                        oyun1f += oku.GetInt32(1);
                        oyun1f += oku.GetInt32(2);
                        oyun1f += oku.GetInt32(3);
                        oyun1f += oku.GetInt32(4);
                    }
                    komut.CommandText = "select o1.fiyati ,o2.fiyati,o3.fiyati,o4.fiyati ,o5.fiyati from oyunlar o1,oyunlar o2,oyunlar o3,oyunlar o4,oyunlar o5 where o1.no='" + g1combo2 + "'and o2.no='" + g2combo2 + "' and o3.no='" + g3combo2 + "'and o4.no='" + g4combo2 + "'and o5.no='" + g5combo2 + "' ";
                    oku.Dispose();
                    oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        oyun2f += oku.GetInt32(0);

                        oyun2f += oku.GetInt32(1);
                        oyun2f += oku.GetInt32(2);
                        oyun2f += oku.GetInt32(3);
                        oyun2f += oku.GetInt32(4);
                    }
                    connect.Close();

                    bool esitmi = oyun1f == oyun2f;
                    bool buyuk_kucuk = oyun1f < oyun2f;

                    if (esitmi == true)
                    {
                        label12.Text="Ödeyeceğiniz Miktar =  15TL";
                    }
                    else
                    {
                        if (buyuk_kucuk == true)
                        {
                            int snc = ((oyun1f - oyun2f) - 75);
                            string a = snc.ToString();
                            string sonuc = "";
                            int i = 0;
                            while (i < a.Length)
                            {
                                if ((i + 1) == a.Length)
                                    break;

                                char x = a[i + 1];
                                sonuc += x;
                                i++;
                            }

                            label12.Text="Ödeyeceğiniz Miktar = " + (sonuc) + " TL";
                        }
                        else
                        {
                            int dogrulama = ((oyun1f - oyun2f) - 75);
                            if (dogrulama > 0)
                            {
                                label12.Text="Alacağınız Miktar = " + dogrulama + " TL";
                            }
                            else if (dogrulama == 0)
                            {
                                label12.Text="Ödeyeceğiniz Miktar =  0TL";
                            }
                            else
                            {
                                string a = dogrulama.ToString();
                                string sonuc = "";
                                int i = 0;

                                while (i < a.Length)
                                {
                                    if ((i + 1) == a.Length)//i +1 a nın legthth tine esitse keser..
                                        break;

                                    char x = a[i + 1];// eger yukardaki break calışmazsa  a nın i+ 1 indexindeki degeri sonuca aktarır..ÖR(-45) sonuca dondurucegi deger(45) dir. 
                                    sonuc += x;
                                    i++;
                                }
                                label12.Text="Ödeyeceğiniz Miktar = " + sonuc + " TL";
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Alacagınız Oyunu Ve Vereceginiz Oyunu Secin");
            }
            
        }
            












            
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Seçiminizi Yapınız")
            {
                c1strign = "-1";
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "1")
            {
                c1strign = "1";
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "2")
            {
                c1strign = "2";
                groupBox1.Visible =true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "3")
            {
                c1strign = "3";
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "4")
            {
                c1strign = "4";
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "5")
            {
                c1strign = "5";
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
            }

            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            g1combo1 = Convert.ToInt32(comboBox2.SelectedIndex )+ 1;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            g1combo2 = Convert.ToInt32(comboBox7.SelectedIndex) + 1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            g2combo1 = Convert.ToInt32(comboBox3.SelectedIndex) + 1;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            g2combo2 = Convert.ToInt32(comboBox8.SelectedIndex) + 1;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            g3combo1 = Convert.ToInt32(comboBox4.SelectedIndex) + 1;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            g3combo2 = Convert.ToInt32(comboBox9.SelectedIndex) + 1;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            g4combo1 = Convert.ToInt32(comboBox5.SelectedIndex) + 1;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            g4combo2 = Convert.ToInt32(comboBox10.SelectedIndex) + 1;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            g5combo1 = Convert.ToInt32(comboBox6.SelectedIndex) + 1;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            g5combo2 = Convert.ToInt32(comboBox11.SelectedIndex) + 1;
        }
    }
}

