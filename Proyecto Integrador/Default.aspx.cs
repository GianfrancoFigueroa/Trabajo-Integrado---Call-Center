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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnIngreso_Click(object sender, EventArgs e)
        {

            DatosUsuarios datosUsuarios = new DatosUsuarios();
            Usuarios Log = new Usuarios();
            

            try
            {
                Log.email = TxtEmail.ToString();
                Log.pass = TxtPass.ToString();
                if (datosUsuarios.Logueo(Log) == true)
                {
                    Session.Add("User", Log);
                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    Response.Redirect("About.aspx");
                }
            }
            catch (Exception ex)
            {

                throw ex; 
            }
            
    }
    }
}
