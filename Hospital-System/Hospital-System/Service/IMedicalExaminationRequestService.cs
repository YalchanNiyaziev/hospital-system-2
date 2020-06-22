using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.View.Model;

namespace Hospital_System.Service
{
    interface IMedicalExaminationRequestService
    {
        void Save(RequestMedicalExaminationModel model);
    }
}
