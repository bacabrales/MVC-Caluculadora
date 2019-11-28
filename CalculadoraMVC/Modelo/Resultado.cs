using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraMVC.Modelo
{
    public class Resultado
    {
        //Numero listaNumero = new Numero();
        public double suma(Numero n)
        {
            double suma = n.N1 + n.N2;
            return suma;
        }











        public double Resta(Numero n)
        {
            double resta = n.N1 - n.N2;
            return resta;
        }
        public double Multiplicacion(Numero n)
        {
            double multiplicacion = n.N1 * n.N2;
            return multiplicacion;
        }
        public double Division(Numero n)
        {
            double division = n.N1 / n.N2;
            return division;
        }
    }
}