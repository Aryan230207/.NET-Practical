using System;

namespace AcademicLeaveSystem
{
    public partial class AcademicCalendar :
        System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Calendar1_SelectionChanged(
            object sender, EventArgs e)
        {
            lblDate.Text =
                "Selected Date: " +
                Calendar1.SelectedDate.ToShortDateString();
        }

        protected void btnHome_Click(
            object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}