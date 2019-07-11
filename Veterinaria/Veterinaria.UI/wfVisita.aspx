<%@ Page Title="" Language="C#" MasterPageFile="~/wfMasterPage.Master" AutoEventWireup="true" CodeBehind="wfVisita.aspx.cs" Inherits="Veterinaria.UI.wfVisita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
        <tr>
             <td >
                <asp:Label ID="Label6" runat="server" Text="Id Raza"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
            <td >
                <asp:Label ID="Label7" runat="server" Text="Fecha de visita"></asp:Label></td>
            <td >
                <asp:Calendar ID="ddlFecha" runat="server"></asp:Calendar></td>
        </tr>

        <tr>
            <td style="text-align:right">
                <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" /></td>
            <td style="text-align:right">
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" /></td>
            <td style="text-align:right">
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" /></td>
            <td style="text-align:right">
                <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" /></td>
        </tr>

        <tr>
            <td colspan="5" >
                <asp:GridView ID="gridview" runat="server" Width="100%" Height="100%"></asp:GridView>

            </td>
        </tr>
    </table>
</asp:Content>
