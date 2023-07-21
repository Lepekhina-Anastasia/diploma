using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            Login.Text = "Введите логин";
            PassField.Text = "Введите пароль";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
            
                return;}
            if (PassField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");

                return;
            }
            string login = Login.Text;
            string pass = PassField.Text;

            DB db = new DB();

            DataTable table=new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `lab_worker` WHERE `login`=@lo AND `pass`=@pa",db.getConnection());
            command.Parameters.Add("@lo",MySqlDbType.VarChar).Value=login;
            command.Parameters.Add("@pa", MySqlDbType.VarChar).Value = pass;
           
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Form1 form1 = new Form1();
                form1.Show();
                Form4 fm4;
                fm4 =new Form4();
                Class2.text=Login.Text;

            }
            else
                MessageBox.Show("Данный пользователь не найден");

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Введите логин")
                Login.Text = "";
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
                PassField.Text = "";
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
                Login.Text = "Введите логин";
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
                PassField.Text = "Введите пароль";
        }
    }
}
