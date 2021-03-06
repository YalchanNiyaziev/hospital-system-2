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

namespace Hospital_System
{
    public partial class SearchMedRecordForm : Form
    {
        
        public SearchMedRecordForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(UCNTextBox.Text))
            {
                MessageBox.Show("Please fill in the field");
            }
            else
            {
                this.Hide();
                ListPatientMedicalServicesForm listPatientMedicalServicesForm 
                    = new ListPatientMedicalServicesForm(UCNTextBox.Text);
                listPatientMedicalServicesForm.ShowDialog();
                this.Close();
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            this.Close();
        }
    }
}
