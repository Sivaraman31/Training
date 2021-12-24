using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContactBookDB
{
    public partial class ContactBook : System.Web.UI.Page
    {
      
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
            {
                connection.Open();
                string sql = "insert into ContactDB  values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                Button1_Click(sender, e);
                command.Dispose();
                connection.Close();
            }
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("select * from ContactDB where PhoneNumber like'" + TextBox5.Text + "%' OR ContactName like'" + TextBox5.Text + "%'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (!object.Equals(ds, null))
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        GridView1.DataSource = ds.Tables[0];
                        GridView1.DataBind();
                    }
                    else
                    {
                        Response.Write("<script>alert('No Record found')</script>");
                    }
                }
                
            }
            TextBox5.Text = string.Empty;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("data source =.; Database =ContactBookDB; Integrated security = SSPI"))
            {
                connection.Open();
                SqlCommand command;
                string sqlQuery = "Select * from ContactDB";
                command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                GridView1.DataSource = dataReader;
                GridView1.DataBind();
                connection.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("data source =.; Database =ContactBookDB; Integrated security = SSPI"))
            {
                connection.Open();
                SqlCommand command;
                command = new SqlCommand("delete from ContactDB where PhoneNumber like'" + TextBox5.Text + "%' OR ContactName like '" + TextBox5.Text + "%'", connection);
                command.ExecuteNonQuery();
                
                Button1_Click(sender, e);
                connection.Close();
            }
            TextBox5.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int PhoneNumber = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string ContactName = (row.FindControl("ContactName") as TextBox).Text;
            string Location = (row.FindControl("Location") as TextBox).Text;
            string Mail = (row.FindControl("EMail") as TextBox).Text;
            string sql = "UPDATE Customers SET ContactName=@Name, Location=@Location, EMail=@mail WHERE PhoneNumber=@PhoneNumber";
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql))
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Name", ContactName);
                    cmd.Parameters.AddWithValue("@Location", Location);
                    cmd.Parameters.AddWithValue("@mail", Mail);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            GridView1.EditIndex = -1;
            this.DataBind();
        }
        protected void RowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            this.DataBind();
        }
    }
}