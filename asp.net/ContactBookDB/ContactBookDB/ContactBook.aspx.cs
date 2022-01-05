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
        int SrNo;
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
            {
                connection.Open();
                string sql = "insert into ContactBDB  values('"+SrNo+"','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
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

        protected void SearchContact_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
            {
                connection.Open();
                        SqlCommand cmd = new SqlCommand($"select * from ContactBDB where PhoneNumber = {TextBox5.Text}", connection);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "ContactDB");
                        if (!object.Equals(ds, null))
                        {
                            SqlDataReader dataReader = cmd.ExecuteReader();
                            while (dataReader.Read())
                            {
                                TextBox1.Text = dataReader[1].ToString();
                                TextBox2.Text = dataReader[2].ToString();
                                TextBox3.Text = dataReader[3].ToString();
                                TextBox4.Text = dataReader[4].ToString();
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
                string sqlQuery = "Select * from ContactBDB";
                command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                ContactGridView.DataSource = dataReader;
                ContactGridView.DataBind();
                connection.Close();
            }
        }

        protected void DeleteContact_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("data source =.; Database =ContactBookDB; Integrated security = SSPI"))
            {
                connection.Open();
                SqlCommand command;
                command = new SqlCommand($"delete from ContactBDB where PhoneNumber = {TextBox5.Text}", connection);
                command.ExecuteNonQuery();                
                Button1_Click(sender, e);
                connection.Close();
            }
            TextBox5.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        private void BindGrid()
        {
            string constr = "data source =.; Database = ContactBookDB; Integrated security = SSPI";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ContactName, PhoneNumber,Location, EMail, SrNo FROM ContactBDB", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ContactGridView.DataSource = dt;
                        ContactGridView.DataBind();
                    }
                }
            }
        }
        protected void gvContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = ContactGridView.SelectedRow;
            ViewState["SrNo"] = row.Cells[1].Text;
            TextBox1.Text = row.Cells[2].Text;
            TextBox2.Text = row.Cells[3].Text;
            TextBox3.Text = row.Cells[4].Text;
            TextBox4.Text = row.Cells[5].Text;
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            string constr = "data source =.; Database = ContactBookDB; Integrated security = SSPI";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                
                string sql = $"UPDATE ContactBDB SET PhoneNumber = {TextBox2.Text}, ContactName = {TextBox1.Text}, Location = {TextBox3.Text}, EMail = {TextBox4.Text} WHERE SrNo = {ViewState["SrNo"]}";

                Response.Write("");
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    BindGrid();
                }
                catch(Exception err)
                {
                    Response.Write(err.Message);
                    Response.Write(ViewState["SrNo"]);
                }
                finally
                {
                    con.Close();
                }        
            }
        }
    }
}