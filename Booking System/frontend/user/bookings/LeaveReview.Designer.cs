namespace Booking_System.frontend.user.bookings
{
    partial class LeaveReview
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
            this.leaveReviewLabel = new System.Windows.Forms.Label();
            this.labelBooking = new System.Windows.Forms.Label();
            this.comboBoxBookings = new System.Windows.Forms.ComboBox();
            this.buttonSaveReview = new System.Windows.Forms.Button();
            this.groupBoxLeaveReview = new System.Windows.Forms.GroupBox();
            this.labelReviewDescription = new System.Windows.Forms.Label();
            this.richTextBoxReviewDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxReviewTitle = new System.Windows.Forms.TextBox();
            this.labelReviewTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxLeaveReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // leaveReviewLabel
            // 
            this.leaveReviewLabel.AutoSize = true;
            this.leaveReviewLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.leaveReviewLabel.Location = new System.Drawing.Point(42, 20);
            this.leaveReviewLabel.Name = "leaveReviewLabel";
            this.leaveReviewLabel.Size = new System.Drawing.Size(288, 54);
            this.leaveReviewLabel.TabIndex = 72;
            this.leaveReviewLabel.Text = "Leave a Review";
            // 
            // labelBooking
            // 
            this.labelBooking.AutoSize = true;
            this.labelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooking.Location = new System.Drawing.Point(66, 105);
            this.labelBooking.Name = "labelBooking";
            this.labelBooking.Size = new System.Drawing.Size(67, 17);
            this.labelBooking.TabIndex = 73;
            this.labelBooking.Text = "Booking: ";
            // 
            // comboBoxBookings
            // 
            this.comboBoxBookings.FormattingEnabled = true;
            this.comboBoxBookings.Location = new System.Drawing.Point(128, 105);
            this.comboBoxBookings.Name = "comboBoxBookings";
            this.comboBoxBookings.Size = new System.Drawing.Size(383, 21);
            this.comboBoxBookings.TabIndex = 74;
            // 
            // buttonSaveReview
            // 
            this.buttonSaveReview.Location = new System.Drawing.Point(550, 226);
            this.buttonSaveReview.Name = "buttonSaveReview";
            this.buttonSaveReview.Size = new System.Drawing.Size(125, 39);
            this.buttonSaveReview.TabIndex = 75;
            this.buttonSaveReview.Text = "Save Review";
            this.buttonSaveReview.UseVisualStyleBackColor = true;
            this.buttonSaveReview.Click += new System.EventHandler(this.buttonSaveReview_Click);
            // 
            // groupBoxLeaveReview
            // 
            this.groupBoxLeaveReview.Controls.Add(this.labelReviewDescription);
            this.groupBoxLeaveReview.Controls.Add(this.richTextBoxReviewDescription);
            this.groupBoxLeaveReview.Controls.Add(this.textBoxReviewTitle);
            this.groupBoxLeaveReview.Controls.Add(this.labelReviewTitle);
            this.groupBoxLeaveReview.Controls.Add(this.buttonSaveReview);
            this.groupBoxLeaveReview.Location = new System.Drawing.Point(69, 144);
            this.groupBoxLeaveReview.Name = "groupBoxLeaveReview";
            this.groupBoxLeaveReview.Size = new System.Drawing.Size(681, 282);
            this.groupBoxLeaveReview.TabIndex = 76;
            this.groupBoxLeaveReview.TabStop = false;
            this.groupBoxLeaveReview.Text = "Review Information";
            // 
            // labelReviewDescription
            // 
            this.labelReviewDescription.AutoSize = true;
            this.labelReviewDescription.Location = new System.Drawing.Point(23, 61);
            this.labelReviewDescription.Name = "labelReviewDescription";
            this.labelReviewDescription.Size = new System.Drawing.Size(99, 13);
            this.labelReviewDescription.TabIndex = 79;
            this.labelReviewDescription.Text = "Review Description";
            // 
            // richTextBoxReviewDescription
            // 
            this.richTextBoxReviewDescription.Location = new System.Drawing.Point(23, 80);
            this.richTextBoxReviewDescription.Name = "richTextBoxReviewDescription";
            this.richTextBoxReviewDescription.Size = new System.Drawing.Size(634, 130);
            this.richTextBoxReviewDescription.TabIndex = 78;
            this.richTextBoxReviewDescription.Text = "";
            // 
            // textBoxReviewTitle
            // 
            this.textBoxReviewTitle.Location = new System.Drawing.Point(96, 28);
            this.textBoxReviewTitle.Name = "textBoxReviewTitle";
            this.textBoxReviewTitle.Size = new System.Drawing.Size(561, 20);
            this.textBoxReviewTitle.TabIndex = 77;
            // 
            // labelReviewTitle
            // 
            this.labelReviewTitle.AutoSize = true;
            this.labelReviewTitle.Location = new System.Drawing.Point(20, 31);
            this.labelReviewTitle.Name = "labelReviewTitle";
            this.labelReviewTitle.Size = new System.Drawing.Size(69, 13);
            this.labelReviewTitle.TabIndex = 76;
            this.labelReviewTitle.Text = "Review Title:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LeaveReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLeaveReview);
            this.Controls.Add(this.comboBoxBookings);
            this.Controls.Add(this.labelBooking);
            this.Controls.Add(this.leaveReviewLabel);
            this.Name = "LeaveReview";
            this.Text = "Leave Review";
            this.groupBoxLeaveReview.ResumeLayout(false);
            this.groupBoxLeaveReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leaveReviewLabel;
        private System.Windows.Forms.Label labelBooking;
        private System.Windows.Forms.ComboBox comboBoxBookings;
        private System.Windows.Forms.Button buttonSaveReview;
        private System.Windows.Forms.GroupBox groupBoxLeaveReview;
        private System.Windows.Forms.Label labelReviewDescription;
        private System.Windows.Forms.RichTextBox richTextBoxReviewDescription;
        private System.Windows.Forms.TextBox textBoxReviewTitle;
        private System.Windows.Forms.Label labelReviewTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}