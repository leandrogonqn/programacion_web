﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.SqlClient;

namespace Repositorio
{
    public class PersonasRepo
    {

        string datosConexion = "Data Source = DESKTOP-AFR6DP5; Initial Catalog = TrabajoPractico1; Integrated Security = True;";
        SqlConnection conexion = new SqlConnection();

        public void GuardarPersona(Persona persona)
        {
            conexion.ConnectionString = datosConexion;
            conexion.Open();
            
            string qy = "insert into Personas values('" + persona.Nombre + "','" + persona.Apellido + "','" + persona.Direccion + "','" + persona.Telefono + "','" + persona.Activo + "')";

            SqlCommand cmd = new SqlCommand(qy, conexion);
            cmd.ExecuteNonQuery(); //Si falla, hace rollback

            conexion.Close();
        }

        public DataTable listarPersonas()
        {

            DataTable dt = new DataTable();

            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select * from Personas WHERE activo = 1";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;

        }

        public DataTable buscarPersona (int personaId)
        {
            DataTable persona = new DataTable();
            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select * from Personas WHERE personasId = " + personaId;

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(persona);
            conexion.Close();

            return persona;
        }

        public void ModificarPersona (int personaId, Persona p)
        {
            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "UPDATE Personas SET nombre = '" + p.Nombre + "', apellido = '" + p.Apellido + "', direccion = '" + p.Direccion + "', telefono = '" + p.Telefono + "' WHERE personasId = " + personaId;

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.ExecuteNonQuery(); //Si falla, hace rollback

            conexion.Close();
        }

    }
}
