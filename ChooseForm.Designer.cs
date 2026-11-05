namespace Caleb_26471_Lab2
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnBicycle
            // 
            btnBicycle.BackColor = Color.DarkGray;
            btnBicycle.Location = new Point(130, 321);
            btnBicycle.Margin = new Padding(4, 4, 4, 4);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(128, 41);
            btnBicycle.TabIndex = 0;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.BackColor = Color.PaleGreen;
            btnMushroom.Location = new Point(440, 321);
            btnMushroom.Margin = new Padding(4, 4, 4, 4);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(149, 41);
            btnMushroom.TabIndex = 1;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = false;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(245, 149);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(218, 19);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Choose one you would like to use.";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(715, 499);
            Controls.Add(lblTitle);
            Controls.Add(btnMushroom);
            Controls.Add(btnBicycle);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "ChooseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose";
            Load += ChooseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBicycle;
        private Button btnMushroom;
        private Label lblTitle;
    }
}