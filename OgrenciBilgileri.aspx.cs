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

public partial class MasterPage : System.Web.UI.Page
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
        query += nl + "INSERT INTO OGRENCI (OGRENCI_ID,OGRENCI_SINIF,OGRENCI_HASTALIK,OGRENCI_ALERJI,OGRENCI_CINSIYET)";
        query += nl + "VALUES ('" + TextID.Text + "','" + TextSınıf.Text + "','" + TextHastalık.Text + "','" + TextAlerji.Text + "','" + TextCinsiyet.Text + "')";

        SqlQuery sqlquery = new SqlQuery();
        DataTable datatable = sqlquery.Query(query);
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string secilen = DropDownList1.SelectedValue;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string query1 = "";
        string query2 = "";
        string query3 = "";
        string nl = System.Environment.NewLine;
        if (DropDownList1.SelectedValue.ToString() == "İsim")
        {
            query1 += nl + "SELECT K.KISI_AD, K.KISI_SOYAD, K.KISI_ID, K.KISI_TC FROM OGRENCI O, KISI K";
            query1 += nl + "WHERE K.KISI_AD LIKE '" + TextAra.Text + "' AND K.KISI_ID=O.OGRENCI_ID";
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query1);
            GridView1.DataSource = datatable;
            GridView1.DataBind();

        }
        else if (DropDownList1.SelectedValue.ToString() == "Tc Kimlik Numarası")
        {

            query2 += nl + "";
            query2 += nl + "SELECT K.KISI_AD, K.KISI_SOYAD, K.KISI_ID, K.KISI_TC FROM OGRENCI O, KISI K";
            query2 += nl + "WHERE K.KISI_TC LIKE '" + TextAra.Text + "' AND K.KISI_ID=O.OGRENCI_ID";
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query2);

            GridView1.DataSource = datatable;
            GridView1.DataBind();

        }
        else if (DropDownList1.SelectedValue.ToString() == "Sistem Numarası")
        {
            query3 += nl + "";
            query3 += nl + "SELECT K.KISI_AD, K.KISI_SOYAD, K.KISI_ID, K.KISI_TC FROM OGRENCI O, KISI K";
            query3 += nl + "WHERE K.KISI_ID LIKE '" + TextAra.Text + "' AND K.KISI_ID=O.OGRENCI_ID";
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query3);

            GridView1.DataSource = datatable;
            GridView1.DataBind();

        }
        else if (DropDownList1.SelectedValue.ToString() == "Sınıf")
        {
            query3 += nl + "";
            query3 += nl + "SELECT K.KISI_AD, K.KISI_SOYAD, K.KISI_ID, K.KISI_TC FROM OGRENCI O, KISI K";
            query3 += nl + "WHERE O.OGRENCI_SINIF LIKE '" + TextAra.Text + "' AND K.KISI_ID=O.OGRENCI_ID";
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query3);

            GridView1.DataSource = datatable;
            GridView1.DataBind();

        }


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Button gelen = (Button)sender;
        string gelenbuton = gelen.CommandName;
        string gelendeger = gelen.CommandArgument;
        Session.Add("secilen", gelendeger);
        GridView1.DataBind();
        Response.Redirect("BulunanOgrenci.aspx");
    }
}