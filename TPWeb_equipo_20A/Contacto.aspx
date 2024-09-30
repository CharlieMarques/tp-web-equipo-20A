<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="TPWeb_equipo_20A.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row g-2 needs-validation px-5" style="margin: 10%">
        <div class="col-md-6">
            <label for="validationCustom01" class="form-label">Nombre</label>
            <input type="text" class="form-control" id="validationCustom01" value="John" required>
            <div class="valid-feedback">
                Looks good!
            </div>
        </div>
        <div class="col-md-6">
            <label for="validationCustom02" class="form-label">Apellido</label>
            <input type="text" class="form-control" id="validationCustom02" value="Doe" required>
            <div class="valid-feedback">
                Looks good!
            </div>
        </div>
        <div class="col-md-6">
            <label for="validationCustom03" class="form-label">Ciudad</label>
            <input type="text" class="form-control" id="validationCustom03" required>
            <div class="invalid-feedback">
                Ingrese una ciudad.
            </div>
        </div>
        <div class="col-md-3">
            <label for="validationCustom04" class="form-label">Provincia</label>
            <input type="text" class="form-control" id="validationCustom04" required>
            <div class="invalid-feedback">
                Ingrese una provincia.
            </div>
        </div>
        <div class="col-md-3">
            <label for="validationCustom05" class="form-label">Código Postal</label>
            <input type="text" class="form-control" id="validationCustom05" required>
            <div id="validationServer03Feedback" class="invalid-feedback">
                Ingrese un código postal.
            </div>
        </div>
        <div class="col-md-6">
            <label for="validationCustom06" class="form-label">Dirección</label>
            <input type="text" class="form-control" id="validationCustom06" required>
            <div id="validationServer04Feedback" class="invalid-feedback">
                Ingrese una dirección.
            </div>
        </div>
        <div class="col-md-1">
            <label for="validationCustom07" class="form-label">Piso</label>
            <input type="text" class="form-control" id="validationCustom07">
        </div>
        <div class="col-md-1">
            <label for="validationCustom06" class="form-label">Número</label>
            <input type="text" class="form-control" id="validationCustom08">
        </div>

        <div class="col-12">
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="" id="invalidCheck" required>
                <label class="form-check-label" for="invalidCheck">
                    Acepto los términos y condiciones
                </label>
                <div class="invalid-feedback">
                    Debes acceder a los términos y condiciones antes de continuar.
                </div>
            </div>
        </div>
        <div class="col-12">
            <button class="btn btn-primary" type="submit">Participar</button>
        </div>
    </div>
</asp:Content>
