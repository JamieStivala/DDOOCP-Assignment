using System.Windows.Forms;

namespace Booking_System.frontend.admin
{
    partial class AdminUserWindow
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageHotelManager = new System.Windows.Forms.TabPage();
            this.labelHotelManagerDefaultCheckOutTime = new System.Windows.Forms.Label();
            this.dateTimePickerHotelManagerDefaultCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.labelHotelManagerDefaultCheckInTime = new System.Windows.Forms.Label();
            this.dateTimePickerHotelManagerDefaultCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.labelHotelManagerLocation = new System.Windows.Forms.Label();
            this.textBoxHotelManagerLocation = new System.Windows.Forms.TextBox();
            this.labelHotelManagerName = new System.Windows.Forms.Label();
            this.textBoxHotelManagerName = new System.Windows.Forms.TextBox();
            this.buttonHotelManagerReset = new System.Windows.Forms.Button();
            this.buttonHotelManagerSave = new System.Windows.Forms.Button();
            this.tabPageRoomManager = new System.Windows.Forms.TabPage();
            this.tabPageBookingManager = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelHotelSelected = new System.Windows.Forms.Label();
            this.comboBoxHotelSelect = new System.Windows.Forms.ComboBox();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageHotelManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHotelManager);
            this.tabControl.Controls.Add(this.tabPageRoomManager);
            this.tabControl.Controls.Add(this.tabPageBookingManager);
            this.tabControl.Location = new System.Drawing.Point(12, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 337);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selecting += this.tabControl_Selecting;
            // 
            // tabPageHotelManager
            // 
            this.tabPageHotelManager.Controls.Add(this.labelHotelManagerDefaultCheckOutTime);
            this.tabPageHotelManager.Controls.Add(this.dateTimePickerHotelManagerDefaultCheckOutTime);
            this.tabPageHotelManager.Controls.Add(this.labelHotelManagerDefaultCheckInTime);
            this.tabPageHotelManager.Controls.Add(this.dateTimePickerHotelManagerDefaultCheckInTime);
            this.tabPageHotelManager.Controls.Add(this.labelHotelManagerLocation);
            this.tabPageHotelManager.Controls.Add(this.textBoxHotelManagerLocation);
            this.tabPageHotelManager.Controls.Add(this.labelHotelManagerName);
            this.tabPageHotelManager.Controls.Add(this.textBoxHotelManagerName);
            this.tabPageHotelManager.Controls.Add(this.buttonHotelManagerReset);
            this.tabPageHotelManager.Controls.Add(this.buttonHotelManagerSave);
            this.tabPageHotelManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageHotelManager.Name = "tabPageHotelManager";
            this.tabPageHotelManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHotelManager.Size = new System.Drawing.Size(768, 311);
            this.tabPageHotelManager.TabIndex = 0;
            this.tabPageHotelManager.Text = "Hotel Manager";
            this.tabPageHotelManager.UseVisualStyleBackColor = true;
            // 
            // labelHotelManagerDefaultCheckOutTime
            // 
            this.labelHotelManagerDefaultCheckOutTime.AutoSize = true;
            this.labelHotelManagerDefaultCheckOutTime.Location = new System.Drawing.Point(517, 94);
            this.labelHotelManagerDefaultCheckOutTime.Name = "labelHotelManagerDefaultCheckOutTime";
            this.labelHotelManagerDefaultCheckOutTime.Size = new System.Drawing.Size(121, 13);
            this.labelHotelManagerDefaultCheckOutTime.TabIndex = 66;
            this.labelHotelManagerDefaultCheckOutTime.Text = "Default Check-Out Time";
            // 
            // dateTimePickerHotelManagerDefaultCheckOutTime
            // 
            this.dateTimePickerHotelManagerDefaultCheckOutTime.CustomFormat = "HH:mm ";
            this.dateTimePickerHotelManagerDefaultCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHotelManagerDefaultCheckOutTime.Location = new System.Drawing.Point(520, 110);
            this.dateTimePickerHotelManagerDefaultCheckOutTime.Name = "dateTimePickerHotelManagerDefaultCheckOutTime";
            this.dateTimePickerHotelManagerDefaultCheckOutTime.ShowUpDown = true;
            this.dateTimePickerHotelManagerDefaultCheckOutTime.Size = new System.Drawing.Size(199, 20);
            this.dateTimePickerHotelManagerDefaultCheckOutTime.TabIndex = 65;
            this.dateTimePickerHotelManagerDefaultCheckOutTime.Value = new System.DateTime(2022, 7, 19, 11, 0, 0, 0);
            // 
            // labelHotelManagerDefaultCheckInTime
            // 
            this.labelHotelManagerDefaultCheckInTime.AutoSize = true;
            this.labelHotelManagerDefaultCheckInTime.Location = new System.Drawing.Point(38, 94);
            this.labelHotelManagerDefaultCheckInTime.Name = "labelHotelManagerDefaultCheckInTime";
            this.labelHotelManagerDefaultCheckInTime.Size = new System.Drawing.Size(113, 13);
            this.labelHotelManagerDefaultCheckInTime.TabIndex = 64;
            this.labelHotelManagerDefaultCheckInTime.Text = "Default Check-In Time";
            // 
            // dateTimePickerHotelManagerDefaultCheckInTime
            // 
            this.dateTimePickerHotelManagerDefaultCheckInTime.CustomFormat = "HH:mm ";
            this.dateTimePickerHotelManagerDefaultCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHotelManagerDefaultCheckInTime.Location = new System.Drawing.Point(41, 110);
            this.dateTimePickerHotelManagerDefaultCheckInTime.Name = "dateTimePickerHotelManagerDefaultCheckInTime";
            this.dateTimePickerHotelManagerDefaultCheckInTime.ShowUpDown = true;
            this.dateTimePickerHotelManagerDefaultCheckInTime.Size = new System.Drawing.Size(199, 20);
            this.dateTimePickerHotelManagerDefaultCheckInTime.TabIndex = 63;
            this.dateTimePickerHotelManagerDefaultCheckInTime.Value = new System.DateTime(2022, 7, 19, 13, 0, 0, 0);
            // 
            // labelHotelManagerLocation
            // 
            this.labelHotelManagerLocation.AutoSize = true;
            this.labelHotelManagerLocation.Location = new System.Drawing.Point(520, 20);
            this.labelHotelManagerLocation.Name = "labelHotelManagerLocation";
            this.labelHotelManagerLocation.Size = new System.Drawing.Size(48, 13);
            this.labelHotelManagerLocation.TabIndex = 62;
            this.labelHotelManagerLocation.Text = "Location";
            // 
            // textBoxHotelManagerLocation
            // 
            this.textBoxHotelManagerLocation.Location = new System.Drawing.Point(520, 35);
            this.textBoxHotelManagerLocation.Name = "textBoxHotelManagerLocation";
            this.textBoxHotelManagerLocation.Size = new System.Drawing.Size(202, 20);
            this.textBoxHotelManagerLocation.TabIndex = 61;
            // 
            // labelHotelManagerName
            // 
            this.labelHotelManagerName.AutoSize = true;
            this.labelHotelManagerName.Location = new System.Drawing.Point(38, 20);
            this.labelHotelManagerName.Name = "labelHotelManagerName";
            this.labelHotelManagerName.Size = new System.Drawing.Size(35, 13);
            this.labelHotelManagerName.TabIndex = 60;
            this.labelHotelManagerName.Text = "Name";
            // 
            // textBoxHotelManagerName
            // 
            this.textBoxHotelManagerName.Location = new System.Drawing.Point(38, 35);
            this.textBoxHotelManagerName.Name = "textBoxHotelManagerName";
            this.textBoxHotelManagerName.Size = new System.Drawing.Size(202, 20);
            this.textBoxHotelManagerName.TabIndex = 59;
            // 
            // buttonHotelManagerReset
            // 
            this.buttonHotelManagerReset.Location = new System.Drawing.Point(454, 245);
            this.buttonHotelManagerReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHotelManagerReset.Name = "buttonHotelManagerReset";
            this.buttonHotelManagerReset.Size = new System.Drawing.Size(117, 35);
            this.buttonHotelManagerReset.TabIndex = 57;
            this.buttonHotelManagerReset.Text = "Reset";
            this.buttonHotelManagerReset.UseVisualStyleBackColor = true;
            this.buttonHotelManagerReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonHotelManagerSave
            // 
            this.buttonHotelManagerSave.Location = new System.Drawing.Point(602, 245);
            this.buttonHotelManagerSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHotelManagerSave.Name = "buttonHotelManagerSave";
            this.buttonHotelManagerSave.Size = new System.Drawing.Size(117, 35);
            this.buttonHotelManagerSave.TabIndex = 56;
            this.buttonHotelManagerSave.Text = "Save";
            this.buttonHotelManagerSave.UseVisualStyleBackColor = true;
            this.buttonHotelManagerSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabPageRoomManager
            // 
            this.tabPageRoomManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoomManager.Name = "tabPageRoomManager";
            this.tabPageRoomManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoomManager.Size = new System.Drawing.Size(768, 311);
            this.tabPageRoomManager.TabIndex = 1;
            this.tabPageRoomManager.Text = "Room Manager";
            this.tabPageRoomManager.UseVisualStyleBackColor = true;
            // 
            // tabPageBookingManager
            // 
            this.tabPageBookingManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookingManager.Name = "tabPageBookingManager";
            this.tabPageBookingManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookingManager.Size = new System.Drawing.Size(768, 311);
            this.tabPageBookingManager.TabIndex = 2;
            this.tabPageBookingManager.Text = "Booking Manager";
            this.tabPageBookingManager.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelHotelSelected
            // 
            this.labelHotelSelected.AutoSize = true;
            this.labelHotelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelSelected.Location = new System.Drawing.Point(19, 13);
            this.labelHotelSelected.Name = "labelHotelSelected";
            this.labelHotelSelected.Size = new System.Drawing.Size(104, 17);
            this.labelHotelSelected.TabIndex = 68;
            this.labelHotelSelected.Text = "Hotel Selected:";
            // 
            // comboBoxHotelSelect
            // 
            this.comboBoxHotelSelect.AllowDrop = true;
            this.comboBoxHotelSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxHotelSelect.FormattingEnabled = true;
            this.comboBoxHotelSelect.Location = new System.Drawing.Point(139, 12);
            this.comboBoxHotelSelect.Name = "comboBoxHotelSelect";
            this.comboBoxHotelSelect.Size = new System.Drawing.Size(599, 21);
            this.comboBoxHotelSelect.TabIndex = 67;
            this.comboBoxHotelSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxHotelSelect_SelectedIndexChanged);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(667, 397);
            this.buttonSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(117, 35);
            this.buttonSignOut.TabIndex = 67;
            this.buttonSignOut.Text = "Signout";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // AdminUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.labelHotelSelected);
            this.Controls.Add(this.comboBoxHotelSelect);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminUserWindow";
            this.Text = "AdminUserWindow";
            this.Load += new System.EventHandler(this.AdminUserWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageHotelManager.ResumeLayout(false);
            this.tabPageHotelManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageHotelManager;
        private System.Windows.Forms.TabPage tabPageRoomManager;
        private System.Windows.Forms.TabPage tabPageBookingManager;
        private System.Windows.Forms.Button buttonHotelManagerReset;
        private System.Windows.Forms.Button buttonHotelManagerSave;
        private System.Windows.Forms.Label labelHotelManagerLocation;
        private System.Windows.Forms.TextBox textBoxHotelManagerLocation;
        private System.Windows.Forms.Label labelHotelManagerName;
        private System.Windows.Forms.TextBox textBoxHotelManagerName;
        private System.Windows.Forms.DateTimePicker dateTimePickerHotelManagerDefaultCheckInTime;
        private Label labelHotelManagerDefaultCheckOutTime;
        private DateTimePicker dateTimePickerHotelManagerDefaultCheckOutTime;
        private Label labelHotelManagerDefaultCheckInTime;
        private ErrorProvider errorProvider;
        private Label labelHotelSelected;
        private ComboBox comboBoxHotelSelect;
        private Button buttonSignOut;
    }
}