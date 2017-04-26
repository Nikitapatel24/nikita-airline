using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
        }
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Dictionary<String, String> param = new Dictionary<string, string>();
        param.Add("title", title.Text);
        param.Add("firstName", txtFirstName.Text);
        param.Add("lastName", txtLastName.Text);
        param.Add("dob", dobDay.Text + "-" + dobMonth.Text + "-" + dobYear.Text);
        param.Add("email", txtEmail.Text);
        param.Add("ppassword", txtPassword.Text);
        param.Add("phone", txtPhone.Text);
        param.Add("address", txtAddress.Text);

        try
        {
            int res = SqlHelper.Execute("SPInsertClient", param);
            Server.Transfer("RegisterSuccess.aspx");

        }
        catch
        {
            lblMessage.Text = "Failed to register";
        }
    }
}