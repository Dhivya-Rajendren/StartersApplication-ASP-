<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CreatePatient.aspx.cs" Inherits="DoctorAppointmentWebApp.CreatePatient" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Reddy's Hospital - New Patient Registration</h1>
    </div>

    <table>
        <tr>
            <td><asp:Label ID="lblPatientName" Text="Patient Name" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtPatientName" runat="server" CssClass="form-control" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblPatientEmail" Text="Patient Email" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblContact" Text="Patient Contact" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtContact" runat="server" CssClass="form-control" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblPatientHistory" Text="Patient History" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtPatientHistory" runat="server" CssClass="form-control" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnRegister" runat="server" Text="Create" CssClass="btn btn-primary" OnClick="btnRegister_Click" />
            </td>
        </tr>
    </table>
   

</asp:Content>
