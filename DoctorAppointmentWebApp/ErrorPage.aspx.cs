using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentWebApp
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int errorCode=int.Parse(Request.QueryString["code"].ToString());

            if (errorCode==404)
            {
                divMsg.InnerHtml = "The file or page you are looking for is not found or not available";
            }
            else if(errorCode==500)
            {
                divMsg.InnerHtml = "There is a Server error. Try again later";
            }

        }
    }
}