using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Seguridad;

namespace TPWeb_equipo_20A
{
    public partial class Master : System.Web.UI.MasterPage
    {
        // protected string CurrentPage { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    CurrentPage = Request.Url.Segments[Request.Url.Segments.Length - 1]; // Gets the current page name
            //    DataBind(); // Bind the data to the controls
            //}
            if (!(Page is Default || Page is CanjearVoucher || Page is VoucherInvalido))
            {
                if (!VoucherValido.voucherValido(Session["voucher"]))
                {
                    Response.Redirect("CanjearVoucher.aspx", false);
                }
            }

        }
    }
}