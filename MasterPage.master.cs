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

public partial class MasterPage : System.Web.UI.MasterPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
        Panel11.Visible = false;
        Panel12.Visible = false;

        string query1 = "";
        string query2 = "";
        string query3 = "";
        string nl = System.Environment.NewLine;
        query1 += nl + "SELECT P.PANELICERIK_ID ";
        query1 += nl + "FROM VELI V, KISI K, KISI_YETKILER KY, YETKILER Y, YETKILER_PANELICERIK YP, PANEL_ICERIK P";
        query1 += nl + "WHERE V.VELI_SIFRE ='" + Session["kisi"] + "' AND V.VELI_ID=K.KISI_ID AND K.KISI_ID= KY.KISI_ID AND KY.YETKI_ID= Y.YETKI_ID AND";
        query1 += nl + "Y.YETKI_ID= YP.YETKI_ID AND YP.PANELICERIK_ID = P.PANELICERIK_ID";
        
        query2 += nl + "SELECT P.PANELICERIK_ID ";
        query2 += nl + "FROM OGRETMEN O, KISI K, KISI_YETKILER KY, YETKILER Y, YETKILER_PANELICERIK YP, PANEL_ICERIK P";
        query2 += nl + "O.OGRETMEN_SIFRE ='" + Session["kisi"] + "' AND O.OGRETMEN_ID=K.KISI_ID AND K.KISI_ID= KY.KISI_ID AND KY.YETKI_ID= Y.YETKI_ID AND";
        query2 += nl + "Y.YETKI_ID= YP.YETKI_ID AND YP.PANELICERIK_ID = P.PANELICERIK_ID";
       
        query3 += nl + "SELECT P.PANELICERIK_ID";
        query3 += nl + "FROM YETKILI YY, KISI K, KISI_YETKILER KY, YETKILER Y, YETKILER_PANELICERIK YP,PANEL_ICERIK P ";
        query3 += nl + "WHERE YY.YETKILI_SIFRE ='" + Session["kisi"] + "' AND YY.YETKILI_ID=K.KISI_ID AND K.KISI_ID= KY.KISI_ID AND KY.YETKI_ID= Y.YETKI_ID AND";
        query3 += nl + "Y.YETKI_ID= YP.YETKI_ID AND YP.PANELICERIK_ID = P.PANELICERIK_ID";

        if(Session["bilgi"].ToString()=="YETKILI")
        {
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query3);
            DBMenuYetki(datatable);
        }
        if(Session["bilgi"].ToString() =="VELI")
        {
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query1);
            DBMenuYetki(datatable);

        }
        if(Session["bilgi"].ToString() == "OGRETMEN")
        {
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query2);
            DBMenuYetki(datatable);
        }
        

    }
    public void DBMenuYetki(DataTable datatable)
    {

        for (int b = 0; b < datatable.Rows.Count; b++)
        {
            if (datatable.Rows[b][0].ToString() == "1")
            {
                Panel1.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "2")
            {
                Panel2.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "3")
            {
                Panel3.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "4")
            {
                Panel4.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "5")
            {
                Panel5.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "6")
            {
                Panel6.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "7")
            {
                Panel7.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "8")
            {
                Panel8.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "9")
            {
                Panel9.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "10")
            {
                Panel10.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "11")
            {
                Panel11.Visible = true;
            }
            else if (datatable.Rows[b][0].ToString() == "12")
            {
                Panel12.Visible = true;
            }
        }

    }
}
