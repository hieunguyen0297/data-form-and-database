using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataFormDisplay.Models
{
    public class Appointment
    {
        public string PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PatientNetwork { get; set; }
        public string DoctorName { get; set; }
        public int PainLevel { get; set; }
    }
}
