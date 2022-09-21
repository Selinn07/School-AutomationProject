using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSchool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(domainUpDown1.Text == "Student Registration")
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();

            }
            else if(domainUpDown1.Text == "Teacher Registration")
            {
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
            else if(domainUpDown1.Text == "Calculate Average")
            {
                Form4 f4 = new Form4();

                f4.label3.Text = "Midterm";
                f4.label4.Text = "Final";
                f4.button3.Visible = false;
                f4.ShowDialog();

            }
            else if(domainUpDown1.Text == "Calculate Salary")
            {
                Form4 F4 = new Form4();

                F4.label3.Text = "Working Hour";
                F4.label4.Visible = false;
                F4.textBox4.Visible = false;
                F4.button2.Visible = false;
                F4.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
