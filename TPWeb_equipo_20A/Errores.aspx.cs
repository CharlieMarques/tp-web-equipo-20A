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

            if (Session.Count > 0)
            {
                lblMensaje.Text = Session["Error"].ToString();
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
            Session.Clear();
        }
    }
}