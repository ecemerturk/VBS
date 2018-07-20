using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable datam = new DataTable();
        DataColumn soruid = new DataColumn();
        soruid.ColumnName = "soruid";
        soruid.DataType = System.Type.GetType("System.Int32");
        datam.Columns.Add(soruid);

        DataColumn cevapid = new DataColumn();
        cevapid.ColumnName = "cevapid";
        cevapid.DataType = System.Type.GetType("System.Int32");
        datam.Columns.Add(cevapid);

        DataColumn soruvalue = new DataColumn();
        soruvalue.ColumnName = "soruvalue";
        soruvalue.DataType = System.Type.GetType("System.String");
        datam.Columns.Add(soruvalue);

        DataColumn cevapvalue = new DataColumn();
        cevapvalue.ColumnName = "cevapvalue";
        cevapvalue.DataType = System.Type.GetType("System.String");
        datam.Columns.Add(cevapvalue);

        DataRow satir1 = datam.NewRow();
        satir1["soruid"] = "1";
        satir1["cevapid"] = "1";
        satir1["soruvalue"] = "soru icerik1";
        satir1["cevapvalue"] = "cevap1 ";
        datam.Rows.Add(satir1);

        DataRow satir2 = datam.NewRow();
        satir2["soruid"] = "1";
        satir2["cevapid"] = "2";
        satir2["soruvalue"] = "soru icerik1";
        satir2["cevapvalue"] = "cevap 2";
        datam.Rows.Add(satir2);

        DataRow satir3 = datam.NewRow();
        satir3["soruid"] = "1";
        satir3["cevapid"] = "3";
        satir3["soruvalue"] = "soru icerik1";
        satir3["cevapvalue"] = "cevap 3";
        datam.Rows.Add(satir3);

        DataRow satir4 = datam.NewRow();
        satir4["soruid"] = "1";
        satir4["cevapid"] = "4";
        satir4["soruvalue"] = "soru icerik1";
        satir4["cevapvalue"] = "cevap 4";
        datam.Rows.Add(satir4);

        DataRow satir5 = datam.NewRow();
        satir5["soruid"] = "2";
        satir5["cevapid"] = "5";
        satir5["soruvalue"] = "soru icerik2";
        satir5["cevapvalue"] = "cevap1 ";
        datam.Rows.Add(satir5);

        DataRow satir6 = datam.NewRow();
        satir6["soruid"] = "2";
        satir6["cevapid"] = "6";
        satir6["soruvalue"] = "soru icerik2";
        satir6["cevapvalue"] = "cevap2 ";
        datam.Rows.Add(satir6);

        DataRow satir7 = datam.NewRow();
        satir7["soruid"] = "2";
        satir7["cevapid"] = "7";
        satir7["soruvalue"] = "soru icerik2";
        satir7["cevapvalue"] = "cevap 3";
        datam.Rows.Add(satir7);

        DataTableIleFormuDoldur(datam);
    }

    private void DataTableIleFormuDoldur(DataTable datam)
    {
        string AktifSoruId = "";


        HtmlGenericControl FormTable = new HtmlGenericControl("table");


        foreach (DataRow satir in datam.Rows)
        {

            if (AktifSoruId != satir["soruid"].ToString())
            {
                HtmlGenericControl trSoruCevapGrubu = new HtmlGenericControl("tr");
                FormTable.Controls.Add(trSoruCevapGrubu);
                HtmlGenericControl tdSoruCevapGrubu = new HtmlGenericControl("td");
                trSoruCevapGrubu.Controls.Add(tdSoruCevapGrubu);
                HtmlGenericControl radioLabel = new HtmlGenericControl("input");
                HtmlGenericControl bosluk = new HtmlGenericControl("br");
                radioLabel.Attributes.Add("type", "radio");
                tdSoruCevapGrubu.InnerText += satir["soruvalue"].ToString();
                tdSoruCevapGrubu.Controls.Add(bosluk);
                tdSoruCevapGrubu.Controls.Add(radioLabel);
                radioLabel.InnerText += satir["cevapvalue"].ToString();
                AktifSoruId = satir["soruid"].ToString();
            }
            else
            {
                HtmlGenericControl trSoruCevapGrubu = new HtmlGenericControl("tr");
                FormTable.Controls.Add(trSoruCevapGrubu);
                HtmlGenericControl tdSoruCevapGrubu = new HtmlGenericControl("td");
                trSoruCevapGrubu.Controls.Add(tdSoruCevapGrubu);
                HtmlGenericControl radioLabel = new HtmlGenericControl("input");
                radioLabel.Attributes.Add("type", "radio");
                tdSoruCevapGrubu.Controls.Add(radioLabel);
                radioLabel.InnerText += satir["cevapvalue"].ToString();
            }

        }
        SoruCevapFormu.Controls.Add(FormTable);
    }
}