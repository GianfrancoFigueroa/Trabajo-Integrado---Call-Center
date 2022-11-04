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

public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatosIncidencias datos = new DatosIncidencias();
            GridIncidencias.DataSource = datos.Listar();
            GridIncidencias.DataBind();

        }

    }
}