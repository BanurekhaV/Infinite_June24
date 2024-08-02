<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="StateManagement.ViewState" %>

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
            <asp:Button ID="BtnStore" runat="server" Text="Store" OnClick="BtnStore_Click"  />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnLoad" runat="server" Text="Load" OnClick="BtnLoad_Click" />

            <br />
            <br />
            <asp:Label ID="lblmessage" runat="server" Text=" "></asp:Label>

        </div>
    </form>
</body>
</html>
