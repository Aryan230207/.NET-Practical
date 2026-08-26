<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ApplyLeave.aspx.cs"
    Inherits="AcademicLeaveSystem.ApplyLeave" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Apply Leave</title>
</head>

<body>

<form id="form1" runat="server">

    <div>

        <h2>Apply Leave</h2>

        Leave Type:

        <asp:DropDownList
            ID="ddlLeaveType"
            runat="server">

            <asp:ListItem>Medical Leave</asp:ListItem>
            <asp:ListItem>Personal Leave</asp:ListItem>
            <asp:ListItem>Emergency Leave</asp:ListItem>

        </asp:DropDownList>

        <br /><br />

        Select Leave Date:

        <br />

        <asp:Calendar
            ID="Calendar1"
            runat="server">
        </asp:Calendar>

        <br />

        Reason:

        <br />

        <asp:TextBox
            ID="txtReason"
            runat="server">
        </asp:TextBox>

        <br /><br />

        <asp:Button ID="btnApply"
            runat="server"
            Text="Apply Leave"
            OnClick="btnApply_Click" />

        <br /><br />

        <asp:Label ID="lblMessage"
            runat="server">
        </asp:Label>

        <br /><br />

        <asp:Button ID="btnHome"
            runat="server"
            Text="Back"
            OnClick="btnHome_Click" />

    </div>

</form>

</body>
</html>