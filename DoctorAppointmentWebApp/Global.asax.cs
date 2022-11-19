using DoctorAppointmentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace DoctorAppointmentWebApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            HttpException httpException = exception as HttpException;   
            DbHelper db = new DbHelper();
            ErrorModel error = new ErrorModel();

            error.ErrorMessage = exception.Message;
        error.ErrorMessage=    error.ErrorMessage.Replace("'", "''");
            error.ErrorURL = Request.Url.AbsoluteUri;
            error.StatusCode = httpException.GetHttpCode();

            db.AddError(error);

          
                Response.Redirect("ErrorPage.aspx?code="+error.StatusCode);
          

        }
    }
}