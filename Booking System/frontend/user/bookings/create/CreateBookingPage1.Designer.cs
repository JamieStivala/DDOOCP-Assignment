namespace Booking_System.frontend.user.bookings.create
{
    partial class CreateBookingPage1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.groupBoxRoomInformation = new System.Windows.Forms.GroupBox();
            this.richTextBoxRoomDescription = new System.Windows.Forms.RichTextBox();
            this.labelRoomDescription = new System.Windows.Forms.Label();
            this.labelCheckOutTimeValue = new System.Windows.Forms.Label();
            this.labelCheckInTimeValue = new System.Windows.Forms.Label();
            this.labelPriceValue = new System.Windows.Forms.Label();
            this.labelMaxAmountOfPeopleValue = new System.Windows.Forms.Label();
            this.buttonBookNow = new System.Windows.Forms.Button();
            this.labelCheckOutTime = new System.Windows.Forms.Label();
            this.labelCheckInTime = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMaxAmountOfRoom = new System.Windows.Forms.Label();
            this.groupBoxReviews = new System.Windows.Forms.GroupBox();
            this.richTextBoxReviewDescription = new System.Windows.Forms.RichTextBox();
            this.labelReviewTitleValue = new System.Windows.Forms.Label();
            this.buttonViewBigReview = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNextReview = new System.Windows.Forms.Button();
            this.labelReviewTitle = new System.Windows.Forms.Label();
            this.labelHotel = new System.Windows.Forms.Label();
            this.groupBoxRoomInformation.SuspendLayout();
            this.groupBoxReviews.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.mainMenuLabel.Location = new System.Drawing.Point(42, 19);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(248, 54);
            this.mainMenuLabel.TabIndex = 71;
            this.mainMenuLabel.Text = "Book a room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Hotel:";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(150, 92);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(383, 21);
            this.comboBoxHotel.TabIndex = 1;
            this.comboBoxHotel.SelectedIndexChanged += new System.EventHandler(this.comboBoxHotel_SelectedIndexChanged);
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(150, 137);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(383, 21);
            this.comboBoxRoom.TabIndex = 2;
            this.comboBoxRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoom_SelectedIndexChanged);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.Location = new System.Drawing.Point(84, 138);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(45, 17);
            this.labelRoom.TabIndex = 76;
            this.labelRoom.Text = "Room";
            // 
            // groupBoxRoomInformation
            // 
            this.groupBoxRoomInformation.Controls.Add(this.richTextBoxRoomDescription);
            this.groupBoxRoomInformation.Controls.Add(this.labelRoomDescription);
            this.groupBoxRoomInformation.Controls.Add(this.labelCheckOutTimeValue);
            this.groupBoxRoomInformation.Controls.Add(this.labelCheckInTimeValue);
            this.groupBoxRoomInformation.Controls.Add(this.labelPriceValue);
            this.groupBoxRoomInformation.Controls.Add(this.labelMaxAmountOfPeopleValue);
            this.groupBoxRoomInformation.Controls.Add(this.buttonBookNow);
            this.groupBoxRoomInformation.Controls.Add(this.labelCheckOutTime);
            this.groupBoxRoomInformation.Controls.Add(this.labelCheckInTime);
            this.groupBoxRoomInformation.Controls.Add(this.labelPrice);
            this.groupBoxRoomInformation.Controls.Add(this.labelMaxAmountOfRoom);
            this.groupBoxRoomInformation.Location = new System.Drawing.Point(73, 183);
            this.groupBoxRoomInformation.Name = "groupBoxRoomInformation";
            this.groupBoxRoomInformation.Size = new System.Drawing.Size(692, 193);
            this.groupBoxRoomInformation.TabIndex = 80;
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
            this.labelCheckOutTimeValue.Location = new System.Drawing.Point(630, 78);
            this.labelCheckOutTimeValue.Name = "labelCheckOutTimeValue";
            this.labelCheckOutTimeValue.Size = new System.Drawing.Size(34, 13);
            this.labelCheckOutTimeValue.TabIndex = 8;
            this.labelCheckOutTimeValue.Text = "00:00";
            // 
            // labelCheckInTimeValue
            // 
            this.labelCheckInTimeValue.AutoSize = true;
            this.labelCheckInTimeValue.Location = new System.Drawing.Point(630, 33);
            this.labelCheckInTimeValue.Name = "labelCheckInTimeValue";
            this.labelCheckInTimeValue.Size = new System.Drawing.Size(34, 13);
            this.labelCheckInTimeValue.TabIndex = 7;
            this.labelCheckInTimeValue.Text = "00:00";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.AutoSize = true;
            this.labelPriceValue.Location = new System.Drawing.Point(391, 78);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(19, 13);
            this.labelPriceValue.TabIndex = 6;
            this.labelPriceValue.Text = "£0";
            // 
            // labelMaxAmountOfPeopleValue
            // 
            this.labelMaxAmountOfPeopleValue.AutoSize = true;
            this.labelMaxAmountOfPeopleValue.Location = new System.Drawing.Point(426, 33);
            this.labelMaxAmountOfPeopleValue.Name = "labelMaxAmountOfPeopleValue";
            this.labelMaxAmountOfPeopleValue.Size = new System.Drawing.Size(13, 13);
            this.labelMaxAmountOfPeopleValue.TabIndex = 5;
            this.labelMaxAmountOfPeopleValue.Text = "0";
            // 
            // buttonBookNow
            // 
            this.buttonBookNow.Location = new System.Drawing.Point(364, 137);
            this.buttonBookNow.Name = "buttonBookNow";
            this.buttonBookNow.Size = new System.Drawing.Size(125, 39);
            this.buttonBookNow.TabIndex = 4;
            this.buttonBookNow.Text = "Next Page";
            this.buttonBookNow.UseVisualStyleBackColor = true;
            this.buttonBookNow.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // labelCheckOutTime
            // 
            this.labelCheckOutTime.AutoSize = true;
            this.labelCheckOutTime.Location = new System.Drawing.Point(537, 78);
            this.labelCheckOutTime.Name = "labelCheckOutTime";
            this.labelCheckOutTime.Size = new System.Drawing.Size(87, 13);
            this.labelCheckOutTime.TabIndex = 3;
            this.labelCheckOutTime.Text = "Check Out Time:";
            // 
            // labelCheckInTime
            // 
            this.labelCheckInTime.AutoSize = true;
            this.labelCheckInTime.Location = new System.Drawing.Point(545, 33);
            this.labelCheckInTime.Name = "labelCheckInTime";
            this.labelCheckInTime.Size = new System.Drawing.Size(79, 13);
            this.labelCheckInTime.TabIndex = 2;
            this.labelCheckInTime.Text = "Check In Time:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(304, 78);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(81, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price Per Night:";
            // 
            // labelMaxAmountOfRoom
            // 
            this.labelMaxAmountOfRoom.AutoSize = true;
            this.labelMaxAmountOfRoom.Location = new System.Drawing.Point(304, 33);
            this.labelMaxAmountOfRoom.Name = "labelMaxAmountOfRoom";
            this.labelMaxAmountOfRoom.Size = new System.Drawing.Size(115, 13);
            this.labelMaxAmountOfRoom.TabIndex = 0;
            this.labelMaxAmountOfRoom.Text = "Max amount of people:";
            // 
            // groupBoxReviews
            // 
            this.groupBoxReviews.Controls.Add(this.richTextBoxReviewDescription);
            this.groupBoxReviews.Controls.Add(this.labelReviewTitleValue);
            this.groupBoxReviews.Controls.Add(this.buttonViewBigReview);
            this.groupBoxReviews.Controls.Add(this.label4);
            this.groupBoxReviews.Controls.Add(this.buttonNextReview);
            this.groupBoxReviews.Controls.Add(this.labelReviewTitle);
            this.groupBoxReviews.Location = new System.Drawing.Point(569, 69);
            this.groupBoxReviews.Name = "groupBoxReviews";
            this.groupBoxReviews.Size = new System.Drawing.Size(201, 111);
            this.groupBoxReviews.TabIndex = 81;
            this.groupBoxReviews.TabStop = false;
            this.groupBoxReviews.Text = "Reviews";
            // 
            // richTextBoxReviewDescription
            // 
            this.richTextBoxReviewDescription.Location = new System.Drawing.Point(13, 55);
            this.richTextBoxReviewDescription.Name = "richTextBoxReviewDescription";
            this.richTextBoxReviewDescription.ReadOnly = true;
            this.richTextBoxReviewDescription.Size = new System.Drawing.Size(182, 21);
            this.richTextBoxReviewDescription.TabIndex = 85;
            this.richTextBoxReviewDescription.Text = "";
            // 
            // labelReviewTitleValue
            // 
            this.labelReviewTitleValue.AutoSize = true;
            this.labelReviewTitleValue.Location = new System.Drawing.Point(49, 20);
            this.labelReviewTitleValue.Name = "labelReviewTitleValue";
            this.labelReviewTitleValue.Size = new System.Drawing.Size(0, 13);
            this.labelReviewTitleValue.TabIndex = 84;
            // 
            // buttonViewBigReview
            // 
            this.buttonViewBigReview.Location = new System.Drawing.Point(103, 82);
            this.buttonViewBigReview.Name = "buttonViewBigReview";
            this.buttonViewBigReview.Size = new System.Drawing.Size(92, 23);
            this.buttonViewBigReview.TabIndex = 5;
            this.buttonViewBigReview.Text = "Show Bigger";
            this.buttonViewBigReview.UseVisualStyleBackColor = true;
            this.buttonViewBigReview.Click += new System.EventHandler(this.buttonViewBigReview_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Description";
            // 
            // buttonNextReview
            // 
            this.buttonNextReview.Location = new System.Drawing.Point(13, 82);
            this.buttonNextReview.Name = "buttonNextReview";
            this.buttonNextReview.Size = new System.Drawing.Size(84, 23);
            this.buttonNextReview.TabIndex = 3;
            this.buttonNextReview.Text = "Next Review";
            this.buttonNextReview.UseVisualStyleBackColor = true;
            this.buttonNextReview.Click += new System.EventHandler(this.buttonNextReview_Click);
            // 
            // labelReviewTitle
            // 
            this.labelReviewTitle.AutoSize = true;
            this.labelReviewTitle.Location = new System.Drawing.Point(10, 20);
            this.labelReviewTitle.Name = "labelReviewTitle";
            this.labelReviewTitle.Size = new System.Drawing.Size(33, 13);
            this.labelReviewTitle.TabIndex = 82;
            this.labelReviewTitle.Text = "Title: ";
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotel.Location = new System.Drawing.Point(84, 93);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(45, 17);
            this.labelHotel.TabIndex = 72;
            this.labelHotel.Text = "Hotel:";
            // 
            // CreateBookingPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxReviews);
            this.Controls.Add(this.groupBoxRoomInformation);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuLabel);
            this.Name = "CreateBookingPage1";
            this.Text = "Create Booking";
            this.groupBoxRoomInformation.ResumeLayout(false);
            this.groupBoxRoomInformation.PerformLayout();
            this.groupBoxReviews.ResumeLayout(false);
            this.groupBoxReviews.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.GroupBox groupBoxRoomInformation;
        private System.Windows.Forms.Button buttonBookNow;
        private System.Windows.Forms.Label labelCheckOutTime;
        private System.Windows.Forms.Label labelCheckInTime;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMaxAmountOfRoom;
        private System.Windows.Forms.GroupBox groupBoxReviews;
        private System.Windows.Forms.Button buttonNextReview;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.Label labelPriceValue;
        private System.Windows.Forms.Label labelMaxAmountOfPeopleValue;
        private System.Windows.Forms.Label labelCheckOutTimeValue;
        private System.Windows.Forms.Label labelCheckInTimeValue;
        private System.Windows.Forms.RichTextBox richTextBoxRoomDescription;
        private System.Windows.Forms.Label labelRoomDescription;
        private System.Windows.Forms.Button buttonViewBigReview;
        private System.Windows.Forms.RichTextBox richTextBoxReviewDescription;
        private System.Windows.Forms.Label labelReviewTitleValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelReviewTitle;
    }
}