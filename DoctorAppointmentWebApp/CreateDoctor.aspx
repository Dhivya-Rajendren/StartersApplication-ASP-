<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="CreateDoctor.aspx.cs" Inherits="DoctorAppointmentWebApp.CreateDoctor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h3>Reddy's Hospital - Doctor Details</h3>
    </div>
    <div class="card">
        <div>
            Enter New Doctor Details
        </div>
        <div class="card-body" style="margin-top:2px">
            <input type="text" name="txtDoctorName" id="txtDoctorName" runat="server" class="form-control "  style="margin-top:5px" placeholder="Enter DoctorName" />
                        <input type="email" name="txtDoctorEmail" id="txtDoctorEmail" runat="server" class="form-control m-2"  style="margin-top:5px" placeholder="Enter Doctor Email" />
            <input type="number" name="txtContact" id="txtContact" runat="server" class="form-control m-2"  style="margin-top:5px" placeholder="Enter Doctor Contact" />
            <div  style="margin-top:5px">
            <asp:DropDownList ID="ddlSpecialization" runat="server">
                <asp:ListItem>-Select Specialization-</asp:ListItem>
                <asp:ListItem>Ortho</asp:ListItem>
                <asp:ListItem>GY</asp:ListItem>
                <asp:ListItem>Cardio</asp:ListItem>
                <asp:ListItem>General</asp:ListItem>
            </asp:DropDownList>
                </div>
        </div>
        <div class="card-footer"  style="margin-top:7px">
            <asp:Button ID="btnCreateDoctor" Text="Create" runat="server"  CssClass="btn btn-secondary m-2" OnClick="btnCreateDoctor_Click" />
        </div>
    </div>

    </asp:Content>
