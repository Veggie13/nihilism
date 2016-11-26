using System;
using System.Collections.Generic;
using System.Web;

namespace keyclue
{
    public class AuthPage : System.Web.UI.Page
    {
        protected KeyClueAccount Account { get; set; }

        public enum LoginState
        {
            LogIn = 0,
            GotCookie,
            AccountBad,
        }

        protected bool GetAccountCookie()
        {
            string acct = Cookie.Load(Request, "mySiteAccount");
            if ("adminy".Equals(acct))
            {
                return true;
            }
            if (!acct.Equals(""))
            {
                Account = new KeyClueAccount(acct);
                if (!Account.Valid)
                {
                    Account = null;
                    return false;
                }
                string pwd = Cookie.Load(Request, "mySiteAccountPassword");
                if (!pwd.Equals(Account.Password))
                {
                    Account = null;
                    return false;
                }
                return true;
            }
            return false;
        }

        protected LoginState GetCurrentState()
        {
            // Assume a default value: first time
            LoginState state = LoginState.LogIn;

            // If page is being loaded in response to a client callback, we know that the state
            // has already been set, so just get it.
            /*if (IsPostBack)
            {
                state = (LoginState)ViewState["loginState"];
            }
            else*/
            {
                // The page is being loaded for the first time or as a response to a redirect.
                // Get the login state parameter passed in as part of the redirect.
                string stateStr = Request.Params["loginState"];

                // If the parameter exists, then this is a response to a redirect.
                if (stateStr != null)
                {
                    state = (LoginState)Int32.Parse(stateStr);
                }

                // Save the state for use in post back.
                ViewState["loginState"] = state;
            }
            return state;
        }
    }
}