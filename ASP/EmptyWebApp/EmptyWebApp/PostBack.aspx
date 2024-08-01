<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBack.aspx.cs" Inherits="EmptyWebApp.PostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtcount" runat="server"></asp:TextBox>
            <br />
            <br/>
            <asp:Button ID="BtnCount" runat="server" Text="Count" OnClick="BtnCount_Click" />
        </div>
    </form>
</body>
</html>
