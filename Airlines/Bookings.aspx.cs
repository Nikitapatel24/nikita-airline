using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Bookings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userType"] == null)
        {
            Response.Redirect("Login.aspx");
        }


        DataTable dt = null;
        if (Session["userType"] != null && Session["userType"].ToString() == "admin")
        {
            dt = SqlHelper.ExecuteQuerySP("SPSelectBooking", new Dictionary<string, string>());
        }
        else
        {
            String userId = Session["userId"].ToString();
            Dictionary<String, String> param = new Dictionary<string, string>();
            param.Add("client", userId);
            dt = SqlHelper.ExecuteQuerySP("SPMyBookings", param);
        }
        String bookings = @"<table class='table'>
                <tr>
                    <th>Flight</th>
                    <th>Date</th>
                    <th>Time</th>
                    <th>From</th>
                    <th>To</th>
                    <th>Passenger Name</th>
                </tr>";
       for (int i = 0; i < dt.Rows.Count; i++)
        {

            bookings += @"<tr>
                    <td>";
           bookings+=dt.Rows[i]["flightname"].ToString()+"</td>";
            bookings+=" <td>"+dt.Rows[i]["flightDate"].ToString()+"</td>";
            bookings+=" <td>"+dt.Rows[i]["flightTime"].ToString()+"</td>";
           bookings+=" <td>"+dt.Rows[i]["from"].ToString()+"</td>";
           bookings+=" <td>"+dt.Rows[i]["to"].ToString()+"</td>";
           bookings += " <td>" + dt.Rows[i]["firstName"].ToString() + " " + dt.Rows[i]["lastName"].ToString() + "</td>";
           bookings += "<td><a href=\"Cancel.aspx?bookingId=" + dt.Rows[i]["bookingId"].ToString() + "\" class=\"btn btn-default\">Cancel Ticket</a>";
           bookings += "</td></tr>";
        }

        bookings += "</table>";

        bookingList.InnerHtml = bookings;
        
    }
}