using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace keyclue
{
    public partial class Inventory : AuthRequiredPage
    {
        protected override void finishPageLoad()
        {
            base.finishPageLoad();

            Label1.Text = Cookie.Load(Request, "mySiteAccount");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            logOut();
        }
    }
}