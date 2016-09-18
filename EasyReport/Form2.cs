using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Sesija;


namespace EasyReport
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (reportViewer1.Visible==false) {
                // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
                this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
                // TODO: This line of code loads data into the 'EasyReportDataSet.zaposlenici_projekti' table. You can move, or remove it, as needed.
                this.zaposlenici_projektiTableAdapter.Fill(this.EasyReportDataSet.zaposlenici_projekti);
                // TODO: This line of code loads data into the 'EasyReportDataSet.projekti' table. You can move, or remove it, as needed.
                this.projektiTableAdapter.Fill(this.EasyReportDataSet.projekti);
                this.reportViewer1.RefreshReport();
                reportViewer1.Show();
            }
            else reportViewer1.Hide();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Projekti_zaposlenici pz = new Projekti_zaposlenici();
                pz.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
