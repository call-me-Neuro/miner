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
            // �������� ��������� ������ �� ���������� ����
            string userInput = textBox1.Text;

            // ������ ���-�� � ����������� �������
            MessageBox.Show("�� �����: " + userInput);
        }
    }
}
