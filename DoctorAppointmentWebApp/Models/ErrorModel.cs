using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorAppointmentWebApp.Models
{
    public class ErrorModel
    {
        public int ErrorId { get; set; }
        public string ErrorURL { get; set; }
        public string ErrorMessage { get; set; }
        public  int StatusCode { get; set; }
    }
}