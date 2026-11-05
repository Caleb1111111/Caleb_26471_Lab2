namespace Caleb_26471_Lab2
{
    public partial class ChooseForm : Form
    {
        private readonly Form _loginForm;
        public ChooseForm(Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void ChooseForm_Load(object sender, EventArgs e)
        {
        }
    }
}
