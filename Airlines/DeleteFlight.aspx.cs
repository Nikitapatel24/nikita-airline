using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteFlight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            String id = Request.Params["DeleteflighId"].ToString();
            Dictionary<String, String> param = new Dictionary<string, string>();
            param.Add("Original_flightId", id);
            SqlHelper.ExecuteQuerySP("SPDeleteFlight", param);
            
        }
        catch { }
        Response.Redirect("flights.aspx");
    }
}