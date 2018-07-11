using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using System.Configuration;
using System.Collections;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using sqlQuery;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string query = "";
        string nl = System.Environment.NewLine;
        query += nl + "INSERT INTO KISI (KISI_ID,KISI_TC,KISI_AD,KISI_SOYAD,KISI_DOGUM,KISI_KGRUBU)";
        query += nl + "VALUES ('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"')";
        query += nl + "INSERT INTO YETKILI (YETKILI_ID,YETKILI_MAIL,YETKILI_TELEFON,YETKILI_BRANS,YETKILI_SIFRE)";
        query += nl + "VALUES ('"+TextBox1.Text+"','"+TextBox7.Text+"','"+TextBox8.Text+"','"+TextBox9.Text+"','"+TextBox10.Text+"')";

        SqlQuery sqlquery = new SqlQuery();
        DataTable datatable = sqlquery.Query(query);
    }
}