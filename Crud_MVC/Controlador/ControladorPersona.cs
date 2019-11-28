using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crud_MVC.Vista;
using Crud_MVC.Modelo;
using System.Web.UI.WebControls;

namespace Crud_MVC.Controlador
{
    public class ControladorPersona
    {
        DatoPersona datoPers = new DatoPersona();
        public void listar(FrmPersona vista)
        {
            ((DataGrid)vista.Page.FindControl("dvgDatos")).DataSource = datoPers.consultar();
            ((DataGrid)vista.Page.FindControl("dvgDatos")).DataBind();
        }
    }
}