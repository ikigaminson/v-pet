<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 452px;
        }
        .auto-style3 {
            height: 547px;
        }
        .auto-style4 {
            width: 39%;
            height: 404px;
        }
        .auto-style6 {
            width: 67px;
            margin-left: 308px;
            margin-top: 0px;
            margin-bottom: 0px;
        }
    </style>
</head>
<body style="height: 565px; background-image: url('imagenes/fondo1.jpg'); background-repeat: no-repeat; background-attachment: fixed; margin-bottom: 2px;" >
    <form id="form1" runat="server">
    <div align="center" class="auto-style3">
        <br />
        <br />
        <br />
        <br />
        <br />
        <table style="margin-left: 145px; font-size: 26px; margin-right: 0px; margin-top: 0px; margin-bottom: 0px;" class="auto-style4">
            <tr>
                <td class="auto-style1"><img src="imagenes/logo.png" style="margin-left: 0px"/></td>
            </tr>
            <tr>
                <td style="font-family: 'eight-Bit Madness'; font-size: 26px; color: #FFFFFF;" class="auto-style1">
                    <br />
                    Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtUsuario" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-family: 'eight-Bit Madness'; color: #FFFFFF;" class="auto-style1">
                    <br />
                    Password:&nbsp;&nbsp;
                    <asp:TextBox ID="txtPass" runat="server" Width="243px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-family: 'eight-Bit Madness'; color: #FFFFFF;" class="auto-style1">
                    <br />
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" style="background-image:url(imagenes/botonIngresar.png); background-repeat:no-repeat" BorderColor="#3333FF" BorderStyle="Outset" Font-Bold="False" Font-Names="Eight-Bit Madness" Font-Size="Large" Height="42px" Width="78px" OnClick="btnIngresar_Click" />
                </td>
            </tr>
            <tr>
                <td align="left" style="font-family: 'eight-Bit Madness'; color: #FFFFFF;" class="auto-style1">
                    
                    <a href="Registro.aspx" style="color:yellow" align="right"><h5 class="auto-style6">Registrate</h5></a>
                </td>
                
            </tr>
            <tr>
                <td align="left" style="font-family: 'eight-Bit Madness'; color: #FFFFFF;" class="auto-style1">
                    
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td>
                
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
