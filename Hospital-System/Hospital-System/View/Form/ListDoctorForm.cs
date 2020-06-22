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
    public partial class ListDoctorForm : Form
    {
        private List<SampleDoctorModel> doctors;
        private IDoctorService doctorService;
        public ListDoctorForm()
        {
            doctorService = new DoctorService();
            doctors = doctorService.GetAllDoctorsAsSampleDoctorModels();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListDoctorForm_Load(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = doctors;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif ", 13);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor=Color.Turquoise;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Turquoise;
            dataGridView1.EnableHeadersVisualStyles = false;

        
            foreach (DataGridViewRow c in dataGridView1.Rows)
            {
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif ", 12);
                c.DefaultCellStyle.ForeColor=Color.Turquoise;
                c.DefaultCellStyle.SelectionBackColor=Color.Turquoise;
                c.DefaultCellStyle.SelectionForeColor = Color.White;
            }
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            MakeExaminationRequestForm makeExaminationRequest = new MakeExaminationRequestForm(id);
            makeExaminationRequest.ShowDialog();
        }
    }
}
