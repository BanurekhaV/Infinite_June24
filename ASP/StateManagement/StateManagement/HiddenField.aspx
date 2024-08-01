<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="StateManagement.HiddenField" %>

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
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />

            <br />
            Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>

            <asp:HiddenField ID="HiddenField2" runat="server" />

        </div>
        <p>
            <asp:Button ID="BtnStore" runat="server" Text="Store" OnClick="BtnStore_Click"  />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnLoad" runat="server" Text="Load" OnClick="BtnLoad_Click" />

        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblmessage" runat="server" Text=" "></asp:Label>

        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
