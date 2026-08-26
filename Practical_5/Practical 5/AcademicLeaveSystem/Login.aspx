<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs"
    Inherits="AcademicLeaveSystem.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
</head>

<body>

<form id="form1" runat="server">

    <div>

        <h2>Academic Calendar and Leave Management System</h2>

        Username:
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>

        <br /><br />

        Password:
        <asp:TextBox ID="txtPassword"
            runat="server"
            TextMode="Password">
        </asp:TextBox>

        <br /><br />

        <asp:CheckBox ID="chkRemember"
            runat="server"
            Text="Remember Me" />

        <br /><br />

        <asp:Button ID="btnLogin"
            runat="server"
            Text="Login"
            OnClick="btnLogin_Click" />

        <br /><br />

        <asp:Label ID="lblMessage"
            runat="server">
        </asp:Label>

    </div>

</form>

</body>
</html>