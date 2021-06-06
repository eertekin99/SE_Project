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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = radioButton1.Checked;
            bool y = radioButton2.Checked;
            String name = textBox1.Text;
            String Address = textBox2.Text;
            String Email = textBox4.Text;
            String phone = maskedTextBox1.Text;
            if (x)
            {         
                string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
                MySqlConnection con = new MySqlConnection(ConString);

                try
                {
                    string CmdString = "INSERT INTO Customer(Name,Mobile_Phone,Address,Email,Type) VALUES ('" + name + "'," + phone + ",'" + Address + "','" + Email + "','Sender')";
                    MySqlCommand MyCommand2 = new MySqlCommand(CmdString, con);
                    MySqlDataReader MyReader2;
                    con.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {

                    }

                    MyReader2.Close();

                }
                catch { }



                String command = "Select ID from Customer WHERE Mobile_Phone = " + phone + " and Name = '" + name + "'";
                MySqlCommand MyCommand3 = new MySqlCommand(command, con);
                MySqlDataReader MyReader3;
                MyReader3 = MyCommand3.ExecuteReader();
                String asd = "";
                while (MyReader3.Read())
                {
                    asd = MyReader3[0].ToString();
                }
                MyReader3.Close();

                string CmdString2 = "INSERT INTO Sender VALUES ("+asd+")";
                MySqlCommand MyCommand4 = new MySqlCommand(CmdString2, con);
                MySqlDataReader MyReader4;
                MyReader4 = MyCommand4.ExecuteReader();
                while (MyReader4.Read())
                {

                }
                MyReader4.Close();
                con.Close();
                MessageBox.Show("Customer Added and Customer ID = "+ asd);









                /*MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
                sda.SelectCommand = MyCommand3;
                DataTable dTable = new DataTable();
                sda.Fill(dTable);
                String x = dTable.*/

            }
            else if(y)
            {
                string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
                MySqlConnection con = new MySqlConnection(ConString);


                try {
                string CmdString = "INSERT INTO Customer(Name,Mobile_Phone,Address,Email,Type) VALUES ('" + name + "'," + phone + ",'" + Address + "','" + Email + "','Receiver')";
                MySqlCommand MyCommand2 = new MySqlCommand(CmdString, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {

                }
                MyReader2.Close();
                }
                catch
                {

                }

                String command = "Select ID from Customer WHERE Mobile_Phone = " + phone + " and Name = '" + name + "'";
                MySqlCommand MyCommand3 = new MySqlCommand(command, con);
                MySqlDataReader MyReader3;
                MyReader3 = MyCommand3.ExecuteReader();
                String asd = "";
                while (MyReader3.Read())
                {
                    asd = MyReader3[0].ToString();
                }
                MyReader3.Close();
                string CmdString2 = "INSERT INTO Receiver VALUES (" + asd + ")";
                MySqlCommand MyCommand4 = new MySqlCommand(CmdString2, con);
                MySqlDataReader MyReader4;
                MyReader4 = MyCommand4.ExecuteReader();
                while (MyReader4.Read())
                {

                }
                MyReader4.Close();
                con.Close();
                MessageBox.Show("Customer Added");


            }
            else
            {
                MessageBox.Show("please pick one type");
            }
        }
    }
}
