using System;

namespace AcademicLeaveSystem
{
    public partial class LeaveStatus :
        System.Web.UI.Page
    {
        protected void Page_Load(
            object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            lblLeaveType.Text =
                Session["leaveType"]?.ToString();

            lblLeaveDate.Text =
                Session["leaveDate"]?.ToString();

            lblReason.Text =
                Session["reason"]?.ToString();

            lblStatus.Text =
                Session["status"]?.ToString();
        }

        protected void btnHome_Click(
            object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}