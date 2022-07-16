namespace Booking_System
{
    partial class FormSignin
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(109, 146);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 23);
            this.emailTextBox.TabIndex = 6;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(40, 22);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(122, 54);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(519, 274);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(136, 40);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(109, 129);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(109, 203);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(109, 220);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 23);
            this.passwordTextBox.TabIndex = 10;
            // 
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.emailTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSignup";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}
