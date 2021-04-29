<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" BackColor="#FF6666" BorderColor="Black" Text="OnlineCalculator"></asp:Label>
        <p>
            <asp:TextBox ID="operand1" runat="server" TextMode="Number">0</asp:TextBox>
            <asp:DropDownList ID="OperDropDown" runat="server">
                <asp:ListItem Value="plus">+</asp:ListItem>
                <asp:ListItem Value="minus">-</asp:ListItem>
                <asp:ListItem Value="multiply">*</asp:ListItem>
                <asp:ListItem Value="divide">/</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="operand2" runat="server" TextMode="Number">0</asp:TextBox>
            <asp:Button ID="Calculate" runat="server" OnClick="Calculate_Click" Text="Calculate" />
        </p>
    </form>
</body>
</html>
