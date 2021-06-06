using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
                MySqlConnection con = new MySqlConnection(ConString);
                string CmdString = "SELECT * FROM Customer";
                MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
            catch
            {
                
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
                MySqlConnection con = new MySqlConnection(ConString);
                string CmdString = "SELECT * FROM Cargo";
                MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
                MySqlConnection con = new MySqlConnection(ConString);
                string CmdString = "SELECT * FROM Branch";
                MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
                MySqlConnection con = new MySqlConnection(ConString);
                string CmdString = "SELECT * FROM Employee";
                MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
            catch
            {

            }
        }
    }
}
