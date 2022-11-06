<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" EnableEventValidation="true" CodeBehind="Patient.aspx.cs" Inherits="DoctorAppointmentWebApp._Patient" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Reddy's Hospital Patient Details</h1>
    </div>

 
    <asp:GridView runat="server" ID="grvPatients" CssClass="table table-table-bordered bg-info" AutoGenerateColumns="False" OnRowEditing="grvPatients_RowEditing"
        OnRowUpdated="grvPatients_RowUpdated" OnRowUpdating="grvPatients_RowUpdating"
        OnRowDeleting="grvPatients_RowDeleting"
        >
        <Columns>
            <asp:TemplateField HeaderText="Patient ID">
                <ItemTemplate>
                    <asp:Label ID="lblPatientId" runat="server" Text='<%#Eval("PatientID") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Patient Name">
                <ItemTemplate>
                    <asp:Label ID="lblPatientName" runat="server" Text='<%#Eval("PatientName") %>' />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtPatientName" runat="server" Text='<%#Eval("PatientName") %>' />
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Patient Email">
                <ItemTemplate>
                    <asp:Label ID="lblPatientEmail" runat="server" Text='<%#Eval("Email") %>' />
                </ItemTemplate>
                 <EditItemTemplate>
                    <asp:TextBox ID="txtPatientEmail" runat="server" Text='<%#Eval("Email") %>' />
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Patient Contact">
                <ItemTemplate>
                    <asp:Label ID="lblPatientContact" runat="server" Text='<%#Eval("Contact") %>' />
                </ItemTemplate>
                 <EditItemTemplate>
                    <asp:TextBox ID="txtPatientContact" runat="server" Text='<%#Eval("Contact") %>' />
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Patient Histrory">
                <ItemTemplate>
                    <asp:Label ID="lblPatientHistory" runat="server" Text='<%#Eval("PatientHistory") %>' />
                </ItemTemplate>
                 <EditItemTemplate>
                    <asp:TextBox ID="txtPatientHistory" runat="server" Text='<%#Eval("PatientHistory") %>' />
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit Details">
                <ItemTemplate>
               <asp:Button CssClass="btn btn-primary" ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />
                </ItemTemplate>
                   <EditItemTemplate>
               <asp:Button CssClass="btn btn-primary" ID="btn_Edit" runat="server" Text="Update" CommandName="Update" />
                </EditItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Edit Details">
                <ItemTemplate>
               <asp:Button CssClass="btn btn-info" ID="btn_Delete" runat="server" Text="Delete" CommandName="Delete" />
                </ItemTemplate>
                 
            </asp:TemplateField>
        </Columns>


    </asp:GridView>
   
    <asp:LinkButton ID="lnkNewPatient" Text="Create" CssClass="btn btn-primary" PostBackUrl="~/CreatePatient.aspx" runat="server" OnClick="lnkNewPatient_Click">

    </asp:LinkButton>
</asp:Content>