using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo_Comercio
{
    public class ClienteBD
    {
        public Cliente CargarCliente(string doc)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                Cliente cliente = new Cliente();
                datos.setConsulta("Select id, documento, nombre, apellido, email ,direccion, ciudad , CP from Clientes where documento =@doc");
                datos.setParametro("@doc", doc);
                datos.Leer();
                while(datos.Lector.Read())
                {
                    cliente.Id = (int)datos.Lector["id"];
                    cliente.Nombre = (string)datos.Lector["nombre"];
                    cliente.Apellido = (string)datos.Lector["apellido"];
                    cliente.Email = (string)datos.Lector["email"];
                    cliente.Ciudad = (string)datos.Lector["ciudad"];
                    cliente.Direccion = (string)datos.Lector["direccion"];
                    cliente.CodigoPostal = (int)datos.Lector["CP"];
                    cliente.Documento = (string)datos.Lector["documento"];
                    
                }
                return cliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
