<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CanjearVoucher.aspx.cs" Inherits="TPWeb_equipo_20A.CanjearVoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Canjea tu voucher</h1>
    
    <div class="mb-3">
        <label for="txtVoucher">Valida tu voucher</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtVoucher" placeholder="Ingresa el codigo de tu voucher"></asp:TextBox>
    </div>
    <asp:Button Text="Avanzar" CssClass="btn btn-primary" ID="btnAvanzar" OnClick="btnAvanzar_Click" runat="server"/>
</asp:Content>
