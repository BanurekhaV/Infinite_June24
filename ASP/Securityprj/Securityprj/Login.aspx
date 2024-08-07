<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Securityprj.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login Name  :&nbsp; <asp:TextBox ID="txtlogin" runat="server"></asp:TextBox>
            <br /><br/>
            Password   : &nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
          <br /><br/>
            <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" />
               <br /><br/>
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
       </div>
    </form>
</body>
</html>
