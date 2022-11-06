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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

            User userDetail = new User();
            

            MembershipUser newUser = Membership.GetUser(CreateUserWizard1.UserName);
        
       
            if (newUser != null)
            {
                userDetail.UserName = newUser.UserName;
                userDetail.Email = newUser.Email;
                userDetail.Password = newUser.GetPassword();
                userDetail.SQuestion = newUser.PasswordQuestion;
                userDetail.SAnswer = "";
            }

            DbHelper db = new DbHelper();
            db.AddNewUser(userDetail);



          

        }

        protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
        {

        }
    }
}