using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploLinq
{
    public partial class Linq : System.Web.UI.Page
    {
        ConexionBase conex = new ConexionBase();
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = conex.empleado.Where(x => x.nomEmpl == "Bryam");
            gvTabla.DataSource = list.ToList();
            gvTabla.DataBind();
        }
    }
}