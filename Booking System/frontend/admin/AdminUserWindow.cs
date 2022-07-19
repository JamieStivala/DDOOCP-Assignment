using System;
using System.Diagnostics;
using System.Windows.Forms;
using Booking_System.backend.database.hotel;
using Booking_System.backend.model.hotel;
using Booking_System.frontend.auth;

namespace Booking_System.frontend.admin
{
    public partial class AdminUserWindow : Form
    {
        private Hotel currentHotel = null;

        public AdminUserWindow()
        {
            InitializeComponent();
        }

        private void AdminUserWindow_Load(object sender, System.EventArgs e)
        {
            ReloadHotelComboBox();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            new FormSignin().Show();
            this.Hide();
        }

        #region Hotel ComboBox Manager
        /**
         * Update which tabs are accessible based on if a valid hotel is selected.
         */
        private void UpdateAccessibleTabs()
        {
            if (currentHotel != null)
            {
                tabPageRoomManager.Enabled = true;
                tabPageBookingManager.Enabled = true;
            }
            else
            {
                tabPageRoomManager.Enabled = false;
                tabPageBookingManager.Enabled = false;

                if (tabControl.SelectedIndex == 0) return;
                this.ShowError("Please select a valid hotel or create a new hotel.");
                tabControl.SelectedTab = tabPageHotelManager;
            }
        }

        /**
         * When a tab is marked as disabled, the user can't access it.
         */
        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled) return;
            e.Cancel = true;
            this.ShowError("Please select a valid hotel or create a new hotel.");
        }

        /**
         * Update internal hotel on hotel change
         */
        private void UpdateInternalCurrentHotel()
        {
            try
            {
                if (comboBoxHotelSelect.SelectedIndex == -1 ||
                    comboBoxHotelSelect.SelectedIndex == comboBoxHotelSelect.Items.Count - 1) this.currentHotel = null;
                else this.currentHotel = HotelWrapper.GetHotel(comboBoxHotelSelect.SelectedIndex + 1);
            }
            catch (Exception ex)
            {
                this.ShowError(ex.Message);
            }
        }

        /**
         * Reload all the items in the Hotel ComboBox
         */
        private void ReloadHotelComboBox(int selectedIndex = 0)
        {
            comboBoxHotelSelect.Items.Clear();
            try
            {
                Hotel[] hotels = HotelWrapper.GetAllHotels();
                foreach (Hotel hotel in hotels)
                {
                    comboBoxHotelSelect.Items.Add(hotel.Name);
                }
            }
            catch (Exception ex)
            {
                //There is nothing to do in this exception.  It can only be thrown IF there are no hotels, in which case, move on to finally clause anyways and don't show an error to the user.
            }
            finally
            {
                comboBoxHotelSelect.Items.Add("<Create New Hotel>");
                comboBoxHotelSelect.SelectedIndex = selectedIndex;
                this.UpdateInternalCurrentHotel();
            }
        }

        /**
         * On ComboBox Item Change, update the tabs.
         */
        private void comboBoxHotelSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateInternalCurrentHotel();
            this.UpdateAccessibleTabs();
            this.SetHotelManagerTabOnHotelChange();
        }
        #endregion

        #region Hotel Manager Tab
        private void SetHotelManagerTabOnHotelChange()
        {
            if (this.currentHotel == null)
            {
                textBoxHotelManagerName.Text = "";
                textBoxHotelManagerLocation.Text = "";
                dateTimePickerHotelManagerDefaultCheckInTime.Value = new DateTime(2022, 1, 1, 13, 0, 0);
                dateTimePickerHotelManagerDefaultCheckOutTime.Value = new DateTime(2022, 1, 1, 11, 0, 0);
            }
            else
            {
                textBoxHotelManagerName.Text = this.currentHotel.Name;
                textBoxHotelManagerLocation.Text = this.currentHotel.Location;
                dateTimePickerHotelManagerDefaultCheckInTime.Value = this.currentHotel.DefaultCheckInTime;
                dateTimePickerHotelManagerDefaultCheckOutTime.Value = this.currentHotel.DefaultCheckOutTime;
            }
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!this.IsDataValid()) return;
            if (this.currentHotel == null)
            {
                try
                {
                    Hotel newHotel = new Hotel(textBoxHotelManagerName.Text, textBoxHotelManagerLocation.Text,
                        dateTimePickerHotelManagerDefaultCheckInTime.Value, dateTimePickerHotelManagerDefaultCheckOutTime.Value);

                    HotelWrapper.CreateHotel(newHotel);
                    this.ReloadHotelComboBox(comboBoxHotelSelect.SelectedIndex);
                }
                catch (Exception ex)
                {
                    this.ShowError(ex.Message);
                }
            }
            else
            {
                try
                {
                    this.currentHotel.Name = textBoxHotelManagerName.Text;
                    this.currentHotel.Location = textBoxHotelManagerLocation.Text;
                    this.currentHotel.DefaultCheckInTime = dateTimePickerHotelManagerDefaultCheckInTime.Value;
                    this.currentHotel.DefaultCheckOutTime = dateTimePickerHotelManagerDefaultCheckOutTime.Value;

                    HotelWrapper.UpdateHotel(this.currentHotel);
                    this.ReloadHotelComboBox(comboBoxHotelSelect.SelectedIndex);
                }
                catch (Exception ex)
                {
                    this.ShowError(ex.Message);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (this.currentHotel == null)
            {
                textBoxHotelManagerName.Text = "";
                textBoxHotelManagerLocation.Text = "";
                dateTimePickerHotelManagerDefaultCheckInTime.Value = new DateTime(2022, 1, 1, 13, 0, 0);
                dateTimePickerHotelManagerDefaultCheckOutTime.Value = new DateTime(2022, 1, 1, 11, 0, 0);
            }
            else
            {
                textBoxHotelManagerName.Text = this.currentHotel.Name;
                textBoxHotelManagerLocation.Text = this.currentHotel.Location;
                dateTimePickerHotelManagerDefaultCheckInTime.Value = this.currentHotel.DefaultCheckInTime;
                dateTimePickerHotelManagerDefaultCheckOutTime.Value = this.currentHotel.DefaultCheckOutTime;
            }
        }
        #endregion

        #region Shared Code Between Tabs
        private bool IsDataValid()
        {
            errorProvider.Clear();
            bool passed = true;
            int currentTab = tabControl.TabIndex;

            if (currentTab == 0)
            {
                Control[] itemsToValidateEmpty = new Control[]
                {
                    textBoxHotelManagerName, textBoxHotelManagerLocation, dateTimePickerHotelManagerDefaultCheckInTime, dateTimePickerHotelManagerDefaultCheckOutTime
                };
                if (GeneralValidation.IsEmpty(itemsToValidateEmpty, errorProvider)) passed = false;
            }

            return passed;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        #endregion

        
    }
}
