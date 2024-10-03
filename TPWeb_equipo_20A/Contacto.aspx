<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="TPWeb_equipo_20A.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row g-2 needs-validation px-1" style="margin-left: 15%; margin-right: 15%; margin-top: 1%;">
                <div class="col-md-12">
                    <h1>Contacto</h1>
                    <h5>Complete el siguiente formulario:</h5>
                </div>
                <div class="col-md-6">
                    <label for="txtNombre" class="form-label">Nombre</label>
                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
                    <asp:RequiredFieldValidator ErrorMessage="El nombre es requerido." ControlToValidate="txtNombre" ForeColor="DarkRed" runat="server" />
                </div>
                <div class="col-md-6">
                    <label for="txtApellido" class="form-label">Apellido</label>
                    <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
                    <asp:RequiredFieldValidator ErrorMessage="El apellido es requerido." ControlToValidate="txtApellido" ForeColor="DarkRed" runat="server" />
                </div>
                <div class="col-md-4">
                    <label for="txtDNI" class="form-label">Nro Documento</label>
                    <asp:TextBox runat="server" ID="txtDNI" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtDNI_TextChanged" />
                    <asp:RequiredFieldValidator ErrorMessage="El DNI es requerido." ControlToValidate="txtDNI" ForeColor="DarkRed" runat="server" />
                </div>
                <div class="col-md-8">
                    <label for="txtEmail" class="form-label">Correo Electrónico</label>
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                    <asp:RequiredFieldValidator ErrorMessage="El correo electrónico es requerido" ControlToValidate="txtEmail" ForeColor="DarkRed" runat="server" />
                    <asp:RegularExpressionValidator ID="msgError" ErrorMessage="Ingrese un email válido." ControlToValidate="txtEmail" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" runat="server" Display="Dynamic" CssClass="text-danger" />
                </div>
                <div class="col-md-6">
                    <label for="txtDireccion" class="form-label">Dirección</label>
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" />
                    <asp:RequiredFieldValidator ErrorMessage="La direccion es requerida." ControlToValidate="txtDireccion" ForeColor="DarkRed" runat="server" />
                </div>
                <div class="col-md-3">
                    <label for="txtCiudad" class="form-label">Ciudad</label>
                    <asp:TextBox runat="server" ID="txtCiudad" CssClass="form-control" />
                    <asp:RequiredFieldValidator ErrorMessage="La ciudad es requerida." ControlToValidate="txtCiudad" ForeColor="DarkRed" runat="server" />
                </div>
                <div class="col-md-3">
                    <label for="txtCodigoPostal" class="form-label">Código Postal</label>
                    <asp:TextBox runat="server" ID="txtCodigoPostal" CssClass="form-control" />
                    <asp:RequiredFieldValidator ErrorMessage="El código postal es requerido." ControlToValidate="txtCodigoPostal" ForeColor="DarkRed" runat="server" />
                    <asp:RangeValidator ErrorMessage="Código postal no valido." ControlToValidate="txtCodigoPostal" Type="Integer" MinimumValue="1" MaximumValue="10000" runat="server" />
                </div>
                <div class="col-12">
                    <asp:CheckBox ID="chkBoxParticipar" runat="server" />
                    <label class="form-check-label" for="chkBoxParticipar">
                        Acepto los términos y condiciones.
                    </label>
                    </div>
                <div class="col-12">
                    <asp:CustomValidator ErrorMessage="Debe aceptar los terminos y condiciones para continuar." ForeColor="DarkRed" runat="server" EnableClientScript="true" OnServerValidate="CheckBoxRequired_ServerValidate"></asp:CustomValidator>
                </div>
                <div class="col-12">
                    <asp:Button Text="Participar" CssClass="btn btn-primary" runat="server" ID="btnParticipar" OnClick="btnParticipar_Click" />
                    <asp:Button Text="Cancelar" runat="server" ID="btnCancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click" />
                </div>                
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
