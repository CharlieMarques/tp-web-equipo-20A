using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public string Codigo { get; set; }
        public int idCliente { get; set; }
        public DateTime FechaCanje { get; set; }
        public int idArticulo { get; set; }
    }
}
