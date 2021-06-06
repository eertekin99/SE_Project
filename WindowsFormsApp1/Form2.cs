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
    public partial class Form2 : Form
    {
        public String ID = "";
        public Form2(String ID_in)
        {
            ID = ID_in;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string ConString = "server=localhost;user id=root;password=12345;persistsecurityinfo=True;database=cargo_database";
            MySqlConnection con = new MySqlConnection(ConString);
            String command = "Select Cargo.ID,Sender_ID,Receiver_ID,Deliverer_ID,Br_Employee_ID,Status,Type,Description,Senders_Delivery_Date,Delivery_Date,Bill_ID,Receiver_Address,Branch_ID,Weight FROM Cargo JOIN at ON Cargo.ID = at.Cargo_ID and Cargo.ID=" + ID; 
            MySqlCommand MyCommand4 = new MySqlCommand(command, con);
            MySqlDataReader MyReader3;
            con.Open();
            MyReader3 = MyCommand4.ExecuteReader();
            String SenderName = "";
            String ReceiverAdress = "";
            String BranchID = "";
            String DelivererID = "";
            String Br_Emp_ID = "";
            String Type = "";
            String ReceiverName = "";
            String BillID = "";
            String DateDelivered = "";
            String EstimatedDate = "";
            String Description = "";
            String Status = "";
            String Weight = "";
            while (MyReader3.Read())
            {
                SenderName = MyReader3[1].ToString();
                ReceiverName= MyReader3[2].ToString();
                DelivererID= MyReader3[3].ToString();
                Br_Emp_ID= MyReader3[4].ToString();
                Status = MyReader3[5].ToString();
                Type= MyReader3[6].ToString();
                Description= MyReader3[7].ToString();
                DateDelivered= MyReader3[8].ToString();
                EstimatedDate= MyReader3[9].ToString();
                BillID= MyReader3[10].ToString();
                ReceiverAdress= MyReader3[11].ToString();
                BranchID = MyReader3[12].ToString();
                Weight = MyReader3[13].ToString();
            }
            textBox5.Text = SenderName;
            textBox1.Text = ReceiverAdress;
            textBox2.Text = BranchID;
            textBox4.Text = DelivererID;
            textBox3.Text = Br_Emp_ID;
            textBox7.Text = ReceiverName;
            textBox6.Text = BillID;
            textBox8.Text = Weight;
            maskedTextBox1.Text = DateDelivered;
            maskedTextBox2.Text = EstimatedDate;
            richTextBox1.Text = Description;
            if (Type == "Fragiled")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }






            MyReader3.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
