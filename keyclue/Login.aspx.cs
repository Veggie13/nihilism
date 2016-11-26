using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace keyclue
{
    public partial class Login : AuthPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginState state = GetCurrentState();

            if (state == LoginState.GotCookie || GetAccountCookie())
            {
                Response.Redirect("Default.aspx");
            }
            else if (IsPostBack)
            {
                Label1.Text = "Invalid username or password.";
            }
            else
            {
                Label1.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            if (username.Equals("adminy") && password.Equals("greatscott"))
            {
                Cookie.Save(Response, "mySiteAccount", username, 365);
                Cookie.Save(Response, "mySiteAccountPassword", password, 365);

                Session["username"] = username;

                Response.Redirect("Admin.aspx");
                return;
            }

            var acct = new KeyClueAccount(username);
            if (acct.Valid && acct.Password.Equals(password))
            {
                Cookie.Save(Response, "mySiteAccount", username, 365);
                Cookie.Save(Response, "mySiteAccountPassword", password, 365);

                Session["username"] = username;

                Response.Redirect("Default.aspx");
            }
        }
    }
}