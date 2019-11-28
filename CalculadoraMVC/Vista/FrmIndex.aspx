<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmIndex.aspx.cs" Inherits="CalculadoraMVC.Vista.FrmIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUno" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtDos" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtTres" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Button ID="btnSumar" runat="server" Text="Suma" OnClick="btnSumar_Click" />
            <asp:Button ID="btnResta" runat="server" Text="Resta" OnClick="btnResta_Click" />
            <asp:Button ID="btnMulti" runat="server" Text="Multiplicación" OnClick="btnMulti_Click" />
            <asp:Button ID="btnDivi" runat="server" Text="Division" OnClick="btnDivi_Click" />
        </div>
    </form>
</body>
</html>
