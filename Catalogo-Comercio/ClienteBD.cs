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
        public int AgregarCliente(Cliente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            int idCliente;

            try
            {
                datos.setConsulta("insert into Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) Values (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP); SELECT SCOPE_IDENTITY();");
                datos.setParametro("@Documento", nuevo.Documento);
                datos.setParametro("@Nombre", nuevo.Nombre);
                datos.setParametro("@Apellido", nuevo.Apellido);
                datos.setParametro("@Email", nuevo.Email);
                datos.setParametro("@Direccion", nuevo.Direccion);
                datos.setParametro("@Ciudad", nuevo.Ciudad);
                datos.setParametro("@CP", nuevo.CodigoPostal);
                return idCliente = datos.ejecutarConsultaScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mensaje de error: {ex.Message}", $"Error al realizar la consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {ex.ToString()}");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
