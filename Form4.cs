using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using MySql.Data.Types;

namespace Project1
{
    public partial class Form4 : Form
    {
        
        MySqlConnection connection = new MySqlConnection("server=localhost; port=7125; username=root; password=root;Database=itproger");
        MySqlCommand command;
        MySqlDataReader mrd;
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Form4_Load(object sender, EventArgs e)
        {
            
            Login4.Text = Class2.text;
            connection.Open();
            string Log = Login4.Text;
            MySqlCommand command;
            MySqlDataReader mrd;
            string selectQuery = "SELECT * From itproger.lab_worker WHERE login='" + Log + "'";
            command = new MySqlCommand(selectQuery, connection);
            mrd = command.ExecuteReader();
            if (mrd.Read())
            {

                Surname.Text = mrd.GetString("Name");
            }
            connection.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LOT.Text == "")
            {
                MessageBox.Show("Введите информацию о реагенте");

                return;
            }
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string lot = LOT.Text;
            int a = int.Parse(Samples.Text);
            int f = int.Parse(textBox2.Text);
            if (a<f)
            {
                MessageBox.Show("Недостаточно реагента для данного количества проб");
            }
            else { 
            int s = a - f;
                if (a<10) { MessageBox.Show("Данный реагент заканчивается."); }
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `reagents` SET `Samples_quantity`=@pa WHERE `LOT`=@lo ", db.getConnection());
            command.Parameters.Add("@lo", MySqlDbType.VarChar).Value = lot;
            command.Parameters.Add("@pa", MySqlDbType.VarChar).Value = s;

            MySqlCommand command1 = new MySqlCommand("INSERT INTO `history` (`LOT`, `Name`, `Action`, `Quantity`,`Time`) VALUES (@LOT,@nam,@action,@quantity,@ti)", db.getConnection());
            command1.Parameters.Add("@LOT", MySqlDbType.VarChar).Value = LOT.Text;
            command1.Parameters.Add("@nam", MySqlDbType.VarChar).Value = Surname.Text;
            command1.Parameters.Add("@action", MySqlDbType.VarChar).Value = "Использовал";
            command1.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = f;
            command1.Parameters.Add("@ti", MySqlDbType.VarChar).Value = sqlFormattedDate;


                db.OpenConnection();
                if (command1.ExecuteNonQuery() == 1)
                    MessageBox.Show("История обновлена");

                adapter.SelectCommand = command;
            adapter.Fill(table);
                
            

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {                
          
        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (NameFe.Text == "")
            {
                MessageBox.Show("Введите LOT или название реагента в поисковой строке");

                return;
            }
            connection.Open();
            string Name = NameFe.Text;
            string selectQuery = "SELECT * From itproger.reagents WHERE Name='" + Name+"'or LOT='"+Name+"'";
            command = new MySqlCommand(selectQuery, connection);
            mrd= command.ExecuteReader();
            if (mrd.Read())
            {

                textBoxNA.Text = mrd.GetString("Name");
                LOT.Text = mrd.GetString("LOT");
                REF.Text = mrd.GetString("REF");
                Date.Text = mrd.GetString("Expiration_date");
                Pose.Text = mrd.GetString("Position");
                Samples.Text = mrd.GetString("Samples_quantity");
                Packing.Text = mrd.GetString("Packing");
            }
            else
            {
                MessageBox.Show("Не найдено.");
            }
            connection.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog(); //  load будет запрашивать у пользователя место, из которого он хочет загрузить файл.
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK) // //если пользователь нажимает в обозревателе кнопку "Открыть".
            {
                pictureBox1.ImageLocation = load.FileName; // в pictureBox'e открывается файл, который был по пути, запрошенном пользователем.

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder(); // создаём "раскодирование изображения"
            NameFe.Text=(decoder.decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap))); //в MessageBox'e программа запишет раскодированное сообщение с изображения, которое предоврительно будет переведено из pictureBox'a в класс Bitmap, чтобы мы смогли с этим изображением работать. 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Позиция_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void Login_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
