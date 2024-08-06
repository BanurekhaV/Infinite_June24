<%@ Page Title="" Language="C#" MasterPageFile="~/OurLayout.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MasterpagePrj.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
     
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><br /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />

        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br /><br />

        <asp:CheckBox ID="CheckBox1" runat="server" /><br /><br />
    </form>
    
</asp:Content>
