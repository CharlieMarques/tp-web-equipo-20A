<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CanjearVoucher.aspx.cs" Inherits="TPWeb_equipo_20A.CanjearVoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mb-3", style="margin-top:2%; margin-left:20%; margin-right:20%">
        <h1>Canjea tu voucher</h1>
        <label for="txtVoucher" style="margin:5px;">Valida tu voucher:</label>
        <asp:TextBox runat="server" CssClass="form-control" style="margin:5px;" ID="txtVoucher" placeholder="Ingresa el codigo"></asp:TextBox>
        <asp:Button Text="Avanzar" CssClass="btn btn-primary" style="margin:5px;" ID="btnAvanzar" OnClick="btnAvanzar_Click" runat="server"></asp:Button>
    </div>
</asp:Content>