using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataFormDisplay.Models
{
    public class Appointment
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's Full Name")]
        public string PatientName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }

        [DisplayName("Patient's Networth")]
        [DataType(DataType.Currency)]
        public decimal PatientNetworth { get; set; }

        [DisplayName("Doctor's Last Name")]
        public string DoctorName { get; set; }

        [Range(1,10)]
        [DisplayName("Patient's Perceived Level of Pain (1 low to 10 high)")]
        public int PainLevel { get; set; }
    }
}
