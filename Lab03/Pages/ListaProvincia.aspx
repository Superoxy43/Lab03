<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProvincia.aspx.cs" Inherits="Lab03.Pages.ListaProvincia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <a href="CrearProvincia.aspx" class="btn btn-secundary" style="color: #0000FF; text-decoration: underline; background-color: #33CCCC">Crear Provincia</a>
    </div>

    <div class="primary-container">
        <div>
            <h2 style="color: #0033CC">Lista de Provincias</h2>
        </div>

        <asp:GridView ID="GvListaProvincias" runat="server" AutoGenerateColumns="true" CssClass="table table-striped" BackColor="#CCCCCC" EditRowStyle-BackColor="#9999FF">
        </asp:GridView>

    </div>





</asp:Content>
