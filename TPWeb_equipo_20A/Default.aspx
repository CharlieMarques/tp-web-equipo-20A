<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWeb_equipo_20A.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row g-2 needs-validation px-5" style="margin-left: 15%; margin-right: 15%; margin-top: 2%">
        <div class="col-md-12">
            <h1>Bienvenido a la promo</h1>
            <p>
                En esta página vas a poder canjear los códigos de voucher que relizaste con tu compra. Si no 
                tienes un código todavía, puedes conseguirlo al realizar una compra en nuestro sitio. Luego se 
                te enviará un código de voucher para poder canjearlo aquí. 
            </p>
            <h5 style="margin: 5px">
                Si ya tienes un código,
            </h5>
            <asp:Button CssClass="btn btn-primary" style="margin:5px;" ID="btnComenzar" runat="server" Text="Comenzar" OnClick="btnComenzar_Clicked" />
        </div>
    </div>
</asp:Content>
