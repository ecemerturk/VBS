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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = "";
        string nl = System.Environment.NewLine;
        query += nl + "SELECT K.KISI_ID, K.KISI_TC, K.KISI_AD, K.KISI_SOYAD, K.KISI_DOGUM, K.KISI_KGRUBU, Y.YETKILI_MAIL, Y.YETKILI_TELEFON, Y.YETKILI_BRANS";
        query += nl + "FROM KISI K, YETKILI Y";
        query += nl + "WHERE K.KISI_ID='"+Session["secilen"]+"' AND K.KISI_ID = Y.YETKILI_ID";
       
        SqlQuery sqlquery = new SqlQuery();
        DataTable datatable = sqlquery.Query(query);
        TextBox1.Text = datatable.Rows[0][0].ToString();
        TextBox2.Text = datatable.Rows[0][1].ToString();
        TextBox3.Text = datatable.Rows[0][2].ToString();
        TextBox4.Text = datatable.Rows[0][3].ToString();
        TextBox5.Text = datatable.Rows[0][4].ToString();
        TextBox6.Text = datatable.Rows[0][5].ToString();
        TextBox7.Text = datatable.Rows[0][6].ToString();
        TextBox8.Text = datatable.Rows[0][7].ToString();
        TextBox9.Text = datatable.Rows[0][8].ToString();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string query1 = "";
        string nl = System.Environment.NewLine;
        query1 += nl + "";
        query1 += nl + "";
        query1 += nl + "";
        query1 += nl + "";
        query1 += nl + "";
        query1 += nl + "";
        query1 += nl + "";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}