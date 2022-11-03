using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clases;
using DatoCallCenter;

namespace Proyecto_Integrador
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatosClientes clientes = new DatosClientes();
            GridVClientes.DataSource = clientes.Listar();
            GridVClientes.DataBind();
        }
    }
}