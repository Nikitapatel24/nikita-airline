<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


 	<div class="row">
	<div class="container">
        <br />
        <br />
        <table class="table">
            <tr>
                <th>Register</th>
                <th></th>
                <th><asp:Label ID="lblMessage" runat="server"></asp:Label></th>
            </tr>
            <tr>
                <td style="width:150px;">Title</td>
                <td>
                    <asp:DropDownList ID="title" runat="server" class="form-control">
                        <asp:ListItem>Mr.</asp:ListItem>
                         <asp:ListItem>Mrs.</asp:ListItem>
                  
                    </asp:DropDownList>
                </td>
                <td></td>
            </tr>
            <tr>
                <td style="width:150px;">First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server" class="form-control"></asp:TextBox> 

                </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter First Name" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width:150px;">Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server" class="form-control"></asp:TextBox> 
                </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Last Name" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width:150px;">Date Of Birth &lt;mm/dd/yyyy&gt;</mm></td>
                <td style="width:150px;"><asp:DropDownList ID="dobDay" runat="server" class="form-control">

                    </asp:DropDownList>&nbsp;
                    <asp:DropDownList ID="dobMonth" runat="server" class="form-control"></asp:DropDownList>&nbsp;
                    <asp:DropDownList ID="dobYear" runat="server" class="form-control"></asp:DropDownList>
                </td>
                 <td></td>
            </tr>
            <tr>
                <td style="width:150px;">Phone</td>
                <td style="width:150px;"><asp:TextBox ID="txtPhone" runat="server" class="form-control"></asp:TextBox> </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Phone" ControlToValidate="txtPhone"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width:150px;">Email</td>
                <td style="width:150px;"><asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox> </td>
                 <td>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width:150px;">Address</td>
                <td style="width:150px;"><asp:TextBox ID="txtAddress" runat="server" class="form-control"></asp:TextBox> </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Address" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width:150px;">Password</td>
                <td style="width:150px;"><asp:TextBox ID="txtPassword" runat="server" class="form-control"></asp:TextBox> </td>
                <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Password" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td style="width:150px;">Confirm Password</td>
                <td style="width:150px;"><asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox> </td>
                  <td>
                      <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Password Mismatch"></asp:CompareValidator>
                 </td>
            </tr>
             <tr>
                <td colspan="2"  style="padding-left:200px;"><asp:Button ID="btnRegister" Text="Register" class="btn btn-default" runat="server" OnClick="btnRegister_Click"/></td> 
            </tr>
        </table>
	</div>		
	</div>
</asp:Content>
