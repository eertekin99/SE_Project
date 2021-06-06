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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            String CustomerID = textBox1.Text;
            String Type = comboBox1.Text;

            try
            {
                string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
                MySqlConnection con = new MySqlConnection(ConString);

                if (Type.Equals("Sender")) {

                    string CmdString = "SELECT Cargo.ID, Customer.Name,Cargo.Delivery_Date,Cost FROM ((Customer JOIN Sender ON Sender.ID=Customer.ID)JOIN Cargo ON Cargo.Sender_ID=Sender.ID)JOIN Bill ON Cargo.Bill_ID=Bill.ID WHERE Sender.ID =" + CustomerID + "";
                    MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }

                else if (Type.Equals("Receiver"))
                {
                    string CmdString = "SELECT Cargo.ID, Customer.Name,Cargo.Delivery_Date FROM (Customer JOIN Receiver ON Receiver.ID=Customer.ID)JOIN Cargo ON Cargo.Receiver_ID=Receiver.ID WHERE Receiver.ID=" + CustomerID +"";
                    MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }

                else
                {
                    MessageBox.Show("Give all inputs.");
                }

            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }



        }
    }
}
