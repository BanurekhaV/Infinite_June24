<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryDestination.aspx.cs" Inherits="StateManagement.QueryDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbldata" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="BtnLoad" runat="server" Text="GetData" OnClick="BtnLoad_Click" />
        </div>
    </form>
</body>
</html>
