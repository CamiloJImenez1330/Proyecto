<%@ Page Title="" Language="C#" MasterPageFile="~/wfMasterPage.Master" AutoEventWireup="true" CodeBehind="Raza.aspx.cs" Inherits="Veterinaria.UI.Raza" %>
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
                <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
        </tr>
    </table>
</asp:Content>
