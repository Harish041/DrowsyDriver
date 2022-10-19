using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Abnormal
{
    public partial class AdminHome : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=WarningSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public AdminHome()
        {
            InitializeComponent();
        }
     
      

        private void AdminHome_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Ownertbl values('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", con);
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record saved!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
    }
}
