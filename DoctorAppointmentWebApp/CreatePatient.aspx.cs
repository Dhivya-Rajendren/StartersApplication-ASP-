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
            if (Page.IsValid)
            {
                Patient newPatient = new Patient();
                newPatient.PatientId = 10;
                newPatient.PatientName = txtPatientName.Text;
                newPatient.Email = txtEmail.Text;
                newPatient.Contact = Convert.ToInt64(txtContact.Text);
                newPatient.PatientHistory = txtPatientHistory.Text;
                DbHelper db = new DbHelper();
                if (db.AddNewPatient(newPatient) > 0)
                {
                    Response.Redirect("Patient.aspx");
                }

            }
           
           
        }

        protected void cvPatientName_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length<3)
            {
                 args.IsValid = false;
            }
        }
    }
}