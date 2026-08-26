using System;

namespace AcademicLeaveSystem
{
    public partial class ApplyLeave :
        System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnApply_Click(
            object sender, EventArgs e)
        {
            // Save leave information in Session

            Session["leaveType"] =
                ddlLeaveType.SelectedItem.Text;

            Session["leaveDate"] =
                Calendar1.SelectedDate.ToShortDateString();

            Session["reason"] =
                txtReason.Text;

            Session["status"] = "Pending";

            lblMessage.Text =
                "Leave Applied Successfully";
        }

        protected void btnHome_Click(
            object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}