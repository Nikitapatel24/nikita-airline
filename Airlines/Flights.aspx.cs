using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Flights : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = SqlHelper.ExecuteQuerySP("spAllFlights", new Dictionary<string, string>()); 
        String flights = "";

        if (Session["userType"] != null && Session["userType"].ToString() == "admin")
        {

            flights = @"<a href='AddFlight.aspx' class='btn btn-default'>Add Flight</a>";
        }
        flights += @"<table class='table'>
                <tr>
                    <th>Name</th>
                    <th>Date</th>
                    <th>Time</th>
                    <th>From</th>
                    <th>To</th>
                    <th></th>
                </tr>";
       for (int i = 0; i < dt.Rows.Count; i++)
        {

            flights += @"<tr>
                    <td>";
           flights+=dt.Rows[i]["flightId"].ToString()+"</td>";
            flights+=" <td>"+dt.Rows[i]["from"].ToString()+"</td>";
            flights+=" <td>"+dt.Rows[i]["to"].ToString()+"</td>";
           flights+=" <td>"+dt.Rows[i]["flightTime"].ToString()+"</td>";
           flights+=" <td>"+dt.Rows[i]["flightDate"].ToString()+"</td>";
           flights += "<td><a href=\"Book.aspx?flighId=" + dt.Rows[i]["flightId"].ToString() + "\" class=\"btn btn-default\">Book Ticket</a>";
            if(Session["userType"]!=null && Session["userType"].ToString()=="admin"){

                flights += "&nbsp;<a href='DeleteFlight.aspx?DeleteflighId=" + dt.Rows[i]["flightId"].ToString() + "' class='btn btn-default'>Delete Flight</a>&nbsp;<a href='EditFlight.aspx?EditflighId=" + dt.Rows[i]["flightId"].ToString() + "' class='btn btn-default'>Edit Flight</a>";
            }

            flights += "</td></tr>";
        }

        flights += "</table>";

        flightList.InnerHtml = flights;
        
    }
}