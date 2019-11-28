using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraMVC.Modelo
{
    public class Numero
    {
        private double n1;
        private double n2;

        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }

        public Numero (double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public Numero()
        {

        }
    }
}