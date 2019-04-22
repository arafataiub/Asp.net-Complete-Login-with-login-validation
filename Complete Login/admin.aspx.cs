using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Complete_Login
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["new"] != null)
            {
                LabelWelcome.Text += Session["new"].ToString();
                LabelCounter.Text = Session["counter"].ToString();
            }
            else
            {
                Response.Redirect("login.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["new"] = null;
            Session["admin"] = null;
            Session["counter"] = null;
            Response.Redirect("login.aspx");
        }
    }
}