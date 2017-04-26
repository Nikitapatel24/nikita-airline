using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["userId"] = null;
        Session["userName"] = null;
        Session["userType"] = null;
        Response.Redirect("default.aspx");
    }
}