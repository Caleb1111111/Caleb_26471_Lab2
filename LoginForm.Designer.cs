namespace Caleb_26471_Lab2
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblTittle = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.Location = new Point(306, 434);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(97, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(138, 199);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 19);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username : ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(138, 283);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 19);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password : ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(242, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(267, 26);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(242, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(267, 26);
            txtPassword.TabIndex = 4;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Location = new Point(317, 111);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(58, 19);
            lblTittle.TabIndex = 5;
            lblTittle.Text = "LOGIN";
            lblTittle.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(720, 606);
            Controls.Add(lblTittle);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblTittle;
    }
}
