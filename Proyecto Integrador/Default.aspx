<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_Integrador._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




<div class="mx-auto" style="width: 200px;"> 

          <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Email address</label>
            <asp:TextBox ID="TxtEmail" TextMode="Email"  class="form-control" runat="server"></asp:TextBox>
            <div id="emailHelp" class="form-text"></div>
          </div>
          <div class="mb-3">
            <label for="exampleInputPassword1" class="form-label">Password</label>
              <asp:TextBox ID="TxtPass" TextMode="Password" class="form-control" runat="server"></asp:TextBox>
          </div>
             <asp:Button ID="BtnIngreso" OnClick="BtnIngreso_Click" runat="server" Text="Ingresar" />
          
</div>

</asp:Content>
