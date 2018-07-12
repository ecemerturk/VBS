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
        if (DropDownList1.SelectedValue.ToString()== "İsim")
        {
            query1 += nl + "SELECT K.KISI_AD, K.KISI_SOYAD, K.KISI_ID, K.KISI_TC FROM YETKILI Y, KISI K";
            query1 += nl + "WHERE K.KISI_AD LIKE '"+TextBox11.Text+"' AND K.KISI_ID=Y.YETKILI_ID";
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query1);

            GridView1.DataSource = datatable;
            GridView1.DataBind();

            //for (int i = 0; i < datatable.Rows.Count; i++)
            //{
            //    TableRow satir = new TableRow();

            //    for (int j = 0; j < datatable.Columns.Count; j++)
            //    {
            //        TableCell sutun = new TableCell();
            //        sutun.Text = datatable.Rows[i][j].ToString();
            //        sutun.BorderStyle = BorderStyle.Inset;
            //        satir.Cells.Add(sutun);
            //    }
            //    Table1.Rows.Add(satir);
            //}
            
        }
        else if(DropDownList1.SelectedValue.ToString() == "Tc Kimlik Numarası")
        {

            query2 += nl + "";
            query2 += nl + "SELECT K.KISI_AD, K.KISI_SOYAD, K.KISI_ID, K.KISI_TC FROM YETKILI Y, KISI K";
            query2 += nl + "WHERE K.KISI_TC LIKE '" + TextBox11.Text + "' AND K.KISI_ID=Y.YETKILI_ID";
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query2);

            GridView1.DataSource = datatable;
            GridView1.DataBind();

            //for (int i = 0; i < datatable.Rows.Count; i++)
            //{
            //    TableRow satir = new TableRow();

            //    for (int j = 0; j < datatable.Columns.Count; j++)
            //    {
            //        TableCell sutun = new TableCell();
            //        sutun.Text = datatable.Rows[i][j].ToString();
            //        sutun.BorderStyle = BorderStyle.Inset;
            //        satir.Cells.Add(sutun);
            //    }
            //    Table1.Rows.Add(satir);
            //}
        }
        else if (DropDownList1.SelectedValue.ToString() == "Sistem Numarası")
        {
            query3 += nl + "";
            query3 += nl + "SELECT K.KISI_AD, K.KISI_SOYAD, K.KISI_ID, K.KISI_TC FROM YETKILI Y, KISI K";
            query3 += nl + "WHERE K.KISI_ID LIKE '" + TextBox11.Text + "' AND K.KISI_ID=Y.YETKILI_ID";
            SqlQuery sqlquery = new SqlQuery();
            DataTable datatable = sqlquery.Query(query3);

            GridView1.DataSource = datatable;
            GridView1.DataBind();

            //for (int i = 0; i < datatable.Rows.Count; i++)
            //{
            //    TableRow satir = new TableRow();

            //    for (int j = 0; j < datatable.Columns.Count; j++)
            //    {
            //        TableCell sutun = new TableCell();
            //        sutun.Text = datatable.Rows[i][j].ToString();
            //        sutun.BorderStyle = BorderStyle.Inset;
            //        satir.Cells.Add(sutun);
            //    }
            //    Table1.Rows.Add(satir);
            //}
        }
    }
}