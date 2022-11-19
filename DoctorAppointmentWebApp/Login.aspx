<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DoctorAppointmentWebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron m-2">
        <h1>Reddy's Hospital</h1>
        <p class="lead"> Welcome to Reddy's Hospital Appointment Portal. Thanks for chossing Us.</p>
    </div>
        <div class="container" style="width:300px" >
            <div class="form-group">
                <label for="UserName">User Name</label>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" />
            </div>
               <div class="form-group">
                <label for="Password">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnLogin" CssClass="btn btn-primary" runat="server" Text="Login" OnClick="btnLogin_Click"/>
            </div>

           <h3 style="margin-top:50px">No Account ? Sign Up Here       <asp:LinkButton PostBackUrl="~/NewUser.aspx" CssClass="btn btn-success" runat="server" ID="lnkREgister" Text="Sign Up"/></h3>
                     <asp:Label ID="Msg" Text=""  runat="server" />

        </div>
    </form>
</body>
</html>
