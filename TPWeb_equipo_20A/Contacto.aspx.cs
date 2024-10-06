using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Catalogo_Comercio;
using System.Linq.Expressions;
using System.EnterpriseServices;

namespace TPWeb_equipo_20A
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static bool NuevoCliente = false;
        private static Cliente cliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NuevoCliente = true;
                if (Session.Count > 0)
                {
                    if (((Voucher)Session["voucher"]).idCliente != -1)
                    {
                        ClienteBD clienteBD = new ClienteBD();
                        txtDNI.Text = clienteBD.CargarCliente(((Voucher)Session["voucher"]).idCliente).Documento;
                        txtDNI_TextChanged(txtDNI, EventArgs.Empty);
                    }
                }
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx", false);
        }
        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    if (NuevoCliente)
                    {
                        ((Voucher)Session["voucher"]).idCliente = CrearNuevoCliente();
                    }
                    else
                    {
                        ((Voucher)Session["voucher"]).idCliente = cliente.Id;
                    }
                    if (((Voucher)Session["voucher"]).idArticulo != -1)
                    {
                        VoucherDB voucherDB = new VoucherDB();
                        voucherDB.CanjearVoucher((Voucher)Session["voucher"]);
                        Response.Redirect("CanjeCompletado.aspx", false);
                    }
                    else
                    {
                        Response.Redirect("ListaArticulos.aspx", false);
                    }
                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());
                    Response.Redirect("Errores.aspx", false);
                }
            }
            else
            {

            }
        }
        protected int CrearNuevoCliente()
        {
            Cliente nuevo = new Cliente();
            nuevo.Documento = txtDNI.Text;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Email = txtEmail.Text;
            nuevo.Direccion = txtDireccion.Text;
            nuevo.Ciudad = txtCiudad.Text;
            nuevo.CodigoPostal = int.Parse(txtCodigoPostal.Text);

            ClienteBD clienteBD = new ClienteBD();

            try
            {
                return clienteBD.AgregarCliente(nuevo);
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Errores.aspx", false);
                return -1;
            }
        }

        protected void txtDNI_TextChanged(object sender, EventArgs e)
        { 
            
            ClienteBD clienteBD = new ClienteBD();
            try
            {
                cliente = clienteBD.CargarCliente(txtDNI.Text);
                if (cliente.Id == 0)
                {
                    NuevoCliente = true;
                }
                else
                {
                    txtEmail.Text = cliente.Email;
                    txtNombre.Text = cliente.Nombre;
                    txtApellido.Text = cliente.Apellido;
                    txtCiudad.Text = cliente.Ciudad;
                    txtCodigoPostal.Text = cliente.CodigoPostal.ToString();
                    txtDireccion.Text = cliente.Direccion;
                    NuevoCliente = false;
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Errores.aspx", false);
            }
        }
        protected void CheckBoxRequired_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = chkBoxParticipar.Checked;
        }
    }
}