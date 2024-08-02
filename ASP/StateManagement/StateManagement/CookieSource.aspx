<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieSource.aspx.cs" Inherits="StateManagement.QuerySource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="lbllogin" runat="server" Text="Login"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:TextBox ID="txtlogin" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <br />
            <br />
             <br />
             <asp:Button ID="BtnRedirect" runat="server" Text="Redirect" OnClick="BtnRedirect_Click"  />
        </div>
    </form>
</body>
</html>
