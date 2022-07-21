namespace Booking_System.frontend.user.bookings.create
{
    partial class CreateBookingPage2
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
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.dateTimePickerCheckInDay = new System.Windows.Forms.DateTimePicker();
            this.labelCheckInTime = new System.Windows.Forms.Label();
            this.labelCheckOutDay = new System.Windows.Forms.Label();
            this.dateTimePickerCheckOutDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAmountOfNightsValue = new System.Windows.Forms.Label();
            this.labelPricePerNightValue = new System.Windows.Forms.Label();
            this.labelAmountOfNights = new System.Windows.Forms.Label();
            this.labelPricePerNight = new System.Windows.Forms.Label();
            this.labelTotalPriceValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBookNow = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.mainMenuLabel.Location = new System.Drawing.Point(42, 19);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(248, 54);
            this.mainMenuLabel.TabIndex = 72;
            this.mainMenuLabel.Text = "Book a room";
            // 
            // dateTimePickerCheckInDay
            // 
            this.dateTimePickerCheckInDay.Location = new System.Drawing.Point(180, 108);
            this.dateTimePickerCheckInDay.Name = "dateTimePickerCheckInDay";
            this.dateTimePickerCheckInDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckInDay.TabIndex = 1;
            this.dateTimePickerCheckInDay.ValueChanged += new System.EventHandler(this.dateTimePickerCheckInDate_ValueChanged);
            // 
            // labelCheckInTime
            // 
            this.labelCheckInTime.AutoSize = true;
            this.labelCheckInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckInTime.Location = new System.Drawing.Point(67, 108);
            this.labelCheckInTime.Name = "labelCheckInTime";
            this.labelCheckInTime.Size = new System.Drawing.Size(92, 17);
            this.labelCheckInTime.TabIndex = 74;
            this.labelCheckInTime.Text = "Check-in Day";
            // 
            // labelCheckOutDay
            // 
            this.labelCheckOutDay.AutoSize = true;
            this.labelCheckOutDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckOutDay.Location = new System.Drawing.Point(437, 108);
            this.labelCheckOutDay.Name = "labelCheckOutDay";
            this.labelCheckOutDay.Size = new System.Drawing.Size(101, 17);
            this.labelCheckOutDay.TabIndex = 76;
            this.labelCheckOutDay.Text = "Check-out Day";
            // 
            // dateTimePickerCheckOutDay
            // 
            this.dateTimePickerCheckOutDay.Location = new System.Drawing.Point(551, 107);
            this.dateTimePickerCheckOutDay.Name = "dateTimePickerCheckOutDay";
            this.dateTimePickerCheckOutDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckOutDay.TabIndex = 2;
            this.dateTimePickerCheckOutDay.ValueChanged += new System.EventHandler(this.dateTimePickerCheckOutDay_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAmountOfNightsValue);
            this.groupBox1.Controls.Add(this.labelPricePerNightValue);
            this.groupBox1.Controls.Add(this.labelAmountOfNights);
            this.groupBox1.Controls.Add(this.labelPricePerNight);
            this.groupBox1.Controls.Add(this.labelTotalPriceValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(70, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 161);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price Breakdown";
            // 
            // labelAmountOfNightsValue
            // 
            this.labelAmountOfNightsValue.AutoSize = true;
            this.labelAmountOfNightsValue.Location = new System.Drawing.Point(128, 66);
            this.labelAmountOfNightsValue.Name = "labelAmountOfNightsValue";
            this.labelAmountOfNightsValue.Size = new System.Drawing.Size(13, 13);
            this.labelAmountOfNightsValue.TabIndex = 5;
            this.labelAmountOfNightsValue.Text = "0";
            // 
            // labelPricePerNightValue
            // 
            this.labelPricePerNightValue.AutoSize = true;
            this.labelPricePerNightValue.Location = new System.Drawing.Point(128, 41);
            this.labelPricePerNightValue.Name = "labelPricePerNightValue";
            this.labelPricePerNightValue.Size = new System.Drawing.Size(13, 13);
            this.labelPricePerNightValue.TabIndex = 4;
            this.labelPricePerNightValue.Text = "£";
            // 
            // labelAmountOfNights
            // 
            this.labelAmountOfNights.AutoSize = true;
            this.labelAmountOfNights.Location = new System.Drawing.Point(28, 66);
            this.labelAmountOfNights.Name = "labelAmountOfNights";
            this.labelAmountOfNights.Size = new System.Drawing.Size(94, 13);
            this.labelAmountOfNights.TabIndex = 3;
            this.labelAmountOfNights.Text = "Amount of Nights: ";
            // 
            // labelPricePerNight
            // 
            this.labelPricePerNight.AutoSize = true;
            this.labelPricePerNight.Location = new System.Drawing.Point(38, 41);
            this.labelPricePerNight.Name = "labelPricePerNight";
            this.labelPricePerNight.Size = new System.Drawing.Size(84, 13);
            this.labelPricePerNight.TabIndex = 2;
            this.labelPricePerNight.Text = "Price Per Night: ";
            // 
            // labelTotalPriceValue
            // 
            this.labelTotalPriceValue.AutoSize = true;
            this.labelTotalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPriceValue.Location = new System.Drawing.Point(122, 112);
            this.labelTotalPriceValue.Name = "labelTotalPriceValue";
            this.labelTotalPriceValue.Size = new System.Drawing.Size(18, 20);
            this.labelTotalPriceValue.TabIndex = 1;
            this.labelTotalPriceValue.Text = "£";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Price:";
            // 
            // buttonBookNow
            // 
            this.buttonBookNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookNow.Location = new System.Drawing.Point(305, 152);
            this.buttonBookNow.Name = "buttonBookNow";
            this.buttonBookNow.Size = new System.Drawing.Size(97, 161);
            this.buttonBookNow.TabIndex = 3;
            this.buttonBookNow.Text = "Book now";
            this.buttonBookNow.UseVisualStyleBackColor = true;
            this.buttonBookNow.Click += new System.EventHandler(this.buttonBookNow_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateBookingPage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBookNow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCheckOutDay);
            this.Controls.Add(this.dateTimePickerCheckOutDay);
            this.Controls.Add(this.labelCheckInTime);
            this.Controls.Add(this.dateTimePickerCheckInDay);
            this.Controls.Add(this.mainMenuLabel);
            this.Name = "CreateBookingPage2";
            this.Text = "Create Booking";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckInDay;
        private System.Windows.Forms.Label labelCheckInTime;
        private System.Windows.Forms.Label labelCheckOutDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTotalPriceValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPricePerNightValue;
        private System.Windows.Forms.Label labelAmountOfNights;
        private System.Windows.Forms.Label labelPricePerNight;
        private System.Windows.Forms.Button buttonBookNow;
        private System.Windows.Forms.Label labelAmountOfNightsValue;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}