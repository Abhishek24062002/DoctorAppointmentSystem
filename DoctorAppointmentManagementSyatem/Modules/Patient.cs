using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem.Modules
{
    public  class Patient
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public virtual List<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
