using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Catalogo_Comercio;
using Dominio;

namespace TPWeb_equipo_20A
{
    public partial class ListaArticulos : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloBD articuloBD = new ArticuloBD();  
            ListaArticulo = articuloBD.listar();
            ImagenDB imagen = new ImagenDB();
            foreach (var articulo in ListaArticulo)
            {
                articulo.Imagenes = imagen.GetImagenes(articulo.Id);
            }

            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaArticulo;
                repRepetidor.DataBind();
            }
        }
        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ((Voucher)Session["voucher"]).idArticulo = int.Parse(((Button)sender).CommandArgument.ToString());
            Response.Redirect("Contacto.aspx", false);
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx", false);
        }
    }
}