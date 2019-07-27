<%@ Page Title="" Language="C#" MasterPageFile="~/wfMasterPage.Master" AutoEventWireup="true" CodeBehind="wfMascota.aspx.cs" Inherits="Veterinaria.UI.wfMascota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
             <td >
                <asp:Label ID="Label6" runat="server" Text="Id Mascota"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
            <td >
                <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
            
            <td >
                <asp:Label ID="Label1" runat="server" Text="Edad"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox></td>
            <td >
                <asp:Label ID="Label2" runat="server" Text="Peso" ></asp:Label></td>
            <td >
                <asp:TextBox ID="txtPeso" runat="server" type="number"></asp:TextBox></td>
          
            
            
        </tr>
        <tr>
              <td >
                <asp:Label ID="Label4" runat="server" Text="Color"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtColor" runat="server"></asp:TextBox></td>
            <td >
                <asp:Label ID="Label5" runat="server" Text="Dueno"></asp:Label></td>
            <td ><asp:DropDownList ID="ddlDueno" runat="server">
                </asp:DropDownList></td>
            <td >
                <asp:Label ID="Label7" runat="server" Text="Raza"></asp:Label></td>
            <td ><asp:DropDownList ID="ddlRaza" runat="server">
                </asp:DropDownList></td>
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
