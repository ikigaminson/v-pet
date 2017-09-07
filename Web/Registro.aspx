<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .auto-style4 {
            margin-left: 305px;
            margin-right: 219px;
            margin-bottom: 2px;
            width: 663px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
            width: 195px;
        }
        .auto-style7 {
            width: 195px;
        }
        .auto-style8 {
            height: 23px;
            width: 228px;
        }
        .auto-style9 {
            width: 228px;
        }
        .auto-style10 {
            width: 195px;
            height: 26px;
        }
        .auto-style11 {
            width: 228px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
        }
        .auto-style13 {
            width: 100%;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><br /><br /><br />
    <div style="border-width: inherit; border-color: #00FFFF; border-style: groove; background-color: #FFFFFF" class="auto-style4" >
        <table style="border: medium ridge #00FFFF; font-family: 'eight-Bit Madness'; font-size: large;" class="auto-style13">
            <tr>
                <th>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registre su Cuenta</th>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;&nbsp; Nombre:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtNombreUser" runat="server" Width="217px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="valONombreUser" runat="server" ControlToValidate="txtNombreUser" ErrorMessage="(*)Debe ingresar un nombre"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;&nbsp; Usuario:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtUserid" runat="server" Width="217px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valOUsuario" runat="server" ControlToValidate="txtUserid" ErrorMessage="(*)Debe ingresar un nombre de usuario"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;&nbsp; Correo:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtCorreo" runat="server" Width="217px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valOCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="(*)Debe ingresar correo"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;&nbsp; Password:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtPass" runat="server" Width="217px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="valOPass" runat="server" ErrorMessage="(*)Debe ingresar password" ControlToValidate="txtPass"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;&nbsp; Confirme password:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtCpass" runat="server" Width="217px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style12">
                    <asp:CompareValidator ID="valPass" runat="server" ControlToCompare="txtPass" ControlToValidate="txtCpass" ErrorMessage="Las password's no coinciden"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="auto-style9">
                    <asp:CheckBox ID="chkSi" runat="server" Text="He leido y acepto los terminos y condiciones de uso"/>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="btnAgregar" runat="server" Text="Crear Cuenta" Width="224px" BackColor="#3366FF" BorderColor="#0000CC" BorderStyle="Double" Font-Names="Eight-Bit Madness" Font-Size="Large" />
                </td>
                <td>&nbsp;</td>
            </tr>
            
        </table>
    </div>
    
</asp:Content>

