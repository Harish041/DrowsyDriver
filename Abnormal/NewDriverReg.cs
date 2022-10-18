using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Abnormal
{
    public partial class NewDriverReg : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=WarningSystem;Integrated Security=True");
        SqlCommand cmd;
        public string userName;
        public NewDriverReg()
        {
            InitializeComponent();
        }

        private void NewDriverReg_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();


            con.Open();
            cmd = new SqlCommand("select * from ownertb ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CompanyName"].ToString());

            }
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from ownertb  where CompanyName='" + comboBox1.Text + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["Mobile"].ToString();
                textBox3.Text = dr["Email"].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {

                cmd = new SqlCommand("insert into drivertb values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Saved!");
                this.Close();

            }
            else
            {
                MessageBox.Show("Password Mismatch!");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userName = textBox1.Text;
        }
    }
}
