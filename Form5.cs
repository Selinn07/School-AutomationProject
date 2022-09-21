using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectSchool
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            kayitlari_getir();
        }

        static string constring = ("Data Source=LAPTOP-M4HCOH0R\\SELIN;Initial Catalog=School;Integrated Security=True");

        SqlConnection baglan = new SqlConnection(constring);


        public void kayitlari_getir()
        {

            string getir = "Select * From Teacher";

            SqlCommand komut = new SqlCommand(getir, baglan);

            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    String kayit = "insert into Teacher (name,surname,lessonID,workingHour,userName,password,email)values(@name,@surname,@lessonID,@workingHour,@userName,@password,@email)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);

                    komut.Parameters.AddWithValue("@name", textBox1.Text);
                    komut.Parameters.AddWithValue("@surname", textBox2.Text);
                    komut.Parameters.AddWithValue("@lessonID", textBox3.Text);
                    komut.Parameters.AddWithValue("@workingHour", textBox4.Text);
                    komut.Parameters.AddWithValue("@userName", textBox5.Text);
                    komut.Parameters.AddWithValue("@password", textBox6.Text);
                    komut.Parameters.AddWithValue("@email", textBox7.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt ekleme işlemi başarılı");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata var!" + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitlari_getir();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
        public void verisil(int id)
        {
            string sil = "Delete from Teacher where teacherID = @id";

            SqlCommand komut = new SqlCommand(sil, baglan);
            baglan.Open();
            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                kayitlari_getir();
            }
        }       
    }
}
