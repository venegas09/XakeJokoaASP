<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Irekierak.aspx.vb" Inherits="XakeJokoaASP.Irekierak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background:black url('../resources/irekierak.jpg') no-repeat center top; height: 364px;">
     <br />
     <br />
     <br />
    <form id="form1" runat="server">
        <center>
        <asp:Panel ID="pPanel" runat="server" BackColor="#FFFF80" BorderColor="Black" BorderStyle="Solid" Font-Bold="False" Height="219px" Width="521px">
            <br />
            <br />
            <br />
            AUKERATU NAHI DUZUN IREKITZEA:<br />
            <br />
            <asp:DropDownList ID="listIrekierak" runat="server" Height="16px" Width="367px">
            </asp:DropDownList>
                <asp:Button ID="btnJarraitu" runat="server" Text="JARRAITU" />

            <br />
            <br />
            <br />
            <asp:Button ID="btnHasiera" runat="server" Text="Hasierara bueltatu" />

        </asp:Panel>

        </center>
    </form>
</body>
</html>
