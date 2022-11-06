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

        public int AddNewUser(User user)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand("insert into AppUsers values('"+user.UserName+"','"+user.Password+"','"+user.ConfirmPassword+"','"+user.Email+"','"+user.SQuestion+"','"+user.SAnswer+"')", con);
            int rows = com.ExecuteNonQuery();

            con.Close();
            return rows;
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

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand("insert into Patient values('" + patient.PatientName + "','" + patient.Email + "'," + patient.Contact + ",'" + patient.PatientHistory + "')", con);
            int rows= com.ExecuteNonQuery();

            con.Close();
            return rows;

        }
    public int UpdatePatient(Patient patient)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand("update patient set contact="+patient.Contact +"where patientId="+patient.PatientId, con);
            int rows = com.ExecuteNonQuery();

            con.Close();
            return rows;

        }

        public int DeletePatient(int patientId)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand(" Delete from patient where patientId=" + patientId, con);
            int rows = com.ExecuteNonQuery();

            con.Close();
            return rows;
        }
    }
}