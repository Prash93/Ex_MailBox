<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inbox.aspx.cs" Inherits="Ex_MailBox.Inbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="ButtonCompose" runat="server" OnClick="ButtonCompose_Click" Text="Compose" Width="110px" />
        <asp:Button ID="ButtonAddressBook" runat="server" style="margin-left: 373px" Text="Address Book" Width="114px" />
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonDelete" runat="server" Text="Delete" />
        <asp:Label ID="LabelFrom" runat="server" Text="From"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Subject"></asp:Label>
        <asp:Label ID="LabelDate" runat="server" Text="Date"></asp:Label>
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
