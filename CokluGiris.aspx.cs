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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Visible = false;
        Button2.Visible = false;
        Button3.Visible = false;
        showButton();

    }
    public void showButton()
    {
        if (Session["yetki1"] != null )
        {
            Button1.Visible = true;
        }
        if (Session["yetki2"] != null)
        {
            Button2.Visible = true;
        }
        if (Session["yetki3"] != null)
        {
            Button3.Visible = true;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Add("kisi", Session["kisi"]);
        Response.Redirect("Default.aspx");

        //if(Session["yetki1"].ToString()== "VELI")
        //{
        //    Session.Add("kisi", Session["kisi"]);
        //    Response.Redirect("Default.aspx");
        //}else if(Session["yetki2"].ToString() == "VELI")
        //{
        //    Session.Add("kisi", Session["kisi"]);
        //    Response.Redirect("Default.aspx");
        //}else if (Session["yetki3"].ToString() == "VELI")
        //{
        //    Session.Add("kisi", Session["kisi"]);
        //    Response.Redirect("Default.aspx");
        //}

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //if (Session["yetki1"].ToString() == "OGRETMEN")
        //{
        //    Session.Add("kisi", Session["kisi"]);
        //    Response.Redirect("CokluGiris.aspx");
        //}
        //else if (Session["yetki2"].ToString() == "OGRETMEN")
        //{
        //    Session.Add("kisi", Session["kisi"]);
        //    Response.Redirect("CokluGiris.aspx");
        //}
        //else if (Session["yetki3"].ToString() == "OGRETMEN")
        //{
        //    Session.Add("kisi", Session["kisi"]);
        //    Response.Redirect("CokluGiris.aspx");
        //}
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //if (Session["yetki1"].ToString() == "YETKILI")
        //{
        //    Session.Add("kisi", Session["kisi"]);
        //    Response.Redirect("CokluGiris.aspx");
        //}
        //else if (Session["yetki2"].ToString() == "YETKILI")
        //{
        //    Session.Add("kisi", Session["kisi"]);
        //    Response.Redirect("CokluGiris.aspx");
        //}
        //else if (Session["yetki3"].ToString() == "YETKILI")
        //{
        //    Session.Add("kisi", Session["kisi"]);
        //    Response.Redirect("CokluGiris.aspx");
        //}
    }
}