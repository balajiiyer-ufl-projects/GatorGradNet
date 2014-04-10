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

public partial class Login2 : System.Web.UI.Page
{
    //OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Login_ButtonClick(object sender, EventArgs e)
    {
        string username = TextBox1.Text;
        string password = TextBox2.Text;
        if (Check_Login(username, password))
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            //Response.Redirect("Default.aspx");
            Response.Redirect("LoginFail.html");
        }
    }
    protected void Register_ButtonClick(object sender, EventArgs e)
    {
        Response.Redirect("Registration.aspx");
    }
    protected bool Check_Login(string Username, string Password)
    {
        GatorGradNet.BusinessLayer.UserManagement uManage = new GatorGradNet.BusinessLayer.UserManagement();
        ProfileUser pUser = uManage.Login(Username, Password);
        if (pUser != null)
        {
            Session["Username"] = Username;
            return true;
        }
/*        OracleCommand cmd = new OracleCommand();
        cmd.CommandText = "SELECT USERNAME,PASSWORD FROM PROFILEUSER";
        cmd.Connection = conn;
        OracleDataReader login;
        conn.Open();
        login = cmd.ExecuteReader();
        if (login.HasRows)
        {
            while (login.Read())
            {
                if (Username.Equals(login.GetString(0)))
                {
                    if (Password.Equals(login.GetString(1)))
                    {
                        Session["UserName"] = Username; 
                        conn.Close();
                        return true;
                    }
                }
            }
        }
        conn.Close();
 */
        return false;
    }
   
    
}