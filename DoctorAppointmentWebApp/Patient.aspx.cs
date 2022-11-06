using DoctorAppointmentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentWebApp
{
    public partial class _Patient : System.Web.UI.Page
    {

        DbHelper db = new DbHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowDetails();
            }
           

        }

        public void ShowDetails()
        {
            db = new DbHelper();
            //   List<Patient> patients = db.GetAllPatients();
            grvPatients.DataSource = db.GetAllPatients();
            grvPatients.DataBind();
        }
        protected void lnkNewPatient_Click(object sender, EventArgs e)
        {

        }

        protected void grvPatients_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvPatients.EditIndex = e.NewEditIndex;
            ShowDetails();

        }

        protected void grvPatients_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {

        }

        protected void grvPatients_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
           

            // Getting the controls from the Gridview on Edit Mode 
            Label patientId = grvPatients.Rows[e.RowIndex].FindControl("lblPatientId") as Label;
            TextBox patientName = grvPatients.Rows[e.RowIndex].FindControl("txtPatientName") as TextBox;
            TextBox email = grvPatients.Rows[e.RowIndex].FindControl("txtPatientEmail") as TextBox;
            TextBox contact =  grvPatients.Rows[e.RowIndex].FindControl("txtPatientContact") as TextBox;
            TextBox patientHistory = grvPatients.Rows[e.RowIndex].FindControl("txtPatientHistory") as TextBox;


            // Creating a patient object with the details from the controls of grid view in Edit mode
            //
            Patient patient = new Patient();
            patient.PatientId =int.Parse( patientId.Text);
           
             patient.PatientName = patientName.Text;
          
            patient.Email = email.Text;
            patient.Contact = long.Parse(contact.Text);
            patient.PatientHistory = patientHistory.Text;
            DbHelper db = new DbHelper();
            db.UpdatePatient(patient);
            // Setting the Edit index to -1 , so to come out of the Edit mode.
            grvPatients.EditIndex = -1;
            ShowDetails();

        }

        protected void grvPatients_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)grvPatients.Rows[e.RowIndex];
            // Getting the first column which is having the patientId.
            Label patientId = row .FindControl("lblPatientId") as Label;
            DbHelper db = new DbHelper();

            int patientIdDelete=int.Parse(patientId.Text);
            db.DeletePatient(patientIdDelete);
            ShowDetails();
        }
    }
}