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
        if (Session["status"] != null)
            Response.Redirect("CrearPet.aspx");

        if (Session["Coleccion"] == null)
        {
            Response.Redirect("Registro.aspx");
        }
        else
        {
            //Reinicia la variable sessión para poder agregar/modificar más elementos xD
            //Session["Nombre"] = null;

            btnVolver.Visible = true;
            gdvUsuario.DataSource = colex.Select(x=> x.PlayerData.User) ;
            gdvUsuario.DataBind();
        }
    }


    protected void gdvUsuario_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnVolver.Visible = true;
        Session["Nombre"] = gdvUsuario.SelectedRow.Cells[1].Text;
    }


    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }


    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (Session["Nombre"] != null)
        {
            if (colex.EliminarUsuario(colex, Session["Nombre"].ToString() ))
            {
                Session["Nombre"] = null;
                lblMsg.Text = "Eliminado con EXITO!!!";
                Response.AppendHeader("Refresh", "0");
            }
        }
    }


    protected void btnModificar_Click(object sender, EventArgs e)
    {
        if (Session["Nombre"] != null)
        {
            Response.Redirect("Registro.aspx");
        }
    }


    
}

