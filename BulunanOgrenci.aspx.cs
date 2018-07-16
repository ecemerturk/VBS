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
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using sqlQuery;
public partial class BulunanOgrenci : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        { }
        else
        { formu_doldur(); }
    }
    void formu_doldur()
    {
        string query = "";
        string nl = System.Environment.NewLine;
        query += nl + "SELECT K.KISI_ID, K.KISI_TC, K.KISI_AD, K.KISI_SOYAD, K.KISI_DOGUM, K.KISI_KGRUBU, O.OGRENCI_SINIF, O.OGRENCI_HASTALIK, O.OGRENCI_ALERJI, O.OGRENCI_CINSIYET";
        query += nl + "FROM KISI K, OGRENCI O";
        query += nl + "WHERE K.KISI_ID='" + Session["secilen"] + "' AND K.KISI_ID = O.OGRENCI_ID";

        SqlQuery sqlquery = new SqlQuery();
        DataTable datatable = sqlquery.Query(query);
        TextID.Text = datatable.Rows[0][0].ToString();
        TextTC.Text = datatable.Rows[0][1].ToString();
        TextAd.Text = datatable.Rows[0][2].ToString();
        TextSoyad.Text = datatable.Rows[0][3].ToString();
        TextDogum.Text = datatable.Rows[0][4].ToString();
        TextKan.Text = datatable.Rows[0][5].ToString();
        TextSınıf.Text = datatable.Rows[0][6].ToString();
        TextHastalık.Text = datatable.Rows[0][7].ToString();
        TextAlerji.Text = datatable.Rows[0][8].ToString();
        TextCinsiyet.Text = datatable.Rows[0][9].ToString();
        TextID.ReadOnly = true;
        TextTC.ReadOnly = true;
    }
    protected void ButtonDuzenle_Click(object sender, EventArgs e)
    {
        string query1 = "";
        string nl = System.Environment.NewLine;
        query1 += nl + "UPDATE KISI";
        query1 += nl + "SET KISI_AD='" + TextAd.Text + "', KISI_SOYAD='" + TextSoyad.Text + "', KISI_DOGUM='" + TextDogum.Text + "', KISI_KGRUBU='" + TextKan.Text + "'";
        query1 += nl + "WHERE KISI_ID='" + Session["secilen"] + "'";
        query1 += nl + "UPDATE OGRENCI";
        query1 += nl + "SET OGRENCI_SINIF='" + TextSınıf.Text + "', OGRENCI_HASTALIK ='" + TextHastalık.Text + "', OGRENCI_ALERJI='" + TextAlerji.Text + "', OGRENCI_CINSIYET='" + TextCinsiyet.Text + "' ";
        query1 += nl + "WHERE OGRENCI_ID='" + Session["secilen"] + "'";

        SqlQuery sqlquery1 = new SqlQuery();
        DataTable datatable1 = sqlquery1.Query(query1);


    }

    protected void ButtonSil_Click(object sender, EventArgs e)
    {
        string query2 = "";
        string nl = System.Environment.NewLine;
        query2 += nl + "UPDATE OKUL_KISI";
        query2 += nl + "SET OKUL_ID=0";
        query2 += nl + "WHERE KISI_ID = " + Session["secilen"] + "";
        SqlQuery sqlquery2 = new SqlQuery();
        DataTable datatable2 = sqlquery2.Query(query2);
        Response.Redirect("BulunanOgrenci.aspx");
    }
}