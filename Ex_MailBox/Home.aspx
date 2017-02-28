<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ex_MailBox.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 175px">
    
        <br />
        <br />
        <asp:Button ID="ButtonLogin" runat="server" Text="Login" Width="127px" />
        <asp:Button ID="ButtonCreateAccount" runat="server" style="margin-left: 346px" Text="Create Account" Width="117px" OnClick="ButtonCreateAccount_Click" />
        <br />
        <br />
        <asp:Label ID="LabelColour" runat="server" Text="Colours"></asp:Label>
        <br />
        <asp:RadioButton ID="RadioButtonRed" runat="server" Text="Red" />
        <asp:RadioButton ID="RadioButtonBlue" runat="server" Text="Blue" />
        <asp:RadioButton ID="RadioButtonGreen" runat="server" Text="Green" />
        <br />
        <br />
        <asp:RadioButton ID="RadioButtonYellow" runat="server" OnCheckedChanged="RadioButton4_CheckedChanged" Text="Yellow" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
