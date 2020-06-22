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
    public partial class MakeExaminationRequestForm : Form
    {
        private readonly string ControlIdentifier = "_Required";
        private string doctorId;
        private IMedicalExaminationRequestService examinationRequestService;
        private List<Control> controls;

        public MakeExaminationRequestForm(string doctorId)
        {
            this.doctorId = doctorId;
            this.examinationRequestService = new MedicalExaminationRequestService();
            this.controls = new List<Control>();
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FindControls(this, controls, ControlIdentifier);
            if (!FieldValidator.HasEmptyFields(controls.ToArray()))
            {

                RequestMedicalExaminationModel requestExaminationModel = CreateModel();
                    this.examinationRequestService.Save(requestExaminationModel);
                    MessageBox.Show("Successfully requested medical examination");
                    this.Close();

             
            }
            else
            {
                MessageBox.Show("Fill in all fileds");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private RequestMedicalExaminationModel CreateModel()
        {
           RequestMedicalExaminationModel examinationRequestModel = new RequestMedicalExaminationModel();
           examinationRequestModel.PatientName = PatientNameTextBox_Required.Text;
           examinationRequestModel.City = PatientCityComboBox_Required.Text;
           examinationRequestModel.Street = PatientStreetTextBox_Required.Text;
           examinationRequestModel.StreetNumber = PatientStreetNumberTextBox_Required.Text;
           examinationRequestModel.DateTo = ExaminationDateToDatePicker_Required.Text;
           examinationRequestModel.TimeTo = ExaminationTimeToTimePicker_Required.Text;
           examinationRequestModel.Email = PatientEmailTextBox_Required.Text;
           examinationRequestModel.Phone = PatientPhoneTextBox_Required.Text;
           examinationRequestModel.DoctorId = int.Parse(this.doctorId);
           return examinationRequestModel;
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
    }
}
