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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            controlaPer.Guardar(this);
            controlaPer.listar(this);
            borrar();
        }

        protected void dvgDatos_edit(object source, DataGridCommandEventArgs e)
        {
            ViewState["id"] = Convert.ToInt32(e.Item.Cells[0].Text);
            txtNombre.Value = e.Item.Cells[1].Text;
            txtApellido.Value = e.Item.Cells[2].Text;
            txtEdad.Value = e.Item.Cells[3].Text;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            controlaPer.Modificar(this,(int)ViewState["id"]);
            controlaPer.listar(this);
            borrar();
        }
        public void borrar()
        {
            txtNombre.Value = "".ToString();
            txtApellido.Value = "".ToString();
            txtEdad.Value = "".ToString();
        }

        protected void dvgDatos_delete(object source, DataGridCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.Item.Cells[0].Text);
            controlaPer.Delete(id);
            controlaPer.listar(this);
            borrar();
        }
    }
}