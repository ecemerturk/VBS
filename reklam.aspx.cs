﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reklam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string n = Request.QueryString["n"];
        Response.Write(n);
    }
}