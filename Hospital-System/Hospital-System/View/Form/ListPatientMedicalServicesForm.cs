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
    public partial class ListPatientMedicalServicesForm : Form
    {
        private string UCN;
        private List<PatientMedicalServiceModel> patientMedicalServicesModels;
        private IMedicalServiceSevice medicalServiceSevice;
        public ListPatientMedicalServicesForm(string UCN)
        {
            this.UCN = UCN;
            this.medicalServiceSevice = new MedicalServiceService();
            this.patientMedicalServicesModels =  medicalServiceSevice.GetMedicalServicesByPatient(UCN);
            InitializeComponent();
        }

        private void ListPatientMedicalServicesForm_Load(object sender, EventArgs e)
        {
            
                dataGridView1.DataSource = patientMedicalServicesModels;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif ", 13);
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Turquoise;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Turquoise;
                dataGridView1.EnableHeadersVisualStyles = false;

                if (this.patientMedicalServicesModels.Count > 0)
                {
                    ErrorLabel.Visible = false;
                    foreach (DataGridViewRow c in dataGridView1.Rows)
                    {
                        c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif ", 12);
                        c.DefaultCellStyle.ForeColor = Color.Turquoise;
                        c.DefaultCellStyle.SelectionBackColor = Color.Turquoise;
                        c.DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                }
                else
                {
                    ErrorLabel.Visible = true;
                }
        }
        
        
    }
}
