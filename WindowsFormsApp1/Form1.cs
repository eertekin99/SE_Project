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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cargo_databaseDataSet3.branch' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.branchTableAdapter.Fill(this.cargo_databaseDataSet3.branch);
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl21.Hide();
            userControl71.Hide();
            userControl61.Show();
            userControl61.BringToFront();


        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl41.Hide();
            userControl31.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl41.Hide();
            userControl31.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl71.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl41.Show();
            userControl41.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl71.Hide();
            userControl51.Show();
            userControl61.Hide();
            userControl51.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl71.Hide();
            userControl61.Show();
            userControl61.BringToFront();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Show();
            userControl71.BringToFront();
        }
    }
}
