using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWeb_equipo_20A
{
    public partial class VoucherInvalido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Canjeado"] != null)
            {
                lblMensaje.Text = "El voucher ingresado ya fue canjeado";
            }
            else if (Session["Invalido"] != null)
            {
                lblMensaje.Text = "Voucher inexistente";
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }
    }
}