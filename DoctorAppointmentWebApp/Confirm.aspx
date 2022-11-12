<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs"  MasterPageFile="~/Site.Master" Inherits="DoctorAppointmentWebApp.Confirm" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="card w-25">
        <div class="card-header">
            <h2>Patient Details </h2>
        </div>
        <div class="card-body">
          <h4> <asp:Label ID="lblPatientName" runat="server"  /></h4> 
               <h4>             <asp:Label ID="lblPatientEmail" runat="server" /></h4> 
           <h4>     <asp:Label ID="lblPatientHistory" runat="server" /></h4> 

        </div>
        <div class="card-footer">
            <h3>Are you sure to Delete the Patient Details ?</h3>
            <asp:Button ID="btnYes" runat="server" CssClass="btn btn-small btn-primary" Text="Yes" OnClick="btnYes_Click" />
                        <asp:Button ID="btnNo" runat="server" CssClass="btn btn-small btn-info" Text="No" OnClick="btnNo_Click"/>

        </div>
    </div>
    </asp:Content>


