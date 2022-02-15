<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactBook.aspx.cs" Inherits="ASPContactDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" cellpadding="0" cellspacing="0" style="border-collapse: collapse">
    <tr>
        <td style="width: 150px">
            Name:<br />
            <asp:TextBox ID="txtName" runat="server" Width="140" />
        </td>
        <td style="width: 150px">
            Country:<br />
            <asp:TextBox ID="txtCountry" runat="server" Width="140" />
        </td>
        <td style="width: 100px">
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="Insert" />
        </td>
    </tr>
</table>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>"
    SelectCommand="SELECT CustomerId, Name, Country FROM Customers"
    InsertCommand="INSERT INTO Customers VALUES (@Name, @Country)"
    UpdateCommand="UPDATE Customers SET Name = @Name, Country = @Country WHERE CustomerId = @CustomerId"
    DeleteCommand="DELETE FROM Customers WHERE CustomerId = @CustomerId">
    <InsertParameters>
        <asp:ControlParameter Name="Name" ControlID="txtName" Type="String" />
        <asp:ControlParameter Name="Country" ControlID="txtCountry" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="CustomerId" Type="Int32" />
        <asp:Parameter Name="Name" Type="String" />
        <asp:Parameter Name="Country" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CustomerId" Type="Int32" />
    </DeleteParameters>
</asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataSourceID="SqlDataSource1"
    DataKeyNames="CustomerId" OnRowDataBound="OnRowDataBound" EmptyDataText="No records has been added." OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150" />
        <asp:BoundField DataField="Country" HeaderText="Country" ItemStyle-Width="150" />
        <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true"
            ItemStyle-Width="100" />
    </Columns>
</asp:GridView>

        </div>
    </form>
</body>
</html>
