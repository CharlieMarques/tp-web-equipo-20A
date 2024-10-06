<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CanjeCompletado.aspx.cs" Inherits="TPWeb_equipo_20A.CanjeCompletado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row g-2 needs-validation px-5" style="margin-left: 15%; margin-right: 15%; margin-top: 2%">
        <div class="col-md-12">
            <h1>Código canjeado</h1>
            <p>
                Su código ha sido canjeado! Revise su casilla de correo para recibir los detalles 
                del sorteo. 
            </p>
        </div>
        <div>
            <asp:Button Text="Volver al inicio" ID="btnVolver" runat="server" CssClass="btn btn-primary" style="margin:5px;" OnClick="btnVolver_Click" />
        </div>
    </div>
</asp:Content>
