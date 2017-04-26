<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditFlight.aspx.cs" Inherits="AddFlight" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">
        
        <div class="row">
            <div class="col-md-12">

                <table class="table">
                    <tr>
                        <th>Edit Flights</th>
                        <th></th>
                        <th>
                            <asp:Label ID="lblMessage" runat="server"></asp:Label></th>
                    </tr>
                    <tr>
                        <td style="width: 150px;">Flight Name</td>
                        <td>
                            <asp:TextBox ID="txtFlightName" runat="server" class="form-control"></asp:TextBox>

                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Flight Name" ControlToValidate="txtFlightName"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                     <tr>
                        <td style="width: 150px;">From</td>
                        <td>
                            <asp:TextBox ID="txtFrom" runat="server" class="form-control"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Flight Source Place" ControlToValidate="txtFrom"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 150px;">To</td>
                        <td>
                            <asp:TextBox ID="txtTo" runat="server" class="form-control"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter Flight Destination Place" ControlToValidate="txtTo"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 150px;">Time (hh:mm)</td>
                        <td>
                            <asp:DropDownList ID="hour" runat="server" class="form-control"  Width="81px">
                            
                            </asp:DropDownList>&nbsp;
                            <asp:DropDownList ID="min" runat="server" class="form-control"  Width="81px">
                               

                            </asp:DropDownList>
                        </td>
                        <td></td>
                    </tr>
                    
                   
                    <tr>
                        <td style="width: 150px;">Flight Date &lt;mm/dd/yyyy&gt;</td>
                        <td style="width: 150px;">
                            <asp:DropDownList ID="day" runat="server" class="form-control"  Width="81px">
                            </asp:DropDownList>&nbsp;
                    <asp:DropDownList ID="month" runat="server" class="form-control"  Width="81px"></asp:DropDownList>&nbsp;
                    <asp:DropDownList ID="year" runat="server" class="form-control"  Width="81px"></asp:DropDownList>
                        </td>
                        <td></td>
                    </tr>

                    <tr>
                        <td colspan="3" style="padding-left: 200px;">
                            <asp:Button ID="btnAdd" Text="Update" class="btn btn-default" runat="server" width="100px" OnClick="btnAdd_Click"/>
                        </td>
                    </tr>

                </table>

            </div>
        </div>
    </div>
</asp:Content>

