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

namespace EasyReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QDOFTEF;Initial Catalog=EasyReport;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From zaposlenici where kor_ime ='" + textBox1.Text + "' and lozinka ='" + textBox2.Text + "' and tip_zaposlenika='1'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) From zaposlenici where kor_ime ='" + textBox1.Text + "' and lozinka ='" + textBox2.Text + "' and tip_zaposlenika='3'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 admin = new Form2();
                admin.Show();
            }
            else if (dt1.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form3 user = new Form3();
                user.Show();
            }
            else
            {
                MessageBox.Show("Pogrešni podaci za prijavu", "Pogreška");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
