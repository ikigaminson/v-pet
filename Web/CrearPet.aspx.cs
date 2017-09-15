using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
public partial class _Default : System.Web.UI.Page
{
    private ColeccionPet colex
    {
        get
        {
            if (Session["ColeccionPet"]==null)
            {
                Session["ColeccionPet"] = new ColeccionPet();
            }
            return (ColeccionPet)Session["ColeccionPet"];
        }
        set
        {
            Session["ColeccionPet"] = value;     
        }
    }

    private ColeccionPlayer colecc
    {
        get
        {
            return (ColeccionPlayer)Session["Coleccion"];
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        
            Random rnd = new Random();
            //var values = Enum.GetValues(typeof(typePet));
            // typePet tipoAleatorio = (typePet)values[R(0, values.Length)];

            Pet baby = new Pet();

        try
        {
            baby.Name = txtNombre.Text;
            baby.Poop = rnd.Next(1, 100);
            baby.Age = rnd.Next(1, 10);
            baby.Date = DateTime.Now;

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
        }
        catch (Exception)
        { 

        }
        
     


    }

    
}