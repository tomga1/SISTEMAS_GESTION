using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ProveedoresNegocio
    {
        public List<Dom_Proveedores> listar()
        {
            List<Dom_Proveedores> lista = new List<Dom_Proveedores>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select * from Proveedores WHERE estado = 1");


                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Dom_Proveedores aux = new Dom_Proveedores();
                    aux.IdProveedor = (int)datos.Lector["idProveedor"];
                    aux.RazonSocial = (string)datos.Lector["razonSocial"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Telefono1 = (string)datos.Lector["telefono1"];
                    aux.Telefono2= (string)datos.Lector["telefono2"];
                    aux.Email = (string)datos.Lector["email"];
                    aux.Estado = (bool)datos.Lector["estado"];
                    aux.FechaRegistro = (DateTime)datos.Lector["fechaRegistro"];
                    aux.Observaciones = (string)datos.Lector["observaciones"];
                    aux.PaginaWeb = (string)datos.Lector["paginaWeb"];






                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al listar productos: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;
        }
    }
}
