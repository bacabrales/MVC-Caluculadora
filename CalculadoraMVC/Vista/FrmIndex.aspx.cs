using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculadoraMVC.Controlador;

namespace CalculadoraMVC.Vista
{
    public partial class FrmIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            ControllerNumero controlador = new ControllerNumero();
            txtTres.Text = controlador.Sumar(this).ToString();
        }

        protected void btnResta_Click(object sender, EventArgs e)
        {
            ControllerNumero controlador = new ControllerNumero();
            txtTres.Text = controlador.Resta(this).ToString();
        }

        protected void btnMulti_Click(object sender, EventArgs e)
        {
            ControllerNumero controlador = new ControllerNumero();
            txtTres.Text = controlador.Multiplicacion(this).ToString();
        }

        protected void btnDivi_Click(object sender, EventArgs e)
        {
            ControllerNumero controlador = new ControllerNumero();
            txtTres.Text = controlador.Division(this).ToString();
        }
    }
}