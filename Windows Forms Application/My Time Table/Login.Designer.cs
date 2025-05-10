namespace My_Time_Table
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            closeButton = new PictureBox();
            emailInput = new TextBox();
            label1 = new Label();
            passwordInput = new TextBox();
            label2 = new Label();
            loginButton = new Button();
            signinButton = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(closeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 70);
            panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Image = Properties.Resources.close_button;
            closeButton.Location = new Point(388, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(41, 32);
            closeButton.SizeMode = PictureBoxSizeMode.Zoom;
            closeButton.TabIndex = 0;
            closeButton.TabStop = false;
            closeButton.Click += closeButton_Click;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(103, 104);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(221, 23);
            emailInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 86);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(103, 170);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(221, 23);
            passwordInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 152);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Gold;
            loginButton.Location = new Point(103, 229);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(87, 32);
            loginButton.TabIndex = 5;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.Gold;
            signinButton.Location = new Point(237, 229);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(87, 32);
            signinButton.TabIndex = 6;
            signinButton.Text = "Sign in";
            signinButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(441, 308);
            Controls.Add(signinButton);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(passwordInput);
            Controls.Add(label1);
            Controls.Add(emailInput);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox emailInput;
        private Label label1;
        private TextBox passwordInput;
        private Label label2;
        private Button loginButton;
        private Button signinButton;
        private PictureBox closeButton;
        private PictureBox pictureBox1;
    }
}
