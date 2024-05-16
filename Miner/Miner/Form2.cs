using System;
using System.Windows.Forms;

namespace Miner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем введенные данные из текстового поля
            string userInput = textBox1.Text;

            // Делаем что-то с полученными данными
            MessageBox.Show("Вы ввели: " + userInput);
        }
    }
}
