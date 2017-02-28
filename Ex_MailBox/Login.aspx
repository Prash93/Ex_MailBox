<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ex_MailBox.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelEmail" runat="server" Text="Email:"></asp:Label> 
        <asp:TextBox ID="TextBoxEmail" runat="server" style="margin-left: 78px" Width="217px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBoxPassword" runat="server" style="margin-left: 53px" Width="217px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="CheckBoxRemMyPass" runat="server" Text="Remember My Password" />
        <br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButtonForgMyPass" runat="server">Forgot My Password</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonLogIn" runat="server" OnClick="ButtonLogIn_Click" Text="Log In" Width="89px" />
    </div>
    </form>
</body>
</html>
