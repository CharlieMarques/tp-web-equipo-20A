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
            voucher.voucherValido = false;
            VoucherDB voucherDB = new VoucherDB();
            try
            {
                if(voucherDB.voucherValido(txtVoucher.Text))
                {
                    voucher.voucherValido = true;
                    Session.Add("voucher", voucher);
                    ((Voucher)Session["voucher"]).Codigo = txtVoucher.Text;
                    Response.Redirect("ListaArticulos.aspx", false);
                }
                else if(voucherDB.voucherCanjeado(txtVoucher.Text))
                {
                    Session.Add("Canjeado", voucher);
                    Response.Redirect("VoucherInvalido.aspx", false);
                }
                                    
                else
                {
                    Session.Add("Invalido", voucher);
                    Response.Redirect("VoucherInvalido.aspx", false);                  
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