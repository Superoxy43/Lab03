<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProvincia.aspx.cs" Inherits="Lab03.Pages.EditarProvincia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar provincia</h2>

    <div>

        <div>
            <span>ID</span>
            <asp:TextBox ID="TxtidProvincia" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div>
            <span>Provincia</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span>Estado</span>
            <asp:TextBox ID="TxtEstado" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="BtnModificar" runat="server" Text="GUARDAR" CssClass="btn btn-primary" OnClick="BtnModificar_Click" />

            <asp:Button ID="BtnEliminar" runat="server" Text="ELIMINAR" CssClass="btn btn-primary" OnClick="BtnEliminar_Click" />
        </div>

        <div>
            <a href="ListaProvincia.aspx" class="btn btn-primary">Cancelar</a>
        </div>





    </div>


</asp:Content>
