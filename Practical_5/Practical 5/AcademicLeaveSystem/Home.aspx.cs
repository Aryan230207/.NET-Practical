using System;

namespace AcademicLeaveSystem
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check Session
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            lblWelcome.Text =
                "Welcome " + Session["username"].ToString();
        }

        protected void btnCalendar_Click(
            object sender, EventArgs e)
        {
            Response.Redirect("AcademicCalendar.aspx");
        }

        protected void btnLeave_Click(
            object sender, EventArgs e)
        {
            Response.Redirect("ApplyLeave.aspx");
        }

        protected void btnStatus_Click(
            object sender, EventArgs e)
        {
            Response.Redirect("LeaveStatus.aspx");
        }

        protected void btnLogout_Click(
            object sender, EventArgs e)
        {
            Session.Clear();

            Response.Redirect("Login.aspx");
        }
    }
}