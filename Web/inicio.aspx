<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inicio.aspx.cs" Inherits="inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="css/Style.css" />
    <title></title>
</head>
<body>
    <!--To make a responsive site, I should do a div version of the form-->
    <div id="div_form">
        <form id="form1" runat="server" action="">
            <!-- action debería mandar a auth.aspx-->
            <table border="0">
                <tr>
                    <td colspan="2">
                        <img src="imagenes/logo.png" /></td>
                </tr>
                <tr>
                    <td>User</td>
                    <td>
                        <asp:TextBox ID="txtUsuario" runat="server" required></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" required></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td id="btnSend">
                        <asp:Button ID="btnIngresar" runat="server" Text="Login" />
                    </td>
                </tr>
            </table>
        </form>
        <p>Not player yet? <a href="Registro.aspx">Register!</a></p>

    </div>

</body>
</html>
