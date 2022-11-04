using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatoCallCenter;

namespace Proyecto_Integrador
{
    public partial class Estados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatosEstados datos = new DatosEstados();
            GridEstado.DataSource = datos.Listar();
            GridEstado.DataBind();
        }
    }
}