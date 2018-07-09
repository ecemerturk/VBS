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
        if(Session["yetki1"]!=null)
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
}