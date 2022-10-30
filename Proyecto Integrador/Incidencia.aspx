<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Incidencia.aspx.cs" Inherits="Proyecto_Integrador.Incidencia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--    Id              
            NroIncidencia  
            IdCliente       
            IdEstado        
            IdPreoridad     
            IdTipoIncidencia
            IdUsuario       
            Problemática    --%>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtNroIncidencia" class="form-label">N° de Incidencia:</label>
                <asp:TextBox runat="server" ID="txtNroIncidencia" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNroIncidencia" class="form-label">N° de Cliente:</label>
                <asp:TextBox runat="server" ID="TextNtocliente" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtIdEstado" class="form-label">Estado:</label>
                <asp:TextBox runat="server" ID="TextIdEstado" CssClass="form-control" />
            </div>
            <%--<div class="mb-3">
                <label for="txtIdPreoridad " class="form-label">IdPreoridad </label>
                <asp:TextBox runat="server" ID="TextIdPreoridad " CssClass="form-control" />
            </div>--%>
            <div class="mb-3">
                <label for="txtIdPreoridad " class="form-label"> Preoridad: </label>
                <asp:TextBox runat="server" ID="TextIdPreoridad" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtIdUsuario " class="form-label">Tipo de Incidencia: </label>
                <asp:TextBox runat="server" ID="TextIdUsuario" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtProblemática" class="form-label">Problemática: </label>
                <textarea class="form-control" id="textProblemática" rows="3"></textarea>
            </div>
            <button type="button" class="btn btn-success">Agregar</button>
            <button type="button" class="btn btn-danger">Cancelar</button>

        </div>
    </div>



</asp:Content>
