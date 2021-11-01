using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            // || or
            // && and

            logindemo();

        }

        private void logindemo()
        {
            if (txtname.Text == "admin" && txtpass.Text == "admin")
            {

                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
