using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GatorGradNet
{
    public partial class GatorGradNet : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            user.Text = Session["UserName"].ToString();
        }

        protected void btn_Logout(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login2.aspx");
        }
}
}