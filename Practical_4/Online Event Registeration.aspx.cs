using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_4
{
    public partial class OnlineEventRegistration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode =
                UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Validate();

            if (!Page.IsValid)
            {
                pnlResult.Visible = false;
                return;
            }

            string name = TextBox1.Text;
            string email = TextBox2.Text;
            string mobile = TextBox3.Text;
            string college = TextBox4.Text;

            string department = RadioButtonList1.SelectedValue;
            string eventName = DropDownList1.SelectedValue;

            string gender = "Not Selected";

            if (Male.Checked)
                gender = "Male";
            else if (Female.Checked)
                gender = "Female";

            string skills = "";

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    if (!string.IsNullOrEmpty(skills))
                    {
                        skills += ", ";
                    }

                    skills += item.Text;
                }
            }

            if (string.IsNullOrEmpty(skills))
            {
                skills = "Not Selected";
            }

            string address = TextArea1.Text;

            string terms = chkTerms.Checked
                ? "Accepted"
                : "Not Accepted";

            lblResult.Text =
                "<b>Full Name:</b> " + Server.HtmlEncode(name) + "<br />" +
                "<b>Email:</b> " + Server.HtmlEncode(email) + "<br />" +
                "<b>Mobile:</b> " + Server.HtmlEncode(mobile) + "<br />" +
                "<b>College:</b> " + Server.HtmlEncode(college) + "<br />" +
                "<b>Department:</b> " + Server.HtmlEncode(department) + "<br />" +
                "<b>Event:</b> " + Server.HtmlEncode(eventName) + "<br />" +
                "<b>Gender:</b> " + Server.HtmlEncode(gender) + "<br />" +
                "<b>Skills:</b> " + Server.HtmlEncode(skills) + "<br />" +
                "<b>Address:</b> " +
                Server.HtmlEncode(address).Replace("\r\n", "<br />") + "<br />" +
                "<b>Terms:</b> " + Server.HtmlEncode(terms);

            pnlResult.Visible = true;
        }
    }
}