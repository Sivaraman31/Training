<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebsiteProject.MasterPages.WebForm4" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../CSS/ADMIN/Dashboard.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="adminPageBodyContentLeft">
        <div class="AuthorsCount">
            <h3>Total Users: <span>1000</span></h3>
            <h3>Active Users: <span>100</span></h3>
        </div>
        <div class="topRatedAuthors">
            <div class="havingHighFollowersHeading">
                <h3>Authors Having High Amount of Followers</h3>
            </div>
            <div class="havingHighFollowersProfile">
                <div class="authorProfileCard">
                    <div class="profileImg">
                        <img src="../../Images/emp.png">
                    </div>
                    <div class="profileDescription">
                        <p>Author Name</p>
                    </div>
                </div>
                <div class="authorProfileCard">
                    <div class="profileImg">
                        <img src="../../Images/emp.png">
                    </div>
                    <div class="profileDescription">
                        <p>Author Name</p>
                    </div>
                </div>
                <div class="authorProfileCard">
                    <div class="profileImg">
                        <img src="../../Images/emp.png">
                    </div>
                    <div class="profileDescription">
                        <p>Author Name</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
	<div class="adminPageBodyContentRight">
					
	</div>
</asp:Content>
