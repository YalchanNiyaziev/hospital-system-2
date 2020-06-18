using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class DoctorHomeForm : Form
    {
        public DoctorHomeForm()
        {
            InitializeComponent();
        }

        private void DoctorHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterExaminationForm registerExamination = new RegisterExaminationForm();
            registerExamination.ShowDialog();

            this.Close();
            
        }
    }
}
