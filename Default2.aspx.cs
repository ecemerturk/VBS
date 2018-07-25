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

        DataColumn cevapTip = new DataColumn();
        cevapTip.ColumnName = "cevapTip";
        cevapTip.DataType = System.Type.GetType("System.String");
        datam.Columns.Add(cevapTip);

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
        satir1["cevapTip"] = "radio";
        satir1["soruvalue"] = "soru icerik1";
        satir1["cevapvalue"] = "cevap1 ";
        datam.Rows.Add(satir1);

        DataRow satir2 = datam.NewRow();
        satir2["soruid"] = "1";
        satir2["cevapid"] = "2";
        satir2["cevapTip"] = "radio";
        satir2["soruvalue"] = "soru icerik1";
        satir2["cevapvalue"] = "cevap 2";
        datam.Rows.Add(satir2);

        DataRow satir3 = datam.NewRow();
        satir3["soruid"] = "1";
        satir3["cevapid"] = "3";
        satir3["cevapTip"] = "radio";
        satir3["soruvalue"] = "soru icerik1";
        satir3["cevapvalue"] = "cevap 3";
        datam.Rows.Add(satir3);

        DataRow satir4 = datam.NewRow();
        satir4["soruid"] = "1";
        satir4["cevapid"] = "4";
        satir4["cevapTip"] = "radio";
        satir4["soruvalue"] = "soru icerik1";
        satir4["cevapvalue"] = "cevap 4";
        datam.Rows.Add(satir4);

        DataRow satir5 = datam.NewRow();
        satir5["soruid"] = "2";
        satir5["cevapid"] = "5";
        satir5["cevapTip"] = "check";
        satir5["soruvalue"] = "soru icerik2";
        satir5["cevapvalue"] = "cevap1 ";
        datam.Rows.Add(satir5);

        DataRow satir6 = datam.NewRow();
        satir6["soruid"] = "2";
        satir6["cevapid"] = "6";
        satir6["cevapTip"] = "check";
        satir6["soruvalue"] = "soru icerik2";
        satir6["cevapvalue"] = "cevap2 ";
        datam.Rows.Add(satir6);

        DataRow satir7 = datam.NewRow();
        satir7["soruid"] = "2";
        satir7["cevapid"] = "7";
        satir7["cevapTip"] = "check";
        satir7["soruvalue"] = "soru icerik2";
        satir7["cevapvalue"] = "cevap 3";
        datam.Rows.Add(satir7);

        DataRow satir8 = datam.NewRow();
        satir8["soruid"] = "3";
        satir8["cevapid"] = "8";
        satir8["cevapTip"] = "textbox";
        satir8["soruvalue"] = "soru icerik3";
        datam.Rows.Add(satir8);

        DataTableIleFormuDoldur(datam);
    }

    private void DataTableIleFormuDoldur(DataTable datam)
    {
        string AktifSoruId = "";


        HtmlGenericControl FormTable = new HtmlGenericControl("div");
        FormTable.Attributes.Add("class", "container offset-sm-3");
        string count = "";

        foreach (DataRow satir in datam.Rows)
        {

            if (AktifSoruId != satir["soruid"].ToString())
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

                if (satir["cevapTip"].ToString() == "radio")
                {
                    if (count != satir["soruid"].ToString())
                    {
                        SoruCevapİçerikGrubu.InnerText += satir["soruvalue"].ToString();
                    }
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                    SoruCevapİçerikGrubu.Controls.Add(radioGrup);
                    SoruCevapİçerikGrubu.Controls.Add(radioLabel);
                    radioLabel.InnerText += satir["cevapvalue"].ToString();
                    count = satir["soruid"].ToString();
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                }
                else if (satir["cevapTip"].ToString() == "check")
                {
                    if (count != satir["soruid"].ToString())
                    {
                        SoruCevapİçerikGrubu.InnerText += satir["soruvalue"].ToString();
                    }
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                    SoruCevapİçerikGrubu.Controls.Add(checkboxLabel);
                    checkboxLabel.InnerText += satir["cevapvalue"].ToString();
                    count = satir["soruid"].ToString();
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                }
                else if (satir["cevapTip"].ToString() == "textbox")
                {
                    if (count != satir["soruid"].ToString())
                    {
                        SoruCevapİçerikGrubu.InnerText += satir["soruvalue"].ToString();
                    }
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                    SoruCevapİçerikGrubu.Controls.Add(acikucluCevap);
                    count = satir["soruid"].ToString();
                    SoruCevapİçerikGrubu.Controls.Add(bosluk);
                }
            }
            //else
            //{
            //    HtmlGenericControl SoruCevapGrubu = new HtmlGenericControl("tr");
            //    FormTable.Controls.Add(SoruCevapGrubu);
            //    HtmlGenericControl SoruCevapİçerikGrubu = new HtmlGenericControl("td");
            //    SoruCevapGrubu.Controls.Add(SoruCevapİçerikGrubu);

            //    HtmlGenericControl radioGrup = new HtmlGenericControl("div");
            //    HtmlGenericControl radioLabel = new HtmlGenericControl("input");
            //    radioLabel.Attributes.Add("type", "radio");
            //    HtmlGenericControl checkboxLabel = new HtmlGenericControl("input");
            //    radioLabel.Attributes.Add("type", "checkbox");
            //    HtmlGenericControl acikucluCevap = new HtmlGenericControl("input");
            //    acikucluCevap.Attributes.Add("type", "text");
            //    HtmlGenericControl bosluk = new HtmlGenericControl("br");

            //    if (satir["cevapTip"].ToString() == "radio")
            //    {
            //        SoruCevapİçerikGrubu.Controls.Add(bosluk);
            //        SoruCevapİçerikGrubu.Controls.Add(radioGrup);
            //        SoruCevapİçerikGrubu.Controls.Add(radioLabel);
            //        radioLabel.InnerText += satir["cevapvalue"].ToString();
            //        AktifSoruId = satir["soruid"].ToString();
            //        SoruCevapİçerikGrubu.Controls.Add(bosluk);
            //    }
            //    else if (satir["cevapTip"].ToString() == "check")
            //    {
            //        SoruCevapİçerikGrubu.Controls.Add(bosluk);
            //        SoruCevapİçerikGrubu.Controls.Add(checkboxLabel);
            //        checkboxLabel.InnerText += satir["cevapvalue"].ToString();
            //        AktifSoruId = satir["soruid"].ToString();
            //        SoruCevapİçerikGrubu.Controls.Add(bosluk);
            //    }
            //    else if (satir["cevapTip"].ToString() == "textbox")
            //    {
            //        SoruCevapİçerikGrubu.Controls.Add(bosluk);
            //        SoruCevapİçerikGrubu.Controls.Add(acikucluCevap);
            //        AktifSoruId = satir["soruid"].ToString();
            //        SoruCevapİçerikGrubu.Controls.Add(bosluk);
            //    }
            //}

        }
        SoruCevapFormu.Controls.Add(FormTable);
    }
}