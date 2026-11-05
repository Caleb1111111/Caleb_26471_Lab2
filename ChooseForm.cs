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

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm(this, _loginForm);
            mushroom.Show();
            this.Hide();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm(this, _loginForm);
            bicycle.Show();
            this.Hide();
        }
    }
}
