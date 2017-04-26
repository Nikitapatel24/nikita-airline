<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Bookings.aspx.cs" Inherits="Bookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">

        <div class="col-md-12" style="text-align: center;">
            <h3>Bookings</h3>
            <br />
        </div>
    </div>

    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8" id="bookingList" runat="server">
           
        </div>
        <div class="col-md-2"></div>
    </div>
</asp:Content>
