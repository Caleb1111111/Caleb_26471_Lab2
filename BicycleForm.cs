namespace Caleb_26471_Lab2
{
    public partial class BicycleForm : Form
    {
        private Form chooseForm;
        private Form loginForm;

        public BicycleForm(Form choose, Form login)
        {
            InitializeComponent();
            chooseForm = choose;
            loginForm = login;
        }

        private void BicycleForm_Load(object sender, EventArgs e)
        {
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStart.Text = "";
            txtEnd.Text = "";
            txtTotal.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int startTime;
            int endTime;

            try
            {
                startTime = int.Parse(txtStart.Text);
                endTime = int.Parse(txtEnd.Text);
            }
            catch
            {
                txtTotal.Text = "";
                MessageBox.Show("Please enter whole numbers for both times.");
                return;
            }

            if (startTime < 0 || startTime > 23)
            {
                txtTotal.Text = "";
                MessageBox.Show("Invalid! Starting time must be between 0 and 23.");
            }
            else if (endTime < 1 || endTime > 24)
            {
                txtTotal.Text = "";
                MessageBox.Show("Invalid! Ending time must be between 1 and 24.");
            }
            else if (startTime >= endTime)
            {
                txtTotal.Text = "";
                MessageBox.Show("Invalid! Starting time must be less than ending time.");
            }
            else
            {
                int totalCost = 0;

                for (int hour = startTime; hour < endTime; hour++)
                {
                    if (hour >= 0 && hour < 7)
                    {
                        totalCost = totalCost + 500;
                    }
                    else if (hour >= 7 && hour < 14)
                    {
                        totalCost = totalCost + 1000;
                    }
                    else if (hour >= 14 && hour < 19)
                    {
                        totalCost = totalCost + 1500;
                    }
                    else if (hour >= 19 && hour < 21)
                    {
                        totalCost = totalCost + 1000;
                    }
                    else if (hour >= 21 && hour < 24)
                    {
                        totalCost = totalCost + 500;
                    }
                }

                txtTotal.Text = totalCost + " RWF";
            }
        }
    }
}
