using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using NHibernate;
using NHibernateLibrary.Entities;
using NHibernateLibrary.Helper;
using NHibernateLibrary;
using GatorGradNet.BusinessLayer;
using GatorGradNet.DataAccessLayer;

namespace GatorGradNet
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = Session["Username"].ToString();
        }
        protected void btnChange_Click(object sender, EventArgs e)
        {
            string hello;
            if (validateUser())
            {
                if (txtNewPassword.Text == txtRetypeNewPassword.Text)
                {
                    String firstName = null;
                    String lastName = null;
                    String email = null;
                    String phno = null;
                    String currentWork = null;
                    String branch = null;
                    float gpa = float.NaN;
                    String prevEducation = null;
                    String prevWork = null;
                    String prevLocation = null;
                    String dreamCompany = null;
                    String userName = Session["Username"].ToString();
                    String password = txtRetypeNewPassword.Text;
                    bool result = BusinessLayer.UserManagement.Instance().UpdateUserProfile(userName, firstName, lastName, password, email, prevEducation, prevWork, prevLocation, currentWork, gpa, dreamCompany, branch);
                    if (result == true)
                    {
                        //password changed sucessfully
                        lblResult.Text = "Password changed sucessfully";
                        lblResult.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        //password change was not sucessfull
                        lblResult.Text = "Password change was unsucesfull";
                        lblResult.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }
        protected bool validateUser()
        {
            BusinessLayer.UserManagement uManage = new BusinessLayer.UserManagement();
            String Username = Session["Username"].ToString();
            String Password = txtcurrentPassword.Text;
            ProfileUser pUser = uManage.Login(Username, Password);
            if (pUser != null)
                return true;
            else
                return false;
        }
}
}