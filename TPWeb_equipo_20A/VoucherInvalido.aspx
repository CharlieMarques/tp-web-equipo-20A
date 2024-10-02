<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="VoucherInvalido.aspx.cs" Inherits="TPWeb_equipo_20A.VoucherInvalido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hubo un problema</h1>
    <div class="mb-3", style="margin-top:2%; margin-left:20%; margin-right:20%">
    <asp:Label Text="Error al cargar la pagina" runat="server" ID="lblMensaje" style="margin:5px;" />
    </div>
    <div class="mb-3", style="margin-top:2%; margin-left:20%; margin-right:20%">
    <asp:Button Text="Volver al inicio" ID="btnVolver" runat="server" CssClass="btn btn-primary" style="margin:5px;" OnClick="btnVolver_Click" />
    </div>
</asp:Content>
