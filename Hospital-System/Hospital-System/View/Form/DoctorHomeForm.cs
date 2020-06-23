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
            DoctorMessageLabel.Text += user.Name.ToUpper();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterExaminationForm registerExamination = new RegisterExaminationForm();
            registerExamination.ShowDialog();
            this.Close();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListDoctorExaminationRequestForm doctorExaminationRequestForm = new ListDoctorExaminationRequestForm(this.doctorId);
            doctorExaminationRequestForm.ShowDialog();
            this.Close();
        }
    }
}
