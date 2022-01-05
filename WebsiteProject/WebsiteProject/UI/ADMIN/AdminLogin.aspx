<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="WebsiteProject.UI.ADMIN.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADMIN LOGIN</title>

    <link href="../../CSS/ADMIN/AdminLogin.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div class="formContent">
            <h3>Login</h3>
            <h3>Admin</h3>
        </div>
        <div class="formContainer">
            <form method="POST"  id="form1" runat="server">
                <div class="inputContainer">
                    <label>UserName</label>
                    <input id="adminUserName" type="text" name="username" runat="server" /><br />
                </div>
                <div class="inputContainer">
                    <label>Password</label>
                    <input id="adminPassword" type="password" name="password" runat="server" /><br />
                </div>
                <asp:Button class="formSubmitButton" Text="Submit" OnClick="AdminFormSubmitted" runat="server" />
            </form>
        </div>
    </div>
</body>
</html>
