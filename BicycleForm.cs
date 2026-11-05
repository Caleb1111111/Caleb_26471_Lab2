using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Caleb_26471_Lab2
{
    public partial class BicycleForm : Form
    {
        private readonly Form _choose;
        private readonly Form _login;

        public BicycleForm(Form choose, Form login)
        {
            InitializeComponent();
            _choose = choose;
            _login = login;
        }

        private void BicycleForm_Load(object sender, EventArgs e)
        {
        }
    }
}
