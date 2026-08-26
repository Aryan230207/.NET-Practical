<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="LeaveStatus.aspx.cs"
    Inherits="AcademicLeaveSystem.LeaveStatus" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Leave Status</title>
</head>

<body>

<form id="form1" runat="server">

    <div>

        <h2>Leave Status</h2>

        Leave Type:

        <asp:Label ID="lblLeaveType"
            runat="server">
        </asp:Label>

        <br /><br />

        Leave Date:

        <asp:Label ID="lblLeaveDate"
            runat="server">
        </asp:Label>

        <br /><br />

        Reason:

        <asp:Label ID="lblReason"
            runat="server">
        </asp:Label>

        <br /><br />

        Status:

        <asp:Label ID="lblStatus"
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