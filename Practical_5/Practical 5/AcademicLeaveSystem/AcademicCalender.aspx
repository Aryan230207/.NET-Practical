<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="AcademicCalendar.aspx.cs"
    Inherits="AcademicLeaveSystem.AcademicCalendar" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Academic Calendar</title>
</head>

<body>

<form id="form1" runat="server">

    <div>

        <h2>Academic Calendar</h2>

        <asp:Calendar
            ID="Calendar1"
            runat="server"
            OnSelectionChanged="Calendar1_SelectionChanged">
        </asp:Calendar>

        <br />

        <asp:Label ID="lblDate"
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