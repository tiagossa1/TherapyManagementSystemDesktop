﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Clientes.Service.Model;

namespace TMS.Appointment.Service.Model
{
    public class AppointmentDto
    {
        public Guid Id { get; set; }
        public Guid ClientID { get; set; }
        public DateTime DateTime { get; set; }
        public int AppointmentTypeID { get; set; }
        public string AppointmentTypeName { get; set; }
        public string AppointmentDescription { get; set; }
        public override bool Equals(object obj)
        {
            var compareTo = obj as AppointmentDto;
            if (ReferenceEquals(this, compareTo)) return true;
            if (compareTo is null) return false;

            return Id.Equals(compareTo.Id);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }
    }
}
