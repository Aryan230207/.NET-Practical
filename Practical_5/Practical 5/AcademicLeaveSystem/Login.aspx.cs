using System;

namespace AcademicLeaveSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["username"] != null)
                {
                    txtUsername.Text =
                        Request.Cookies["username"].Value;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "student" && password == "123")
            {
                // Save username in Session
                Session["username"] = username;

                // Save username in Cookie
                if (chkRemember.Checked)
                {
                    Response.Cookies["username"].Value = username;

                    Response.Cookies["username"].Expires =
                        DateTime.Now.AddDays(7);
                }

                Response.Redirect("Home.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid Username or Password";
            }
        }
    }
}