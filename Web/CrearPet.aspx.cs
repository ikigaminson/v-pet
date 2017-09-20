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
            if (Session["Coleccion"] == null)
            {
                Session["Coleccion"] = new ColeccionPlayer();
            }
            return (ColeccionPlayer)Session["Coleccion"];
        }
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        bool valPet = colex.Exists(x => x.PlayerData.User.Equals(Session["user"]) && x.PetData != null);
        lblError.Visible = false;
        if (IsPostBack && valPet)
            Response.Redirect("petView.aspx");

        if (Session["status"] == null || Session["user"] == null)
            Response.Redirect("Inicio.aspx");

        if (valPet)
            Response.Redirect("petView.aspx");

    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {

        //Random rnd = new Random();
        //var values = Enum.GetValues(typeof(typePet));
        // typePet tipoAleatorio = (typePet)values[R(0, values.Length)];      

        try
        {
            Pet baby = new Pet
            {
                Name = txtNombre.Text,
                Poop = 0,
                Age = 0,
                Date = DateTime.Now
            };

            if (ddlTipo.SelectedValue == "Virus")
            {
                baby.PetType = typePet.virus;
            }
            else if (ddlTipo.SelectedValue == "Dato")
            {
                baby.PetType = typePet.data;
            }
            else if (ddlTipo.SelectedValue == "Vacuna")
            {
                baby.PetType = typePet.vacuum;
            }
            string p = Session["user"].ToString();

            if (!colex.AgregarPet(colex, baby, p))
                lblError.Visible = true;
            else
                Response.Redirect("petView.aspx");

        }
        catch (Exception)
        {

        }




    }


}