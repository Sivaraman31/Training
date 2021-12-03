<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dummy.aspx.cs" Inherits="sample.Dummy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="lblform"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtform" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnform" runat="server" Text="Submit" />
    </form>
</body>
</html>
