using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorAppointmentWebApp.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Email { get; set; }
        public long Contact { get; set; }
        public string SpecializedIn { get; set; }
    }
}