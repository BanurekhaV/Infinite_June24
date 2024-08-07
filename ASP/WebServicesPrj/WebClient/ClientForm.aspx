<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientForm.aspx.cs" Inherits="WebClient.ClientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Name : &nbsp &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID ="txtname" runat="server"></asp:TextBox>
            <br />
            Enter a Real Number :  &nbsp; &nbsp;
            <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnhello" runat="server" Text="For Hello" OnClick="btnhello_Click" />
            <asp:Button ID="btnmsg" runat="server" Text="For Message" OnClick="btnmsg_Click" />
            <asp:Button ID="btnsquare" runat="server" Text="For Square" OnClick="btnsquare_Click" />
            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
        </div>

    </form>
</body>
</html>
