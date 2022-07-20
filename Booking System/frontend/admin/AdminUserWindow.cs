using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Booking_System.backend.database;
using Booking_System.backend.database.hotel;
using Booking_System.backend.model.hotel;
using Booking_System.backend.model.user;
using Booking_System.frontend.auth;
using Booking_System.frontend.user;

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
            LoadAllUsers();
            tabControl.Selecting += tabControl_Selecting; //TabControl Selecting to be able to cancel
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            new FormSignin().Show();
            this.Hide();
        }

        #region Hotel ComboBox Manager
        private readonly Dictionary<int, Hotel> indexedHotels = new Dictionary<int, Hotel>();

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
                else this.currentHotel = this.indexedHotels[comboBoxHotelSelect.SelectedIndex];
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
            this.indexedHotels.Clear();
            try
            {
                Hotel[] hotels = HotelWrapper.GetAllHotels();
                for (int i = 0; i != hotels.Length; i++)
                {
                    this.indexedHotels.Add(i, hotels[i]);
                    comboBoxHotelSelect.Items.Add(hotels[i].Name);
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
            this.FillRoomManagerComboBox();
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

        private void buttonHotelManagerSave_Click(object sender, System.EventArgs e)
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

        private void buttonHotelManagerReset_Click(object sender, EventArgs e)
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

        #region Room Manager Tab

        private readonly Dictionary<int, Room> indexedRooms = new Dictionary<int, Room>(); //Store the index in the list -> room, so when the items in the list change (Or ID is not consecutive) the code does not break
        private void FillRoomManagerComboBox(int selectedRoomId = -1)
        {
            int selectedRoomIndex = 0;

            if (this.currentHotel == null) return; //If the hotel room is not selected, return
            this.currentRoom = null; //Reset current room
            comboBoxRoomManagerRoomSelected.Items.Clear(); //Reset combo box
            indexedRooms.Clear(); //Reset indexed rooms

            try
            {
                Room[] rooms = RoomWrapper.GetHotelRooms(this.currentHotel.Id); //Get all the hotel rooms

                for (int i = 0; i != rooms.Length; i++)
                {
                    Room room = rooms[i];
                    comboBoxRoomManagerRoomSelected.Items.Add(room.Name);
                    indexedRooms.Add(i, room); //Store the indexed room
                    if(room.Id == selectedRoomId) selectedRoomIndex = i;
                }
            }
            catch (Exception ex)
            {
                //There is nothing to do here.  This exception can only happen if there are no hotel rooms
            }
            finally
            {
                comboBoxRoomManagerRoomSelected.Items.Add("<Create new room>");
                comboBoxRoomManagerRoomSelected.SelectedIndex = selectedRoomIndex; //If the room is not found, just go to create new room
            }
        }

        private Room currentRoom;
        private void comboBoxRoomManagerRoomSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRoomManagerRoomSelected.SelectedIndex == comboBoxRoomManagerRoomSelected.Items.Count - 1) //If the room is set to "Create New Room", reset all values to default
            {
                this.currentRoom = null;
                textBoxRoomManagerName.Text = "";
                textBoxRoomManagerDescription.Text = "";
                numericUpDownRoomManagerCapacity.Value = 1;
                numericUpDownRoomManagerPrice.Value = 10;
                numericUpDownRoomManagerAmountOfRooms.Value = 1;
            }
            else //If a valid room is selected, set the text boxes to the values of the room
            {
                this.currentRoom = this.indexedRooms[comboBoxRoomManagerRoomSelected.SelectedIndex];

                textBoxRoomManagerName.Text = currentRoom.Name;
                textBoxRoomManagerDescription.Text = currentRoom.Description;
                numericUpDownRoomManagerCapacity.Value = currentRoom.Capacity;
                numericUpDownRoomManagerPrice.Value = (decimal)currentRoom.Price;
                numericUpDownRoomManagerAmountOfRooms.Value = currentRoom.AmountOfRooms;
            }
        }

        private void buttonRoomManagerSave_Click(object sender, EventArgs e)
        {
            if (this.currentRoom == null) //If creating new room
            {
                Room room = new Room(this.currentHotel.Id, textBoxRoomManagerName.Text, textBoxRoomManagerDescription.Text,
                    decimal.ToInt32(numericUpDownRoomManagerCapacity.Value), (double)numericUpDownRoomManagerPrice.Value,
                    decimal.ToInt32(numericUpDownRoomManagerAmountOfRooms.Value));
                try
                {
                    RoomWrapper.CreateRoom(room);
                    this.FillRoomManagerComboBox(room.Id);
                }
                catch (Exception ex)
                {
                    this.ShowError(ex.Message);
                }
            }
            else //If updating room
            {
                try
                {
                    this.currentRoom.Name = textBoxRoomManagerName.Text;
                    currentRoom.Description = textBoxRoomManagerDescription.Text;
                    currentRoom.Capacity = (int)numericUpDownRoomManagerCapacity.Value;
                    currentRoom.Price = (double)numericUpDownRoomManagerPrice.Value;
                    currentRoom.AmountOfRooms = (int)numericUpDownRoomManagerAmountOfRooms.Value;
                    RoomWrapper.UpdateRoom(this.currentRoom);
                    this.FillRoomManagerComboBox(this.currentRoom.Id);
                }
                catch (Exception ex)
                {
                    this.ShowError(ex.Message);
                }
            }
        }

        /**
         * On reset press, reset the text boxes
         */
        private void buttonRoomManagerReset_Click(object sender, EventArgs e)
        {
            if (this.currentRoom == null)
            {
                textBoxRoomManagerName.Text = "";
                textBoxRoomManagerDescription.Text = "";
                numericUpDownRoomManagerCapacity.Value = 1;
                numericUpDownRoomManagerPrice.Value = 10;
                numericUpDownRoomManagerAmountOfRooms.Value = 1;
            }
            else
            {
                textBoxRoomManagerName.Text = currentRoom.Name;
                textBoxRoomManagerDescription.Text = currentRoom.Description;
                numericUpDownRoomManagerCapacity.Value = currentRoom.Capacity;
                numericUpDownRoomManagerPrice.Value = (decimal)currentRoom.Price;
                numericUpDownRoomManagerAmountOfRooms.Value = currentRoom.AmountOfRooms;
            }
        }
        #endregion

        #region User Manager Tab

        private User[] allUsers;
        private void LoadAllUsers()
        {
            try
            {
                listViewUserManagerUserList.Items.Clear();

                User[] users = UserWrapper.GetAllUsers();
                this.allUsers = users;

                for (int i = 0; i != users.Length; i++)
                {
                    char isAdmin = users[i].Type == UserType.Admin ? 'Y' : 'N';
                    ListViewItem listViewItem = new ListViewItem(users[i].Uuid);
                    listViewItem.SubItems.Add($"{users[i].FirstName} {users[i].LastName}");
                    listViewItem.SubItems.Add(isAdmin + "");
                    listViewUserManagerUserList.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                this.ShowError(ex.Message);
            }
        }

        private User GetSelectedUser()
        {
            if (listViewUserManagerUserList.SelectedItems.Count != 1)
            {
                this.ShowError("Please select a user.");
                return null;
            } 

            string uuid = listViewUserManagerUserList.SelectedItems[0].Text;
            return allUsers.Single(value => value.Uuid == uuid); //Get the user with that UUID
        }

        private void buttonUserManagerToggleAdmin_Click(object sender, EventArgs e)
        {
            User user = GetSelectedUser();
            UserType originalUserType = user.Type;

            switch (user.Type)
            {
                case UserType.Admin:
                {
                    DialogResult dialogResult =
                        MessageBox.Show($"Are you sure you want to remove {user.FirstName} {user.LastName} from an administrator?",
                            "Confirm administrator change", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes) user.Type = UserType.Customer;
                    break;
                }
                case UserType.Customer:
                {
                    DialogResult dialogResult =  
                        MessageBox.Show($"Are you sure you want to make {user.FirstName} {user.LastName} an administrator?",
                            "Confirm administrator change", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes) user.Type = UserType.Admin;
                    break;
                }
            }

            if(originalUserType == user.Type) return; //Means nothing was updated

            UserWrapper.UpdateUser(user);
            LoadAllUsers(); //Reload user list
        }

        private void buttonUserManagerEditUser_Click(object sender, EventArgs e)
        {
            User user = this.GetSelectedUser();
            new EditPersonalInformation(user).Show(); 
            LoadAllUsers(); //Reload user list
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
