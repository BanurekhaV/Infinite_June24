<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieDestination.aspx.cs" Inherits="StateManagement.CookieDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:label ID="lbldata1" runat="server" Text=""></asp:label>

            <br /><br />
            <asp:Label ID="lbldata2" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="BtnLoad" runat="server" Text="GetData" OnClick="BtnLoad_Click" />

        </div>
    </form>
</body>
</html>
