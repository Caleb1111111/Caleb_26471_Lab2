namespace Caleb_26471_Lab2
{
    public partial class MushroomForm : Form
    {
        private Form chooseForm;
        private Form loginForm;

        private int step = 1;
        private string q1 = "";

        public MushroomForm(Form choose, Form login)
        {
            InitializeComponent();
            chooseForm = choose;
            loginForm = login;
        }

        private void MushroomForm_Load(object sender, EventArgs e)
        {
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (step == 1)
            {
                q1 = "yes";
                step = 2;
                lblQuestion.Text = "Q2: Does your mushroom have gills?";
            }
            else if (step == 2)
            {
                if (q1 == "no")
                {
                    lblQuestion.Text = "Done!";
                    lblResult.Text = "Your mushroom is: Agaric Jaunissant";
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnStartOver.Visible = true;
                    step = 1;
                    q1 = "";
                }
                else
                {
                    step = 3;
                    lblQuestion.Text = "Q3: Does your mushroom have a ring?";
                }
            }
            else if (step == 3)
            {
                lblQuestion.Text = "Done!";
                lblResult.Text = "Your mushroom is: Amanite tue-mouche";
                btnYes.Visible = false;
                btnNo.Visible = false;
                btnStartOver.Visible = true;
                step = 1;
                q1 = "";
            }
            else if (step == 4)
            {
                lblQuestion.Text = "Done!";
                lblResult.Text = "Your mushroom is: Pied bleu";
                btnYes.Visible = false;
                btnNo.Visible = false;
                btnStartOver.Visible = true;
                step = 1;
                q1 = "";
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (step == 1)
            {
                q1 = "no";
                step = 2;
                lblQuestion.Text = "Q2: Does your mushroom have a ring?";
            }
            else if (step == 2)
            {
                if (q1 == "no")
                {
                    lblQuestion.Text = "Done!";
                    lblResult.Text = "Your mushroom is: Coprin chevelu";
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnStartOver.Visible = true;
                    step = 1;
                    q1 = "";
                }
                else
                {
                    lblQuestion.Text = "Done!";
                    lblResult.Text = "Your mushroom is: Cepe de bordeaux";
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnStartOver.Visible = true;
                    step = 1;
                    q1 = "";
                }
            }
            else if (step == 3)
            {
                step = 4;
                lblQuestion.Text = "Q4: Does your mushroom have a convex cup?";
            }
            else if (step == 4)
            {
                lblQuestion.Text = "Done!";
                lblResult.Text = "Your mushroom is: Girolle";
                btnYes.Visible = false;
                btnNo.Visible = false;
                btnStartOver.Visible = true;
                step = 1;
                q1 = "";
            }
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            lblQuestion.Text = "Q1: Does your mushroom grow in a forest?";
            lblResult.Text = "";
            btnYes.Visible = true;
            btnNo.Visible = true;
            btnStartOver.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            chooseForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            chooseForm.Hide();
            this.Close();
        }
    }
}
