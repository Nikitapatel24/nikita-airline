<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Book.aspx.cs" Inherits="Book" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        
        <div class="row">
            <div class="col-md-12">

                <table class="table">
                    <tr>
                        <th>Flight</th>
                        <th></th>
                        <th style="width: 173px">
                            &nbsp;</th>
                        <th>
                            &nbsp;</th>
                    </tr>
                    <tr>
                        <td style="width: 150px;">Flight Name</td>
                        <td>
                            <asp:Label ID="lblFlightName" runat="server" Text="Label"></asp:Label>

                        </td>
                        <td style="width: 173px">
                            Time (hh:mm)</td>
                        <td>
                            <asp:Label ID="lblFlightTime" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                     <tr>
                        <td style="width: 150px;">From</td>
                        <td>
                            <asp:Label ID="lblFrom" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td style="width: 173px">
                            Flight Date &lt;mm/dd/yyyy&gt;</td>
                        <td>
                            <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 150px; height: 38px;">To</td>
                        <td style="height: 38px">
                            <asp:Label ID="lblTo" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td style="height: 38px; width: 173px">
                            &nbsp;</td>
                        <td style="height: 38px">
                            &nbsp;</td>
                    </tr>
                    
                </table>
                <br />
        <br />
        <table class="table">
            <tr>
                <th>Passenger Details</th>
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
                <td colspan="2"  style="padding-left:200px;"><asp:Button ID="btnBook" Text="Book Ticket" class="btn btn-default" runat="server" OnClick="btnBook_Click" /></td> 
            </tr>
        </table>
            </div>
        </div>
    </div>
</asp:Content>

