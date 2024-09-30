using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Catalogo_Comercio;

namespace TPWeb_equipo_20A
{
    public partial class CanjearVoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAvanzar_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            VoucherDB voucherDB = new VoucherDB();
            try
            {
                if(voucherDB.voucherValido(txtVoucher.Text))
                {
                    Response.Redirect("ListaArticulos.aspx", false);
                }
                else
                {
                    txtVoucher.Text = "Codigo no valido";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}