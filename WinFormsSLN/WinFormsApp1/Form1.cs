namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greet_Click(object sender, EventArgs e)
        {
            result.Text = $"Result: Hello {userName.Text}";
        }
    }
}
