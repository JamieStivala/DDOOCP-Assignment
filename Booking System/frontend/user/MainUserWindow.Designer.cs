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
            this.mainMenuLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.mainMenuLabel.Location = new System.Drawing.Point(39, 25);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(226, 54);
            this.mainMenuLabel.TabIndex = 8;
            this.mainMenuLabel.Text = "Main Menu";
            // 
            // createBookingButton
            // 
            this.createBookingButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.createBookingButton.Location = new System.Drawing.Point(75, 109);
            this.createBookingButton.Name = "createBookingButton";
            this.createBookingButton.Size = new System.Drawing.Size(111, 42);
            this.createBookingButton.TabIndex = 9;
            this.createBookingButton.Text = "Create Booking";
            this.createBookingButton.UseVisualStyleBackColor = true;
            // 
            // viewBookingButton
            // 
            this.viewBookingButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.viewBookingButton.Location = new System.Drawing.Point(303, 109);
            this.viewBookingButton.Name = "viewBookingButton";
            this.viewBookingButton.Size = new System.Drawing.Size(111, 42);
            this.viewBookingButton.TabIndex = 10;
            this.viewBookingButton.Text = "View/Edit Bookings";
            this.viewBookingButton.UseVisualStyleBackColor = true;
            // 
            // editPersonalInformationButton
            // 
            this.editPersonalInformationButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.editPersonalInformationButton.Location = new System.Drawing.Point(526, 109);
            this.editPersonalInformationButton.Name = "editPersonalInformationButton";
            this.editPersonalInformationButton.Size = new System.Drawing.Size(111, 42);
            this.editPersonalInformationButton.TabIndex = 11;
            this.editPersonalInformationButton.Text = "Edit Personal Information";
            this.editPersonalInformationButton.UseVisualStyleBackColor = true;
            // 
            // signoutButton
            // 
            this.signoutButton.Location = new System.Drawing.Point(526, 323);
            this.signoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(117, 35);
            this.signoutButton.TabIndex = 12;
            this.signoutButton.Text = "Signout";
            this.signoutButton.UseVisualStyleBackColor = true;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // MainUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
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