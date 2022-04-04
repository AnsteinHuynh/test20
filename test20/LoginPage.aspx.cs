using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorMessage.Visible = false;
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
        }
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
        }
        protected void Login_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=cosc3380-zoo.database.windows.net;Initial Catalog=ZooDatabaseDump;Persist Security Info=True;User ID=dhphan3;Password=***********");
            using (SqlConnection con = new SqlConnection(@"Data Source=cosc3380-zoo.database.windows.net;Initial Catalog=ZooDatabaseDump;Persist Security Info=True;User ID=dhphan3; Password=K7EY2kh@ri*oJH9"))
            {
                con.Open();
                string query = "SELECT COUNT(1) FROM UserLogin WHERE username=@username AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, con);
                sqlCmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtUserPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = txtUserName.Text.Trim();
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    ErrorMessage.Visible = true;
                }
                con.Close();
            }

            //SqlConnection con = new SqlConnection("Data Source=cosc3380-zoo.database.windows.net;Initial Catalog=ZooDatabaseDump;Persist Security Info=True;User ID=dhphan3;Password=***********");
            //SqlCommand comm = new SqlCommand("Inser into StudentInfo tab values")
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}