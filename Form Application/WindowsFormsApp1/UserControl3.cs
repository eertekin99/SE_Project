using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class UserControl3 : UserControl
    {
        private string CONNECTION_STRING;

        public UserControl3()
        {
            InitializeComponent();
            string branches = "SELECT * FROM(Branch)";
            string deliverers = "SELECT * FROM(Deliverer)";
            string branchemployees = "SELECT * FROM(BranchEmployee)";
            db_to_combo(branches, 3);
            db_to_combo(deliverers, 2);
            db_to_combo(branchemployees, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Type = "";
            bool x = radioButton1.Checked;
            bool y = radioButton2.Checked;
            if (x)
            {
                Type = "Fragiled";
            }
            else
            {
                Type = "Not Fragiled";
            }

            //combobox3 = textbox2
            //combobox2 = textbox4
            //combobox4 = textbox3

            String ReceiverAdress = textBox1.Text;

            String BranchID = comboBox3.Text;
            String DelivererID = comboBox2.Text;
            String BranchEmpID = comboBox4.Text;

            String Cost = textBox6.Text;
            String DateDelivered = maskedTextBox1.Text;
            String EstimatedDate = maskedTextBox2.Text;
            String description = richTextBox1.Text;
            String SenderID = textBox5.Text;
            String paymentType = comboBox1.Text;
            String ReceiverId = textBox7.Text;
            String Weight = textBox8.Text;

           



            string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
            MySqlConnection con = new MySqlConnection(ConString);


            
            string CmdString20 = "Select ID from Branch where Branch.Name = '" + BranchID + "'";
            MySqlCommand MyCommand20 = new MySqlCommand(CmdString20, con);
            MySqlDataReader MyReader20;
            con.Open();
            MyReader20 = MyCommand20.ExecuteReader();
            while (MyReader20.Read())
            {
                BranchID = MyReader20[0].ToString();
            }
            MyReader20.Close();
            



            string CmdString = "INSERT INTO Bill(Sender_ID,Payment_Type,Cost)VALUES("+SenderID+", '"+paymentType+"',"+Cost+")";
                MySqlCommand MyCommand2 = new MySqlCommand(CmdString, con);
                MySqlDataReader MyReader2;
                //con.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {

                }
                MyReader2.Close();

                String command = "SELECT ID FROM (Bill)";
                MySqlCommand MyCommand3 = new MySqlCommand(command, con);
                MySqlDataReader MyReader3;
                MyReader3 = MyCommand3.ExecuteReader();
                String BillID = "";
                while (MyReader3.Read())
                {
                    BillID = MyReader3[0].ToString();
                }
                MyReader3.Close();

                string CmdString2 = "INSERT INTO Cargo(Deliverer_ID, Br_Employee_ID, Status, Type, Description, Senders_Delivery_Date, Delivery_Date, Bill_ID, Receiver_Address,Sender_ID,Receiver_ID,Weight) Values(" + DelivererID+","+BranchEmpID+",'Not Delivered','"+Type+"','"+description+"','"+DateDelivered+"','"+EstimatedDate+"',"+BillID+",'"+ReceiverAdress+"',"+SenderID+","+ReceiverId+ "," + Weight +")";
                MySqlCommand MyCommand4 = new MySqlCommand(CmdString2, con);
                MySqlDataReader MyReader4;
                MyReader4 = MyCommand4.ExecuteReader();
                while (MyReader4.Read())
                {

                }
                MyReader4.Close();

            String command1 = "SELECT ID FROM (Cargo)";
            MySqlCommand MyCommand5 = new MySqlCommand(command1, con);
            MySqlDataReader MyReader5;
            MyReader5 = MyCommand5.ExecuteReader();
            String ID = "";
            while (MyReader5.Read())
            {
                ID = MyReader5[0].ToString();
            }
            MyReader5.Close();

            String command6 = "SELECT Location FROM (Branch) WHERE Branch.ID= "+ BranchID;
            MySqlCommand MyCommand9 = new MySqlCommand(command6, con);
            MySqlDataReader MyReader9;
            MyReader9 = MyCommand9.ExecuteReader();
            String Branch_Loc = "";
            while (MyReader9.Read())
            {
                Branch_Loc = MyReader9[0].ToString();
            }
            MyReader9.Close();

            string CmdString3 = "INSERT INTO at(Branch_ID, Branch_Location, Cargo_ID, Received) VALUES(" + BranchID+",'"+Branch_Loc+"',"+ID+",'"+DateDelivered+"')";
            MySqlCommand MyCommand6 = new MySqlCommand(CmdString3, con);
            MySqlDataReader MyReader6;
            MyReader6 = MyCommand6.ExecuteReader();
            while (MyReader6.Read())
            {

            }
            MyReader6.Close();
            con.Close();

            MessageBox.Show("Cargo Added and Cargo's ID = "+ ID);


        }


        public void db_to_combo(String CmdString, int num)
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
                    if(num == 3)
                        comboBox3.Items.Add(MyReader2.GetString("Name"));
                    if(num == 2)
                        comboBox2.Items.Add(MyReader2.GetString("ID"));
                    if(num == 4)
                        comboBox4.Items.Add(MyReader2.GetString("ID"));
                }
                MyReader2.Close();

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textbox2
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textbox4
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textbox3
        }
    }



}
