<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Flights.aspx.cs" Inherits="Flights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">

        <div class="col-md-12" style="text-align: center;">
            <h3>Flights</h3>
            <br />
        </div>
    </div>

    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8" id="flightList" runat="server">
           
        </div>
        <div class="col-md-2"></div>
    </div>
</asp:Content>
