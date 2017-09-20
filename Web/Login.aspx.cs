using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

public partial class inicio : System.Web.UI.Page
{


    private ColeccionPlayer colex
    {
        get { return (ColeccionPlayer)Session["Coleccion"]; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        //Si no es null va a ver pet, sino crea/limpia "user" y mantiene en página
        if (Session["status"] != null)
            Response.Redirect("CrearPet.aspx");
        else
            Session["user"] = null;
    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        if (Session["Coleccion"] != null)
        {
            if (colex.Exists(x => x.PlayerData.User.Equals(txtUsuario.Text)))
            {
                if (colex.Exists(z => z.PlayerData.Password.Equals(txtPass.Text) && z.PlayerData.User.Equals(txtUsuario.Text)))
                {
                    //Genera si está logueado
                    Session["status"] = true;
                    //Indica el usuario con el que está trabajando
                    Session["user"] = txtUsuario.Text;
                    Response.Redirect("CrearPet.aspx");
                }
                else
                    lblMsg.Text = "Contraseña erronea";
            }
            else
                lblMsg.Text = "El Usuario no Existe";
        }
        else
        {
            lblMsg.Text = "El Usuario no Existe";
        }



    }
}