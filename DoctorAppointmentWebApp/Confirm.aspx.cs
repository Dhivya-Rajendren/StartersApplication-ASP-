using DoctorAppointmentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentWebApp
{
    public partial class Confirm : System.Web.UI.Page
    {
        DbHelper db = null;

        int patientId = 0;
        public Confirm()
        {
            db=new DbHelper();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
          
            List<Patient> allPatients = db.GetAllPatients();
             patientId = int.Parse(Request.QueryString["patientId"]);
            Patient patient = allPatients.Find(t=>t.PatientId==patientId);
            if (patient == null)
            {

            }
            else
            {
                lblPatientName.Text = patient.PatientName;
                lblPatientEmail.Text = patient.Email;
                lblPatientHistory.Text = patient.PatientHistory;
            }
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            db.DeletePatient(patientId);
            Response.Redirect("Patient.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Patient.aspx");
        }
    }
}