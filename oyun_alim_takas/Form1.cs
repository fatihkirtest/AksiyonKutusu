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
    public partial class Form1 : Form
    {
        //SqlConnection connect = new SqlConnection("Data Source=FATIH-DELL\\SQLEXPRESS;Initial Catalog=proje1;Integrated Security=true");
          SqlConnection connect = new SqlConnection("Data Source=FATIH-DELL;Initial Catalog=proje1;Integrated Security=true");
        int i = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Text = "Her yılın bulunduğumuz döneminde ortaya çıkan Call Of Duty\n Xbox One lansmanında yeni oyunuyla kendini gösterdi.Tamamen\n yeni nesil grafiklerle hazırlanan Call Of Duty: Ghost farklı karakterleri\n ve bambaşka bir evreni konu alacak. Ghosts adlı özel bir ekibin üyesi\n olacağımız yapımda, bambaşka bir maceraya atılacağız.\nYapımın ileride çıkacak olan indirilebilir içerikleri bir süreliğine Xbox One'a\n özel olacak. Bu sürenin ne kadar olduğu ise belirtilmiş değil. Ayrıca oyun\n yine ilk olarak Xbox One konsoluna çıkışını yapacak.";
            linkLabel3.Text = "Cod Ghost Yayımlanan İlk Fragman İçin Tıklayınız";
            label10.Text = "  Xbox One'ın duyurusundan önce oldukça kafa karıştırıcı\n haberlerle karşımıza çıkan Battlefield\n cephesinde işler netlik kazandı.\n Battlefield 4'ün çıkış tarihi ve çıkacağı\n platformlar belli oldu.Yapılan açıklamalara göre Battlefield 4\n 29 Ekim 2013 tarihinde piyasaya sunulacak.\n Oyun hem bu nesil hem de gelecek nesil platformlar olmak üzere\n PC, PS3, Xbox 360, PS4 ve Xbox One için rafları süsleyecek.";
            linkLabel1.Visible = false;
            button6.Visible = false;
            textBox2.UseSystemPasswordChar = true;
            label7.Visible = false;
            button5.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            pictureBox2.Visible = false;
            label3.Visible = false;
            comboBox1.Visible = false;
            linkLabel2.Visible = false;
            listBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            pictureBox1.Visible = false;
          // SqlConnection connect = new SqlConnection("Data Source=FATIH-DELL\\SQLEXPRESS;Initial Catalog=proje1;Integrated Security=true");

            SqlConnection connect = new SqlConnection("Data Source=FATIH-DELL;Initial Catalog=proje1;Integrated Security=true");
           
           /*SqlConnectionStringBuilder connecstring = new SqlConnectionStringBuilder();
           connecstring.DataSource = "FATIH-DELL";
           connecstring.InitialCatalog = "proje1";
           connecstring.Password = "";
           connecstring.UserID = "fatih-dell\fatih";
           connecstring.IntegratedSecurity = true;

           SqlConnection connect = new SqlConnection(connecstring.ConnectionString.ToString());*/
            connect.Open();
            string sorgu = "Select oyunlar From oyunlar";
            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku.GetString(0));
                comboBox2.Items.Add(oku.GetString(0));
                comboBox3.Items.Add(oku.GetString(0));
            }
            connect.Close();
        }
        int stok = 0;
        int no = -1;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Assassin's Creed III")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Assassin's Creed III Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[0];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Assassin's Creed III Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=1";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();

            }
            else if (comboBox1.SelectedItem.ToString() == "Dead Space 3")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Dead Space 3 Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[1];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Dead Space 3 Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=2";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();


            }
            else if (comboBox1.SelectedItem.ToString() == "Hitman Absolution")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Hitman Absolution Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[2];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Hitman Absolution Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=11";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Call of Duty Black Ops 2")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Call of Duty Black Ops 2 Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[3];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Black Ops 2 Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=3";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Battlefield 3")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Battlefield 3 Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[4];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Battlefield 3 Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=4";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "God of War Ascension")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "God of War Ascension Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[5];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "God of War Ascension Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=8";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Need for Speed Most Wanted")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Need for Speed Most Wanted Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[6];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "NFS Most Wanted Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=5";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Tomb Raider")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Tomb Raider Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[7];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Tomb Raider Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=6";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Crysis 3")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Crysis 3 Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[8];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Crysis 3 Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=7";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "FIFA13")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "FIFA13 Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[9];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "FIFA 13 Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=9";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Killzone 3")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Killzone 3 Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[10];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Killzone 3 Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=10";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Farcry 3")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Farcry 3 Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[11];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Farcry 3 Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=12";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Max Payne 3")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Max Payne 3 Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[12];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Max Payne 3 Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=13";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Heavy Rain")
            {
                linkLabel1.Visible = true;
                pictureBox2.Image = ımageList2.Images[0];
                button6.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label6.Visible = false;
                label4.Text = "Heavy Rain Oyuniçi Ekran Görüntüleri";
                button3.Visible = true;
                button4.Visible = true;
                pictureBox2.Visible = true;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                pictureBox1.Image = ımageList1.Images[13];
                pictureBox1.Visible = true;
                listBox1.Items.Clear();
                linkLabel2.Text = "Heavy Rain Fragman";
                connect.Open();
                string sorgu = "Select oyunlar,gelistirici,dagitici,tur,cikis_tarihi,fiyati,platform,stok,no From oyunlar where no=14";
                SqlCommand komut = new SqlCommand(sorgu, connect);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add("Oyun Adı :" + "  " + oku.GetString(0));
                    listBox1.Items.Add("Geliştirici :" + "  " + oku.GetString(1));
                    listBox1.Items.Add("Dağıtıcı :" + "  " + oku.GetString(2));
                    listBox1.Items.Add("Türü :" + "  " + oku.GetString(3));
                    listBox1.Items.Add("Çıkış Tarihi :" + "  " + oku.GetString(4));
                    listBox1.Items.Add("Fiyatı :" + "  " + oku.GetInt32(5) + "TL");
                    listBox1.Items.Add("Platform :" + "  " + oku.GetString(6));
                    stok = oku.GetInt32(7);
                    no = oku.GetInt32(8);
                }
                connect.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool dogrulama = false;
            connect.Open();
            string sorgu = "Select kullanici_adi,sifre,no From yeniuye";
            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (textBox1.Text == oku.GetString(0) && textBox2.Text == oku.GetString(1))
                {
                    dogrulama = true;
                    button5.Text = oku.GetString(0);
                    bilgi.kulanıcı_denetimi = oku.GetInt32(2).ToString();
                    break;
                }
            }
            connect.Close();
            if (dogrulama == true)
            {
                MessageBox.Show("Hoşgeldiniz Sayın" + "  " + textBox1.Text);
                yeniÜyeKaydıToolStripMenuItem.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                linkLabel3.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label7.Text = "Profilim :";
                label1.Visible = true;
                comboBox1.Visible = true;
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                button3.Visible = true;
                label5.Visible = false;
                textBox1.Visible = false;
                label6.Visible = false;
                textBox2.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
                label7.Visible = true;
                checkBox1.Visible = false;
                label8.Visible = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Battlefield 3")
            {
                if (i < 5)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 5)
                {
                    pictureBox2.Image = ımageList2.Images[5];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Assassin's Creed III")
            {
                if (i < 6)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 11)
                {
                    pictureBox2.Image = ımageList2.Images[11];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Hitman Absolution")
            {
                if (i < 11)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 5)
                {
                    pictureBox2.Image = ımageList2.Images[16];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "FIFA13")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Farcry 3")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Max Payne 3")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Heavy Rain")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Crysis 3")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "God of War Ascension")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Tomb Raider")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Dead Space 3")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Need for Speed Most Wanted")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Call of Duty Black Ops 2")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Killzone 3")
            {
                if (i < 4)
                {
                    i++;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 4)
                {
                    pictureBox2.Image = ımageList2.Images[4];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Battlefield 3")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Assassin's Creed III")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Hitman Absolution")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "FIFA13")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Farcry 3")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Max Payne")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Heavy Rain")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Crysis 3")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "God of War Ascension")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Tomb Raider")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Dead Space")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Need for Speed Most Wanted")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Call of Duty Black Ops 2")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Killzone 3")
            {
                if (i > 0)
                {
                    i--;
                    pictureBox2.Image = ımageList2.Images[i];
                }
                else if (i == 0)
                {
                    pictureBox2.Image = ımageList2.Images[0];
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Assassin's Creed III")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=-pUhraVG7Ow");
            }
            else if (comboBox1.SelectedItem.ToString() == "Dead Space 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=u5f5tOmMkLk");
            }
            else if (comboBox1.SelectedItem.ToString() == "Battlefield 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=YQiVNE7TMK4");
            }
            else if (comboBox1.SelectedItem.ToString() == "Need for Speed Most Wanted")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=0-Imb_hTVmw");
            }
            else if (comboBox1.SelectedItem.ToString() == "Call of Duty Black Ops 2")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=O-uv3r_s8iE");
            }
            else if (comboBox1.SelectedItem.ToString() == "Farcry 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=J6gnOVJsCsM");
            }
            else if (comboBox1.SelectedItem.ToString() == "Max Payne 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=-PbphJ8KMjo");
            }
            else if (comboBox1.SelectedItem.ToString() == "God of War Ascension")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=1aDhfTGkLTg");
            }
            else if (comboBox1.SelectedItem.ToString() == "Crysis 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=YQDbxCK9xLU");
            }
            else if (comboBox1.SelectedItem.ToString() == "Tomb Raider")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=xH66YdKR-rw");
            }
            else if (comboBox1.SelectedItem.ToString() == "Heavy Rain")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=451eMRoZav8");
            }
            else if (comboBox1.SelectedItem.ToString() == "Killzone 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=hrvbCkqBW5A");
            }
            else if (comboBox1.SelectedItem.ToString() == "Hitman Absolution")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=gLYEyQ4ouWE");
            }
            else if (comboBox1.SelectedItem.ToString() == "FIFA13")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=cNnmAlEnUt0");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Assassin's Creed III")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=-pUhraVG7Ow");
            }
            else if (comboBox1.SelectedItem.ToString() == "Dead Space 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=u5f5tOmMkLk");
            }
            else if (comboBox1.SelectedItem.ToString() == "Battlefield 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=YQiVNE7TMK4");
            }
            else if (comboBox1.SelectedItem.ToString() == "Need for Speed Most Wanted")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=0-Imb_hTVmw");
            }
            else if (comboBox1.SelectedItem.ToString() == "Call of Duty Black Ops 2")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=O-uv3r_s8iE");
            }
            else if (comboBox1.SelectedItem.ToString() == "Farcry 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=J6gnOVJsCsM");
            }
            else if (comboBox1.SelectedItem.ToString() == "Max Payne 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=-PbphJ8KMjo");
            }
            else if (comboBox1.SelectedItem.ToString() == "God of War Ascension")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=1aDhfTGkLTg");
            }
            else if (comboBox1.SelectedItem.ToString() == "Crysis 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=YQDbxCK9xLU");
            }
            else if (comboBox1.SelectedItem.ToString() == "Tomb Raider")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=xH66YdKR-rw");
            }
            else if (comboBox1.SelectedItem.ToString() == "Heavy Rain")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=451eMRoZav8");
            }
            else if (comboBox1.SelectedItem.ToString() == "Killzone 3")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=hrvbCkqBW5A");
            }
            else if (comboBox1.SelectedItem.ToString() == "Hitman Absolution")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=gLYEyQ4ouWE");
            }
            else if (comboBox1.SelectedItem.ToString() == "FIFA13")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=cNnmAlEnUt0");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int combo2, combo3, oyun1f = 0, oyun2f = 0;
            combo2 = (comboBox2.SelectedIndex) + 1;
            combo3 = (comboBox3.SelectedIndex) + 1;
            SqlCommand komut = new SqlCommand("select fiyati from oyunlar where no='" + combo2 + "' ", connect);
            connect.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyun1f = oku.GetInt32(0);
            }
            komut.CommandText = "select fiyati from oyunlar where no='" + combo3 + "' ";
            oku.Dispose();
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyun2f = oku.GetInt32(0);
            }
            connect.Close();

            bool esitmi = oyun1f == oyun2f;
            bool buyuk_kucuk = oyun1f < oyun2f;

            if (esitmi == true)
            {
                MessageBox.Show("Ödeyeceğiniz Miktar =  15TL");
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

                    MessageBox.Show("Ödeyeceğiniz Miktar = " + (sonuc) + " TL");
                }
                else
                {
                    int dogrulama = ((oyun1f - oyun2f) - 15);
                    if (dogrulama > 0)
                    {
                        MessageBox.Show("Alacağınız Miktar = " + dogrulama + " TL");
                    }
                    else if (dogrulama == 0)
                    {
                        MessageBox.Show("Ödeyeceğiniz Miktar =  0TL");
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
                        MessageBox.Show("Ödeyeceğiniz Miktar = " + sonuc + " TL");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
              Form3 form3 = new Form3();
              form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (stok == 0)
                MessageBox.Show("Malesef Oyun Stoğumuzda Kalmamıştır");
            else
            {
                stok -= 1;
                SqlCommand komut = new SqlCommand("update oyunlar set stok='" + stok + "' where no='"+no+"'", connect);
                connect.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Oyun Alındı Bizi Tercih Ettiğiniz İçin Teşekkürler");
                connect.Close();

            }
        }


        private void yeniÜyeKaydıToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Zxnx3W-HA18");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Zxnx3W-HA18");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=ZD9fWUUeL00");
        }
    }
}


