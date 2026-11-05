namespace Caleb_26471_Lab2
{
    public partial class ChooseForm : Form
    {
        private Form loginForm;

        public ChooseForm(Form login)
        {
            InitializeComponent();
            loginForm = login;
        }

        private void ChooseForm_Load(object sender, EventArgs e)
        {
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm(this, loginForm);
            bicycle.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm(this, loginForm);
            mushroom.Show();
            this.Hide();
        }
    }
}
