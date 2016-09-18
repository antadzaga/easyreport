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
using Domain;
using Sesija;

namespace EasyReport
{
    public partial class Projekti_zaposlenici : Form
    {
        Spajanje s;
        Zaposlenici p;
        projekti p1;
        public Projekti_zaposlenici()
        {
            InitializeComponent();
            s = new Spajanje();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button2.Visible = true;
                comboBox1.Visible = true;
                button5.Enabled = false;
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QDOFTEF;Initial Catalog=EasyReport;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select naziv from tip_zaposlenika";
                cmd.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(dt4);
                    foreach(DataRow dr in dt4.Rows)
                {
                    comboBox1.Items.Add(dr["naziv"].ToString());

                }
                con.Close();
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button2.Visible = false;
                button5.Enabled = true;
                comboBox1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p = new Zaposlenici();
            p.Ime = textBox1.Text;
            p.Prezime = textBox2.Text;
            p.Kor_ime = textBox3.Text;
            p.Lozinka = textBox4.Text;
            if (comboBox1.SelectedItem.ToString() == "Administrator")
            {
                p.Tip_zaposlenika = 1;
            }
            else if (comboBox1.SelectedItem.ToString() == "Racunovoda")
            {
                p.Tip_zaposlenika = 2;
            }
            else if (comboBox1.SelectedItem.ToString() == "Zaposlenik")
            {
                p.Tip_zaposlenika = 3;
            }
            s.Insert(p);
            MessageBox.Show("Zaposlenik uspješno dodan", "Uspjeh");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 bb = new Form2();
            bb.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            p1 = new projekti();
            p1.Naziv = textBox1.Text;
            p1.Budzet = Convert.ToInt32(textBox2.Text);
            s.insert1(p1);
            MessageBox.Show("Novi projekt uspješno dodan", "Uspjeh");
            textBox1.Clear();
            textBox2.Clear();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void Projekti_zaposlenici_Load(object sender, EventArgs e)
        {

        }
    }
}
