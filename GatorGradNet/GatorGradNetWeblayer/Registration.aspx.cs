using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;

public partial class Registration : System.Web.UI.Page
{
    //OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        String UserName = txtName.Text;
        String Password = txtPassword.Text;
        String Email = txtEmail.Text;
        //if (Password.Equals(txtRetypePassword.Text)) return;
        //else 
        Register_User(UserName, Password, Email);
        Session["Username"] = UserName;
        Response.Redirect("Default.aspx");
    }
    protected void Register_User(string username, string password, string email)
    {
        //OracleCommand cmd = new OracleCommand();
        //cmd.CommandText = "INSERT INTO PROFILEUSER VALUES(200,'" + username + "','" + password + "','" + email + "','annauniv','tcs','chennai',null)";
        //cmd.Connection = conn;
        //conn.Open();
        //cmd.ExecuteNonQuery();
        //conn.Close();
        GatorGradNet.BusinessLayer.UserManagement uManage = new GatorGradNet.BusinessLayer.UserManagement();
        uManage.RegisterUser(username, password, email);
    }
}