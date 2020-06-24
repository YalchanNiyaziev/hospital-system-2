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
using Hospital_System.View.Util;

namespace Hospital_System
{
    public partial class RegisterMedicalStaffForm : Form
    {
        private readonly string ControlIdentifier = "Box";
        private IDoctorService doctorService;
        private List<Control> controls = new List<Control>();
        public RegisterMedicalStaffForm()
        {

            doctorService = new DoctorService();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindControls(this,controls,ControlIdentifier);
            if (!FieldValidator.HasEmptyFields(controls.ToArray()))
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

        

        private RegisterDoctorModel CreateModel()
        {
            RegisterDoctorModel model = new RegisterDoctorModel();
            model.Name = NameTextBox.Text;
            model.Ucn = UcnTextBox.Text;
            model.City = CityComboBox.Text;
            model.Street = StreetTextBox.Text;
            model.StreetNumber = StreetNumberTextBox.Text;
            model.Ward = WardComboBox.SelectedIndex;
            model.Specialization = SpecializationComboBox.SelectedIndex;
            model.Role = RoleComboBox.SelectedIndex;
            model.Username = UsernameTextBox.Text;
            model.Password = PasswordBox.Text;
            model.Phone = PhoneTextBox.Text;
            return model;
        }

        private void FindControls(Control owner,List<Control> controlList, string name)
        {
            foreach (Control c in owner.Controls)
            {
                if (c.Name.Contains(name))
                {
                    controlList.Add(c);
                }
                if (c.HasChildren) FindControls(c, controlList, name);
            }


        }
      
    }
}
