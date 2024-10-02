using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Catalogo_Comercio;
using System.Linq.Expressions;

namespace TPWeb_equipo_20A
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx", false);
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {

        }

        protected void txtDocumento_TextChanged(object sender, EventArgs e)
        {            
            ClienteBD clienteBD = new ClienteBD();
            try
            {
                Cliente cliente = clienteBD.CargarCliente(txtDocumento.Text);
                txtEmail.Text = cliente.Email;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtCiudad.Text = cliente.Ciudad;
                
                if(cliente.CodigoPostal == 0)               
                    txtCodigoPostal.Text = "";
                else
                txtCodigoPostal.Text = cliente.CodigoPostal.ToString();
                txtDireccion.Text =cliente.Direccion;
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}