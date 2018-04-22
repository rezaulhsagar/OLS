using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty((string)Session["username"]))
        {
            resorucesfalse.Attributes.Add("style", "display:block");
            resourcestrue.Attributes.Add("style", "display:none");
        }
        else
        {
            resorucesfalse.Attributes.Add("style", "display:none");
            resourcestrue.Attributes.Add("style", "display:block");
        }
    }

    protected void Stanford_U_Click(object sender, EventArgs e)
    {
        Response.ContentType = "Application/pdf";
        Response.AppendHeader("Content-Disposition", "attachment; filename=Stanford_U.pdf");
        Response.TransmitFile(Server.MapPath("~/resources/Stanford_U.pdf"));
        Response.End();
    }
    protected void National_Taiwan_U_Click(object sender, EventArgs e)
    {
        Response.ContentType = "Application/pdf";
        Response.AppendHeader("Content-Disposition", "attachment; filename=National_Taiwan_U.pdf");
        Response.TransmitFile(Server.MapPath("~/resources/National_Taiwan_U.pdf"));
        Response.End();
    }
    protected void KTH_Royal_U_Click(object sender, EventArgs e)
    {
        Response.ContentType = "Application/pdf";
        Response.AppendHeader("Content-Disposition", "attachment; filename=KTH_Royal_U.pdf");
        Response.TransmitFile(Server.MapPath("~/resources/KTH_Royal_U.pdf"));
        Response.End();
    }
}