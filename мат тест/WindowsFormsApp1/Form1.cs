using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int value;
        int value1;
        int value2;
        int value3;
        int value4;
        int value5;
        int value6;
        int value7;
        int i = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Тест
        {
            Random rnd = new Random();
            value = rnd.Next(1, 101);
            value1 = rnd.Next(1, 101);
            value2 = rnd.Next(1, 101);
            value3 = rnd.Next(1, 101);
            value4 = rnd.Next(1, 101);
            value5 = rnd.Next(1, 101);
            value6 = rnd.Next(1, 101);
            value7 = rnd.Next(1, 101);

            label1.Text = value.ToString();
            label3.Text = value1.ToString();
            label4.Text = value2.ToString();
            label6.Text = value3.ToString();
            label7.Text = value4.ToString();
            label9.Text = value5.ToString();
            label10.Text = value6.ToString();
            label12.Text = value7.ToString();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label17.Text = "Не проверено";
            label18.Text = "Не проверено";
            label19.Text = "Не проверено";
            label20.Text = "Не проверено";
            label23.Text = "Не определена";

            timer1.Enabled = true;
            i = 60;
            label24.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e) // Проверить
        {
            timer1.Stop();

            int grade = 5;

            string eve = textBox1.Text;
            if (eve == "")
            {
                eve = "0";
            }
            else
            {
                eve = textBox1.Text;
            }
            int a = Convert.ToInt32(eve);
            int aa = value + value1;
            if (aa == a)
            {
                label17.Text = "Верно!";
            }
            else if (aa != a)
            {
                label17.Text = "Неверно:" + aa;
                grade -= 1;
            }

            string ler = textBox2.Text;
            if(ler == "")
            {
                ler = "0";
            }
            else
            {
                ler = textBox2.Text;
            }
            int b = Convert.ToInt32(ler);
            int bb = value2 - value3;
            if (bb == b)
            {
                label18.Text = "Верно!";
            }
            else if (bb != b)
            {
                label18.Text = "Неверно:" + bb;
                grade -= 1;
            }

            string nas = textBox3.Text;
            if (nas == "")
            {
                nas = "0";
            }
            else
            {
                nas = textBox3.Text;
            }
            int c = Convert.ToInt32(nas);
            int cc = value4 * value5;
            if (cc == c)
            {
                label19.Text = "Верно!";
            }
            else if (cc != c)
            {
                label19.Text = "Неверно:" + cc;
                grade -= 1;
            }

            string yur = textBox4.Text;
            if (yur == "")
            {
                yur = "-324";
            }
            else
            {
                yur = textBox4.Text;
            }
            int d = Convert.ToInt32(yur);
            int dd = value6 / value7;
            if (dd == d)
            {
                label20.Text = "Верно!";
            }
            else if (dd != d)
            {
                label20.Text = "Неверно:" + dd;
                grade -= 1;
            }

            label23.Text = grade.ToString();

            if (grade == 5)
            {
                MessageBox.Show("Ваша оценка 5");
            }
            if (grade == 4)
            {
                MessageBox.Show("Ваша оценка 4");
            }
            if (grade == 3)
            {
                MessageBox.Show("Ваша оценка 3");
            }
            if (grade == 2)
            {
                MessageBox.Show("Ваша оценка 2");
            }
            if (grade == 1)
            {
                MessageBox.Show("Ваша оценка 1");
            }
        }

        private void button3_Click(object sender, EventArgs e) //Выход
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            label24.Text = i.ToString();
            if (i == 0)
            {
                button2_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
