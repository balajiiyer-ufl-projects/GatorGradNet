using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GatorGradNet
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BusinessLayer.RecruitmentStatistics rs = new BusinessLayer.RecruitmentStatistics();
            String pathName = "Statistics/data.tsv";
            String fileName = Server.MapPath(pathName);
            rs.StatisticsByYear("microsoft", fileName);

        }
    }
}