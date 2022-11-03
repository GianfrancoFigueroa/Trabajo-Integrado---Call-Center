<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="Proyecto_Integrador.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<%-- Id       
     Nombre   
     Apellido 
     DNI      
     Teléfono 
     Email    
     Domicilio
    --%> 

   <p class="h3 mb-3">Clientes Call Center:</p>
                <div class="row">
                    <div class="col-6">
                        <div class="mb-3">
                            <label for="txtNroNombre" class="form-label">Nombre:</label>
                            <asp:TextBox runat="server" ID="txtNroIncidencia" CssClass="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="txtApellido" class="form-label">Apellido:</label>
                            <asp:TextBox runat="server" ID="TextApellido" CssClass="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="txtDNI" class="form-label">DNI:</label>
                            <asp:TextBox runat="server" ID="TextDNI" CssClass="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="txtTel" class="form-label">Teléfono: </label>
                             <asp:TextBox runat="server" ID="TextBox1" CssClass="form-control" />
                        </div>
                    
                        <div class="mb-3">
                            <label for="txtEmail " class="form-label">E-mail: </label>
                            <asp:TextBox runat="server" ID="TextEmail" CssClass="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="txtDomicilio" class="form-label">Domicilio: </label>
                            <asp:TextBox runat="server" ID="TextBox2" CssClass="form-control" />
                        </div>
                      
                        <div class="mb-3">
                        <button type="button" class="btn btn-success">Agregar</button>
                        <button type="button" class="btn btn-primary">Modificar</button>
                        <button type="button" class="btn btn-danger">Cancelar</button>
                            
                        </div>
                        </div>

                    </div>
                    


</asp:Content>
