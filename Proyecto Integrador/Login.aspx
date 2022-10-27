<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto_Integrador.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<div class="jumbotron">
    <h1>LOGIN</h1>
    <div>

    <p>
        <asp:TextBox ID="TxTName" runat="server"></asp:TextBox>
     </p>
        
     <p>
         <asp:TextBox ID="TxTPass" runat="server"></asp:TextBox>  
      </p>

        <asp:Button ID="Button1" runat="server" Text="Ingresar" />

   

    </div>

    


</div>
    
</asp:Content>

