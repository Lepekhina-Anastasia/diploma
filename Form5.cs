using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet11.Лаб_работники". При необходимости она может быть перемещена или удалена.
            this.лаб_работникиTableAdapter.Fill(this.database1DataSet11.Лаб_работники);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost; port=7125; username=root; password=root;Database=itproger");
            MySqlCommand command;
            MySqlDataReader mrd;
            connection.Open();
            string Name = textBox1.Text;
            string selectQuery = "SELECT * From itproger.history WHERE Name='" + Name + "'or LOT='" + Name + "'";
            command = new MySqlCommand(selectQuery, connection);
            mrd = command.ExecuteReader();
            if (mrd.Read())
            {

                UserNameBox.Text = mrd.GetString("Name");
                LOTBox.Text = mrd.GetString("LOT");
                ActionBox.Text = mrd.GetString("Action");
                DateBox.Text = mrd.GetString("Time");
                QuantityBox.Text = mrd.GetString("Quantity");
                
            }
            else
            {
                MessageBox.Show("Не найдено.");
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder(); // создаём "раскодирование изображения"
            textBox1.Text = (decoder.decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog(); //  load будет запрашивать у пользователя место, из которого он хочет загрузить файл.
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK) // //если пользователь нажимает в обозревателе кнопку "Открыть".
            {
                pictureBox1.ImageLocation = load.FileName; // в pictureBox'e открывается файл, который был по пути, запрошенном пользователем.

            }
        }
    }
}
