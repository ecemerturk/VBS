using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGenerateControl_Click(object sender, EventArgs e)
    {
        // oluşturulacak kontrollerin sayısını al
        int Count = Convert.ToInt16(txtControlsCount.Text);
        // CheckBoxList'teki her bir liste öğesi üzerinden döngü yap
        foreach (ListItem li in chkBoxListControlType.Items)
        {
            if (li.Selected)
            {
                // label üret
                if (li.Value == "Label")
                {
                    for (int i = 1; i <= Count; i++)
                    {
                        Label aa = new Label();
                        aa.Text = "Label - " + i.ToString();
                        pnlTextBoxes.Controls.Add(aa);
                    }
                }
                // textbox üret
                else if (li.Value == "TextBox")
                {
                    for (int i = 1; i <= Count; i++)
                    {
                        TextBox txtBox = new TextBox();
                        txtBox.Text = "TextBox - " + i.ToString();
                        pnlTextBoxes.Controls.Add(txtBox);
                    }
                }
                // button üret
                else
                {
                    for (int i = 1; i <= Count; i++)
                    {
                        Button btn = new Button();
                        btn.Text = "Button - " + i.ToString();
                        pnlButtons.Controls.Add(btn);
                    }
                }
            }
        }
    }
}