namespace Booking_System.frontend.user.bookings
{
    partial class ModifyBooking
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
            this.viewBookingLabel = new System.Windows.Forms.Label();
            this.groupBoxReviews = new System.Windows.Forms.GroupBox();
            this.buttonNextReview = new System.Windows.Forms.Button();
            this.groupBoxRoomInformation = new System.Windows.Forms.GroupBox();
            this.richTextBoxRoomDescription = new System.Windows.Forms.RichTextBox();
            this.labelRoomDescription = new System.Windows.Forms.Label();
            this.labelCheckOutTimeValue = new System.Windows.Forms.Label();
            this.labelCheckInTimeValue = new System.Windows.Forms.Label();
            this.labelMaxAmountOfPeopleValue = new System.Windows.Forms.Label();
            this.labelCheckOutTime = new System.Windows.Forms.Label();
            this.labelCheckInTime = new System.Windows.Forms.Label();
            this.labelMaxAmountOfRoom = new System.Windows.Forms.Label();
            this.buttonSaveModifiedBooking = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAmountOfNightsValue = new System.Windows.Forms.Label();
            this.labelPricePerNightValue = new System.Windows.Forms.Label();
            this.labelAmountOfNights = new System.Windows.Forms.Label();
            this.labelPricePerNight = new System.Windows.Forms.Label();
            this.labelTotalPriceValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCheckOutDay = new System.Windows.Forms.Label();
            this.dateTimePickerCheckOutDay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerCheckInDay = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxReviews.SuspendLayout();
            this.groupBoxRoomInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBookingLabel
            // 
            this.viewBookingLabel.AutoSize = true;
            this.viewBookingLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.viewBookingLabel.Location = new System.Drawing.Point(41, 19);
            this.viewBookingLabel.Name = "viewBookingLabel";
            this.viewBookingLabel.Size = new System.Drawing.Size(337, 54);
            this.viewBookingLabel.TabIndex = 72;
            this.viewBookingLabel.Text = "Modify a booking";
            // 
            // groupBoxReviews
            // 
            this.groupBoxReviews.Controls.Add(this.buttonNextReview);
            this.groupBoxReviews.Location = new System.Drawing.Point(548, 72);
            this.groupBoxReviews.Name = "groupBoxReviews";
            this.groupBoxReviews.Size = new System.Drawing.Size(201, 111);
            this.groupBoxReviews.TabIndex = 83;
            this.groupBoxReviews.TabStop = false;
            this.groupBoxReviews.Text = "Reviews";
            // 
            // buttonNextReview
            // 
            this.buttonNextReview.Location = new System.Drawing.Point(6, 82);
            this.buttonNextReview.Name = "buttonNextReview";
            this.buttonNextReview.Size = new System.Drawing.Size(189, 23);
            this.buttonNextReview.TabIndex = 3;
            this.buttonNextReview.Text = "Next Review";
            this.buttonNextReview.UseVisualStyleBackColor = true;
            // 
            // groupBoxRoomInformation
            // 
            this.groupBoxRoomInformation.Controls.Add(this.richTextBoxRoomDescription);
            this.groupBoxRoomInformation.Controls.Add(this.labelRoomDescription);
            this.groupBoxRoomInformation.Controls.Add(this.labelCheckOutTimeValue);
            this.groupBoxRoomInformation.Controls.Add(this.labelCheckInTimeValue);
            this.groupBoxRoomInformation.Controls.Add(this.labelMaxAmountOfPeopleValue);
            this.groupBoxRoomInformation.Controls.Add(this.labelCheckOutTime);
            this.groupBoxRoomInformation.Controls.Add(this.labelCheckInTime);
            this.groupBoxRoomInformation.Controls.Add(this.labelMaxAmountOfRoom);
            this.groupBoxRoomInformation.Location = new System.Drawing.Point(295, 208);
            this.groupBoxRoomInformation.Name = "groupBoxRoomInformation";
            this.groupBoxRoomInformation.Size = new System.Drawing.Size(454, 185);
            this.groupBoxRoomInformation.TabIndex = 82;
            this.groupBoxRoomInformation.TabStop = false;
            this.groupBoxRoomInformation.Text = "Room Information";
            // 
            // richTextBoxRoomDescription
            // 
            this.richTextBoxRoomDescription.Location = new System.Drawing.Point(20, 57);
            this.richTextBoxRoomDescription.Name = "richTextBoxRoomDescription";
            this.richTextBoxRoomDescription.ReadOnly = true;
            this.richTextBoxRoomDescription.Size = new System.Drawing.Size(198, 119);
            this.richTextBoxRoomDescription.TabIndex = 10;
            this.richTextBoxRoomDescription.Text = "";
            // 
            // labelRoomDescription
            // 
            this.labelRoomDescription.AutoSize = true;
            this.labelRoomDescription.Location = new System.Drawing.Point(17, 33);
            this.labelRoomDescription.Name = "labelRoomDescription";
            this.labelRoomDescription.Size = new System.Drawing.Size(91, 13);
            this.labelRoomDescription.TabIndex = 9;
            this.labelRoomDescription.Text = "Room Description";
            // 
            // labelCheckOutTimeValue
            // 
            this.labelCheckOutTimeValue.AutoSize = true;
            this.labelCheckOutTimeValue.Location = new System.Drawing.Point(376, 76);
            this.labelCheckOutTimeValue.Name = "labelCheckOutTimeValue";
            this.labelCheckOutTimeValue.Size = new System.Drawing.Size(34, 13);
            this.labelCheckOutTimeValue.TabIndex = 8;
            this.labelCheckOutTimeValue.Text = "00:00";
            // 
            // labelCheckInTimeValue
            // 
            this.labelCheckInTimeValue.AutoSize = true;
            this.labelCheckInTimeValue.Location = new System.Drawing.Point(376, 56);
            this.labelCheckInTimeValue.Name = "labelCheckInTimeValue";
            this.labelCheckInTimeValue.Size = new System.Drawing.Size(34, 13);
            this.labelCheckInTimeValue.TabIndex = 7;
            this.labelCheckInTimeValue.Text = "00:00";
            // 
            // labelMaxAmountOfPeopleValue
            // 
            this.labelMaxAmountOfPeopleValue.AutoSize = true;
            this.labelMaxAmountOfPeopleValue.Location = new System.Drawing.Point(417, 37);
            this.labelMaxAmountOfPeopleValue.Name = "labelMaxAmountOfPeopleValue";
            this.labelMaxAmountOfPeopleValue.Size = new System.Drawing.Size(13, 13);
            this.labelMaxAmountOfPeopleValue.TabIndex = 5;
            this.labelMaxAmountOfPeopleValue.Text = "0";
            // 
            // labelCheckOutTime
            // 
            this.labelCheckOutTime.AutoSize = true;
            this.labelCheckOutTime.Location = new System.Drawing.Point(283, 76);
            this.labelCheckOutTime.Name = "labelCheckOutTime";
            this.labelCheckOutTime.Size = new System.Drawing.Size(87, 13);
            this.labelCheckOutTime.TabIndex = 3;
            this.labelCheckOutTime.Text = "Check Out Time:";
            // 
            // labelCheckInTime
            // 
            this.labelCheckInTime.AutoSize = true;
            this.labelCheckInTime.Location = new System.Drawing.Point(291, 56);
            this.labelCheckInTime.Name = "labelCheckInTime";
            this.labelCheckInTime.Size = new System.Drawing.Size(79, 13);
            this.labelCheckInTime.TabIndex = 2;
            this.labelCheckInTime.Text = "Check In Time:";
            // 
            // labelMaxAmountOfRoom
            // 
            this.labelMaxAmountOfRoom.AutoSize = true;
            this.labelMaxAmountOfRoom.Location = new System.Drawing.Point(295, 37);
            this.labelMaxAmountOfRoom.Name = "labelMaxAmountOfRoom";
            this.labelMaxAmountOfRoom.Size = new System.Drawing.Size(115, 13);
            this.labelMaxAmountOfRoom.TabIndex = 0;
            this.labelMaxAmountOfRoom.Text = "Max amount of people:";
            // 
            // buttonSaveModifiedBooking
            // 
            this.buttonSaveModifiedBooking.Location = new System.Drawing.Point(600, 399);
            this.buttonSaveModifiedBooking.Name = "buttonSaveModifiedBooking";
            this.buttonSaveModifiedBooking.Size = new System.Drawing.Size(125, 39);
            this.buttonSaveModifiedBooking.TabIndex = 4;
            this.buttonSaveModifiedBooking.Text = "Save Modified Booking";
            this.buttonSaveModifiedBooking.UseVisualStyleBackColor = true;
            this.buttonSaveModifiedBooking.Click += new System.EventHandler(this.buttonSaveModifiedBooking_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAmountOfNightsValue);
            this.groupBox1.Controls.Add(this.labelPricePerNightValue);
            this.groupBox1.Controls.Add(this.labelAmountOfNights);
            this.groupBox1.Controls.Add(this.labelPricePerNight);
            this.groupBox1.Controls.Add(this.labelTotalPriceValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 185);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price Breakdown";
            // 
            // labelAmountOfNightsValue
            // 
            this.labelAmountOfNightsValue.AutoSize = true;
            this.labelAmountOfNightsValue.Location = new System.Drawing.Point(125, 82);
            this.labelAmountOfNightsValue.Name = "labelAmountOfNightsValue";
            this.labelAmountOfNightsValue.Size = new System.Drawing.Size(13, 13);
            this.labelAmountOfNightsValue.TabIndex = 5;
            this.labelAmountOfNightsValue.Text = "0";
            // 
            // labelPricePerNightValue
            // 
            this.labelPricePerNightValue.AutoSize = true;
            this.labelPricePerNightValue.Location = new System.Drawing.Point(125, 57);
            this.labelPricePerNightValue.Name = "labelPricePerNightValue";
            this.labelPricePerNightValue.Size = new System.Drawing.Size(13, 13);
            this.labelPricePerNightValue.TabIndex = 4;
            this.labelPricePerNightValue.Text = "£";
            // 
            // labelAmountOfNights
            // 
            this.labelAmountOfNights.AutoSize = true;
            this.labelAmountOfNights.Location = new System.Drawing.Point(25, 82);
            this.labelAmountOfNights.Name = "labelAmountOfNights";
            this.labelAmountOfNights.Size = new System.Drawing.Size(94, 13);
            this.labelAmountOfNights.TabIndex = 3;
            this.labelAmountOfNights.Text = "Amount of Nights: ";
            // 
            // labelPricePerNight
            // 
            this.labelPricePerNight.AutoSize = true;
            this.labelPricePerNight.Location = new System.Drawing.Point(35, 57);
            this.labelPricePerNight.Name = "labelPricePerNight";
            this.labelPricePerNight.Size = new System.Drawing.Size(84, 13);
            this.labelPricePerNight.TabIndex = 2;
            this.labelPricePerNight.Text = "Price Per Night: ";
            // 
            // labelTotalPriceValue
            // 
            this.labelTotalPriceValue.AutoSize = true;
            this.labelTotalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPriceValue.Location = new System.Drawing.Point(119, 128);
            this.labelTotalPriceValue.Name = "labelTotalPriceValue";
            this.labelTotalPriceValue.Size = new System.Drawing.Size(18, 20);
            this.labelTotalPriceValue.TabIndex = 1;
            this.labelTotalPriceValue.Text = "£";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Price:";
            // 
            // labelCheckOutDay
            // 
            this.labelCheckOutDay.AutoSize = true;
            this.labelCheckOutDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckOutDay.Location = new System.Drawing.Point(21, 145);
            this.labelCheckOutDay.Name = "labelCheckOutDay";
            this.labelCheckOutDay.Size = new System.Drawing.Size(101, 17);
            this.labelCheckOutDay.TabIndex = 88;
            this.labelCheckOutDay.Text = "Check-out Day";
            // 
            // dateTimePickerCheckOutDay
            // 
            this.dateTimePickerCheckOutDay.Location = new System.Drawing.Point(135, 144);
            this.dateTimePickerCheckOutDay.Name = "dateTimePickerCheckOutDay";
            this.dateTimePickerCheckOutDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckOutDay.TabIndex = 86;
            this.dateTimePickerCheckOutDay.ValueChanged += new System.EventHandler(this.dateTimePickerCheckOutDay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 87;
            this.label2.Text = "Check-in Day";
            // 
            // dateTimePickerCheckInDay
            // 
            this.dateTimePickerCheckInDay.Location = new System.Drawing.Point(137, 110);
            this.dateTimePickerCheckInDay.Name = "dateTimePickerCheckInDay";
            this.dateTimePickerCheckInDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckInDay.TabIndex = 85;
            this.dateTimePickerCheckInDay.ValueChanged += new System.EventHandler(this.dateTimePickerCheckInDay_ValueChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(469, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 39);
            this.buttonCancel.TabIndex = 89;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ModifyBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelCheckOutDay);
            this.Controls.Add(this.dateTimePickerCheckOutDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerCheckInDay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxReviews);
            this.Controls.Add(this.groupBoxRoomInformation);
            this.Controls.Add(this.viewBookingLabel);
            this.Controls.Add(this.buttonSaveModifiedBooking);
            this.Name = "ModifyBooking";
            this.Text = "Modify Booking";
            this.groupBoxReviews.ResumeLayout(false);
            this.groupBoxRoomInformation.ResumeLayout(false);
            this.groupBoxRoomInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewBookingLabel;
        private System.Windows.Forms.GroupBox groupBoxReviews;
        private System.Windows.Forms.Button buttonNextReview;
        private System.Windows.Forms.GroupBox groupBoxRoomInformation;
        private System.Windows.Forms.RichTextBox richTextBoxRoomDescription;
        private System.Windows.Forms.Label labelRoomDescription;
        private System.Windows.Forms.Label labelCheckOutTimeValue;
        private System.Windows.Forms.Label labelCheckInTimeValue;
        private System.Windows.Forms.Label labelMaxAmountOfPeopleValue;
        private System.Windows.Forms.Button buttonSaveModifiedBooking;
        private System.Windows.Forms.Label labelCheckOutTime;
        private System.Windows.Forms.Label labelCheckInTime;
        private System.Windows.Forms.Label labelMaxAmountOfRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAmountOfNightsValue;
        private System.Windows.Forms.Label labelPricePerNightValue;
        private System.Windows.Forms.Label labelAmountOfNights;
        private System.Windows.Forms.Label labelPricePerNight;
        private System.Windows.Forms.Label labelTotalPriceValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCheckOutDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckInDay;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}