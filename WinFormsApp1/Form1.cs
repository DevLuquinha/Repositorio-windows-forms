namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();

            button1.Text = class1.Nome();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
