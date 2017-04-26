using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cancel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        try
        {
            String id = Request.Params["bookingId"].ToString();
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("original_bookingid", id );
            
            int res = SqlHelper.Execute("SPDeleteBooking", myDict);

        }
        catch(Exception ee)
        {
        }
        Response.Redirect("Bookings.aspx");
    }
}