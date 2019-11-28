using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crud_MVC.Vista;
using Crud_MVC.Modelo;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Crud_MVC.Controlador
{
    public class ControladorPersona
    {
        DatoPersona datoPers = new DatoPersona();
        Persona persona = new Persona();
        public void listar(FrmPersona vista)
        {
            ((DataGrid)vista.Page.FindControl("dvgDatos")).DataSource = datoPers.consultar();
            ((DataGrid)vista.Page.FindControl("dvgDatos")).DataBind();
        }

        public void Guardar(FrmPersona vista)
        {
            persona.Nombre = ((HtmlInputText)vista.Page.Form.FindControl("txtNombre")).Value;
            persona.Apellido = ((HtmlInputText)vista.Page.Form.FindControl("txtApellido")).Value;
            persona.Edad = Convert.ToInt32(((HtmlInputText)vista.Page.Form.FindControl("txtEdad")).Value);
            datoPers.insertar(persona);
        }

        public void Modificar(FrmPersona vista, int id)
        {
            persona.Nombre = ((HtmlInputText)vista.Form.FindControl("txtNombre")).Value;
            persona.Apellido = ((HtmlInputText)vista.Form.FindControl("txtApellido")).Value;
            persona.Edad = Convert.ToInt32(((HtmlInputText)vista.Page.Form.FindControl("txtEdad")).Value);
            datoPers.modificar(persona, id);
        }

        public void Delete(int id)
        {
            datoPers.delete(id);
        }
    }
}