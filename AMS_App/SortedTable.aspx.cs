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
    public partial class SortedTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadFacilityLayout();
        }

        private void LoadFacilityLayout()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection((ConfigurationManager.ConnectionStrings["DB_Connection"].ToString())))
            {

                string query = "Select Buildings.buildingName as 'Building Name', Floors.floorNumber as 'Floor Number', Rooms.roomNumber as 'Room Number', Rooms.roomName as 'Room Name' FROM Buildings LEFT JOIN Floors ON Buildings.BuildingsPK = Floors.FloorsPK LEFT JOIN Rooms ON Floors.floorNumber = Rooms.roomPK";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            DataView dv = new DataView(dt);
            rptDataTable.DataSource = dv;
            rptDataTable.DataBind();
        }
                
    }
}