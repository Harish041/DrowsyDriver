using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Abnormal
{
    
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" & textBox2.Text == "admin")
            {

                AdminHome ah = new AdminHome();
                ah.Show();

            }
            else
            {
                MessageBox.Show("Password Mismatch!");

            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
