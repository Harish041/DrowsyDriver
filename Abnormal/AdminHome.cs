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

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Eng Project\AbnormalDriverPrediction\AbnormalDriverPrediction\Driverdb.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;

        public AdminHome()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into owntb values('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record saved!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";

        }
    }
}
