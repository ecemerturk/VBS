using sqlQuery;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Kaydet_Click(object sender, EventArgs e)
    {
        string query = "";
        string n1 = System.Environment.NewLine;

        SqlQuery sqlquery = new SqlQuery();
        DataTable datatable = sqlquery.Query(query);
    }
}