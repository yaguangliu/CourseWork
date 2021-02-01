using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LibraryTry3.Domain;
using LibraryTry3.Tools;
using Microsoft.Win32;

namespace LibraryTry3
{
    /// <summary>
    /// Interaction logic for EditReaderDialog.xaml
    /// </summary>
    public partial class EditReaderDialog : Window
    {
        public Reader CurrentReader;
        public byte[] currenPhoto;
        public EditReaderDialog(Reader reader)
        {
            InitializeComponent();
            CurrentReader = reader;
            currenPhoto = CurrentReader.Photo;
            comboGender.ItemsSource = Enum.GetValues(typeof(Reader.GenderEnum));
            comboProvince.ItemsSource = Enum.GetValues(typeof(Address.ProvinceEnum));
            tbID.Text = CurrentReader.ReaderID;
            txtCity.Text = CurrentReader.Address.City;
            txtEmail.Text = CurrentReader.Email;
            txtFirst.Text = CurrentReader.FirstName;
            txtLast.Text = CurrentReader.LastName;
            txtPhone.Text = CurrentReader.Phone;
            txtPostcode.Text = CurrentReader.Address.Postcode;
            txtRoomNo.Text = CurrentReader.Address.RoomNum;
            txtStreet1.Text = CurrentReader.Address.AddressLine1;
            txtStreet2.Text = CurrentReader.Address.AddressLine2;
            txtPhoto.Visibility = Visibility.Hidden;
            readerPhoto.Source = LibUtils.ByteArrayToBitmapImage(currenPhoto);
            birthDatePicker.SelectedDate = CurrentReader.DateOfBirth;
            startDatePiker.SelectedDate = CurrentReader.StartDate;
            comboGender.Text = CurrentReader.Gender.ToString();
            comboProvince.Text = CurrentReader.Address.Province.ToString();

        }

        private void Btn_close_edit_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_update_reader_OnClick(object sender, RoutedEventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            /*if (txtCity.Text.Length == 0)
            {
                MessageBox.Show("City is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.Address.City = txtCity.Text;
            /*if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Email is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.Email = txtEmail.Text;

            /*
            if (txtFirst.Text.Length == 0)
            {
                MessageBox.Show("First Name is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.FirstName = txtFirst.Text;

            var lastText = txtLast.Text;
            /*if (lastText.Length == 0)
            {
                MessageBox.Show("Last Name is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.LastName = lastText;

            var phoneText = txtPhone.Text;
            /*if (phoneText.Length == 0)
            {
                MessageBox.Show("Phone is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.Phone = phoneText;

            var postcodeText = txtPostcode.Text;
            /*if (postcodeText.Length == 0)
            {
                MessageBox.Show("Post Code is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.Address.Postcode = postcodeText;

            var roomText = txtRoomNo.Text;
            /*if (roomText.Length == 0)
            {
                MessageBox.Show("Room Num is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.Address.RoomNum = roomText;

            var street1Text = txtStreet1.Text;
            /*if (street1Text.Length == 0)
            {
                MessageBox.Show("Address Line1 is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.Address.AddressLine1 = street1Text;

            var street2Text = txtStreet2.Text;
            CurrentReader.Address.AddressLine2 = street2Text;

            var selectedGender = comboGender.SelectedItem;
            /*if (selectedGender == null)
            {
                MessageBox.Show("Gender is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/
            CurrentReader.Gender = (Reader.GenderEnum)selectedGender;

            var selectedProvince = comboProvince.SelectedItem;
            /*if (selectedProvince == null)
            {
                MessageBox.Show("Pronvince is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.Address.Province = (Address.ProvinceEnum) selectedProvince;

            DateTime? selectedDate = birthDatePicker.SelectedDate;
            /*if (selectedDate == null)
            {
                MessageBox.Show("Birth date is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.DateOfBirth = (DateTime)selectedDate;

            DateTime? startDate = startDatePiker.SelectedDate;
            /*if (startDate == null)
            {
                MessageBox.Show("Start Date is the mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

            CurrentReader.StartDate = (DateTime) startDate;

            Globals.context.SaveChanges();
            DialogResult = true;
        }

        private void Btn_clear_reader_info_OnClick(object sender, RoutedEventArgs e)
        {
            txtCity.Clear();
            txtEmail.Clear();
            txtFirst.Clear();
            tbID.Text = "";
            txtLast.Clear();
            txtPhone.Clear();
            txtPhoto.Visibility = Visibility.Visible;
            txtPostcode.Clear();
            txtRoomNo.Clear();
            txtStreet1.Clear();
            txtStreet2.Clear();
            txtEmail.Clear();
            birthDatePicker.Text = "";
            startDatePiker.SelectedDate = null;
            comboGender.Text = "";
            comboProvince.Text = "";
            readerPhoto.Source = null;
        }

        private void Btn_update_photo_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png|All Files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    currenPhoto = File.ReadAllBytes(openFileDialog.FileName);
                    txtPhoto.Visibility = Visibility.Hidden;
                    BitmapImage bitmap = LibUtils.ByteArrayToBitmapImage(currenPhoto);
                    readerPhoto.Source = bitmap;
                }
                catch (Exception exception) when (exception is SystemException || exception is IOException)
                {
                    MessageBox.Show(exception.Message, "File reading failed", MessageBoxButton.OK,
                        MessageBoxImage.Error);

                }
            }
        }

        private bool ValidateFields()
        {
            var cityText = txtCity.Text;
            if (cityText.Length == 0)
            {
                MessageBox.Show("City is a mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string cityPattern = @"^[A-Za-z\s\.-:]{3,}$";
            if (!Regex.IsMatch(cityText, cityPattern))
            {
                MessageBox.Show("City must be at least three letters with space,and special characters",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            var emailText = txtEmail.Text;
            if (emailText.Length == 0)
            {
                MessageBox.Show("Email is a mandatory field", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(emailText, emailPattern))
            {
                MessageBox.Show("You email is not right, please input again.",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            var firstText = txtFirst.Text;
            if (firstText.Length == 0)
            {
                MessageBox.Show("First Name is a mandatory field",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string namePattern = @"^[A-Z][a-z/s]{2,}$";
            if (!Regex.IsMatch(firstText, namePattern))
            {
                MessageBox.Show("First name must have at least three letter, and first letter is uppercase",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            var lastText = txtLast.Text;
            if (lastText.Length == 0)
            {
                MessageBox.Show("Last Name is a mandatory field",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!Regex.IsMatch(lastText, namePattern))
            {
                MessageBox.Show("Last name must have at least three letter, and first letter is uppercase",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            var phoneText = txtPhone.Text;
            if (phoneText.Length == 0)
            {
                MessageBox.Show("Phone is a mandatory field",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string phonePattern = @"^\d{10}$";
            if (!Regex.IsMatch(phoneText, phonePattern))
            {
                MessageBox.Show("Phone number must be 10 numbers.", "Errror",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            var postcodeText = txtPostcode.Text;
            if (postcodeText.Length == 0)
            {
                MessageBox.Show("Postcode is a mandatory field",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string codePattern = @"^[A-Z]\d[A-Z]\s\d[A-Z]\d$";
            if (!Regex.IsMatch(postcodeText, codePattern))
            {
                MessageBox.Show("Postal code must be like this A8A 9H9", "Errror",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            var roomTxt = txtRoomNo.Text;
            if (roomTxt.Length == 0)
            {
                MessageBox.Show("Room Number is a mandatory field",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string roomPattern = @"[\w\-.]+$";
            if (!Regex.IsMatch(roomTxt, roomPattern))
            {
                MessageBox.Show("Post code is a combination of letters, numbers and special charachters like .-, at least 2", "Errror",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            var street1Text = txtStreet1.Text;
            if (street1Text.Length == 0)
            {
                MessageBox.Show("Street 1 is a mandatory field",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string streetPattern = @"[\w\s\.-]{2,}$";
            if (!Regex.IsMatch(street1Text, streetPattern))
            {
                MessageBox.Show("Street must be at least two letters, number,  with space and special characters",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            /*var street2Text = txtStreet2.Text;
            if (!Regex.IsMatch(street2Text, streetPattern))
            {
                MessageBox.Show("Street must be at least two letters with space and special characters",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }*/

            DateTime? birthDate = birthDatePicker.SelectedDate;
            if (birthDate == null)
            {
                MessageBox.Show("You must choose a date", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return false;
            }

            DateTime? startDate = startDatePiker.SelectedDate;
            if (startDate == null)
            {
                MessageBox.Show("You must choose a date", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return false;
            }

            var selectedGender = comboGender.SelectedItem;
            if (selectedGender == null)
            {
                MessageBox.Show("You must choose the gender", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return false;
            }

            var selectedProvince = comboProvince.SelectedItem;
            if (selectedProvince == null)
            {
                MessageBox.Show("You must choose the province", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return false;
            }
          


            return true;
        }


        private void EditReaderDialog_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
