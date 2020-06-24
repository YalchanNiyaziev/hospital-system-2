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
    public partial class ShowExaminationRequestDetailsForm : Form
    {
        private const int ExaminationRequestApproveCode = 1;
        private const int ExaminationRequestRejectCode = 2;
        private IMedicalExaminationRequestService medicalExaminationRequestService;
        private ExaminationRequestDetailsModel requestExaminationModel;
        private int examinationRequestId;
        public ShowExaminationRequestDetailsForm(int id)
        {
            this.examinationRequestId = id;
            this.medicalExaminationRequestService = new MedicalExaminationRequestService();
            this.requestExaminationModel = this.medicalExaminationRequestService.GetMedicalExaminationRequestById(examinationRequestId);
            InitializeComponent();
        }

        private void ShowExaminationRequestDetailsForm_Load(object sender, EventArgs e)
        {
            InitializeLabels();
        }

        private void InitializeLabels()
        {
            PatientNameLabel.Text = this.requestExaminationModel.Name;
            PatientCityLabel.Text = this.requestExaminationModel.City;
            PatientStreetLabel.Text = this.requestExaminationModel.Street;
            PatientStreetNumberLabel.Text = this.requestExaminationModel.StreetNumber;
            ExaminationDateLabel.Text = this.requestExaminationModel.Date;
            ExaminationTimeLabel.Text = this.requestExaminationModel.Time;
            PatientPhoneLabel.Text = this.requestExaminationModel.Phone;
            PatientEmailLabel.Text = this.requestExaminationModel.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medicalExaminationRequestService.UpdateStatus(examinationRequestId, ExaminationRequestApproveCode);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medicalExaminationRequestService.UpdateStatus(examinationRequestId, ExaminationRequestRejectCode);
            this.Close();
        }
    }
}
