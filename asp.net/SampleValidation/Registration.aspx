<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SampleValidation.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>


    <link rel="stylesheet" href="Style.css" />

    <style>
        @import url('https://fonts.googleapis.com/family-Bitter|Creat+Round|Pacifico');
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <div class="container">
                <div class="inner1">
                    <span>Sign in with Social Media</span><br /><br />
                    <a href="#" class="fb">Login with Facebook</a><br />
                    <a href="#" class="tw">Login with Twitter</a><br />
                    <a href="#" class="gl">Login with Google+</a><br />
                </div>
                <div class="inner2">
                    <h3>Sign Up</h3>

                    <asp:TextBox ID="uname" placeholder="Wsername" runat="server"></asp:TextBox>
                    <asp:TextBox ID="email" placeholder="E-mail" runat="server"></asp:TextBox>
                    <asp:TextBox ID="pass" placeholder="Password" TextMode="password" runat="server"></asp:TextBox>
                    <asp:TextBox ID="cops" placeholder="Reenter Password" TextMode="password" runat="server"></asp:TextBox>

                    <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Sign Me Up" />
                </div>
            </div>
        </section>
    </form>
</body>
</html>
