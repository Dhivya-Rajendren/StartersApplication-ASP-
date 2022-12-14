using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace DoctorAppointmentWebApp.Models
{
    public class DbHelper
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public DbHelper()
        {
            string conString = ConfigurationManager.ConnectionStrings["AppointmentDB"].ConnectionString;
            con = new SqlConnection(conString);
            con.Open();
        }

        public int AddError(ErrorModel error)
        {
            return ExecuteDMLCommand("insert into tblAppErrors values('" + error.ErrorURL + "','" + error.ErrorMessage + "'," + error.StatusCode + ")");
        }

        public int ExecuteDMLCommand(string dmlCommand)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand(dmlCommand, con);
            int rows = com.ExecuteNonQuery();

            con.Close();
            return rows;
        }

        public int AddNewUser(User user)
        {
          return ExecuteDMLCommand("insert into tblUser values('"+user.UserName+"','"+user.Password+"','"+user.Email+"')");
            
        }
        public List<Patient> GetAllPatients()
        {
            if (con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            List<Patient> patients = new List<Patient>();
            com = new SqlCommand("Select * from Patient", con);
            reader= com.ExecuteReader();
            while(reader.Read())
            {
                Patient patient = new Patient();
                patient.PatientId = reader.GetInt32(0);
                patient.PatientName = reader["PatientName"].ToString();
                patient.Contact = (long)reader["Contact"];
                patient.Email = reader.GetString(2);
                patient.PatientHistory=reader.GetString(4);
                patients.Add(patient);
            }
            reader.Close();
            con.Close();
            return patients;


        }

        public int AddNewPatient(Patient patient)
        {

            return ExecuteDMLCommand("insert into Patient values('" + patient.PatientName + "','" + patient.Email + "'," + patient.Contact + ",'" + patient.PatientHistory + "')");
           
            

        }
    public int UpdatePatient(Patient patient)
        {
        return   ExecuteDMLCommand("update patient set contact="+patient.Contact +"where patientId="+patient.PatientId);
          

        }

        public int DeletePatient(int patientId)
        {
       return    ExecuteDMLCommand(" Delete from patient where patientId=" + patientId);
        
        }
    }
}