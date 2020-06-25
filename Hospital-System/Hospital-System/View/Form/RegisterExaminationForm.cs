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
    public partial class RegisterExaminationForm : Form
    {
        public readonly int MedicalServiceType = 0;
        private readonly string ControlIdentifier = "_Required";
        private List<Control> controls = new List<Control>();
        private IMedicalServiceService medicalServiceSevice;
        private int doctorId;
        public RegisterExaminationForm(int doctorId)
        {
            this.doctorId = doctorId;
            medicalServiceSevice = new MedicalServiceService();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindControls(this, controls, ControlIdentifier);
            if (!FieldValidator.HasEmptyFields(controls.ToArray()))
            {
                
                    RegisterMedicalExaminationModel medicalExaminationModel = CreateModel();
                    medicalServiceSevice.Save(medicalExaminationModel, MedicalServiceType);
                    MessageBox.Show("Successfully recorded medical examination");
                    this.Close();


            }
            else
            {
                MessageBox.Show("Fill in all fileds");
            }
        }

        private RegisterMedicalExaminationModel CreateModel()
        {
            RegisterMedicalExaminationModel model = new RegisterMedicalExaminationModel
            {
                PatientName = PatientNameTextBox_Required.Text,
                Ucn = PatientUCNTextBox_Required.Text,
                City = PatientCityComboBox_Required.Text,
                Street = PatientStreetNumberTextBox_Required.Text,
                StreetNumber = PatientStreetNumberTextBox_Required.Text,
                Date = ExaminationDatePicker_Required.Value.ToString("MM/dd/yyyy"),
                Disease = DiseaseTextBox_Required.Text,
                MedicalOpinion = MedicalOpinionTextBox_Required.Text,
                Phone = PhoneNumberTextBox_Required.Text,
                DoctorId = this.doctorId
            };
            return model;
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

        private void button4_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
