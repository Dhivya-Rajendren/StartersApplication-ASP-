using DoctorAppointmentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentWebApp
{
    public partial class CreateDoctor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.DoctorName = txtDoctorName.Value;
            doctor.Email = txtDoctorEmail.Value;
            doctor.Contact = Convert.ToInt64(txtContact.Value);
        }
    }
}