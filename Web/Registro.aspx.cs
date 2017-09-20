using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

public partial class Registro : System.Web.UI.Page
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
        set { Session["Coleccion"] = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["status"] != null)
            Response.Redirect("CrearPet.aspx");

        if (!IsPostBack)
        {
            if (Session["Nombre"] == null)
            {
                btnModificar.Visible = false;
                btnAgregar.Visible = true;
            }
            else //Session tiene datos, viene de Listar
            {
                btnModificar.Visible = true;
                btnAgregar.Visible = false;
                foreach (var c in colex)
                {
                    if (c.PlayerData.User.Equals(Session["Nombre"].ToString()))
                    {
                        txtNombreUser.Text = c.PlayerData.Name;
                        txtUserid.Text = c.PlayerData.User;
                        txtCorreo.Text = c.PlayerData.Mail.ToString();
                        txtPass.Text = c.PlayerData.Password.ToString();
                        chkSi.Checked = true;
                        txtNombreUser.Enabled = false;
                        txtUserid.Enabled = false;
                        chkSi.Enabled = false;
                    }
                }
            }
        }
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {

        if (chkSi.Checked)
        {
            try
            {
                //Verifica si existe el usuario. En el caso de que no, recién agrega.
                if (!colex.Exists(x => x.PlayerData.User.Equals(txtUserid.Text)))
                {
                    Player play = new Player();
                    play.Name = txtNombreUser.Text;
                    play.User = txtUserid.Text;
                    play.Mail = txtCorreo.Text;
                    play.Password = txtPass.Text;

                    ColeccionPet da = new ColeccionPet
                    {
                        PlayerData = play,
                        PetData = null
                    };
                    colex.Add(da);

                    lblMsg.Text = "Se ha registrado Exitosamente!!";
                    Response.AddHeader("Refresh", "0,URL=Login.aspx");
                }
                else
                    lblMsg.Text = "¡Usuario ya existe!";
                    
            }
            catch (Exception ex)
            {
                lblMsg.Text = "No se ha registrado " + ex.Message;
            }
        }
        else
        {
            lblMsg.Text = "Debe aceptar Terminos y Condiciones";
        }

    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        string correo = txtCorreo.Text;
        string password = txtPass.Text;
        if (colex.ModificarUsuario(colex, txtUserid.Text, correo, password))
        {
            Session["Nombre"] = null;
            Response.Redirect("Listar.aspx");
        }
        else
        {
            lblMsg.Text = "ERROR";



        }
    }

}