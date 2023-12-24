namespace year
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            String year = textBox1.Text;
            int year1 = Convert.ToInt32(year);
            textBox2.Text = year1.ToString();
        }*/

 
       private void button1_Click(object sender, EventArgs e)
        {
            int n, t;
            n = int.Parse(textBox1.Text);
            t = (n % 4);
            if (t == 0)
                textBox2.Text = "дю";
            else
                textBox2.Text = "мер";
        }
    }
}