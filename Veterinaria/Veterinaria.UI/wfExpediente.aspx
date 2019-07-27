<%@ Page Title="" Language="C#" MasterPageFile="~/wfMasterPage.Master" AutoEventWireup="true" CodeBehind="wfExpediente.aspx.cs" Inherits="Veterinaria.UI.wfExpediente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
             <td >
                <asp:Label ID="Label6" runat="server" Text="Id Expediente"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtIdEx" runat="server"></asp:TextBox></td>
            <td >
                <asp:Label ID="Label1" runat="server" Text="Id Mascota"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtIdMas" runat="server"></asp:TextBox></td>
            <td >
                <asp:Label ID="Label2" runat="server" Text="Id Visita"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtIdVis" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label3" runat="server" Text="Fecha de Ingreso"></asp:Label></td>
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
