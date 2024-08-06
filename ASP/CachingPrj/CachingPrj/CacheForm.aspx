<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheForm.aspx.cs" Inherits="CachingPrj.CacheForm" %>
<!--<%@ OutputCache Duration="30" VaryByParam="None" Location="ServerAndClient" %>-->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select a Product : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:DropDownList ID="dplist1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dplist1_SelectedIndexChanged">
            <asp:ListItem Text="All" Value="All"></asp:ListItem>
               <asp:ListItem Text="Laptops" Value="Laptops"></asp:ListItem>
                <asp:ListItem Text="Desktops" Value="Desktops"></asp:ListItem>
                <asp:ListItem Text="Tablets" Value="Tablets"></asp:ListItem>
                <asp:ListItem Text="Smart Phones" Value="SmartPhones"></asp:ListItem>
               </asp:DropDownList>
            <br />
            <br />


            <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>

            <p>&nbsp;</p>
            <p>
            Server Time  : 
                <asp:Label ID="lbldata" runat="server" Text="Label"></asp:Label>
            </p>
            <br />
            Client Time    :
            <script>
                document.write(Date());
            </script>
        </div>
    </form>
</body>
</html>
