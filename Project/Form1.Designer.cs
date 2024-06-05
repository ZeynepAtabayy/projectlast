namespace Project
{
    partial class Form1
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
            grpboxPas = new GroupBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUserName = new Label();
            lblEnter = new Label();
            grpboxGrs = new GroupBox();
            grpboxPas.SuspendLayout();
            grpboxGrs.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxPas
            // 
            grpboxPas.BackColor = Color.IndianRed;
            grpboxPas.Controls.Add(btnLogin);
            grpboxPas.Controls.Add(txtPassword);
            grpboxPas.Controls.Add(txtUsername);
            grpboxPas.Controls.Add(lblPassword);
            grpboxPas.Controls.Add(lblUserName);
            grpboxPas.Controls.Add(lblEnter);
            grpboxPas.Location = new Point(266, 153);
            grpboxPas.Margin = new Padding(2, 2, 2, 2);
            grpboxPas.Name = "grpboxPas";
            grpboxPas.Padding = new Padding(2, 2, 2, 2);
            grpboxPas.Size = new Size(527, 301);
            grpboxPas.TabIndex = 1;
            grpboxPas.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(222, 224);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 27);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(208, 159);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(121, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(208, 101);
            txtUsername.Margin = new Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(121, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(82, 159);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(82, 101);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(82, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name";
            // 
            // lblEnter
            // 
            lblEnter.AutoSize = true;
            lblEnter.Location = new Point(230, 22);
            lblEnter.Margin = new Padding(2, 0, 2, 0);
            lblEnter.Name = "lblEnter";
            lblEnter.Size = new Size(43, 20);
            lblEnter.TabIndex = 0;
            lblEnter.Text = "Enter";
            lblEnter.Click += lblEnter_Click;
            // 
            // grpboxGrs
            // 
            grpboxGrs.BackColor = Color.RosyBrown;
            grpboxGrs.Controls.Add(grpboxPas);
            grpboxGrs.Location = new Point(-2, 6);
            grpboxGrs.Margin = new Padding(2, 2, 2, 2);
            grpboxGrs.Name = "grpboxGrs";
            grpboxGrs.Padding = new Padding(2, 2, 2, 2);
            grpboxGrs.Size = new Size(1070, 577);
            grpboxGrs.TabIndex = 6;
            grpboxGrs.TabStop = false;
            grpboxGrs.Text = "Video Admin";
            grpboxGrs.Enter += grpboxGrs_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 586);
            Controls.Add(grpboxGrs);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Login Page";
            grpboxPas.ResumeLayout(false);
            grpboxPas.PerformLayout();
            grpboxGrs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpboxPas;
        private Label lblPassword;
        private Label lblUserName;
        private Label lblEnter;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private GroupBox grpboxGrs;
    }
}
