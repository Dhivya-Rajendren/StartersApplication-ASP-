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
        static List<Patient> patients = new List<Patient>();
      
        protected void Page_Load(object sender, EventArgs e)
        {

            //List<int> numbers = new List<int>();// List of integers
            //numbers.Add(1);
            //numbers.Add(2);

            //List<string> names = new List<string>();//List of strings
            //names.Add("Kishore");
            //names.Add("Aabha");

      
             patients = new List<Patient>();// List of patients or I can call it as List of patient objects.
            Patient patient = new Patient();
            patient.PatientId = 1;
            patient.PatientName = "Jacob";
            patient.Email = "Jacob@outlook.com";
            patient.Contact = 78451296;
            patient.PatientHistory = "Patient was here for fever before";
            patients.Add(patient);
            Patient p1 = new Patient();
            p1.PatientId = 2;
            p1.PatientName = "Mathew";
            p1.Email = "Mathew @ gmail.com";
            p1.Contact = 45127896;
            p1.PatientHistory = "Patient with Cold and Cough";
            patients.Add(p1);
            Patient newPatient = (Patient)Session["NewPatient"];
            if (newPatient != null)
            {
                patients.Add(newPatient);
            }


                grvPatients.DataSource = patients;
            grvPatients.DataBind();


        }

        protected void lnkNewPatient_Click(object sender, EventArgs e)
        {

        }
    }
}