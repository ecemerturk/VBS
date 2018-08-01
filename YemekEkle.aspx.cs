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
        string nl = System.Environment.NewLine;
        query += nl + "INSERT INTO KISI (YEMEKHANE_ANA,YEMEKHANE_YAN,YEMEKHANE_SALATA,YEMEKHANE_TATLI)";
        query += nl + "VALUES ('" + txtYemek.Text + "','" + txtYanYemek.Text + "','" + txtSalata.Text + "','" + txtTatli.Text + "')";

        SqlQuery sqlquery = new SqlQuery();
        DataTable datatable = sqlquery.Query(query);
    }
}