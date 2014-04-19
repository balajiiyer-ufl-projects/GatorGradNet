using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
public partial class PrevLocation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlAnchor ht = new HtmlAnchor();
        ht.HRef = "#";
        ht.InnerText = "Manipal";
        ht.Attributes.Add("class","users");
        this.group.Controls.Add(ht);
    }
}