<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedirectVsTransfer.aspx.cs" Inherits="CachingPrj.RedirectVsTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name : &nbsp;&nbsp;<asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
            <br />
            Email : &nbsp;&nbsp; <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnGetData" runat="server" Text="GetPage" OnClick="btnGetData_Click" />

        </div>
    </form>
</body>
</html>
