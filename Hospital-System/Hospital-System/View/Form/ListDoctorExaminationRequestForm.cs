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
    public partial class ListDoctorExaminationRequestForm : Form
    {
        private List<SampleExaminationRequestModel> examinationRequestList;
        private IMedicalExaminationRequestService medicalExaminationRequestService;
        public ListDoctorExaminationRequestForm(int doctorId)
        {
            medicalExaminationRequestService = new MedicalExaminationRequestService();
            this.examinationRequestList = medicalExaminationRequestService.GetAllPendingRequestByDoctor(doctorId);
            InitializeComponent();
        }

        private void ListDoctorExaminationRequestForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = examinationRequestList;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif ", 13);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Turquoise;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Turquoise;
            dataGridView1.EnableHeadersVisualStyles = false;

            if (this.examinationRequestList.Count > 0)
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(this.dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            ShowExaminationRequestDetailsForm showExaminationRequestDetailsForm = new ShowExaminationRequestDetailsForm(id);
            showExaminationRequestDetailsForm.ShowDialog();
        }
    }
}
