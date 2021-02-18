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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string building = buildingTextBox.Text.ToString();
            string roomName = roomNameTextBox.Text.ToString();
            string roomNumber = roomNumberTextBox.Text.ToString();
            string floorNumber = floorNumberTextBox.Text.ToString();
            string firstName = firstNameTextBox.Text.ToString();
            string lastName = lastNameTextBox.Text.ToString();

            int roomPK;

            //if (roomName == "Meeting Room")
            //{
            //    roomPK = 1;
            //}
            //else if (roomName == "Office")
            //{
            //    roomPK = 2;
            //}
            //else if (roomName == "President Office")
            //{
            //    roomPK = 3;
            //}
            //else if (roomName == "Vice President Office")
            //{
            //    roomPK = 3;
            //}
            //else if (roomName == "HR Office")
            //{
            //    roomPK = 3;
            //}
            //else if (roomName == "Closet")
            //{
            //    roomPK = 0;
            //}
            //else if (roomName == "Janitor Room")
            //{
            //    roomPK = 0;
            //}
            //else if (roomName == "Break Room")
            //{
            //    roomPK = 0;
            //}
            //else
            //{
            //    Int32.TryParse(floorNumber, out roomPK);
            //}

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Connection"].ToString()))
            {
                connection.Open();

                string query1 = "INSERT INTO dbo.Buildings (buildingName) SELECT (@building) WHERE NOT EXISTS (SELECT @building FROM dbo.Buildings WHERE buildingName = @building)";
                string query2 = "INSERT INTO dbo.Rooms (roomName, roomNumber, roomPK) VALUES (@roomName, @roomNumber)";
                string query3 = "INSERT INTO dbo.Floors (floorNumber) SELECT (@floorNumber) WHERE NOT EXISTS (SELECT @floorNumber FROM dbo.Floors WHERE floorNumber = @floorNumber)";
                string query4 = "INSERT INTO dbo.People (firstName, lastName) VALUES (@firstName, @lastName)";

                SqlCommand cmd1 = new SqlCommand(query1, connection);
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                SqlCommand cmd3 = new SqlCommand(query3, connection);
                SqlCommand cmd4 = new SqlCommand(query4, connection);

                cmd1.CommandType = System.Data.CommandType.Text;
                cmd2.CommandType = System.Data.CommandType.Text;
                cmd3.CommandType = System.Data.CommandType.Text;
                cmd4.CommandType = System.Data.CommandType.Text;

                cmd1.Parameters.AddWithValue("building", building);
                cmd2.Parameters.AddWithValue("roomName", roomName);
                cmd2.Parameters.AddWithValue("roomNumber", roomNumber);
                cmd3.Parameters.AddWithValue("floorNumber", floorNumber);
                cmd4.Parameters.AddWithValue("firstName", firstName);
                cmd4.Parameters.AddWithValue("lastName", lastName);
                //cmd4.Parameters.Add("roomPK", SqlDbType.Int).Value = roomPK;

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();

                connection.Close();
            }

            buildingTextBox.Text = "";
            roomNameTextBox.Text = "";
            roomNumberTextBox.Text = "";
            floorNumberTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }

    }
}