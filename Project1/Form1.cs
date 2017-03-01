using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBox;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello C#";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 32767;
            decimal b = 1.356M;
            float pi = 3.1415F;
            int ipi = (int)pi;

            //MessageBox.Show(ipi.ToString());
            string tmpStr = "123456";
            int tmpInt = Convert.ToInt32(tmpStr);

            int tmpInt1 = int.Parse(tmpStr);
   
            //MessageBox.Show("转换后的值是：{0}",tmpInt.ToString());

            //Console.WriteLine("转换后的值是：{0}", tmpInt.ToString());

            textBox1.Text = "你点击了" + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double opr1 = 13.5;
            double opr2 = 8.23;
            double x;
            x = opr1 * opr2;
            MessageBox.Show(x.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string oper = comboBox1.Text;
            switch (oper)
            {
                case "+":
                    label2.Text = Convert.ToString(double.Parse(textBox2.Text) + double.Parse(textBox3.Text));
                    break;
                case "-":
                    label2.Text = Convert.ToString(double.Parse(textBox2.Text) - double.Parse(textBox3.Text));
                    break;
                case "*":
                    label2.Text = Convert.ToString(double.Parse(textBox2.Text) * double.Parse(textBox3.Text));
                    break;
                case "/":
                    label2.Text = Convert.ToString(double.Parse(textBox2.Text) / double.Parse(textBox3.Text));
                    break;
            }
            bool b = false;
            int a1, a2;
            a1 = int.Parse(textBox2.Text);
            a2 = int.Parse(textBox3.Text);
            if (a1 > a2)
            {
                MessageBox.Show(b.ToString());
            }
        }

        internal void button5_Click(object sender, EventArgs e)
        {
            //string[] week = {"Mon", "Tues", "Wen", "Fri", "Sun"};
            //foreach (string s in week)
            //{
            //    MessageBox.Show(s);
            //}
            try
            {
                int x = int.Parse(textBox2.Text);
                int y = 10;
                int z = x + y;
                label2.Text = Convert.ToString(z);

            }
            catch (Exception d)
            {
                //Console.WriteLine(d.Message);
                MessageBox.Show(d.Message);
            }
            finally
            {
                textBox2.Text = "";
            }
            string s1 = "Hello World!";
            string s2 = "456";
            bool b1 = s1.Equals(s2);

            StringBuilder  str = new StringBuilder();
            str.Append("hello,");
            str.AppendLine("hi");
            str.Append("haha");
            MessageBox.Show(str.ToString());


        }
    }
}
