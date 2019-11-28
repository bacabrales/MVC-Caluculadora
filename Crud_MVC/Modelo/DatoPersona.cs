using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Crud_MVC.Modelo
{
    public class DatoPersona
    {
        public List<Persona> consultar()
        {
            SqlConnection conex = Singleton.obtenerConexion();
            SqlDataAdapter adap = new SqlDataAdapter("pa_Consultar", conex);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return (from DataRow row in dt.Rows
                    select new Persona() {
                        Id = Convert.ToInt32(row["idEmpl"]),
                        Nombre = Convert.ToString(row["nomEmpl"]),
                        Apellido = Convert.ToString(row["apeEmpl"]),
                        Edad = Convert.ToInt32(row["edadEmpl"])
                    }).ToList();
        }

        public void insertar(Persona persona)
        {
            SqlConnection conex = Singleton.obtenerConexion();
            SqlCommand comand = new SqlCommand("pa_Guardar",conex);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@nombre",persona.Nombre);
            comand.Parameters.AddWithValue("@apellido", persona.Apellido);
            comand.Parameters.AddWithValue("@edad", persona.Edad);
            comand.ExecuteNonQuery();
        }

        public void modificar(Persona persona, int id)
        {
            SqlConnection conex = Singleton.obtenerConexion();
            SqlCommand comand = new SqlCommand("pa_Modificar",conex);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@id",id);
            comand.Parameters.AddWithValue("@nombre",persona.Nombre);
            comand.Parameters.AddWithValue("@apellido", persona.Apellido);
            comand.Parameters.AddWithValue("@edad", persona.Edad);
            comand.ExecuteNonQuery();
        }

        public void delete(int id)
        {
            SqlConnection conex = Singleton.obtenerConexion();
            SqlCommand comand = new SqlCommand("pa_delete", conex);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@id", id);
            comand.ExecuteNonQuery();
        }
    }
}