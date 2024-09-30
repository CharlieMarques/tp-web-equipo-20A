<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListaArticulos.aspx.cs" Inherits="TPWeb_equipo_20A.ListaArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .card {
            height: 100%;
            display: flex;
            flex-direction: column;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Elegi tu premio</h1>
    </div>
    <div class="row row-cols-1 row-cols-md-3 g-4" style="margin: 10px; ">
        <asp:Repeater runat="server" ID="repRepetidor">
            <ItemTemplate>
                <div class="card" style="margin: 10px; max-width: 30%">
                    <div id="carousel<%# Eval("Id") %>" class="carousel slide" data-bs-ride="carousel">
                        <div class="carousel-inner">
                            <asp:Repeater runat="server" DataSource='<%# Eval("Imagenes") %>'>
                                <ItemTemplate>
                                    <div class="carousel-item <%# Container.ItemIndex == 0 ? "active" : "" %>" style="height: 400px; align-content: center" >
                                        <img src='<%# Eval("UrlImagen") %>' class="d-block img-fluid fixed-size" alt="Imagen del Articulo" />
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%# Eval("Id") %>" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Anterior</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carousel<%# Eval("Id") %>" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Siguiente</span>
                        </button>
                    </div>
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Nombre") %></h5>
                        <p class="card-text"><%# Eval("Descripcion") %></p>
                        <asp:Button Text="Seleccionar" CssClass="btn btn-primary" runat="server" ID="btnSeleccionar" CommandArgument='<%# Eval("Id") %>' CommandName="ArticuloId" OnClick="btnSeleccionar_Click"/>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>