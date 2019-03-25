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
    public partial class Form5 : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=AREL\\SQLEXPRESS;Initial Catalog=proje1;Integrated security=true");
        DataSet veriseti;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proje1DataSet.yeniuye' table. You can move, or remove it, as needed.
            this.yeniuyeTableAdapter.Fill(this.proje1DataSet.yeniuye);
            veriseti = new DataSet();
        }
    }
}
