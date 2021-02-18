using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AMS_App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = UserLoginTextbox.Text.ToString();
            string password = UserPasswordTextbox.Text.ToString();

            string firstName = "";

            // Check with the database that password and user exists
            using (SqlConnection connection = new SqlConnection((ConfigurationManager.ConnectionStrings["DB_Connection"].ToString())))
            {
                connection.Open();

                string query = "SELECT People.firstName FROM dbo.People WHERE userLogin = @username AND userPass = @password";

                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Connection = connection;

                firstName = (string) cmd.ExecuteScalar();
      
            }
            
            if(firstName == null)
            {
                ErrorMessage.Text = "Username/Password Incorrect, please try again.";
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
      
        }
    }
}