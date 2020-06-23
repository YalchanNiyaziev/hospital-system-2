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
        private readonly string ControlIdentifier = "_Required";
        private List<Control> controls = new List<Control>();
        private IMedicalExaminationService medicalExaminationService;
        public RegisterExaminationForm()
        {
            medicalExaminationService = new MedicalExaminationService();
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
                    medicalExaminationService.Save(medicalExaminationModel);
                    MessageBox.Show("Successfully recorded medical examination");
                    // this.Hide();
                    // DoctorHomeForm doctorHome = new DoctorHomeForm();
                    // doctorHome.ShowDialog();
                    // this.Close();


            }
            else
            {
                MessageBox.Show("Fill in all fileds");
            }
        }

        private RegisterMedicalExaminationModel CreateModel()
        {
            RegisterMedicalExaminationModel model = new RegisterMedicalExaminationModel();
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
            // this.Hide();
            // DoctorHomeForm doctorHome = new DoctorHomeForm();
            // doctorHome.ShowDialog();
            // this.Close();
        }
    }
}
