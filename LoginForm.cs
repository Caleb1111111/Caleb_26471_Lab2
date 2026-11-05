namespace Caleb_26471_Lab2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            ChooseForm chooseForm = new ChooseForm(this);
            chooseForm.Show();
            this.Hide();
        }
    }
}
