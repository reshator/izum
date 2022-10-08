namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                double a = Convert.ToDouble(textBox1.Text);
                // стоимость одного грамма
                double b = a / 1000;
                for (int i = 100; i < 1000; i += 100)
                {
                    listBox1.Items.Add($"{b * i} за {i} грамм");
                }
            }
            catch (FormatException)
            {

               
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}