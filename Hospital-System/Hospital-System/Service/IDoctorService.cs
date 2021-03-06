﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.View.Model;

namespace Hospital_System.Service
{
    interface IDoctorService
    {
        void Save(RegisterDoctorModel doctorModel);
        List<SampleDoctorModel> GetAllDoctorsAsSampleDoctorModels();
    }
}
