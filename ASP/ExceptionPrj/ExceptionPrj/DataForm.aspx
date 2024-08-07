<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataForm.aspx.cs" Inherits="ExceptionPrj.DataForm"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Grid1" runat="server"></asp:GridView>
            <br />
            <br />
            <asp:Label ID="lblmsg1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
