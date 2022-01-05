using System;
using System.Web.Routing;

namespace WebsiteProject
{
	public class Global : System.Web.HttpApplication
	{
		void RegisterRoutes(RouteCollection routes)
		{
			// Default
			// routes.MapPageRoute("", "", "~/UI/ADMIN/DailyPuzzles.aspx");

			// Admin URL Routings
			routes.MapPageRoute("Admin", "Admin", "~/UI/ADMIN/AdminLogin.aspx");
			routes.MapPageRoute("Dashboard", "Admin/Dashboard", "~/UI/ADMIN/Dashboard.aspx");
			routes.MapPageRoute("DailyPuzzles", "Admin/DailyPuzzles", "~/UI/ADMIN/DailyPuzzles.aspx");
			routes.MapPageRoute("AdminBlog", "Admin/AdminBlog", "~/UI/ADMIN/AdminBlog.aspx");
			routes.MapPageRoute("UserStatistics", "Admin/UserStatistics", "~/UI/ADMIN/UserStatistics.aspx");
			routes.MapPageRoute("Report1", "Admin/Report1", "~/UI/ADMIN/Report1.aspx");
			routes.MapPageRoute("Report2", "Admin/Report2", "~/UI/ADMIN/Report2.aspx");
			routes.MapPageRoute("Report3", "Admin/Report3", "~/UI/ADMIN/Report3.aspx");
		}

		protected void Application_Start(object sender, EventArgs e)
		{
			RegisterRoutes(RouteTable.Routes);
		}

		protected void Session_Start(object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}