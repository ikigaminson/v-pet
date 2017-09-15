using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
public partial class _Default : System.Web.UI.Page
{
    private ColeccionPlayer colex
    {
        get
        {
           
            return (ColeccionPlayer)Session["Coleccion"];
        }

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Coleccion"] == null)
        {
            Response.Redirect("Registro.aspx");
        }
        else
        {
           
            btnCrear.Visible = true;
            gdvPet.DataSource = colex;
            gdvPet.DataBind();
        }
    }


    protected void gdvPet_SelectedIndexChanged(object sender, EventArgs e)
    {

        btnCrear.Visible = true;
        Session["Nombre"] = gdvPet.SelectedRow.Cells[1].Text;
    }


    protected void btnCrear_Click(object sender, EventArgs e)
    {
        Response.Redirect("CrearPet.aspx");
    }
}

