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
       
        Dictionary<String, String> param = new Dictionary<String, String>();
        param.Add("email", username.Value);
        param.Add("ppassword", password.Value);
        DataTable dt = SqlHelper.ExecuteQuerySP("SPSelectClient", param);
          if (dt.Rows.Count > 0)
          {
              Session["userId"] = dt.Rows[0]["passengerId"].ToString();
              Session["userName"] = dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();
              Session["userType"] = "user";
              Response.Redirect("default.aspx");
          }
          else
          {
              msg.Text = "Failed to login";
          }
       

    }
}