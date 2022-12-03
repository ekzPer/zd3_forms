namespace zd3._3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            double y;
            if (x == 1 || x == -1) y = 1;
            else if (x >= 0 && x != 1) y = -1 / 1 - x;
            else y = 1 / 1 + x;
            return y;
        }

        static void f(double x, out double y)
        {
            if (x == 1 || x == -1) y = 1;
            else if (x >= 0 && x != 1) y = -1 / 1 - x;
            else y = 1 / 1 + x;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Clear();
                textBox5.Clear();
                string a_1 = textBox1.Text;
                string b_1 = textBox2.Text;
                string h_1 = textBox3.Text;


                double a = Convert.ToDouble(a_1);
                double b = Convert.ToDouble(b_1);
                double h = Convert.ToDouble(h_1);

                textBox4.Text = "При возврате значения:\r\n";
                for (double i = a; i <= b; i += h)
                {
                    textBox4.Text += string.Format("f({0:f2})={1:f4})", i, f(i));
                    textBox4.Text += "\r\n";
                }

                textBox5.Text = "При передаче по ссылке:\r\n";
                double y;
                for (double i = a; i <= b; i += h)
                {
                    f(i, out y);
                    textBox5.Text += string.Format("f({0:f2})={1:f4}", i, y);
                    textBox5.Text += "\r\n";
                }
            }
            catch
            {
                textBox4.Text = "Введите коректное число";
                textBox5.Text = "Введите коректное число";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t1 = item as TextBox;
                    t1.Text = string.Empty;
                }
            }
        }
    }
}