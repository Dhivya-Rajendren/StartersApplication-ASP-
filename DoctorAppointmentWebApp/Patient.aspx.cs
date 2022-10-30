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

            db = new DbHelper();
         //   List<Patient> patients = db.GetAllPatients();
            grvPatients.DataSource = db.GetAllPatients();
            grvPatients.DataBind();
        }

        protected void lnkNewPatient_Click(object sender, EventArgs e)
        {

        }
    }
}