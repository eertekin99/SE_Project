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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
            string branches = "SELECT * FROM(Branch)";
            db_to_combo(branches);
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Type = "";
            String CargoID = textBox1.Text;
            String NewBranchID = comboBox2.Text;
            String Date = maskedTextBox1.Text;


            string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
            MySqlConnection con = new MySqlConnection(ConString);


            string CmdString20 = "Select ID from Branch where Branch.Name = '" + NewBranchID + "'";
            MySqlCommand MyCommand20 = new MySqlCommand(CmdString20, con);
            MySqlDataReader MyReader20;
            con.Open();
            MyReader20 = MyCommand20.ExecuteReader();
            while (MyReader20.Read())
            {
                NewBranchID = MyReader20[0].ToString();
            }
            MyReader20.Close();



            String command6 = "SELECT Location FROM (Branch) WHERE Branch.ID=" + NewBranchID;
            MySqlCommand MyCommand9 = new MySqlCommand(command6, con);
            MySqlDataReader MyReader9;
            //con.Open();
            MyReader9 = MyCommand9.ExecuteReader();
            String Branch_Loc = "";
            while (MyReader9.Read())
            {
                Branch_Loc = MyReader9[0].ToString();
            }
            MyReader9.Close();





            string CmdString = "INSERT INTO at(Branch_ID, Branch_Location, Cargo_ID, Received) VALUES(" + NewBranchID + ",'" + Branch_Loc + "'," + CargoID + ",'" + Date + "')";

            MySqlCommand MyCommand2 = new MySqlCommand(CmdString, con);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();

            while (MyReader2.Read())
            {

            }
            MyReader2.Close();
            



            MessageBox.Show("Cargo Location Updated!");
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
                   
                    comboBox2.Items.Add(MyReader2.GetString("Name"));
                    
                }
                MyReader2.Close();

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            String Type = "";
            String CargoID = textBox4.Text;
            String Status = comboBox1.Text;


            string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
            MySqlConnection con = new MySqlConnection(ConString);



            String command6 = "UPDATE Cargo SET Cargo.Status = '"+ Status +"' WHERE Cargo.ID = "+ CargoID +"";
            MySqlCommand MyCommand9 = new MySqlCommand(command6, con);
            MySqlDataReader MyReader9;
            con.Open();
            MyReader9 = MyCommand9.ExecuteReader();
            while (MyReader9.Read())
            {
               
            }
            MyReader9.Close();




            MessageBox.Show("Cargo Status Updated!");


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
