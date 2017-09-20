<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CrearPet.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 195px;
            height: 19px;
        }
        .auto-style2 {
            width: 195px;
            height: 24px;
        }
        .auto-style3 {
            height: 24px;
        }
        .auto-style4 {
            width: 195px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            height: 19px;
        }
        .auto-style7 {
            height: 24px;
            width: 294px;
        }
        .auto-style8 {
            height: 26px;
            width: 294px;
        }
        .auto-style9 {
            height: 19px;
            width: 294px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="background-color: #FFFFFF">
    <table style="border-color: #00FFFF; border-style: outset; width:100%;">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style7"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style4" style="font-family: 'Eight-Bit Madness'">&nbsp; Nombre de V-pet:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtNombre" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                </td>
        </tr>
        <tr>
            <td class="auto-style1" style="font-family: 'eight-Bit Madness'">&nbsp; Tipo:</td>
            <td class="auto-style9" >
               
                <asp:DropDownList ID="ddlTipo" runat="server" Font-Names="Eight-Bit Madness" Font-Size="Medium">
                    <asp:ListItem>Seleccione</asp:ListItem>
                    <asp:ListItem>Virus</asp:ListItem>
                    <asp:ListItem>Vacuna</asp:ListItem>
                    <asp:ListItem>Dato</asp:ListItem>
                </asp:DropDownList>
               
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style9">
                 <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" Font-Names="Eight-Bit Madness" BorderColor="#3333FF" BorderStyle="Outset" Font-Size="Large" Height="34px" Width="79px" style="background-image:url(imagenes/botonIngresar.png); background-repeat:no-repeat"/></td>
            <td class="auto-style6"><a ID="lblError" name="lblError" runat="server">Error D:</a><td>
        </tr>
    </table></div>
</asp:Content>

