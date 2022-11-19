<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="DoctorAppointmentWebApp.WebForm1" %>
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
            <p class="alert alert-success">Register Details </p>
            <div class="form-group">
                <label for="UserName">User Name</label>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" />
            </div>
               <div class="form-group">
                <label for="Password">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" />
            </div>
              <div class="form-group">
                <label for="ConfirmPassword">Confirm Password</label>
                <asp:TextBox ID="txtCPassword" runat="server" CssClass="form-control" />
                  <asp:CompareValidator ID="cvPassword" runat="server" ControlToValidate="txtCPassword" ControlToCompare="txtPassword" ErrorMessage="Password mismatch" ForeColor="Red" />
            </div>
            <div class="form-group">
                <label for="Email">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnRegister" CssClass="btn btn-success" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
                    <asp:Label ID="Msg" Text=""  runat="server" />

        </div>
    </form>
</body>
</html>
