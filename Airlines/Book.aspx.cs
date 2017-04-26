using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Book : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        if (Session["userType"].ToString() == "user")
        {
            String id = Session["userId"].ToString();
            String fId = Request.Params["flighId"];
            Dictionary<String, String> param = new Dictionary<String, String>();
            param.Add("flightName", fId);
            param.Add("client", id);
            SqlHelper.Execute("SPInsertBooking", param);
            Response.Redirect("bookings.aspx");
        }
        if (!IsPostBack)
        {
            for (int i = 1; i < 32; i++)
            {
                dobDay.Items.Add("" + i);
            }
            for (int i = 1940; i < 2001; i++)
            {
                dobYear.Items.Add("" + i);
            }
            dobYear.SelectedIndex = 40;
            for (int i = 1; i < 13; i++)
            {
                dobMonth.Items.Add("" + i);
            }

            String fId = Request.Params["flighId"];
            try
            {
                Dictionary<String, String> param = new Dictionary<String, String>();
                param.Add("@flightId", fId);
                DataTable dt = SqlHelper.ExecuteQuerySP("SPSelectFlight", param);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Flight f = new Flight(dr["flightId"].ToString(), dr["flightDate"].ToString(), dr["flightTime"].ToString(), dr["from"].ToString(), dr["to"].ToString());
                    lblFlightName.Text = f.fId;
                    lblFrom.Text = f.fFrom;
                    lblTo.Text = f.fTo;
                    lblFlightTime.Text = f.fTime;
                    lblDate.Text = f.fDate;
                }
                else
                {
                    Response.Redirect("Flights.aspx");
                }
            }
            catch
            {
                Response.Redirect("Flights.aspx");
            }
        }
        
    }
    protected void btnBook_Click(object sender, EventArgs e)
    {
        Dictionary<String, String> param = new Dictionary<string, string>();
        param.Add("title", title.Text);
        param.Add("firstName", txtFirstName.Text);
        param.Add("lastName", txtLastName.Text);
        param.Add("dob", dobDay.Text + "-" + dobMonth.Text + "-" + dobYear.Text);
        param.Add("email", txtEmail.Text);
        param.Add("ppassword", "123");
        param.Add("phone", txtPhone.Text);
        param.Add("address", txtAddress.Text);

        try
        {
            int res = SqlHelper.Execute("SPInsertClient", param);
            param.Clear();
            param.Add("flightName", lblFlightName.Text);
            param.Add("client", res+"");
            SqlHelper.Execute("SPInsertBooking", param);
            Response.Redirect("bookings.aspx");
        }
        catch
        {
            lblMessage.Text = "Failed to book ticket";
        }
    }
   
}