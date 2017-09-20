using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Threading.Tasks;

public partial class viewPet : System.Web.UI.Page
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
        if (Session["status"] == null)
            Response.Redirect("Login.aspx");
        if (colex.Exists(x => x.PlayerData.User.Equals(Session["user"]) && x.PetData == null))
            Response.Redirect("CrearPet.aspx");
    }

    protected void StatusPet_onClick(object sender, EventArgs e) {

        //Si el gif se ve, lo hace invisible y debería mostrar los datos del vpet
        if (vPet.Visible == true)
        {
            vPet.Visible = false;
            lblvp.Visible = true;
            lblvp.InnerText = "jajaja";
        }
        //oculta los datos y muestra el gif
        else
        {
            vPet.Visible = true;
            lblvp.Visible = false;
        }
    }

    //async es por el await del Delay
    protected async void EatTime_onClick(object sender, EventArgs e) {
        //Esto debería poder cambiar la imagen, pero nada que funciona
        ClientScript.RegisterStartupScript(typeof(Page), "script", "reloadImg();", true);
        await Task.Delay(5000);
        vPet.Src = "imagenes/Pets/guilattack.gif";
        
    }

    protected void PoopTime_onClick(object sender, EventArgs e) {
    }
}