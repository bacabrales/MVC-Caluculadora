using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_MVC.Modelo
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}