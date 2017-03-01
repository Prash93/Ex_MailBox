<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ex_MailBox.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #RadioRed {
            width: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 457px">
    
        <br />
        <asp:Button ID="ButtonLogin" runat="server" Text="Login" Width="127px" OnClick="ButtonLogin_Click" />
        <asp:Button ID="ButtonCreateAccount" runat="server" style="margin-left: 346px" Text="Create Account" Width="117px" OnClick="ButtonCreateAccount_Click" />
        <br />
        <br />
        <asp:Label ID="LabelColour" runat="server" Text="Colours"></asp:Label>
        <br />
        <asp:RadioButton ID="RadioButtonRed" runat="server" Text="Red" />
        <asp:RadioButton ID="RadioButtonBlue" runat="server" Text="Blue"  />
        <asp:RadioButton ID="RadioButtonGreen" runat="server" Text="Green"  />
        <asp:RadioButton ID="RadioButtonYellow" runat="server" Text="Yellow"  />
        <br />
        <br />
        <asp:Button ID="ButtonRed" runat="server" OnClick="ButtonRed_Click" Text="Red" Width="63px" />
        <asp:Button ID="ButtonBlue" runat="server" OnClick="ButtonBlue_Click" style="margin-left: 32px" Text="Blue" Width="62px" />
        <asp:Button ID="ButtonGreen" runat="server" OnClick="ButtonGreen_Click" style="margin-left: 40px" Text="Green" />
        <asp:Button ID="ButtonYellow" runat="server" OnClick="ButtonYellow_Click" style="height: 26px; margin-left: 54px" Text="Yellow" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
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
