<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComposeMail.aspx.cs" Inherits="Ex_MailBox.ComposeMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelToAddress" runat="server" Text="To: "></asp:Label>
        <asp:TextBox ID="TextBoxToAddress" runat="server" style="margin-left: 118px" Width="225px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelCCAddress" runat="server" Text="Cc: "></asp:Label>
        <asp:TextBox ID="TextBoxCCAddress" runat="server" style="margin-left: 116px" Width="229px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelSubject" runat="server" Text="Subject: "></asp:Label>
        <asp:TextBox ID="TextBoxSubject" runat="server" style="margin-left: 88px" Width="226px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBoxBody" runat="server" Height="238px" Width="450px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonSend" runat="server" OnClick="ButtonSend_Click" style="margin-left: 372px" Text="Send" Width="88px" />
        <br />
    
    </div>
    </form>
</body>
</html>
