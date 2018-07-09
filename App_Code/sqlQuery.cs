using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
/// <summary>
/// Summary description for sqlQuery
/// </summary>

    namespace sqlQuery
{
    public class SqlQuery
    {
        public DataTable Query(string query)
        {
            SqlConnection connect;
            connect = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            connect.Open();
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;
        }
    }
}
