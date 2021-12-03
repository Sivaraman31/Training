<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleForm.aspx.cs" Inherits="SampleApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblform" runat="server" Text="Name"></asp:Label><asp:TextBox ID="txtform" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnform" runat="server" Text="Click Me" OnClick="btnform_Click" />
        </div>
    </form>
</body>
</html>
