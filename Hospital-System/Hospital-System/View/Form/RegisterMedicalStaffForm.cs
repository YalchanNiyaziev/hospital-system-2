using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_System.Service;
using Hospital_System.Service.Implementation;
using Hospital_System.View.Model;

namespace Hospital_System
{
    public partial class RegisterMedicalStaffForm : Form
    {
        private IDoctorService doctorService;
        public RegisterMedicalStaffForm()
        {

            doctorService = new DoctorService();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!HasEmptyFields())
            {
                if (PasswordBox.Text.Equals(ConfirmPasswordBox.Text))
                {
                    RegisterDoctorModel doctorModel = CreateModel();
                    doctorService.Save(doctorModel);
                    MessageBox.Show("Successfully created medical staff profile");
                    this.Hide();
                    AdminHomeForm adminHome = new AdminHomeForm();
                    adminHome.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Password and Confirm Pasword mismatch");
                }

            }
            else
            {
                MessageBox.Show("Fill in all fileds");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeForm adminHome = new AdminHomeForm();
            adminHome.ShowDialog();
            this.Close();
        }

        private bool HasEmptyFields()
        {
            bool hasEmpty = false;
            if (string.IsNullOrEmpty(NameTextBox.Text)
                || string.IsNullOrEmpty(UcnTextBox.Text)
                || string.IsNullOrWhiteSpace(CityComboBox.Text)
                || string.IsNullOrEmpty(StreetTextBox.Text)
                || string.IsNullOrEmpty(StreetNumberTextBox.Text)
                || string.IsNullOrEmpty(WardComboBox.Text)
                || string.IsNullOrEmpty(SpecializationComboBox.Text)
                || string.IsNullOrEmpty(RoleComboBox.Text)
                || string.IsNullOrEmpty(UsernameTextBox.Text)
                || string.IsNullOrEmpty(PasswordBox.Text)
                || string.IsNullOrEmpty(ConfirmPasswordBox.Text)
                || string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                hasEmpty = true;
            }

            return hasEmpty;
        }

        private RegisterDoctorModel CreateModel()
        {
            RegisterDoctorModel model = new RegisterDoctorModel();
            model.Name = NameTextBox.Text;
            model.Ucn = UcnTextBox.Text;
            model.City = CityComboBox.Text;
            model.Street = StreetTextBox.Text;
            model.StreetNumber = StreetNumberTextBox.Text;
            model.Ward = WardComboBox.Text;
            model.Specialization = SpecializationComboBox.Text;
            model.Role = RoleComboBox.Text;
            model.Username = UsernameTextBox.Text;
            model.Password = PasswordBox.Text;
            model.Phone = PhoneTextBox.Text;
            return model;
        }

      
    }
}
