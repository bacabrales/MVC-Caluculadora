using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Crud_MVC.Controlador;

namespace Crud_MVC.Vista
{
    public partial class FrmPersona : System.Web.UI.Page
    {
        ControladorPersona controlaPer = new ControladorPersona();
        protected void Page_Load(object sender, EventArgs e)
        {
            controlaPer.listar(this);
        }
    }
}