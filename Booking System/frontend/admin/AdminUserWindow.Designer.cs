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
            this.buttonHotelManagerRemove = new System.Windows.Forms.Button();
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
            this.buttonRoomManagerRemove = new System.Windows.Forms.Button();
            this.textBoxRoomManagerDescription = new System.Windows.Forms.RichTextBox();
            this.buttonRoomManagerReset = new System.Windows.Forms.Button();
            this.buttonRoomManagerSave = new System.Windows.Forms.Button();
            this.numericUpDownRoomManagerAmountOfRooms = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRoomManagerPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRoomManagerCapacity = new System.Windows.Forms.NumericUpDown();
            this.labelRoomManagerPrice = new System.Windows.Forms.Label();
            this.labelRoomManagerDescription = new System.Windows.Forms.Label();
            this.labelRoomManagerAmountOfRooms = new System.Windows.Forms.Label();
            this.labelRoomManagerCapacity = new System.Windows.Forms.Label();
            this.labelRoomManagerName = new System.Windows.Forms.Label();
            this.textBoxRoomManagerName = new System.Windows.Forms.TextBox();
            this.labelRoomManagerRoomSelected = new System.Windows.Forms.Label();
            this.comboBoxRoomManagerRoomSelected = new System.Windows.Forms.ComboBox();
            this.tabPageUserManager = new System.Windows.Forms.TabPage();
            this.buttonUserManagerRemove = new System.Windows.Forms.Button();
            this.buttonUserManagerEditUser = new System.Windows.Forms.Button();
            this.buttonUserManagerToggleAdmin = new System.Windows.Forms.Button();
            this.listViewUserManagerUserList = new System.Windows.Forms.ListView();
            this.UserColumnHeaderUUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserColumnHeaderFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserColumnHeaderIsAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelHotelSelected = new System.Windows.Forms.Label();
            this.comboBoxHotelSelect = new System.Windows.Forms.ComboBox();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonViewModifyBookings = new System.Windows.Forms.Button();
            this.buttonCreateUserBooking = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageHotelManager.SuspendLayout();
            this.tabPageRoomManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomManagerAmountOfRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomManagerPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomManagerCapacity)).BeginInit();
            this.tabPageUserManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHotelManager);
            this.tabControl.Controls.Add(this.tabPageRoomManager);
            this.tabControl.Controls.Add(this.tabPageUserManager);
            this.tabControl.Location = new System.Drawing.Point(12, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 337);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageHotelManager
            // 
            this.tabPageHotelManager.Controls.Add(this.buttonHotelManagerRemove);
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
            // buttonHotelManagerRemove
            // 
            this.buttonHotelManagerRemove.Location = new System.Drawing.Point(311, 245);
            this.buttonHotelManagerRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHotelManagerRemove.Name = "buttonHotelManagerRemove";
            this.buttonHotelManagerRemove.Size = new System.Drawing.Size(117, 35);
            this.buttonHotelManagerRemove.TabIndex = 67;
            this.buttonHotelManagerRemove.Text = "Remove";
            this.buttonHotelManagerRemove.UseVisualStyleBackColor = true;
            this.buttonHotelManagerRemove.Click += new System.EventHandler(this.buttonHotelManagerRemove_Click);
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
            this.dateTimePickerHotelManagerDefaultCheckOutTime.TabIndex = 6;
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
            this.dateTimePickerHotelManagerDefaultCheckInTime.TabIndex = 5;
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
            this.textBoxHotelManagerLocation.TabIndex = 4;
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
            this.textBoxHotelManagerName.TabIndex = 3;
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
            this.buttonHotelManagerReset.Click += new System.EventHandler(this.buttonHotelManagerReset_Click);
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
            this.buttonHotelManagerSave.Click += new System.EventHandler(this.buttonHotelManagerSave_Click);
            // 
            // tabPageRoomManager
            // 
            this.tabPageRoomManager.Controls.Add(this.buttonRoomManagerRemove);
            this.tabPageRoomManager.Controls.Add(this.textBoxRoomManagerDescription);
            this.tabPageRoomManager.Controls.Add(this.buttonRoomManagerReset);
            this.tabPageRoomManager.Controls.Add(this.buttonRoomManagerSave);
            this.tabPageRoomManager.Controls.Add(this.numericUpDownRoomManagerAmountOfRooms);
            this.tabPageRoomManager.Controls.Add(this.numericUpDownRoomManagerPrice);
            this.tabPageRoomManager.Controls.Add(this.numericUpDownRoomManagerCapacity);
            this.tabPageRoomManager.Controls.Add(this.labelRoomManagerPrice);
            this.tabPageRoomManager.Controls.Add(this.labelRoomManagerDescription);
            this.tabPageRoomManager.Controls.Add(this.labelRoomManagerAmountOfRooms);
            this.tabPageRoomManager.Controls.Add(this.labelRoomManagerCapacity);
            this.tabPageRoomManager.Controls.Add(this.labelRoomManagerName);
            this.tabPageRoomManager.Controls.Add(this.textBoxRoomManagerName);
            this.tabPageRoomManager.Controls.Add(this.labelRoomManagerRoomSelected);
            this.tabPageRoomManager.Controls.Add(this.comboBoxRoomManagerRoomSelected);
            this.tabPageRoomManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoomManager.Name = "tabPageRoomManager";
            this.tabPageRoomManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoomManager.Size = new System.Drawing.Size(768, 311);
            this.tabPageRoomManager.TabIndex = 1;
            this.tabPageRoomManager.Text = "Room Manager";
            this.tabPageRoomManager.UseVisualStyleBackColor = true;
            // 
            // buttonRoomManagerRemove
            // 
            this.buttonRoomManagerRemove.Location = new System.Drawing.Point(312, 245);
            this.buttonRoomManagerRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRoomManagerRemove.Name = "buttonRoomManagerRemove";
            this.buttonRoomManagerRemove.Size = new System.Drawing.Size(117, 35);
            this.buttonRoomManagerRemove.TabIndex = 91;
            this.buttonRoomManagerRemove.Text = "Remove";
            this.buttonRoomManagerRemove.UseVisualStyleBackColor = true;
            this.buttonRoomManagerRemove.Click += new System.EventHandler(this.buttonRoomManagerRemove_Click);
            // 
            // textBoxRoomManagerDescription
            // 
            this.textBoxRoomManagerDescription.Location = new System.Drawing.Point(520, 70);
            this.textBoxRoomManagerDescription.Name = "textBoxRoomManagerDescription";
            this.textBoxRoomManagerDescription.Size = new System.Drawing.Size(202, 104);
            this.textBoxRoomManagerDescription.TabIndex = 11;
            this.textBoxRoomManagerDescription.Text = "";
            // 
            // buttonRoomManagerReset
            // 
            this.buttonRoomManagerReset.Location = new System.Drawing.Point(457, 245);
            this.buttonRoomManagerReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRoomManagerReset.Name = "buttonRoomManagerReset";
            this.buttonRoomManagerReset.Size = new System.Drawing.Size(117, 35);
            this.buttonRoomManagerReset.TabIndex = 89;
            this.buttonRoomManagerReset.Text = "Reset";
            this.buttonRoomManagerReset.UseVisualStyleBackColor = true;
            this.buttonRoomManagerReset.Click += new System.EventHandler(this.buttonRoomManagerReset_Click);
            // 
            // buttonRoomManagerSave
            // 
            this.buttonRoomManagerSave.Location = new System.Drawing.Point(605, 245);
            this.buttonRoomManagerSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRoomManagerSave.Name = "buttonRoomManagerSave";
            this.buttonRoomManagerSave.Size = new System.Drawing.Size(117, 35);
            this.buttonRoomManagerSave.TabIndex = 88;
            this.buttonRoomManagerSave.Text = "Save";
            this.buttonRoomManagerSave.UseVisualStyleBackColor = true;
            this.buttonRoomManagerSave.Click += new System.EventHandler(this.buttonRoomManagerSave_Click);
            // 
            // numericUpDownRoomManagerAmountOfRooms
            // 
            this.numericUpDownRoomManagerAmountOfRooms.Location = new System.Drawing.Point(46, 203);
            this.numericUpDownRoomManagerAmountOfRooms.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRoomManagerAmountOfRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRoomManagerAmountOfRooms.Name = "numericUpDownRoomManagerAmountOfRooms";
            this.numericUpDownRoomManagerAmountOfRooms.Size = new System.Drawing.Size(202, 20);
            this.numericUpDownRoomManagerAmountOfRooms.TabIndex = 10;
            this.numericUpDownRoomManagerAmountOfRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownRoomManagerPrice
            // 
            this.numericUpDownRoomManagerPrice.DecimalPlaces = 2;
            this.numericUpDownRoomManagerPrice.Location = new System.Drawing.Point(520, 203);
            this.numericUpDownRoomManagerPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRoomManagerPrice.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRoomManagerPrice.Name = "numericUpDownRoomManagerPrice";
            this.numericUpDownRoomManagerPrice.Size = new System.Drawing.Size(202, 20);
            this.numericUpDownRoomManagerPrice.TabIndex = 12;
            this.numericUpDownRoomManagerPrice.ThousandsSeparator = true;
            this.numericUpDownRoomManagerPrice.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownRoomManagerCapacity
            // 
            this.numericUpDownRoomManagerCapacity.Location = new System.Drawing.Point(43, 131);
            this.numericUpDownRoomManagerCapacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRoomManagerCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRoomManagerCapacity.Name = "numericUpDownRoomManagerCapacity";
            this.numericUpDownRoomManagerCapacity.Size = new System.Drawing.Size(202, 20);
            this.numericUpDownRoomManagerCapacity.TabIndex = 9;
            this.numericUpDownRoomManagerCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRoomManagerPrice
            // 
            this.labelRoomManagerPrice.AutoSize = true;
            this.labelRoomManagerPrice.Location = new System.Drawing.Point(520, 187);
            this.labelRoomManagerPrice.Name = "labelRoomManagerPrice";
            this.labelRoomManagerPrice.Size = new System.Drawing.Size(104, 13);
            this.labelRoomManagerPrice.TabIndex = 84;
            this.labelRoomManagerPrice.Text = "Price Per Night (in £)";
            // 
            // labelRoomManagerDescription
            // 
            this.labelRoomManagerDescription.AutoSize = true;
            this.labelRoomManagerDescription.Location = new System.Drawing.Point(520, 55);
            this.labelRoomManagerDescription.Name = "labelRoomManagerDescription";
            this.labelRoomManagerDescription.Size = new System.Drawing.Size(60, 13);
            this.labelRoomManagerDescription.TabIndex = 82;
            this.labelRoomManagerDescription.Text = "Description";
            // 
            // labelRoomManagerAmountOfRooms
            // 
            this.labelRoomManagerAmountOfRooms.AutoSize = true;
            this.labelRoomManagerAmountOfRooms.Location = new System.Drawing.Point(43, 187);
            this.labelRoomManagerAmountOfRooms.Name = "labelRoomManagerAmountOfRooms";
            this.labelRoomManagerAmountOfRooms.Size = new System.Drawing.Size(93, 13);
            this.labelRoomManagerAmountOfRooms.TabIndex = 80;
            this.labelRoomManagerAmountOfRooms.Text = "Amount Of Rooms";
            // 
            // labelRoomManagerCapacity
            // 
            this.labelRoomManagerCapacity.AutoSize = true;
            this.labelRoomManagerCapacity.Location = new System.Drawing.Point(43, 115);
            this.labelRoomManagerCapacity.Name = "labelRoomManagerCapacity";
            this.labelRoomManagerCapacity.Size = new System.Drawing.Size(48, 13);
            this.labelRoomManagerCapacity.TabIndex = 76;
            this.labelRoomManagerCapacity.Text = "Capacity";
            // 
            // labelRoomManagerName
            // 
            this.labelRoomManagerName.AutoSize = true;
            this.labelRoomManagerName.Location = new System.Drawing.Point(43, 55);
            this.labelRoomManagerName.Name = "labelRoomManagerName";
            this.labelRoomManagerName.Size = new System.Drawing.Size(35, 13);
            this.labelRoomManagerName.TabIndex = 72;
            this.labelRoomManagerName.Text = "Name";
            // 
            // textBoxRoomManagerName
            // 
            this.textBoxRoomManagerName.Location = new System.Drawing.Point(43, 70);
            this.textBoxRoomManagerName.Name = "textBoxRoomManagerName";
            this.textBoxRoomManagerName.Size = new System.Drawing.Size(202, 20);
            this.textBoxRoomManagerName.TabIndex = 8;
            // 
            // labelRoomManagerRoomSelected
            // 
            this.labelRoomManagerRoomSelected.AutoSize = true;
            this.labelRoomManagerRoomSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomManagerRoomSelected.Location = new System.Drawing.Point(25, 15);
            this.labelRoomManagerRoomSelected.Name = "labelRoomManagerRoomSelected";
            this.labelRoomManagerRoomSelected.Size = new System.Drawing.Size(108, 17);
            this.labelRoomManagerRoomSelected.TabIndex = 70;
            this.labelRoomManagerRoomSelected.Text = "Room Selected:";
            // 
            // comboBoxRoomManagerRoomSelected
            // 
            this.comboBoxRoomManagerRoomSelected.AllowDrop = true;
            this.comboBoxRoomManagerRoomSelected.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxRoomManagerRoomSelected.FormattingEnabled = true;
            this.comboBoxRoomManagerRoomSelected.Location = new System.Drawing.Point(145, 14);
            this.comboBoxRoomManagerRoomSelected.Name = "comboBoxRoomManagerRoomSelected";
            this.comboBoxRoomManagerRoomSelected.Size = new System.Drawing.Size(599, 21);
            this.comboBoxRoomManagerRoomSelected.TabIndex = 7;
            this.comboBoxRoomManagerRoomSelected.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomManagerRoomSelected_SelectedIndexChanged);
            // 
            // tabPageUserManager
            // 
            this.tabPageUserManager.Controls.Add(this.buttonCreateUserBooking);
            this.tabPageUserManager.Controls.Add(this.buttonViewModifyBookings);
            this.tabPageUserManager.Controls.Add(this.buttonUserManagerRemove);
            this.tabPageUserManager.Controls.Add(this.buttonUserManagerEditUser);
            this.tabPageUserManager.Controls.Add(this.buttonUserManagerToggleAdmin);
            this.tabPageUserManager.Controls.Add(this.listViewUserManagerUserList);
            this.tabPageUserManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserManager.Name = "tabPageUserManager";
            this.tabPageUserManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserManager.Size = new System.Drawing.Size(768, 311);
            this.tabPageUserManager.TabIndex = 3;
            this.tabPageUserManager.Text = "User Manager";
            this.tabPageUserManager.UseVisualStyleBackColor = true;
            // 
            // buttonUserManagerRemove
            // 
            this.buttonUserManagerRemove.Location = new System.Drawing.Point(6, 269);
            this.buttonUserManagerRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserManagerRemove.Name = "buttonUserManagerRemove";
            this.buttonUserManagerRemove.Size = new System.Drawing.Size(117, 33);
            this.buttonUserManagerRemove.TabIndex = 58;
            this.buttonUserManagerRemove.Text = "Remove";
            this.buttonUserManagerRemove.UseVisualStyleBackColor = true;
            this.buttonUserManagerRemove.Click += new System.EventHandler(this.buttonUserManagerRemove_Click);
            // 
            // buttonUserManagerEditUser
            // 
            this.buttonUserManagerEditUser.Location = new System.Drawing.Point(129, 269);
            this.buttonUserManagerEditUser.Name = "buttonUserManagerEditUser";
            this.buttonUserManagerEditUser.Size = new System.Drawing.Size(110, 33);
            this.buttonUserManagerEditUser.TabIndex = 2;
            this.buttonUserManagerEditUser.Text = "Edit User";
            this.buttonUserManagerEditUser.UseVisualStyleBackColor = true;
            this.buttonUserManagerEditUser.Click += new System.EventHandler(this.buttonUserManagerEditUser_Click);
            // 
            // buttonUserManagerToggleAdmin
            // 
            this.buttonUserManagerToggleAdmin.Location = new System.Drawing.Point(245, 268);
            this.buttonUserManagerToggleAdmin.Name = "buttonUserManagerToggleAdmin";
            this.buttonUserManagerToggleAdmin.Size = new System.Drawing.Size(115, 34);
            this.buttonUserManagerToggleAdmin.TabIndex = 1;
            this.buttonUserManagerToggleAdmin.Text = "Toggle Admin";
            this.buttonUserManagerToggleAdmin.UseVisualStyleBackColor = true;
            this.buttonUserManagerToggleAdmin.Click += new System.EventHandler(this.buttonUserManagerToggleAdmin_Click);
            // 
            // listViewUserManagerUserList
            // 
            this.listViewUserManagerUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserColumnHeaderUUID,
            this.UserColumnHeaderFullName,
            this.UserColumnHeaderIsAdmin});
            this.listViewUserManagerUserList.HideSelection = false;
            this.listViewUserManagerUserList.Location = new System.Drawing.Point(6, 6);
            this.listViewUserManagerUserList.MultiSelect = false;
            this.listViewUserManagerUserList.Name = "listViewUserManagerUserList";
            this.listViewUserManagerUserList.Size = new System.Drawing.Size(756, 256);
            this.listViewUserManagerUserList.TabIndex = 0;
            this.listViewUserManagerUserList.UseCompatibleStateImageBehavior = false;
            this.listViewUserManagerUserList.View = System.Windows.Forms.View.Details;
            // 
            // UserColumnHeaderUUID
            // 
            this.UserColumnHeaderUUID.Text = "UUID";
            this.UserColumnHeaderUUID.Width = 361;
            // 
            // UserColumnHeaderFullName
            // 
            this.UserColumnHeaderFullName.Text = "Full Name";
            this.UserColumnHeaderFullName.Width = 291;
            // 
            // UserColumnHeaderIsAdmin
            // 
            this.UserColumnHeaderIsAdmin.Text = "Is Admin?";
            this.UserColumnHeaderIsAdmin.Width = 88;
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
            this.comboBoxHotelSelect.TabIndex = 1;
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
            // buttonViewModifyBookings
            // 
            this.buttonViewModifyBookings.Location = new System.Drawing.Point(502, 269);
            this.buttonViewModifyBookings.Name = "buttonViewModifyBookings";
            this.buttonViewModifyBookings.Size = new System.Drawing.Size(127, 34);
            this.buttonViewModifyBookings.TabIndex = 59;
            this.buttonViewModifyBookings.Text = "View/Modify Bookings";
            this.buttonViewModifyBookings.UseVisualStyleBackColor = true;
            this.buttonViewModifyBookings.Click += new System.EventHandler(this.buttonViewModifyBookings_Click);
            // 
            // buttonCreateUserBooking
            // 
            this.buttonCreateUserBooking.Location = new System.Drawing.Point(635, 268);
            this.buttonCreateUserBooking.Name = "buttonCreateUserBooking";
            this.buttonCreateUserBooking.Size = new System.Drawing.Size(127, 34);
            this.buttonCreateUserBooking.TabIndex = 60;
            this.buttonCreateUserBooking.Text = "Create User Booking";
            this.buttonCreateUserBooking.UseVisualStyleBackColor = true;
            this.buttonCreateUserBooking.Click += new System.EventHandler(this.buttonCreateUserBooking_Click);
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
            this.tabPageRoomManager.ResumeLayout(false);
            this.tabPageRoomManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomManagerAmountOfRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomManagerPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomManagerCapacity)).EndInit();
            this.tabPageUserManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageHotelManager;
        private System.Windows.Forms.TabPage tabPageRoomManager;
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
        private Label labelRoomManagerRoomSelected;
        private ComboBox comboBoxRoomManagerRoomSelected;
        private Label labelRoomManagerPrice;
        private Label labelRoomManagerDescription;
        private Label labelRoomManagerAmountOfRooms;
        private Label labelRoomManagerCapacity;
        private Label labelRoomManagerName;
        private TextBox textBoxRoomManagerName;
        private NumericUpDown numericUpDownRoomManagerCapacity;
        private NumericUpDown numericUpDownRoomManagerPrice;
        private NumericUpDown numericUpDownRoomManagerAmountOfRooms;
        private Button buttonRoomManagerReset;
        private Button buttonRoomManagerSave;
        private TabPage tabPageUserManager;
        private ListView listViewUserManagerUserList;
        private ColumnHeader UserColumnHeaderUUID;
        private ColumnHeader UserColumnHeaderFullName;
        private ColumnHeader UserColumnHeaderIsAdmin;
        private Button buttonUserManagerEditUser;
        private Button buttonUserManagerToggleAdmin;
        private RichTextBox textBoxRoomManagerDescription;
        private Button buttonHotelManagerRemove;
        private Button buttonRoomManagerRemove;
        private Button buttonUserManagerRemove;
        private Button buttonViewModifyBookings;
        private Button buttonCreateUserBooking;
    }
}