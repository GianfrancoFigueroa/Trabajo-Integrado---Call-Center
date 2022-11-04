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
    public partial class Prioridad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatosPrioridad datos = new DatosPrioridad();
            GridPrioridades.DataSource = datos.Listar();
            GridPrioridades.DataBind();
        }
    }
}