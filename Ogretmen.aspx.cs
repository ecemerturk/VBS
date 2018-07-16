using sqlQuery;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;
using System.Collections;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

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
        query += nl + "VALUES ('" + TextID.Text + "','" + TextTC.Text + "','" + TextAd.Text + "','" + TextSoyad.Text + "','" + TextDogum.Text + "','" + TextKan.Text + "')";
        query += nl + "INSERT INTO OGRETMEN (OGRETMEN_ID,OGRETMEN_MAIL,OGRETMEN_TEL,OGRETMEN_BRANS,OGRETMEN_SIFRE)";
        query += nl + "VALUES ('" + TextID.Text + "','" + TextMail.Text + "','" + TextTel.Text + "','" + TextBrans.Text + "','" + TextSifre.Text + "')";

        SqlQuery sqlquery = new SqlQuery();
        DataTable datatable = sqlquery.Query(query);
    }
}