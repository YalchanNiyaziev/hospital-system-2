using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.View.Model;

namespace Hospital_System.Service
{
    interface IMedicalServiceService
    {
        List<PatientMedicalServiceModel> GetMedicalServicesByPatient(string UCN);
        void Save(RegisterMedicalExaminationModel model, int type);
        void Save(RegisterMedicalOperationModel model, int type);


    }
}
