using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatoCallCenter;

namespace Proyecto_Integrador
{
    public partial class TipoIncidencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatosTipoIncidencia datos = new DatosTipoIncidencia();
            GridTipoInc.DataSource = datos.Listar();
            GridTipoInc.DataBind();
        }
    }
}