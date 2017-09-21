<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="viewPet.aspx.cs" Inherits="viewPet" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <!--  <script>
        function reloadImg() {
            d = new Date();
            $("#vPet").attr("src", "/imagenes/Pets/guileat.gif?"+d.getTime());
        }
    </script>-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <table style="width: 80%;">
        <tr>
            <td style="text-align: center"><a id="status" onserverclick="StatusPet_onClick" runat="server">
                <img style="width: 50px; height: 50px" src="imagenes/Icons/status.png" /></a></td>
            <td style="text-align: center"><a id="food" onserverclick="EatTime_onClick" runat="server">
                <img style="width: 50px; height: 50px" src="imagenes/Icons/food.png" /></a></td>
            <td style="text-align: center"><a id="poop" onserverclick="PoopTime_onClick" runat="server">
                <img style="width: 50px; height: 50px" src="imagenes/Icons/poop.png" /></a></td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">
                <img id="vPet" style="width: 200px; height: 200px" src="imagenes/Pets/guilattack.gif" runat="server" /><
                <img id="vpEat" style="width: 200px; height: 200px" src="imagenes/Pets/guileat.gif" runat="server" />
                <asp:Label ID="lblvp" runat="server" visible="false">></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <p>
    </p>
    <p>
    </p>
</asp:Content>

