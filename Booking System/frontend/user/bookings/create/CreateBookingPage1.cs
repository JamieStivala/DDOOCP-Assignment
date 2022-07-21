using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booking_System.backend.database.hotel;
using Booking_System.backend.model.hotel;
using Booking_System.backend.model.user;

namespace Booking_System.frontend.user.bookings.create
{
    public partial class CreateBookingPage1 : Form
    {
        private Hotel[] hotels;
        private Room[] rooms;
        private User user;
        public CreateBookingPage1(User user)
        {
            InitializeComponent();
            this.LoadHotels();
            this.user = user;
        }

        private void LoadHotels()
        {
            comboBoxHotel.Items.Clear();
            try
            {
                this.hotels = HotelWrapper.GetAllHotels();
                foreach (Hotel hotel in hotels)
                {
                    comboBoxHotel.Items.Add(hotel.Name);
                }
            }
            catch (Exception ex)
            {
                this.ShowError(ex.Message);
            }
        }

        private Hotel selectedHotel;
        private void LoadHotelRooms()
        {
            comboBoxRoom.Items.Clear();
            this.rooms = null;

            this.selectedHotel = this.hotels[comboBoxHotel.SelectedIndex];
            try
            {
                this.rooms = RoomWrapper.GetHotelRooms(selectedHotel.Id);
                foreach (Room room in this.rooms)
                {
                    comboBoxRoom.Items.Add(room.Name);
                }
            }
            catch (Exception ex)
            {
                this.ShowError(ex.Message);
            }
        }

        private void ResetHotelRoomInformation()
        {
            richTextBoxRoomDescription.Text = "";
            labelMaxAmountOfPeopleValue.Text = "0";
            labelPriceValue.Text = "£0";
            labelCheckInTimeValue.Text = "00:00";
            labelCheckOutTimeValue.Text = "00:00";
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadHotelRooms();
            this.ResetHotelRoomInformation();
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ResetHotelRoomInformation();
            Room room = this.rooms[comboBoxRoom.SelectedIndex]; //Get the selected room

            labelMaxAmountOfPeopleValue.Text = $"{room.Capacity}";
            labelPriceValue.Text = $"£{room.Price}";
            richTextBoxRoomDescription.Text = $"{room.Description}";
            labelCheckInTimeValue.Text = $"{this.selectedHotel.DefaultCheckInTime.ToShortTimeString()}";
            labelCheckOutTimeValue.Text = $"{this.selectedHotel.DefaultCheckOutTime.ToShortTimeString()}";
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            if (comboBoxRoom.SelectedIndex == -1 || this.selectedHotel == null || this.rooms?[comboBoxRoom.SelectedIndex] == null)
            {
                this.ShowError("Please select a hotel and a room to continue to the next page.");
            }
            else
            {
                Room selectedRoom = this.rooms?[comboBoxRoom.SelectedIndex];
                new CreateBookingPage2(this.user, this.selectedHotel, selectedRoom).Show();
                this.Close();
            }
        }
    }
}
