﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Student Transaction");
            comboBox1.Items.Add("Teacher Transaction");
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Student Transaction")
            {
                Form2 f2 = new Form2();

                f2.label1.Text = "Login to the student system";
                f2.domainUpDown1.Items.Add("Student Registration");
                f2.domainUpDown1.Items.Add("Calculate Average");
                f2.ShowDialog();
            }
            else if (comboBox1.Text == "Teacher Transaction" )
            {
                Form2 F2 = new Form2();

                F2.label1.Text = "Login to the teacher system";
                F2.domainUpDown1.Items.Add("Teacher Registration");
                F2.domainUpDown1.Items.Add("Calculate Salary");
                F2.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
