<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearProvincia.aspx.cs" Inherits="Lab03.Pages.CrearProvincia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>CREAR PROVINCIA</h2>

    <div>

        <div>
            <span>Provincia</span>
            <asp:TextBox ID="TxtProvincia" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div style="table-layout: fixed">
            <asp:Button ID="BtnAgregar" runat="server"
                Text="GUARDAR"
                ForeColor="White" CssClass="btn btn-primary"
                OnClick="BtnAgregar_Click" BorderColor="#0066FF" />

            <div>
                <a href="ListaProvincia.aspx" class="btn btn-secundary" style="border-style: ridge; color: #3399FF; ">Cancelar</a>
            </div>
        </div>

    </div>



</asp:Content>
