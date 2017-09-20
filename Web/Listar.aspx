<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Listar.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <table style="width: 100%;" id="algo">
        <tr>
            <td class="auto-style1" id="1"></td>
            <td class="auto-style1" id="2"></td>
            <td class="auto-style1" id="3"></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:GridView ID="gdvUsuario" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnSelectedIndexChanged="gdvUsuario_SelectedIndexChanged" AutoGenerateSelectButton="True">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
                <br />
                <asp:label id="lblMsg" runat="server" Font-Names="Eight-Bit Madness" ForeColor="White"></asp:label>
                <br />
                <br />
                <asp:button id="btnModificar" runat="server" onclick="btnModificar_Click" text="Modificar Datos" style="background-image: url(imagenes/botonIngresar.png)" bordercolor="#3333FF" borderstyle="Outset" font-bold="False" font-names="Eight-Bit Madness" font-size="Medium" />
                <asp:button id="btnEliminar" runat="server" onclick="btnEliminar_Click" text="Eliminar Usuario" style="background-image: url(imagenes/botonIngresar.png)" bordercolor="#3333FF" borderstyle="Outset" font-bold="False" font-names="Eight-Bit Madness" font-size="Medium" />
                <br />
                <br />
            </td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:button id="btnVolver" runat="server" onclick="btnVolver_Click" text="Volver al Login" style="background-image: url(imagenes/botonIngresar.png)" bordercolor="#3333FF" borderstyle="Outset" font-bold="False" font-names="Eight-Bit Madness" font-size="Large" />
            </td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
    </table>
</asp:Content>



