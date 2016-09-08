<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tyontekijat.aspx.cs" Inherits="Tyontekijat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tyontekijat</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Hae" OnClick="Button1_Click"/>
        <div id="esitys">
            <h2>Tyontekijamme</h2>
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
            <asp:Label ID="lblMessages" runat="server" Text="..."></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
