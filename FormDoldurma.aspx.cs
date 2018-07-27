using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using System.Configuration;
using System.Collections;
using System.Web.UI.WebControls.WebParts;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using sqlQuery;



public partial class FormDoldurma : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = "";
        string nl = System.Environment.NewLine;
        query += nl + "SELECT T.TSORU_ID, T.TSORU, T.TCEVAP_TIPI, C.CEVAP";
        query += nl + "FROM TAKIP_SORULARI T , CEVAP_SECENEK C";
        query += nl + "WHERE T.TSORU_ID=C.SORU_ID";
        SqlQuery sqlquery = new SqlQuery();
        DataTable datatable = sqlquery.Query(query);
        FormuDoldur(datatable);
    }
    private void FormuDoldur(DataTable datatable)
    {
        string AktifSoruId = "";


        HtmlGenericControl FormTable = new HtmlGenericControl("div");
        FormTable.Attributes.Add("class", "container offset-sm-3");
        string count = "";

        foreach (DataRow satir in datatable.Rows)
        {

            if (AktifSoruId != satir["TSORU_ID"].ToString())
            {
                HtmlGenericControl SoruCevapGrubu = new HtmlGenericControl("div");
                SoruCevapGrubu.Attributes.Add("class", "row");
                FormTable.Controls.Add(SoruCevapGrubu);
                HtmlGenericControl SoruCevapİçerikGrubu = new HtmlGenericControl("div");
                SoruCevapİçerikGrubu.Attributes.Add("class", "col-sm-3");
                SoruCevapGrubu.Controls.Add(SoruCevapİçerikGrubu);

                HtmlGenericControl radioGrup = new HtmlGenericControl("div");
                HtmlGenericControl radioLabel = new HtmlGenericControl("input");
                radioLabel.Attributes.Add("type", "radio");
                radioLabel.Attributes.Add("name", "radioGrup");
                HtmlGenericControl checkboxLabel = new HtmlGenericControl("input");
                checkboxLabel.Attributes.Add("type", "checkbox");
                HtmlGenericControl acikucluCevap = new HtmlGenericControl("textarea");
                //acikucluCevap.Attributes.Add("type", "text");
                HtmlGenericControl bosluk = new HtmlGenericControl("br");

                if (satir["TCEVAP_TIPI"].ToString() == "radio")
                {
                    if (count != satir["TSORU_ID"].ToString())
                    {
                        SoruCevapİçerikGrubu.InnerText += satir["TSORU"].ToString();
                    }
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                    SoruCevapİçerikGrubu.Controls.Add(radioGrup);
                    SoruCevapİçerikGrubu.Controls.Add(radioLabel);
                    radioLabel.InnerText += satir["CEVAP"].ToString();
                    count = satir["TSORU_ID"].ToString();
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                }
                else if (satir["TCEVAP_TIPI"].ToString() == "check")
                {
                    if (count != satir["TSORU_ID"].ToString())
                    {
                        SoruCevapİçerikGrubu.InnerText += satir["TSORU"].ToString();
                    }
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                    SoruCevapİçerikGrubu.Controls.Add(checkboxLabel);
                    checkboxLabel.InnerText += satir["CEVAP"].ToString();
                    count = satir["TSORU_ID"].ToString();
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                }
                else if (satir["TCEVAP_TIPI"].ToString() == "textbox")
                {
                    if (count != satir["TSORU_ID"].ToString())
                    {
                        SoruCevapİçerikGrubu.InnerText += satir["TSORU"].ToString();
                    }
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                    SoruCevapİçerikGrubu.Controls.Add(acikucluCevap);
                    count = satir["TSORU_ID"].ToString();
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                }
            }
            
        }
        SoruCevapFormu.Controls.Add(FormTable);
    }
}