namespace Caleb_26471_Lab2
{
    partial class MushroomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            lblResult = new Label();
            btnStartOver = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(210, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mushroom Identifier";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = false;
            lblQuestion.Location = new Point(88, 120);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(510, 50);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Q1: Does your mushroom grow in a forest?";
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.PaleGreen;
            btnYes.Location = new Point(180, 200);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(120, 40);
            btnYes.TabIndex = 2;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.LightCoral;
            btnNo.Location = new Point(390, 200);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(120, 40);
            btnNo.TabIndex = 3;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = false;
            lblResult.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblResult.Location = new Point(88, 280);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(510, 40);
            lblResult.TabIndex = 4;
            lblResult.Text = "";
            // 
            // btnStartOver
            // 
            btnStartOver.BackColor = Color.SteelBlue;
            btnStartOver.ForeColor = Color.White;
            btnStartOver.Location = new Point(270, 350);
            btnStartOver.Name = "btnStartOver";
            btnStartOver.Size = new Size(150, 35);
            btnStartOver.TabIndex = 5;
            btnStartOver.Text = "Start Over";
            btnStartOver.Visible = false;
            btnStartOver.UseVisualStyleBackColor = false;
            btnStartOver.Click += btnStartOver_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkOrange;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(58, 448);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(533, 448);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 35);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(697, 522);
            Controls.Add(lblTitle);
            Controls.Add(lblQuestion);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Controls.Add(lblResult);
            Controls.Add(btnStartOver);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MushroomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom Finder";
            Load += MushroomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQuestion;
        private Button btnYes;
        private Button btnNo;
        private Label lblResult;
        private Button btnStartOver;
        private Button btnBack;
        private Button btnLogout;
    }
}