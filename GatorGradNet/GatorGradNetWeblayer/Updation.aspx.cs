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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            String firstName = txtFirstName.Text;//present
            String lastName = txtLastName.Text;//present
            String email = txtEmail.Text;//present
            String phno = txtPhoneNo.Text;
            String currentWork=txtCurrentWork.Text;
            String branch = txtBranch.Text;//present
            float gpa = float.NaN;
            if(!String.IsNullOrEmpty(txtGPA.Text) && !String.IsNullOrWhiteSpace(txtGPA.Text))
            gpa = (float)Convert.ToDouble(txtGPA.Text);//present
            String prevEducation = txtPrevUniv.Text;//present
            String prevWork = txtPrevWork.Text;//present
            String prevLocation = txtPrevLoc.Text;//present
            String dreamCompany = txtDreamCompany.Text;//present
            String userName = Session["Username"].ToString();
            String password = null;//null passwords will not propagate to database.
            bool result =BusinessLayer.UserManagement.Instance().UpdateUserProfile(userName, firstName, lastName, password, email, prevEducation, prevWork, prevLocation, currentWork, gpa, dreamCompany, branch);
            if (result == true)
            {
                //Update successful
                lblResult.Text = "Profile updated succesfully!";
                lblResult.ForeColor = System.Drawing.Color.Green;
                lblResult.Visible = true;
            }
            else
            {
                //Update unsuccessful
                lblResult.Text = "Profile can not be updated right now!";
                lblResult.ForeColor = System.Drawing.Color.Red;
                lblResult.Visible = true;
            }
        }
}
}