using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DoctorAppointmentWebApp.Models;

namespace DoctorAppointmentWebApp
{
    public partial class CreatePatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();
            newPatient.PatientId = 10;
            newPatient.PatientName = txtPatientName.Text;
            newPatient.Email = txtEmail.Text;
            newPatient.Contact =Convert.ToInt64( txtContact.Text);
            newPatient.PatientHistory=txtPatientHistory.Text;
            Session["NewPatient"] = newPatient;//Key-valu pair data
            Response.Redirect("Patient.aspx");
        }
    }
}