using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        signupmodal.Attributes.Add("style", "display:none");
        loginmodal.Attributes.Add("style", "display:none");
        loginok.Attributes.Add("style", "display:none");
        loginfailed.Attributes.Add("style", "display:none");
        signupok.Attributes.Add("style", "display:none");
        signupfailed.Attributes.Add("style", "display:none");
        if (string.IsNullOrEmpty((string)Session["username"]))
        {
            firstbutton.Text = "Sign Up";
            secondbutton.Text = "Login";
        }
        else
        {
            firstbutton.Text = Session["username"].ToString();
            secondbutton.Text = "Logout";
        }
    }
    protected void firstbutton_Click(object sender, EventArgs e)
    {
        signupmodal.Attributes.Add("style", "display:none");
        loginmodal.Attributes.Add("style", "display:none");
        if (string.IsNullOrEmpty((string)Session["username"]))
        {
            signupmodal.Attributes.Add("style", "display:block");
        }
        else
        {
            //profile button
        }
    }
    protected void secondbutton_Click(object sender, EventArgs e)
    {
        signupmodal.Attributes.Add("style", "display:none");
        loginmodal.Attributes.Add("style", "display:none");
        if (string.IsNullOrEmpty((string)Session["username"]))
        {
            loginmodal.Attributes.Add("style", "display:block");
        }
        else
        {
            Session["username"] = null;
            firstbutton.Text = "Sign Up";
            secondbutton.Text = "Login";
            Response.Redirect("~/home.aspx");
        }
    }
    protected void loginbutton_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
        con.Open();
        String q = "select count(*) from[usertable] where username='" + usernameinput.Text.ToString() + "' and password='" + passwordinput.Text.ToString() + "'";
        SqlCommand cmd = new SqlCommand(q, con);
        Int32 verify = Convert.ToInt32(cmd.ExecuteScalar());
        if (verify > 0)
        {
            Session["username"] = usernameinput.Text.ToString();
            loginokmsg.Text = "Welcome " + usernameinput.Text.ToString() + "!";
            loginok.Attributes.Add("style", "display:block");
            Page.Header.Controls.Add(new LiteralControl(string.Format("<META http-equiv=\"REFRESH\" content=\"2;url={0}\" > ", "home.aspx")));
            
        }
        else
        {
            loginfailed.Attributes.Add("style", "display:block");
            Page.Header.Controls.Add(new LiteralControl(string.Format("<META http-equiv=\"REFRESH\" content=\"2;url={0}\" > ", "home.aspx")));
        }
        con.Close();
    }
    protected void signupbutton_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
        con.Open();
        String q = "insert into[usertable] values('" + susernameinput.Text.ToString() + "', '" + firstnameinput.Text.ToString() + "','" + lastnameinput.Text.ToString() + "', '" + spasswordinput.Text.ToString() + "', '" + emailinput.Text.ToString() + "')";
        SqlCommand cmd = new SqlCommand(q, con);
        try
        {
            Int32 verify = Convert.ToInt32(cmd.ExecuteScalar());
            signupok.Attributes.Add("style", "display:block");
            Session["username"] = susernameinput.Text.ToString();
            Page.Header.Controls.Add(new LiteralControl(string.Format("<META http-equiv=\"REFRESH\" content=\"2;url={0}\" > ", "home.aspx")));

        }
        catch
        {
            signupfailed.Attributes.Add("style", "display:block");
            Page.Header.Controls.Add(new LiteralControl(string.Format("<META http-equiv=\"REFRESH\" content=\"2;url={0}\" > ", "home.aspx")));
        }
        
        
        con.Close();
    }
    
}
