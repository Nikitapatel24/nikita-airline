using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
       
       if (username.Value == "admin" && password.Value == "admin")
          {
              Session["userId"] = "admin";
              Session["userName"] = "Admin";
              Session["userType"] = "admin";
              Response.Redirect("default.aspx");
          }
          else
          {
              msg.Text = "Failed to login";
          }
       

    }
}