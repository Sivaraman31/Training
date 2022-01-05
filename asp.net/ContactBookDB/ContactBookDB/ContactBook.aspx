<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactBook.aspx.cs" Inherits="ContactBookDB.ContactBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
	            margin: 0;
	            padding: 0;
          }

        .container {
                border:2px solid black;
	            height: 90%;
	            width: 100%;
	            display: flex;
	            flex-direction: column;
          }

        header {
	            height: 10%;
	            width: 100%;
	            display: flex;
	            justify-content: center;
	            align-items: center;
          }
        .input {
	width: 30%;
	display: flex;
	justify-content: space-between;
	margin: 0 auto;
	padding: 5px 0;
}
.input1{
    width:100%;
    margin: 0 auto;
	padding: 5px 0;
}
.btn{
    text-align:center;
}
.submitButton {
	font-size: 14px;
	padding: 7px 10px;
	margin-top: 20px;
}

.input label {
	font-size: 24px;
}
.Container1 {
	height: 100%;
	width: 50%;
	border-left: 2px solid red;
}
.auto-style1{
    align-self:center;
    height:50%;
    width:50%;
}

    </style>
</head>
<body>
    <form class="form" runat="server" autocomplete="off">
         <div>
             
                 <header><h1>
                     Contact Book</h1></header>
                 <div class="input">
                     <label>Contact Name</label>
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                 </div>
                 <div class="input">
                     <label>Phone Number</label>
                     <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
                     
                 </div>
                 <div class="input">
                     <label>Location</label>
                     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    
                 </div>
                 <div class="input">
                     <label>E-Mail</label>
                     <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                     
                 </div>
                 <div class="btn"> 
                     <asp:Button CssClass="submitButton" Text="Add Contact" runat="server" ID="btnAdd" OnClick="btnAdd_Click" />
                     <asp:Button CssClass="submitButton" Text="Display Contact" runat="server" ID="Button1" OnClick="Button1_Click" />
                    
                 </div>
             

             <div class="container1">
                 <div class="input">
                     <asp:TextBox class="input1" ID="TextBox5" runat="server"></asp:TextBox>
                 </div>
                 <div class="input">
                     <asp:Button CssClass="submitButton" Text="Search Contact" runat="server" ID="btnSearch" OnClick="SearchContact_Click" />
                     <asp:Button CssClass="submitButton" Text="Delete Contact" runat="server" ID="btnDelete" OnClick="DeleteContact_Click" />
                     <asp:Button CssClass="submitButton" Text="Update" runat="server" ID="btnUpdate" OnClick="Update_Click" />
                 </div>
             </div>
             
         </div>
        
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <div style="margin-left:29%;">
             
             <asp:GridView ID="ContactGridView" runat="server" Height="268px" Width="614px" OnSelectedIndexChanged="gvContacts_SelectedIndexChanged">
                <Columns>
                    
                    <asp:CommandField ShowSelectButton="True"/>
                </Columns>
             </asp:GridView>
         </div>
        
    </form>
</body>
</html>
