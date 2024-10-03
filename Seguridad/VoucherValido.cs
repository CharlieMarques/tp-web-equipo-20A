using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Seguridad
{
    public static class VoucherValido
    {
        public static bool voucherValido(object vouch)
        {
            Voucher voucher = vouch != null ? (Voucher)vouch : null;
            if(voucher != null && voucher.voucherValido)
            {
                return true;
            }
            return false;
        }
    }
}
