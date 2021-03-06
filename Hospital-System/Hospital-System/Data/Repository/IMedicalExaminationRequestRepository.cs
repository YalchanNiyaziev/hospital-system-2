﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_System.Data.Entity;

namespace Hospital_System.Data.Repository
{
    public interface IMedicalExaminationRequestRepository : IGenericRepository<MedicalExaminationRequest>
    {
        List<MedicalExaminationRequest> FindByDoctor(int doctorId);
        MedicalExaminationRequest FindById(int id);
    }
}
