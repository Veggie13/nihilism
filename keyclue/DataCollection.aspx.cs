using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace keyclue
{
    public partial class DataCollection : AuthRequiredPage
    {
        protected override void finishPageLoad()
        {
            base.finishPageLoad();

            Label1.Text = Cookie.Load(Request, "mySiteAccount");

            string username = Label1.Text;
            var acct = new KeyClueAccount(username);
            if (acct.BStage == 1)
            {
                Label2.Visible = false;
                LinkButton1.Visible = false;
            }

            string strReq = Request.QueryString["file"];
            if ("20130108.zip".Equals(strReq))
            {
                string path = "E:\\KeyClueFiles\\";
                switch (acct.Stage)
                {
                    default:
                    case 0: path += "stage0"; break;
                    case 1: path += "stage1"; break;
                    case 2: path += "stage2"; break;
                    case 3: path += "stage3"; break;
                }
                path += "\\20130108.zip";
                //path = Server.MapPath(path);
                var f = new System.IO.FileInfo(path);
                if (f.Exists)
                {
                    Response.Clear();
                    Response.AddHeader("Content-Disposition", "attachment; filename=20130108.zip");
                    Response.AddHeader("Content-Length", f.Length.ToString());
                    Response.ContentType = "application/octet-stream";
                    Response.WriteFile(f.FullName);
                    Response.End();
                }
                else
                {
                    Response.Write("This file does not exist.");
                }
            }
            else if (acct.BStage == 0 && "20130103.zip".Equals(strReq))
            {
                string path = "E:\\KeyClueFiles\\dummy\\20130103.zip";
                var f = new System.IO.FileInfo(path);
                if (f.Exists)
                {
                    Response.Clear();
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + strReq);
                    Response.AddHeader("Content-Length", f.Length.ToString());
                    Response.ContentType = "application/octet-stream";
                    Response.WriteFile(f.FullName);
                    Response.End();
                }
                else
                {
                    Response.Write("This file does not exist.");
                }
            }
            else if (strReq != null && !"".Equals(strReq))
            {
                string path = "E:\\KeyClueFiles\\dummy\\dummy.zip";
                var f = new System.IO.FileInfo(path);
                if (f.Exists)
                {
                    Response.Clear();
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + strReq);
                    Response.AddHeader("Content-Length", f.Length.ToString());
                    Response.ContentType = "application/octet-stream";
                    Response.WriteFile(f.FullName);
                    Response.End();
                }
                else
                {
                    Response.Write("This file does not exist.");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            logOut();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string username = Label1.Text;

            Response.Redirect("DataCollection.aspx?file=20130103.zip");
        }
    }
}