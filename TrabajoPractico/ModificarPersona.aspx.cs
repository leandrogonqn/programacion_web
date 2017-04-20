using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Data;

namespace TrabajoPractico
{
    public partial class ModificarPersona : System.Web.UI.Page
    {
        PersonasNego personasNego = new PersonasNego(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            int personaId = int.Parse(Request["personaId"].ToString());
            llenarCampos(personaId);
        }

        private void llenarCampos(int personaId)
        {
            DataTable dt = new DataTable();
            dt = personasNego.buscarPersona(personaId);

            foreach (DataRow data in dt.Rows)
            {
                txtNombre.Text = data["nombre"].ToString();
                txtApellido.Text = data["apellido"].ToString();
                txtDireccion.Text = data["direccion"].ToString();
                txtTelefono.Text = data["telefono"].ToString();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}