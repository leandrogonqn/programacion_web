using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;

namespace TrabajoPractico
{
    public partial class AltaPersona : System.Web.UI.Page
    {
        PersonasNego PersonaNego = new PersonasNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            CargarGrilla();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPersona();
        }

        private void CargarGrilla()
        {
            gdvPersonas.DataSource = PersonaNego.listarPersonas(); //ESTO CARGA LA GRILLA
            gdvPersonas.DataBind(); //ESTO CARGA LA GRILLA
        }

        private void GuardarPersona()
        {
            Persona persona = new Persona();

            try
            {

                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.Direccion = txtDireccion.Text;
                persona.Telefono = txtTelefono.Text;

                PersonaNego.GuardarPersonas(persona);

                txtNombre.Text = String.Empty;
                txtApellido.Text = String.Empty;
                txtDireccion.Text = String.Empty;
                txtTelefono.Text = String.Empty;

                CargarGrilla();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void gdvPersonas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Modificar")
            {
                int personaId = int.Parse(e.CommandArgument.ToString());
                string pagina="ModificarPersona.aspx?personaId=" + personaId;
                Response.Redirect(pagina);
            }
        }
    }
}