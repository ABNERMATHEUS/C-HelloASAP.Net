<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Intervalo.aspx.cs" Inherits="HelloASP.NET.Intervalo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        X =<asp:TextBox ID="TextBox1" runat="server" Width="249px"></asp:TextBox>
    
    </div>
        Y =
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="gerarGerar" runat="server" Height="39px" OnClick="Button1_Click" Text="Gerar" Width="96px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
