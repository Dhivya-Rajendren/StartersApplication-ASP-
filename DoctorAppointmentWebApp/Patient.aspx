<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="Patient.aspx.cs" Inherits="DoctorAppointmentWebApp._Patient" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Reddy's Hospital Patient Details</h1>
    </div>

 
    <asp:GridView runat="server" ID="grvPatients" CssClass="table table-table-bordered bg-info">

    </asp:GridView>
   
    <asp:LinkButton ID="lnkNewPatient" Text="Create" CssClass="btn btn-primary" PostBackUrl="~/CreatePatient.aspx" runat="server" OnClick="lnkNewPatient_Click">

    </asp:LinkButton>
</asp:Content>