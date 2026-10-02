using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_EF_Project3.Models
{
    internal class Appointment
    {
        // 2 foreign keys (primary composit key defined in migration for a cleaner code)
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        //extra column
        public DateTime AppointmentDate { get; set; }

        //mapping 1 to many relations (Patient to Appointment) , (Doctor to Appointment)
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
