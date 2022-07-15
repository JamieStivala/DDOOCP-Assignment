namespace Booking_System.frontend.user
{
    partial class MainUserWindow
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
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.createBookingButton = new System.Windows.Forms.Button();
            this.viewBookingButton = new System.Windows.Forms.Button();
            this.editPersonalInformationButton = new System.Windows.Forms.Button();
            this.signoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainMenuLabel.Location = new System.Drawing.Point(46, 29);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(226, 54);
            this.mainMenuLabel.TabIndex = 8;
            this.mainMenuLabel.Text = "Main Menu";
            // 
            // createBookingButton
            // 
            this.createBookingButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createBookingButton.Location = new System.Drawing.Point(88, 126);
            this.createBookingButton.Name = "createBookingButton";
            this.createBookingButton.Size = new System.Drawing.Size(129, 49);
            this.createBookingButton.TabIndex = 9;
            this.createBookingButton.Text = "Create Booking";
            this.createBookingButton.UseVisualStyleBackColor = true;
            // 
            // viewBookingButton
            // 
            this.viewBookingButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewBookingButton.Location = new System.Drawing.Point(354, 126);
            this.viewBookingButton.Name = "viewBookingButton";
            this.viewBookingButton.Size = new System.Drawing.Size(129, 49);
            this.viewBookingButton.TabIndex = 10;
            this.viewBookingButton.Text = "View/Edit Bookings";
            this.viewBookingButton.UseVisualStyleBackColor = true;
            // 
            // editPersonalInformationButton
            // 
            this.editPersonalInformationButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPersonalInformationButton.Location = new System.Drawing.Point(614, 126);
            this.editPersonalInformationButton.Name = "editPersonalInformationButton";
            this.editPersonalInformationButton.Size = new System.Drawing.Size(129, 49);
            this.editPersonalInformationButton.TabIndex = 11;
            this.editPersonalInformationButton.Text = "Edit Personal Information";
            this.editPersonalInformationButton.UseVisualStyleBackColor = true;
            // 
            // signoutButton
            // 
            this.signoutButton.Location = new System.Drawing.Point(614, 373);
            this.signoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(136, 40);
            this.signoutButton.TabIndex = 12;
            this.signoutButton.Text = "Signout";
            this.signoutButton.UseVisualStyleBackColor = true;
            // 
            // MainUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signoutButton);
            this.Controls.Add(this.editPersonalInformationButton);
            this.Controls.Add(this.viewBookingButton);
            this.Controls.Add(this.createBookingButton);
            this.Controls.Add(this.mainMenuLabel);
            this.Name = "MainUserWindow";
            this.Text = "MainUserWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Button createBookingButton;
        private System.Windows.Forms.Button viewBookingButton;
        private System.Windows.Forms.Button editPersonalInformationButton;
        private System.Windows.Forms.Button signoutButton;
    }
}