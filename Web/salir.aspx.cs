using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class salir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Nombre"] = null;
        Session["status"] = null;
        Session["user"] = null;

        Response.Redirect("Inicio.aspx");
    }
}