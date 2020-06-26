using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_System.View.Model;

namespace Hospital_System
{
    public partial class DoctorHomeForm : Form
    {
        private int doctorId;
        private UserModel user;
        public DoctorHomeForm (UserModel userModel)
        {
            this.user = userModel;
            this.doctorId = userModel.Id;
            InitializeComponent();
        }

        private void DoctorHomeForm_Load(object sender, EventArgs e)
        {
            DoctorMessageLabel.Text = DoctorMessageLabel.Text+"\n\r      "+user.Name.ToUpper();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterExaminationForm registerExaminationForm = new RegisterExaminationForm(user.Id);
            registerExaminationForm.ShowDialog();
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListDoctorExaminationRequestForm doctorExaminationRequestForm = new ListDoctorExaminationRequestForm(this.user);
            doctorExaminationRequestForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegisterMedicalOperationForm registerMedicalOperationForm = new RegisterMedicalOperationForm(user.Id);
            registerMedicalOperationForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.ShowDialog();
            this.Close();
        }
    }
}
