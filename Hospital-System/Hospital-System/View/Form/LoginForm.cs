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
    public partial class LoginForm : Form
    {
        private readonly string ControlIdentifier = "_Required";
        private string username;
        private string password;
        private IUserService userService;
        private List<Control> controls;

        public LoginForm()
        {
            this.controls= new List<Control>();
            this.userService= new UserService();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.username = UsernameBox_Required.Text;
            this.password = PasswordBox_Required.Text;
            FindControls(this, controls, ControlIdentifier);
            if (!FieldValidator.HasEmptyFields(controls.ToArray()))
            {
                LoginModel loginModel = CreateLoginModel(username, password);
                UserModel userModel = userService.Login(loginModel);
                if (userModel != null)
                {
                    Form userForm = this.GetFormByRole(userModel);
                    if (userForm != null)
                    {
                        this.Hide();
                        userForm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");

                }
            }
            else
            {
                MessageBox.Show("Fill in all fileds");
            }

        }

            private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

            private LoginModel CreateLoginModel(string username, string password)
            {
                LoginModel loginModel = new LoginModel
                {
                    Username = username,
                    Password = password
                };
                return loginModel;
            }
        private void FindControls(Control owner, List<Control> controlList, string name)
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

        private Form GetFormByRole(UserModel userModel)
        {
            Form form = null;
            if (userModel.Role.Equals(UserRoleNameProvider.Doctor))
            {
                form = new DoctorHomeForm(userModel);
            }
            else if(userModel.Role.Equals(UserRoleNameProvider.Admin))
            {
                
                    form = new AdminHomeForm();
                
            }
            return form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMedRecordForm searchMedRecord = new SearchMedRecordForm();
            searchMedRecord.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListDoctorForm listDoctorForm = new ListDoctorForm();
            listDoctorForm.ShowDialog();
            this.Close();
        }
    }
}
