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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text); // Let's assume the hourly earnings are 100 TL. //weekly
            int d = 4 * (a * 100);//monthly

            MessageBox.Show(string.Format("{0} {1} SALARY: {2}", textBox1.Text, textBox2.Text,d ));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            int y = int.Parse(textBox4.Text);
            int ort = (((x * 40) / 100) + ((y * 60) / 100));

            MessageBox.Show(string.Format("{0} {1} AVERAGE: {2}", textBox1.Text, textBox2.Text, ort));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
