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
            
        }
    }
}
