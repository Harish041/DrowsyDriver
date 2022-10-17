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
    public partial class DriverLogin : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Eng Project\AbnormalDriverPrediction\AbnormalDriverPrediction\Driverdb.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;

        public DriverLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //New_Driver nd = new New_Driver();
          //  nd.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from drivtb where  UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                //DriverHome dh = new DriverHome();
                //dh.username = textBox1.Text;
                //dh.Show();

                MessageBox.Show("Login Completed!");

            }
            else
            {

                MessageBox.Show("Password Mismatch!");

            }
            con.Close();


        }
    }
}
