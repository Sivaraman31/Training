using System;

namespace WebsiteProject.UI.ADMIN
{
	public partial class AdminLogin : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				if(Session["AdminUserName"] != null)
				{
					Response.Redirect("/Admin/Dashboard");
				}
			}
		}

		protected void AdminFormSubmitted(object sender, EventArgs e)
		{
			string userName = adminUserName.Value.ToString();
			string password = adminPassword.Value.ToString();

			if(new WebsiteProjectDB.ADMIN.CheckLogin().AdminLoginValidation(userName, password))
			{
				Session["AdminUserName"] = userName;
				Response.Redirect("/Admin/Dashboard");
			}
			else
			{
				Response.Write("Wrong Password");
			}
		}
	}
}