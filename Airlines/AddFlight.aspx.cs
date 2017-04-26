using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddFlight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            for (int i = 1; i < 32; i++)
            {
                day.Items.Add("" + i);
            }
            for (int i = 2017; i < 2021; i++)
            {
                year.Items.Add("" + i);
            }
            
            for (int i = 1; i < 13; i++)
            {
                month.Items.Add("" + i);
            }
            for (int i = 0; i < 24; i++)
            {
                if (i < 10)
                {
                    hour.Items.Add("0" + i);
                }
                else
                {
                    hour.Items.Add(i.ToString());
                }
            }
            for (int i = 0; i < 60; i++)
            {
                if (i < 10)
                {
                    min.Items.Add("0" + i);
                }
                else
                {
                    min.Items.Add(i == 0 ? "00" : i.ToString());
                }
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Flight f = new Flight(txtFlightName.Text, day.Text + "/" + month.Text + "/" + year.Text, hour.Text + ":" + min.Text, txtFrom.Text, txtTo.Text);
        Dictionary<String, String> param = new Dictionary<string, string>();
        param.Add("flightId", f.fId);
        param.Add("from", f.fFrom);
        param.Add("to", f.fTo);
        param.Add("flightTime", f.fTime);
        param.Add("flightDate", f.fDate);

        try
        {
            int res = SqlHelper.Execute("SPInsertFlight", param);
            if (res == 0)
            {
                Response.Redirect("Flights.aspx");
            }
            else
            {
                lblMessage.Text = "Failed to add flight";
            }
        }
        catch (Exception ee)
        {
            lblMessage.Text = ee.Message;
        }
    }
}