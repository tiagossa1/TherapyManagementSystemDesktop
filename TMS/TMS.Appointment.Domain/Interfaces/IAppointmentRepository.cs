﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Appointment.Domain.Models;

namespace TMS.Appointment.Domain.Interfaces
{
    public interface IAppointmentRepository
    {
        bool Post(AppointmentModel obj);

        bool Put(AppointmentModel obj);

        bool Delete(Guid id);

        AppointmentModel Get(Guid id);

        IList<AppointmentModel> GetAll();
    }
}