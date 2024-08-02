<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondSession.aspx.cs" Inherits="StateManagement.SecondSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtngetSession" runat="server" Text="Get Session Details" OnClick="BtngetSession_Click" />
            <br /><br />
            <asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
