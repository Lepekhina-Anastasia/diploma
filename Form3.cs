using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Project1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection("server=localhost; port=7125; username=root; password=root;Database=itproger");
            MySqlCommand command;
            MySqlDataReader mrd;


            Login3.Text = Class2.text;
            connection.Open();
            string Log = Login3.Text;
            string selectQuery = "SELECT * From itproger.lab_worker WHERE login='" + Log + "'";
            command = new MySqlCommand(selectQuery, connection);
            mrd = command.ExecuteReader();
            if (mrd.Read())
            {

                Surname.Text = mrd.GetString("Name");
            }
            connection.Close();
            REFfield.Text = "Введите REF";
            LOTfield.Text = "Введите LOT";
            Namefield.Text = "Введите название";
            Positionfield.Text = "Введите позицию";
            Samples_quantityfield.Text= "Введите количество проб";
            Expiration_datefield.Text = "2001-01-01";
            Packingfield.Text = " ";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Packingfield.Items.AddRange(new string[] {  });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LOTfield.Text=="Введите LOT")
            {
                MessageBox.Show("Введите LOT");
                return;
            }
            if (Namefield.Text == "Введите название")
            {
                MessageBox.Show("Введите название");
                return;
            }
            if (REFfield.Text == "Введите REF")
            {
                MessageBox.Show("Введите REF");
                return;
            }
            if (Positionfield.Text == "Введите количество проб")
            {
                MessageBox.Show("Введите количество проб");
                return;
            }
            if (Expiration_datefield.Text == "2001-01-01")
            {
                MessageBox.Show("Введите срок годности");
                return;
            }
            if (Samples_quantityfield.Text == "Введите количество проб")
            {
                MessageBox.Show("Введите количество проб");
                return;
            }
            if (Packingfield.Text == " ")
            {
                MessageBox.Show("Выберите фасовку");
                return;
            }


            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `reagents` (`LOT`, `Name`, `REF`, `Position`, `Expiration_date`, `Samples_quantity`, `Packing`) VALUES (@LOT,@name,@REF,@position,@exp_date,@samp_quantity,@packing)", db.getConnection());
            command.Parameters.Add("@LOT",MySqlDbType.VarChar).Value=LOTfield.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Namefield.Text;
            command.Parameters.Add("@REF", MySqlDbType.VarChar).Value = REFfield.Text;
            command.Parameters.Add("@position", MySqlDbType.VarChar).Value = Positionfield.Text;
            command.Parameters.Add("@exp_date", MySqlDbType.Date).Value = Expiration_datefield.Text;
            command.Parameters.Add("@samp_quantity", MySqlDbType.Int16).Value = Samples_quantityfield.Text;
            command.Parameters.Add("@packing", MySqlDbType.VarChar).Value = Packingfield.Text;

            MySqlCommand command1 = new MySqlCommand("INSERT INTO `history` (`LOT`, `Name`, `Action`, `Quantity`, `Time`) VALUES (@LOT,@nam,@action,@quantity, @tim)", db.getConnection());
            command1.Parameters.Add("@LOT", MySqlDbType.VarChar).Value = LOTfield.Text;
            command1.Parameters.Add("@nam", MySqlDbType.VarChar).Value = Surname.Text;
            command1.Parameters.Add("@action", MySqlDbType.VarChar).Value = "Добавил";
            command1.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = Samples_quantityfield.Text;
            command1.Parameters.Add("@tim", MySqlDbType.VarChar).Value = sqlFormattedDate;



            db.OpenConnection();
            
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Реагент добавлен");
            else
                MessageBox.Show("Реагент не добавлен");
            if (command1.ExecuteNonQuery() == 1)
                MessageBox.Show("История обновлена");

            db.CloseConnection();

            SaveFileDialog save = new SaveFileDialog(); // save будет запрашивать у пользователя, место, в которое он захочет сохранить файл. 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; //создаём фильтр, который определяет, в каких форматах мы сможем сохранить нашу информацию. В данном случае выбираем форматы изображений. Записывается так: "название_формата_в обозревателе|*.расширение_формата")
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "Сохранить".
            {
                pictureBox1.Image.Save(save.FileName); //изображение из pictureBox'a сохраняется под именем, которое введёт пользователь
            }
        }


        private void REFfield_TextChanged(object sender, EventArgs e)
        {
           
        }

       

        private void REFfield_Enter(object sender, EventArgs e)
        {
            if (REFfield.Text == "Введите REF")
                REFfield.Text = "";


        }
        private void REFfield_Leave(object sender, EventArgs e)
        {
            if (REFfield.Text == "")
                REFfield.Text = "Введите REF";
        }

        
        private void Samples_Quantityfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void Namefield_Enter(object sender, EventArgs e)
        {
            if (Namefield.Text == "Введите название")
                Namefield.Text = "";
        }

        private void Namefield_Leave(object sender, EventArgs e)
        {
            if (Namefield.Text == "")
                Namefield.Text = "Введите название";
        }

        private void LOTfield_Enter(object sender, EventArgs e)
        {
            if (LOTfield.Text == "Введите LOT")
                LOTfield.Text = "";
        }

        private void LOTfield_Leave(object sender, EventArgs e)
        {
            if (LOTfield.Text == "")
                LOTfield.Text = "Введите LOT";
        }

        private void Positionfield_Enter(object sender, EventArgs e)
        {
            if (Positionfield.Text == "Введите позицию")
                Positionfield.Text = "";
        }

        private void Positionfield_Leave(object sender, EventArgs e)
        {
            if (Positionfield.Text == "")
                Positionfield.Text = "Введите позицию";
        }

        private void Expiration_datefield_Enter(object sender, EventArgs e)
        {
            if (Expiration_datefield.Text == "2001-01-01")
                Expiration_datefield.Text = "";
        }

        private void Expiration_datefield_Leave(object sender, EventArgs e)
        {
            if (Expiration_datefield.Text == "")
                Expiration_datefield.Text = "2001-01-01";
        }

        private void Samples_quantityfield_Enter(object sender, EventArgs e)
        {
            if (Samples_quantityfield.Text == "Введите количество проб")
                Samples_quantityfield.Text = "";
        }

        private void Samples_quantityfield_Leave(object sender, EventArgs e)
        {
            if (Samples_quantityfield.Text == "")
                Samples_quantityfield.Text = "Введите количество проб";
        }


        public Boolean check()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `reagents` (`LOT`, `Name`, `REF`, `Position`, `Expiration date`, `Samples quantity`, `Packing`) VALUES (@LOT,@name,@REF,@position,@exp_date,@samp_quantity,@packing)", db.getConnection());
            command.Parameters.Add("@LOT", MySqlDbType.VarChar).Value = LOTfield.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Namefield.Text;
            command.Parameters.Add("@REF", MySqlDbType.VarChar).Value = REFfield.Text;
            command.Parameters.Add("@position", MySqlDbType.VarChar).Value = Positionfield.Text;
            command.Parameters.Add("@exp_date", MySqlDbType.Date).Value = Expiration_datefield.Text;
            command.Parameters.Add("@samp_quantity", MySqlDbType.Int16).Value = Samples_quantityfield.Text;
            command.Parameters.Add("@packing", MySqlDbType.VarChar).Value = Packingfield.Text;
           
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данные о реагенте есть в базе");
                return true;
            }
            else
                return false;
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
            string qrtext = LOTfield.Text; //считываем текст из TextBox'a
            QRCodeEncoder encoder = new QRCodeEncoder(); //создаем объект класса QRCodeEncoder
            Bitmap qrcode = encoder.Encode(qrtext); // кодируем слово, полученное из TextBox'a (qrtext) в переменную qrcode. класса Bitmap(класс, который используется для работы с изображениями)
            pictureBox1.Image = qrcode as Image; // pictureBox выводит qrcode как изображение.

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
