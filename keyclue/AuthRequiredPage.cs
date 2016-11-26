using System;
using System.Collections.Generic;
using System.Web;

namespace keyclue
{
    public abstract class AuthRequiredPage : AuthPage
    {
        protected virtual void finishPageLoad()
        {
        }

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // get our current state
            LoginState state = GetCurrentState();

            if (state != LoginState.GotCookie)
            {
                // Get cookie to load user account info, and set state that cookie has been received.
                if (!GetAccountCookie())
                {
                    Response.Redirect("Login.aspx");
                    return;
                }
                ViewState["loginState"] = LoginState.GotCookie;
            }

            finishPageLoad();
        }

        protected void logOut()
        {
            Cookie.Delete(Response, "mySiteAccount");
            Cookie.Delete(Response, "mySiteAccountPassword");
            ViewState["loginState"] = LoginState.LogIn;
            Session.Remove("username");
            Response.Redirect("Login.aspx");
        }

    }
}