namespace Booking_System.frontend.user.bookings.modify
{
    partial class ListBookings
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
            this.labelListAllBookings = new System.Windows.Forms.Label();
            this.buttonViewBooking = new System.Windows.Forms.Button();
            this.buttonDeleteBooking = new System.Windows.Forms.Button();
            this.listViewBookings = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHotelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmountOfNights = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmountPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelListAllBookings
            // 
            this.labelListAllBookings.AutoSize = true;
            this.labelListAllBookings.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.labelListAllBookings.Location = new System.Drawing.Point(43, 19);
            this.labelListAllBookings.Name = "labelListAllBookings";
            this.labelListAllBookings.Size = new System.Drawing.Size(309, 54);
            this.labelListAllBookings.TabIndex = 73;
            this.labelListAllBookings.Text = "List all bookings";
            // 
            // buttonViewBooking
            // 
            this.buttonViewBooking.Location = new System.Drawing.Point(636, 391);
            this.buttonViewBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewBooking.Name = "buttonViewBooking";
            this.buttonViewBooking.Size = new System.Drawing.Size(117, 35);
            this.buttonViewBooking.TabIndex = 75;
            this.buttonViewBooking.Text = "View/Modify Booking";
            this.buttonViewBooking.UseVisualStyleBackColor = true;
            this.buttonViewBooking.Click += new System.EventHandler(this.buttonViewBooking_Click);
            // 
            // buttonDeleteBooking
            // 
            this.buttonDeleteBooking.Location = new System.Drawing.Point(492, 391);
            this.buttonDeleteBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteBooking.Name = "buttonDeleteBooking";
            this.buttonDeleteBooking.Size = new System.Drawing.Size(117, 35);
            this.buttonDeleteBooking.TabIndex = 76;
            this.buttonDeleteBooking.Text = "Delete Booking";
            this.buttonDeleteBooking.UseVisualStyleBackColor = true;
            this.buttonDeleteBooking.Click += new System.EventHandler(this.buttonDeleteBooking_Click);
            // 
            // listViewBookings
            // 
            this.listViewBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnHotelName,
            this.columnRoomName,
            this.columnAmountOfNights,
            this.columnAmountPaid});
            this.listViewBookings.HideSelection = false;
            this.listViewBookings.Location = new System.Drawing.Point(52, 85);
            this.listViewBookings.Name = "listViewBookings";
            this.listViewBookings.Size = new System.Drawing.Size(701, 291);
            this.listViewBookings.TabIndex = 77;
            this.listViewBookings.UseCompatibleStateImageBehavior = false;
            this.listViewBookings.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            // 
            // columnHotelName
            // 
            this.columnHotelName.Text = "Hotel Name";
            this.columnHotelName.Width = 227;
            // 
            // columnRoomName
            // 
            this.columnRoomName.Text = "Room Name";
            this.columnRoomName.Width = 198;
            // 
            // columnAmountOfNights
            // 
            this.columnAmountOfNights.Text = "Amount of Nights";
            this.columnAmountOfNights.Width = 97;
            // 
            // columnAmountPaid
            // 
            this.columnAmountPaid.Text = "Amount Paid";
            this.columnAmountPaid.Width = 92;
            // 
            // ListBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewBookings);
            this.Controls.Add(this.buttonDeleteBooking);
            this.Controls.Add(this.buttonViewBooking);
            this.Controls.Add(this.labelListAllBookings);
            this.Name = "ListBookings";
            this.Text = "ListBookings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListAllBookings;
        private System.Windows.Forms.Button buttonViewBooking;
        private System.Windows.Forms.Button buttonDeleteBooking;
        private System.Windows.Forms.ListView listViewBookings;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnHotelName;
        private System.Windows.Forms.ColumnHeader columnRoomName;
        private System.Windows.Forms.ColumnHeader columnAmountOfNights;
        private System.Windows.Forms.ColumnHeader columnAmountPaid;
    }
}