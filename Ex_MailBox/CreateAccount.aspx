<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="Ex_MailBox.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelEmailAdd" runat="server" Text="Email Address: "></asp:Label>
        <asp:TextBox ID="TextBoxEmailAdd" runat="server" style="margin-left: 30px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelName" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server" style="margin-left: 80px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelAddress" runat="server" Text="Address: "></asp:Label>
        <asp:TextBox ID="TextBoxAddress" runat="server" style="margin-left: 67px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelPassword" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="TextBoxPassword" runat="server" style="margin-left: 61px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelReenterPass" runat="server" Text="Re-enter Password: "></asp:Label>
        <asp:TextBox ID="TextBoxReenterPass" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelSecQuest" runat="server" Text="Security Question: "></asp:Label>
        <asp:TextBox ID="TextBoxSecQuest" runat="server" style="margin-left: 10px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelSecAns" runat="server" Text="Security Answer: "></asp:Label>
        <asp:TextBox ID="TextBoxSecAns" runat="server" style="margin-left: 19px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonCreateAccount" runat="server" OnClick="ButtonCreateAccount_Click" style="margin-left: 51px" Text="Create Account" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
