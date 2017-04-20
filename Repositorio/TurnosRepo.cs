using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.SqlClient;

namespace Repositorio
{
    public class TurnosRepo
    {

        string datosConexion = "Data Source = DESKTOP-AFR6DP5; Initial Catalog = TrabajoPractico1; Integrated Security = True;";
        SqlConnection conexion = new SqlConnection();

        public void guardarTurno(Turno turno)
        {
            conexion.ConnectionString = datosConexion;
            conexion.Open();


            string qy = "insert into Turnos values('" + turno.PersonaId + "','" + turno.RegistroTurno + "','" + turno.FechaTurno + "','" + turno.MotivoTurno + "','" + turno.Tareas + "')";

            SqlCommand cmd = new SqlCommand(qy, conexion);
            cmd.ExecuteNonQuery(); //Si falla, hace rollback

            conexion.Close();
        }
        public DataTable listarTurnos()
        {

            DataTable dt = new DataTable();

            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select * from Personas inner join Turnos on Turnos.personaId = Personas.personasId";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;

        }

        public DataTable CargarDropdown()
        {
            DataTable dt = new DataTable();

            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select personasId, CONVERT(varchar(10), personasId) + ' - ' + nombre + ' ' + apellido as datos from Personas";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;
        }

    }
}
