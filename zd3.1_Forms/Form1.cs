namespace zd3._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private static double f(double a, double b)
        {
            double result;
            result = Math.Sqrt(a * a + b * b);
            return result;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox7.Clear();
                string a_1 = textBox5.Text;
                string b_1 = textBox6.Text;
                double a = Convert.ToDouble(a_1);
                double b = Convert.ToDouble(b_1);
                if (a >= 0 && b >= 0) 
                {
                    textBox7.Text += f(a, b);
                }
                else textBox7.Text = "¬ведите коректное число";
            }
            catch
            {
                textBox7.Clear();
                textBox7.Text = "¬ведите коректное число";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        static double P(double AB, double AC, double DC)
        {
            double BC = Math.Sqrt(AB * AB + AC * AC);
            return AB + AC + DC + Math.Sqrt(BC * BC + DC * DC);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ab_1 = textBox1.Text;
                string ac_1 = textBox2.Text;
                string dc_1 = textBox3.Text;
                double AB = Convert.ToDouble(ab_1);
                double AC = Convert.ToDouble(ac_1);
                double DC = Convert.ToDouble(dc_1);
                if (AB > 0 && AC > 0 && DC > 0)
                {
                    textBox4.Text += P(AB, AC, DC);
                }
                else textBox4.Text = "¬ведите коректное число";
            }
            catch
            {
                textBox4.Text = "¬ведите коректное число";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}