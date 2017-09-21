using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Threading.Tasks;
using System.Threading;
using System.Text;

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
        vpEat.Visible = false;
    }

    protected void StatusPet_onClick(object sender, EventArgs e)
    {
        Pet peteru = GetPet();

        //Si el gif se ve, lo hace invisible y debería mostrar los datos del vpet
        if (vPet.Visible == true)
        {
            vPet.Visible = false;
            lblvp.Visible = true;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Status " + peteru.Name);
            sb.AppendLine("Edad: " + peteru.Age + " dias");
            sb.AppendLine("Comida: " + peteru.Food);

            lblvp.Text = sb.ToString();
        }
        //oculta los datos y muestra el gif
        else
        {
            vPet.Visible = true;
            lblvp.Visible = false;
        }
    }


    protected void EatTime_onClick(object sender, EventArgs e)
    {
        //ClientScript.RegisterStartupScript(typeof(Page), "script", "reloadImg();", true);
        Pet peteru = GetPet();
        lblvp.Visible = false;

        //Por jones debería switch entre los gifs, pero no lo hace. hace lo que le da la puta gana D:<
        vpEat.Visible = true;
        vPet.Visible = false;

        //Alimenta de mala manera al pet po' >:c
        peteru.Food++;

        //Espera 2 sec. antes de volver al gif original
        Thread.Sleep(2000);

        //Hace switch entre los gifs xD
        vpEat.Visible = false;
        vPet.Visible = true;

        SetPet(peteru);//Japones quien te conoce(?)

    }

    protected void PoopTime_onClick(object sender, EventArgs e)
    {
    }

    /// <summary>
    ///    Obtiene la mascota desde la colección
    /// </summary>
    /// <returns>Pet</returns>
    private Pet GetPet()
    {
        return colex.Last(x => x.PlayerData.User.Equals(Session["user"])).PetData;
    }

    /// <summary>
    ///     Guarda la mascota del usuario en la colección
    /// </summary>
    /// <param name="p">Valor pet a cambiar</param>
    private void SetPet(Pet p)
    {
        colex.Last(x => x.PlayerData.User.Equals(Session["user"])).PetData = p;
    }
}