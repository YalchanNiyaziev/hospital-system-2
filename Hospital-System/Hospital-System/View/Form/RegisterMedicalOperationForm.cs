﻿using System;
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
    public partial class RegisterMedicalOperationForm : Form
    {
        private readonly int MedicalServiceType = 1;
        private readonly string ControlIdentifier = "_Required";
        private List<Control> controls;
        private IMedicalServiceService medicalServiceService;
        private int doctorId;
        public RegisterMedicalOperationForm(int doctorId)
        {
            this.controls = new List<Control>();
            this.doctorId = doctorId;
            this.medicalServiceService = new MedicalServiceService();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindControls(this, controls, ControlIdentifier);
            if (!FieldValidator.HasEmptyFields(controls.ToArray()))
            {

                RegisterMedicalOperationModel medicalOperationModel = CreateModel();
                medicalServiceService.Save(medicalOperationModel, MedicalServiceType);
                MessageBox.Show("Successfully recorded medical operation");
                this.Close();


            }
            else
            {
                MessageBox.Show("Fill in all fileds");
            }
        }

        private RegisterMedicalOperationModel CreateModel()
        {
            RegisterMedicalOperationModel model = new RegisterMedicalOperationModel
            {
                PatientName = PatientNameTextBox_Required.Text,
                Ucn = PatientUCNTextBox_Required.Text,
                City = PatientCityComboBox_Required.Text,
                Street = PatientStreetNumberTextBox_Required.Text,
                StreetNumber = PatientStreetNumberTextBox_Required.Text,
                Date = OperationDatePicker_Required.Value.ToString("MM/dd/yyyy"),
                OperationDescription = OperationDescriptionTextBox_Required.Text,
                OperationResult = OperationResultTextBox_Required.Text,
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
