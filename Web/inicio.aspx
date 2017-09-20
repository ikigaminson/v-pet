<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            height: 23px;
            width: 151px;
        }
        .auto-style3 {
            width: 151px;
        }
        .auto-style4 {
            height: 23px;
            width: 598px;
        }
        .auto-style5 {
            width: 598px;
        }
        .auto-style6 {
            margin-left: 0px;
            margin-right: 0px;
        }
        .auto-style7 {
            margin-left: 63px;
        }
        .auto-style8 {
            width: 100%;
            margin-left: 230px;
        }
        .auto-style10 {
            width: 835px;
            height: 104px;
            margin-left: 1px;
            margin-top: 66px;
        }
        .auto-style11 {
            height: 23px;
            width: 79px;
        }
        .auto-style12 {
            width: 79px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  align="center" class="auto-style10">
    <table class="auto-style8">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style4"style="font-family: 'Eight-Bit Madness'; font-size: 50px; color: #FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bienvenido a V-Pet</td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnLogin" runat="server" Font-Names="Eight-Bit Madness" Font-Size="X-Large" Text="Iniciar Sesion" style="background-image:url(imagenes/botonIngresar.png)" BorderColor="#3333FF" BorderStyle="Outset" OnClick="btnLogin_Click" CssClass="auto-style7"/>
                &nbsp;<asp:Button ID="btnReg" runat="server" Font-Names="Eight-Bit Madness" Font-Size="X-Large" Text="Registrarse" style="background-image:url(imagenes/botonIngresar.png)" BorderColor="#3333FF" BorderStyle="Outset" OnClick="btnReg_Click" CssClass="auto-style6"/>
            </td>
            <td class="auto-style12">
                
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
        </tr>
    </table>
    </div>
</asp:Content>

