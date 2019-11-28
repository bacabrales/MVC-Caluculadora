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
    }
}