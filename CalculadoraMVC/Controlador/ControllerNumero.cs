using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalculadoraMVC.Modelo;
using CalculadoraMVC.Vista;
using System.Web.UI.WebControls;

namespace CalculadoraMVC.Controlador
{
    public class ControllerNumero
    {
        Numero numero = new Numero();
        Resultado operaciones = new Resultado();

        public Double Sumar(FrmIndex vista)
        {
            numero.N1 = Convert.ToSingle(((TextBox)vista.Page.Form.FindControl("txtUno")).Text);
            numero.N2 = Convert.ToSingle(((TextBox)vista.Page.Form.FindControl("txtDos")).Text);
            return operaciones.suma(numero);
        }











        public Double Resta(FrmIndex vista)
        {
            numero.N1 = Convert.ToSingle(((TextBox)vista.Page.Form.FindControl("txtUno")).Text);
            numero.N2 = Convert.ToSingle(((TextBox)vista.Page.Form.FindControl("txtDos")).Text);
            return operaciones.Resta(numero);
        }
        public Double Multiplicacion(FrmIndex vista)
        {
            numero.N1 = Convert.ToSingle(((TextBox)vista.Page.Form.FindControl("txtUno")).Text);
            numero.N2 = Convert.ToSingle(((TextBox)vista.Page.Form.FindControl("txtDos")).Text);
            return operaciones.Multiplicacion(numero);
        }
        public Double Division(FrmIndex vista)
        {
            numero.N1 = Convert.ToSingle(((TextBox)vista.Page.Form.FindControl("txtUno")).Text);
            numero.N2 = Convert.ToSingle(((TextBox)vista.Page.Form.FindControl("txtDos")).Text);
            return operaciones.Division(numero);
        }
    }
}