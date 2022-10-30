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
    
    <table>
        <tr> <%-- es una fila --%>
            <td> <%-- columna dentro de la fila --%>
                <p class="h3 mb-3">Cargar Incidencias Call Center:</p>
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
                            <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="mb-3">
                            <label for="txtComentario" class="form-label">Comentario: </label>
                            <textarea class="form-control" id="textComentario" rows="2"></textarea>
                        </div>
                    
                        <div class="mb-3">
                            <label for="txtIdPreoridad " class="form-label">Preoridad: </label>
                            <asp:DropDownList ID="ddlPreoridad" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="mb-3">
                            <label for="txtIdUsuario " class="form-label">Tipo de Incidencia: </label>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="mb-3">
                            <label for="txtProblemática" class="form-label">Problemática: </label>
                            <textarea class="form-control" id="textProblemática" rows="5"></textarea>
                        </div>
                        <button type="button" class="btn btn-success">Agregar</button>
                        <button type="button" class="btn btn-primary">Modificar</button>
                        <button type="button" class="btn btn-danger">Cancelar</button>

                    </div>
                </div>
            </td>
        </tr>
    </table>




</asp:Content>
