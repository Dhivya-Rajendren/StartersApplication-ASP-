using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DoctorAppointmentWebApp.Models;
namespace DoctorAppointmentWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DbHelper dbHelper = null;
        public WebForm1()
        {
            dbHelper = new DbHelper();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.UserName = txtUserName.Text;
            newUser.Password=txtPassword.Text;
            newUser.ConfirmPassword = txtCPassword.Text;

            newUser.Email = txtEmail.Text;

            if ( dbHelper.AddNewUser(newUser)>0)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {

            }

        }
    }
}