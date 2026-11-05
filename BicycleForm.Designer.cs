namespace Caleb_26471_Lab2
{
    partial class BicycleForm
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
            lblStart = new Label();
            lblEnd = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnCalculate = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnReset = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(220, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bicycle Rental";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(88, 120);
            lblStart.Name = "lblStart";
            lblStart.TabIndex = 1;
            lblStart.Text = "Starting time (0-23) :";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(88, 180);
            lblEnd.Name = "lblEnd";
            lblEnd.TabIndex = 2;
            lblEnd.Text = "Ending time (1-24) :";
            // 
            // txtStart
            // 
            txtStart.BackColor = Color.LightYellow;
            txtStart.Location = new Point(280, 117);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(200, 26);
            txtStart.TabIndex = 3;
            // 
            // txtEnd
            // 
            txtEnd.BackColor = Color.LightYellow;
            txtEnd.Location = new Point(280, 177);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(200, 26);
            txtEnd.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.SteelBlue;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(180, 240);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 35);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(88, 320);
            lblTotal.Name = "lblTotal";
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total :";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.LightGreen;
            txtTotal.Location = new Point(280, 317);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(200, 26);
            txtTotal.TabIndex = 7;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightGray;
            btnReset.Location = new Point(320, 240);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 35);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkOrange;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(58, 448);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 9;
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
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(691, 524);
            Controls.Add(lblTitle);
            Controls.Add(lblStart);
            Controls.Add(lblEnd);
            Controls.Add(txtStart);
            Controls.Add(txtEnd);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(btnReset);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BicycleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicycle Rental";
            Load += BicycleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStart;
        private Label lblEnd;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnCalculate;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnReset;
        private Button btnBack;
        private Button btnLogout;
    }
}