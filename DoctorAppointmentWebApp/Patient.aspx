<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="Patient.aspx.cs" Inherits="DoctorAppointmentWebApp._Patient" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Reddy's Hospital Patient Details</h1>
    </div>

 
    <asp:GridView runat="server" ID="grvPatients" CssClass="table table-table-bordered bg-info">

    </asp:GridView>
   

</asp:Content>