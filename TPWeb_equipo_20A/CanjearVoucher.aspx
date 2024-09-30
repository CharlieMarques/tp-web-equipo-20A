<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CanjearVoucher.aspx.cs" Inherits="TPWeb_equipo_20A.CanjearVoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Canjea tu voucher</h1>
    <div class="mb-3", style="margin:10%; margin-left:25%; margin-right:25%">
        <label for="txtVoucher" style="margin:5px;">Valida tu voucher</label>
        <asp:TextBox runat="server" CssClass="form-control" style="margin:5px;" ID="txtVoucher" placeholder="Ingresa el codigo de tu voucher"></asp:TextBox>
        <asp:Button Text="Avanzar" CssClass="btn btn-primary" style="margin:5px;" ID="btnAvanzar" OnClick="btnAvanzar_Click" runat="server"></asp:Button>
    </div>
</asp:Content>