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
    public partial class ModificarTurno : System.Web.UI.Page
    {
        TurnosNego turnosNego = new TurnosNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            int turnosId = int.Parse(Request["turnosId"].ToString());
            llenarCampos(turnosId);
        }

        private void llenarCampos(int turnosId)
        {
            DataTable dt = new DataTable();
            dt = turnosNego.buscarTurnos(turnosId);

            foreach (DataRow data in dt.Rows)
            {
                string fmt = "00";
                DateTime dia = Convert.ToDateTime(data["fechaTurno"].ToString());
                ddlPersona.SelectedValue = data["personaId"].ToString();
                dtDiaDelTurno.Value = dia.Year.ToString() + "-" + dia.Month.ToString(fmt) + "-" + dia.Day.ToString(fmt);;
                dtHoraDelTurno.Value = dia.TimeOfDay.ToString();
                txtMotivoTurno.Text = data["motivosTurno"].ToString();
                txtTareas.Text = data["tareas"].ToString();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int turnosId = int.Parse(Request["turnosId"].ToString());
            Turno turno = new Turno();

            try
            {
                turno.PersonaId = int.Parse(ddlPersona.SelectedItem.Value);
                turno.FechaTurno = Convert.ToDateTime(dtDiaDelTurno.Value + " " + (dtHoraDelTurno.Value));
                turno.MotivoTurno = txtMotivoTurno.Text;
                turno.Tareas = txtTareas.Text;

                turnosNego.modificarTurno(turnosId, turno);

                Response.Redirect("AltaTurno.aspx");
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