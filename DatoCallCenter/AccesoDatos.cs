using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatoCallCenter
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion=new SqlConnection("server=.\\SQLEXPRESS; database=CallCenter; integrated security=true");
            comando=new SqlCommand();
        }
        public void setearQuery(string query)
        {
            comando.CommandType=System.Data.CommandType.Text;
            comando.CommandText=query;
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion()
        {
            if (lector != null) 
            {
                lector.Close(); 
            }
            conexion.Close();
        }

    }


}
