using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using sqlQuery;


public partial class LoginForDB : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Contents.Remove("kisi");
        Label4.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //hatalıMsj();
        //query = "SELECT 'VELI' AS TABLOADI, VELI_ID AS ID FROM VELI WHERE (VELI_MAIL = '"+ TextBox2.Text+"' ) AND ( VELI_SIFRE = '"+TextBox1.Text+"') UNION ALL SELECT 'YETKILI' AS TABLOADI, YETKILI_ID AS ID FROM YETKILI WHERE(YETKILI_MAIL = '"+TextBox2.Text+"') AND (YETKILI_SIFRE = '"+TextBox1.Text+"') UNION ALL SELECT 'OGRETMEN' AS TABLOADI, OGRETMEN_ID AS ID FROM OGRETMEN WHERE(OGRETMEN_MAIL = '"+ TextBox2.Text+"') AND (OGRETMEN_SIFRE = '"+ TextBox1.Text+"')";

        string query = "";
        string nl = System.Environment.NewLine;

        query += nl + " SELECT 'VELI' AS TABLOADI, VELI_ID AS ID FROM VELI  ";
        query += nl + " WHERE (VELI_MAIL = '" + TextBox2.Text + "' ) AND  ";
        query += nl + " ( VELI_SIFRE = '" + TextBox1.Text + "')  ";
        query += nl + " UNION ALL ";
        query += nl + " SELECT 'YETKILI' AS TABLOADI, YETKILI_ID AS ID FROM YETKILI  ";
        query += nl + " WHERE(YETKILI_MAIL = '" + TextBox2.Text + "') AND   ";
        query += nl + " (YETKILI_SIFRE = '" + TextBox1.Text + "') ";
        query += nl + " UNION ALL ";
        query += nl + " SELECT 'OGRETMEN' AS TABLOADI, OGRETMEN_ID AS ID FROM OGRETMEN ";
        query += nl + " WHERE(OGRETMEN_MAIL = '" + TextBox2.Text + "') AND ";
        query += nl + " (OGRETMEN_SIFRE = '" + TextBox1.Text + "') ";


        SqlQuery sqlquery = new SqlQuery();
        DataTable datatable = sqlquery.Query(query);

        controlLogin(datatable);
    }
    public void controlLogin(DataTable datatable)
    {
        
        if (datatable.Rows.Count > 0)
        {
            string yetkili = datatable.Rows[0][0].ToString();

            //if (datatable.Rows.Count>1)
            //{
            //    Response.Write(" " + datatable.Rows[0][0].ToString() + "  "+ datatable.Rows[1][0].ToString());
            //    Session
            //}
            if (yetkili == "YETKILI" || yetkili == "VELI" || yetkili == "OGRETMEN")
            {
                Session.Add("kisi", TextBox1.Text);
                if (datatable.Rows.Count > 1)
                {
                    string yetkili2 = datatable.Rows[1][0].ToString();
                    Session.Add("kisi2", TextBox1.Text);
                }
                Response.Redirect("Default.aspx");
            }
        }
        else
        {
            Label4.Visible = true;
            Label4.BackColor = System.Drawing.Color.Red;
            Label4.Text = "Yanlış email veya şifre girdiniz";
            Response.AppendHeader("Refresh", "2;url=LoginForDb.aspx");
        }
    }
    //public void hatalıMsj()
    //{
    //    Boolean sonuc;
    //    sonuc = controlmetin();
    //    if (sonuc == true)
    //    {
    //        string query;
    //        query = "SELECT VELI_ID FROM VELI WHERE (VELI_MAIL = '" + TextBox2.Text + "' ) AND ( VELI_SIFRE = '" + TextBox1.Text + "') UNION ALL SELECT YETKILI_ID FROM YETKILI WHERE(YETKILI_MAIL = '" + TextBox2.Text + " ') AND (YETKILI_SIFRE = '" + TextBox1.Text + "')UNION ALL SELECT OGRETMEN_ID FROM OGRETMEN WHERE(OGRETMEN_MAIL = '" + TextBox2.Text + "') AND(OGRETMEN_SIFRE = '" + TextBox1.Text + "')";
    //        controlLogin(query);
    //    }
    //    else
    //    {
    //        Label4.Visible = true;
    //        Label4.BackColor = System.Drawing.Color.Red;
    //        Label4.Text = "yanlış yapıyorsun :)";
    //        Response.AppendHeader("Refresh", "2;url=LoginForDb.aspx");
    //    }
    //}

    //public bool controlmetin()
    //{
    //    string karakterEmail, karakterSifre;
    //    karakterEmail = TextBox2.Text;
    //    karakterSifre = TextBox1.Text;
    //    if (karakterEmail.IndexOf("'") == -1)
    //    {
    //        return false;
    //    }
    //    else if (karakterSifre.IndexOf("'") == -1)
    //    {
    //        return false;
    //    }else
    //    {
    //        return true;
    //    }
    //}


}