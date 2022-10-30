﻿using System;
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

    }
}