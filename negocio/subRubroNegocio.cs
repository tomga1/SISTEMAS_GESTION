using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio; 

namespace negocio
{
    public class subRubroNegocio
    {
        public List<Dom_SubRubro> listar()
        {
            List<Dom_SubRubro> lista = new List<Dom_SubRubro>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select * from SUB_RUBRO order by Id_SubRubro");


                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Dom_SubRubro aux = new Dom_SubRubro();
                    aux.IdSubRubro = (int)datos.Lector["Id_SubRubro"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    

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


        //public void agregar(Dom_empleados nuevo)
        //{
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("insert into empleados (legajo, nombre, apellido, fecha_nacimiento, cuit, direccion, telefono, email, id_puesto, fecha_ingreso, id_estado, telefono_emergencia) values (@legajo, @nombre, @apellido, @fecha_nacimiento, @cuit, @direccion, @telefono, @email, @id_puesto, @fecha_ingreso, @id_estado, @telefono_emergencia)");

        //        datos.setearParametro("@legajo", nuevo.legajo);
        //        datos.setearParametro("@nombre", nuevo.nombre.ToUpper());
        //        datos.setearParametro("@apellido", nuevo.apellido.ToUpper());
        //        datos.setearParametro("@fecha_nacimiento", nuevo.fechaNacimiento);
        //        datos.setearParametro("@cuit", nuevo.cuit.ToUpper());
        //        datos.setearParametro("@direccion", nuevo.direccion.ToUpper());
        //        datos.setearParametro("@telefono", nuevo.telefono.ToUpper());
        //        datos.setearParametro("@email", nuevo.email.ToUpper());
        //        datos.setearParametro("@id_puesto", nuevo.oPuesto.idPuesto);
        //        datos.setearParametro("@fecha_ingreso", nuevo.fechaIngreso);
        //        datos.setearParametro("@id_estado", nuevo.oEstado.idEstado);
        //        datos.setearParametro("@telefono_emergencia", nuevo.telefonoEmergencia.ToUpper());

        //        datos.ejecutarAccion();

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}


        //public void eliminar(int id)
        //{
        //    try
        //    {
        //        AccesoDatos datos = new AccesoDatos();
        //        datos.setearConsulta("DELETE empleados where id_empleado = @id_empleado");
        //        datos.setearParametro("@id_empleado", id);
        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public void modificar(Dom_empleados empleado)
        //{
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("update empleados set legajo = @legajo, nombre = @nombre, apellido = @apellido, fecha_nacimiento = @fechaNacimiento, cuit = @cuit, direccion = @direccion, telefono = @telefono, email = @email, id_puesto = @idPuesto, fecha_ingreso = @fechaIngreso, id_estado = @idEstado, telefono_emergencia = @telefonoEmergencia where id_empleado = @id_empleado");
        //        datos.setearParametro("@legajo", empleado.legajo);
        //        datos.setearParametro("@nombre", empleado.nombre.ToUpper());
        //        datos.setearParametro("@apellido", empleado.apellido.ToUpper());
        //        datos.setearParametro("@fechaNacimiento", empleado.fechaNacimiento);
        //        datos.setearParametro("@cuit", empleado.cuit.ToUpper());
        //        datos.setearParametro("@direccion", empleado.direccion.ToUpper());
        //        datos.setearParametro("@telefono", empleado.telefono.ToUpper());
        //        datos.setearParametro("@email", empleado.email.ToUpper());
        //        datos.setearParametro("@idPuesto", empleado.oPuesto.idPuesto);
        //        datos.setearParametro("@fechaIngreso", empleado.fechaIngreso);
        //        datos.setearParametro("@idEstado", empleado.oEstado.idEstado);
        //        datos.setearParametro("@telefonoEmergencia", empleado.telefonoEmergencia.ToUpper());
        //        datos.setearParametro("@id_empleado", empleado.idEmpleado);



        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}


        //public List<Dom_empleados> listarActivos()
        //{
        //    List<Dom_empleados> lista = new List<Dom_empleados>();
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("SELECT e.id_empleado, e.legajo, e.nombre, e.apellido, e.fecha_nacimiento, e.cuit, e.direccion, e.telefono, e.email, p.nombre_puesto AS nombre_puesto, e.fecha_ingreso, es.nombre_estado AS estado, e.telefono_emergencia FROM empleados e JOIN puestos p ON p.id_puesto = e.id_puesto JOIN estado es ON es.id_estado = e.id_estado WHERE e.id_estado = 1;");


        //        datos.ejecutarLectura();

        //        while (datos.Lector.Read())
        //        {
        //            Dom_empleados aux = new Dom_empleados();
        //            aux.idEmpleado = (int)datos.Lector["id_empleado"];
        //            aux.legajo = (string)datos.Lector["legajo"];
        //            aux.nombre = (string)datos.Lector["nombre"];
        //            aux.apellido = (string)datos.Lector["apellido"];
        //            aux.fechaNacimiento = (DateTime)datos.Lector["fecha_nacimiento"];
        //            aux.cuit = (string)datos.Lector["cuit"];
        //            aux.direccion = (string)datos.Lector["direccion"];
        //            aux.telefono = (string)datos.Lector["telefono"];
        //            aux.email = (string)datos.Lector["email"];
        //            aux.oPuesto = new Dom_puestos();
        //            aux.oPuesto.NombrePuesto = (string)datos.Lector["nombre_puesto"];
        //            aux.fechaIngreso = (DateTime)datos.Lector["fecha_ingreso"];
        //            aux.oEstado = new Dom_Estado();
        //            aux.oEstado.nombreEstado = (string)datos.Lector["estado"];
        //            aux.telefonoEmergencia = (string)datos.Lector["telefono_emergencia"];



        //            lista.Add(aux);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine("Error al listar productos: " + ex.Message);
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }

        //    return lista;
        //}














        //public void actualizarPrecioCompra(int idProducto, decimal nuevoPrecioCompra)
        //{
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("UPDATE productos SET precio_compra = @precio_compra WHERE id_producto = @id_producto");
        //        datos.setearParametro("@precio_compra", nuevoPrecioCompra);
        //        datos.setearParametro("@id_producto", idProducto);

        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        //public void actualizarPrecioVenta(int idProducto, decimal nuevoPrecioVenta)
        //{
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("UPDATE productos SET precio_venta = @precio_venta WHERE id_producto = @id_producto");
        //        datos.setearParametro("@precio_venta", nuevoPrecioVenta);
        //        datos.setearParametro("@id_producto", idProducto);

        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        //public void actualizarStock(int idProducto, int cantidad)
        //{
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("UPDATE productos SET stock = stock + @cantidad WHERE id_producto = @id_producto");
        //        datos.setearParametro("@cantidad", cantidad);
        //        datos.setearParametro("@id_producto", idProducto);

        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}


        //public List<Dom_Producto> filtrar(string campo, string criterio, string filtro)
        //{
        //    List<Dom_Producto> lista = new List<Dom_Producto>();
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        string consulta = "SELECT id_producto, codigo, codigo_barra, nombre, p.descripcion, r.descripcion AS rubro_descripcion, stock,precio_compra, precio_venta, u.descripcion AS unidad_medida_descripcion, fecha_vencimiento, p.estado, fecha_registro, pro.razon_social AS razon_social, mar.descripcion_marca AS descripcion_marca FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN unidades_medida u ON u.id_unidad_medida = p.id_unidad_medida JOIN proveedor pro ON pro.id_proveedor = p.id_proveedor JOIN marcas mar ON mar.id_marca = p.id_marca and ";


        //        switch (campo)
        //        {
        //            case "Codigo":
        //                switch (criterio)
        //                {
        //                    default:
        //                        consulta += "codigo like '%" + filtro + "%'";
        //                        break;
        //                }
        //                break;

        //            case "Codigo Barra":
        //                switch (criterio)
        //                {
        //                    default:
        //                        consulta += "codigo_barra like '%" + filtro + "%'";
        //                        break;
        //                }
        //                break;

        //            case "Nombre":
        //                switch (criterio)
        //                {
        //                    default:
        //                        consulta += "nombre like '%" + filtro + "%'";
        //                        break;
        //                }
        //                break;

        //            case "Rubro":
        //                switch (criterio)
        //                {
        //                    default:
        //                        consulta += "id_rubro like '%" + filtro + "%'";
        //                        break;
        //                }
        //                break;

        //            case "Unidad Medida":
        //                switch (criterio)
        //                {
        //                    default:
        //                        consulta += "id_unidad_medida like '%" + filtro + "%'";
        //                        break;
        //                }
        //                break;

        //            case "Proveedor":
        //                switch (criterio)
        //                {
        //                    default:
        //                        consulta += "id_proveedor like '%" + filtro + "%'";
        //                        break;
        //                }
        //                break;
        //            case "Marca":
        //                switch (criterio)
        //                {
        //                    default:
        //                        consulta += "id_marca like '%" + filtro + "%'";
        //                        break;
        //                }
        //                break;

        //        }

        //        datos.setearConsulta(consulta);
        //        datos.ejecutarLectura();

        //        while (datos.Lector.Read())
        //        {
        //            Dom_Producto aux = new Dom_Producto();
        //            aux.Rubro = new Dom_Rubro();

        //            aux.codigo = (string)datos.Lector["codigo"];
        //            aux.codigo_de_barra = (string)datos.Lector["codigo_barra"];
        //            aux.nombre = (string)datos.Lector["nombre"];
        //            aux.descripcion = (string)datos.Lector["descripcion"];
        //            aux.Rubro = new Dom_Rubro();
        //            aux.Rubro.descripcion = (string)datos.Lector["descripcion"];
        //            aux.UnidadMedida = new Dom_UnidadDeMedida();
        //            aux.UnidadMedida.descripcion = (string)datos.Lector["descripcion"];
        //            aux.fecha_vencimiento = (DateTime)datos.Lector["fecha_vencimiento"];
        //            aux.Proveedor = new Dom_Proveedor();
        //            aux.Proveedor.razon_social = (string)datos.Lector["razon_social"];
        //            aux.Marca = new Dom_Marca();
        //            aux.Marca.descripcion = (string)datos.Lector["descripcion"];

        //            lista.Add(aux);
        //        }

        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }


        //    throw new NotImplementedException();
        //}
    }
}
