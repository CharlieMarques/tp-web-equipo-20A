using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Catalogo_Comercio
{
    public class VoucherDB
    {
        AccesoDatos datos = new AccesoDatos();
        public bool voucherValido(string voucher)
        {
            try
            {
                datos.setConsulta("Select idCliente from Vouchers where CodigoVoucher = @Voucher");
                datos.setParametro("@Voucher", voucher);
                datos.Leer();
                while(datos.Lector.Read())
                {
                    if (datos.Lector["idCliente"] is DBNull)
                        return true;
                }
                return false;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }
        public bool voucherCanjeado(string voucher)
        {
            try
            {
                datos.setConsulta("Select idCliente from Vouchers where CodigoVoucher = @Vouch");
                datos.setParametro("@Vouch", voucher);
                datos.Leer();
                while (datos.Lector.Read())
                {
                    if (!(datos.Lector["idCliente"] is DBNull))
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void CanjearVoucher(Voucher voucher)
        {
            AccesoDatos datos = new AccesoDatos();
         
            try
            {
                datos.setConsulta("Update Vouchers set IdArticulo = @ArticuloId, IdCliente = @ClienteId, FechaCanje = @Fecha Where CodigoVoucher = @CodigoVoucher");
                datos.setParametro("@ArticuloId", voucher.idArticulo);
                datos.setParametro("@ClienteId", voucher.idCliente);
                datos.setParametro("@Fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                datos.setParametro("@CodigoVoucher", voucher.Codigo);

                datos.ejecutarConsulta();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
