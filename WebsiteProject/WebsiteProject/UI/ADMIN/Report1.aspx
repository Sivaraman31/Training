<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Report1.aspx.cs" Inherits="WebsiteProject.MasterPages.WebForm5" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../CSS/ADMIN/Report.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ReportPageBodyContentLeft">
        <div class="ReportPageBodyContentLeftTop">
            <h3>Most Reported Blogs</h3>
            <div class="ReportedBlogNames">
                <p class="BlogName">Blog One</p>
                <p class="BlogName">Blog Two</p>
                <p class="BlogName">Blog Three</p>
                <p class="BlogName">Blog Four</p>
                <p class="BlogName">Blog Five</p>
                <asp:Button Text="Shows" CssClass="ShowAllBlogs" runat="server" />
            </div>
        </div>
    </div>
     <div class="ReportPageBodyContentRight">
         <div class="ReportPageBodyContentRightTop">
            <h3>Report Review</h3>
            <div class="ReviewBlogNames">
                <p class="BlogName">Review Blog One</p>
                <p class="BlogName">Review Blog Two</p>
                <p class="BlogName">Review Blog Three</p>
                <p class="BlogName">Review Blog Four</p>
                <p class="BlogName">Review Blog Five</p>
                <asp:Button Text="Shows" CssClass="ShowAllBlogs" runat="server" />
            </div>
         </div>         
     </div>
</asp:Content>
