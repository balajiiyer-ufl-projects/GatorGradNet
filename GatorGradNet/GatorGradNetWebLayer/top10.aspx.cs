using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GatorGradNet
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var pathName = "Statistics/pieData.csv";
            var fileName = Server.MapPath(pathName);
            
            if (File.Exists(fileName))
            { 
                File.GetAccessControl(fileName);
                File.Delete(fileName);
            }
            else
            {
                FileStream fs1 = File.Create(fileName);
                //file updation;
                fs1.Close();
                System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
                String lines = "age,population";
                file.WriteLine(lines);
                lines = "Amazon,270";
                file.WriteLine(lines);
                lines = "Bloomberg,200";
                file.WriteLine(lines);
                file.Close();
            }
            
        }
    }
}