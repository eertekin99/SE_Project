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
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            string cargos = "SELECT ID FROM(Cargo)";
            db_to_combo(cargos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp = comboBox1.Text;

            string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
            MySqlConnection con = new MySqlConnection(ConString);

            string CmdString20 = "Select ID from Cargo where Cargo.ID = '" + temp + "'";
            MySqlCommand MyCommand20 = new MySqlCommand(CmdString20, con);
            MySqlDataReader MyReader20;
            con.Open();
            MyReader20 = MyCommand20.ExecuteReader();
            while (MyReader20.Read())
            {
        
            }
            MyReader20.Close();

            try
            {
                int a = Convert.ToInt32(temp);
                
                //string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
                //MySqlConnection con = new MySqlConnection(ConString);
                
                string CmdString = "SELECT At.Cargo_ID,At.Received ,Branch.Name,Cargo.Status FROM (Branch JOIN  At ON Branch.ID=At.Branch_ID)JOIN Cargo ON Cargo.ID=At.Cargo_ID WHERE At.Cargo_ID="+a;
                MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
            catch
            {
                MessageBox.Show("Invalid input, please enter an integer value");
            }
            
            Form2 f1 = new Form2(temp);
            f1.Show();
           
        }

        public void db_to_combo(String CmdString)
        {
            try
            {

                string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
                MySqlConnection con = new MySqlConnection(ConString);

                MySqlCommand MyCommand2 = new MySqlCommand(CmdString, con);

                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
             
                    comboBox1.Items.Add(MyReader2.GetString("ID"));
                    
                }
                MyReader2.Close();

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
