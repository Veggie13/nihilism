using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace keyclue
{
    public partial class Admin : AuthRequiredPage
    {
        protected override void finishPageLoad()
        {
            base.finishPageLoad();

            string username = Cookie.Load(Request, "mySiteAccount");
            if (!"adminy".Equals(username))
            {
                logOut();
                return;
            }

            var acct = new KeyClueAccount("Zoo");
            TextBox1.Text = acct.Stage.ToString();

            acct = new KeyClueAccount("Geo");
            TextBox2.Text = acct.Stage.ToString();

            acct = new KeyClueAccount("Mech");
            TextBox3.Text = acct.Stage.ToString();

            acct = new KeyClueAccount("Chem");
            TextBox4.Text = acct.Stage.ToString();

            acct = new KeyClueAccount("Civil");
            TextBox5.Text = acct.Stage.ToString();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var acct = new KeyClueAccount("Zoo");
            acct.Stage = int.Parse(TextBox1.Text);
            acct.Write();
            acct = new KeyClueAccount("Geo");
            acct.Stage = int.Parse(TextBox2.Text);
            acct.Write();
            acct = new KeyClueAccount("Mech");
            acct.Stage = int.Parse(TextBox3.Text);
            acct.Write();
            acct = new KeyClueAccount("Chem");
            acct.Stage = int.Parse(TextBox4.Text);
            acct.Write();
            acct = new KeyClueAccount("Civil");
            acct.Stage = int.Parse(TextBox5.Text);
            acct.Write();
            logOut();
        }

    }
}