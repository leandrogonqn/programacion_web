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
    public partial class AltaTurno : System.Web.UI.Page
    {
        TurnosNego turnosNego = new TurnosNego();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarGrilla();
            CargarDropdown();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarTurno();
        }

        private void CargarGrilla()
        {
            gdvTurnos.DataSource = turnosNego.listarTurnos(); //ESTO CARGA LA GRILLA
            gdvTurnos.DataBind(); //ESTO CARGA LA GRILLA
        }

        private void GuardarTurno()
        {
            Turno turno = new Turno();

            try
            {
                turno.PersonaId = int.Parse(ddlPersona.SelectedItem.Value);
                turno.FechaTurno = Convert.ToDateTime(dtDiaDelTurno.Value + " " + (dtHoraDelTurno.Value));
                turno.RegistroTurno = DateTime.Now;
                turno.MotivoTurno = txtMotivoTurno.Text;
                turno.Tareas = txtTareas.Text;

                turnosNego.guadarTurnos(turno);
                
                dtDiaDelTurno.Value = String.Empty;
                dtHoraDelTurno.Value = String.Empty;
                txtMotivoTurno.Text = String.Empty;
                txtTareas.Text = String.Empty;
                

                CargarGrilla();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void ddlPersona_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                CargarDropdown();

            }
        }

        private void CargarDropdown()
        {
            ddlPersona.DataSource = turnosNego.CargarDropdown();
            ddlPersona.DataTextField = "datos";
            ddlPersona.DataValueField = "personasId";
            ddlPersona.DataBind();
            ddlPersona.Items.Insert(0, "Seleccione el cliente para asignarle turno");
        }

    }
}