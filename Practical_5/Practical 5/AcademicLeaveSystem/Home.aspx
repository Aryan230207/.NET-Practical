<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Home.aspx.cs"
    Inherits="AcademicLeaveSystem.Home" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Home</title>
</head>

<body>

<form id="form1" runat="server">

    <div>

        <h2>Welcome to Academic Leave Management System</h2>

        <asp:Label ID="lblWelcome"
            runat="server">
        </asp:Label>

        <br /><br />

        <asp:Button ID="btnCalendar"
            runat="server"
            Text="Academic Calendar"
            OnClick="btnCalendar_Click" />

        <br /><br />

        <asp:Button ID="btnLeave"
            runat="server"
            Text="Apply Leave"
            OnClick="btnLeave_Click" />

        <br /><br />

        <asp:Button ID="btnStatus"
            runat="server"
            Text="Leave Status"
            OnClick="btnStatus_Click" />

        <br /><br />

        <asp:Button ID="btnLogout"
            runat="server"
            Text="Logout"
            OnClick="btnLogout_Click" />

    </div>

</form>

</body>
</html>