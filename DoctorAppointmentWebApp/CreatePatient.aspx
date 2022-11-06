<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CreatePatient.aspx.cs" Inherits="DoctorAppointmentWebApp.CreatePatient" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Reddy's Hospital - New Patient Registration</h1>
    </div>

    <table>
        <tr>
            <td><asp:Label ID="lblPatientName" Text="Patient Name" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtPatientName" runat="server" CssClass="form-control" />
<%--                <asp:RequiredFieldValidator ID="rfvPatientName" runat="server" ValidationGroup="grpCreate" ForeColor="OrangeRed" ErrorMessage ="Patient Name can't be Empty" ControlToValidate="txtPatientName" />--%>
          <asp:CustomValidator ValidationGroup="grpCreate" ID="cvPatientName" runat="server" OnServerValidate="cvPatientName_ServerValidate" 
              ErrorMessage="The Length Should be Greater than 2" ControlToValidate="txtPatientName"  ForeColor="OrangeRed"/>
                </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblPatientEmail" Text="Patient Email" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />

                <asp:RegularExpressionValidator ID="revPatientEmail" runat="server" ValidationGroup="grpCreate" ControlToValidate="txtEmail" ErrorMessage="Give a Proper Email Address" ForeColor="OrangeRed" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  />
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblContact" Text="Patient Contact" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtContact" runat="server" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="rfvContact" runat="server" ValidationGroup="grpCreate" ForeColor="OrangeRed" ErrorMessage ="Patient Contact can't be Empty" ControlToValidate="txtContact"  />
                                <asp:RegularExpressionValidator ID="revContact" ValidationGroup="grpCreate" runat="server" ControlToValidate="txtContact" ErrorMessage="Contact number should be 10 digit and should start from [6-9]" ForeColor="OrangeRed" 
                                    ValidationExpression="^[6-9][0-9]{9}$"  />

                </td>

        </tr>
        <tr>
            <td><asp:Label ID="Label1" Text="Confirm Contact" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtConfirmContact" runat="server" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="grpCreate" runat="server" ForeColor="OrangeRed" ErrorMessage ="Patient Confirm Contact can't be Empty" ControlToValidate="txtConfirmContact"  />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1"  ValidationGroup="grpCreate" runat="server" ControlToValidate="txtConfirmContact" ErrorMessage="Contact number should be 10 digit and should start from [6-9]" ForeColor="OrangeRed" 
                                    ValidationExpression="^[6-9][0-9]{9}$"  />
                <asp:CompareValidator ID="cvContact" runat="server" ControlToValidate="txtConfirmContact" ControlToCompare="txtContact" ErrorMessage="Contact and Confirm Contact are not matching" />

                </td>

        </tr>
        <tr>
            <td><asp:Label ID="lblAge" Text="Patient Age" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtAge" runat="server" CssClass="form-control" />
                <asp:RangeValidator ID="rgAge" runat="server" ForeColor="OrangeRed" ValidationGroup="grpCreate" ControlToValidate="txtAge" ErrorMessage="Patient Age should be Greater than 20" MinimumValue="20" MaximumValue="100" Type="Integer" />
                          

                </td>

        </tr>
        <tr>
            <td><asp:Label ID="lblPatientHistory" Text="Patient History" CssClass="text-primary" runat="server"/> </td>
            <td><asp:TextBox ID="txtPatientHistory" runat="server" CssClass="form-control" />
                                        <asp:RequiredFieldValidator ID="rfvHistory" runat="server" ValidationGroup="grpCreate" ForeColor="OrangeRed" ErrorMessage ="Patient History can't be Empty" ControlToValidate="txtPatientHistory"  />
                </td>

        </tr>
        
        <tr>
            <td colspan="2">
                <asp:Button ID="btnRegister" runat="server" Text="Create" CssClass="btn btn-primary" OnClick="btnRegister_Click" ValidationGroup="grpCreate" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-info" />
            </td>
        </tr>
        <tr>
            <td> <asp:ValidationSummary ID="ValidationSummary1" runat="server" /></td>
        </tr>
       
    </table>
   

</asp:Content>
