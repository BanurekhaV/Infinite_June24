<%@ Page Title="" Language="C#" MasterPageFile="~/OurLayout.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterpagePrj.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" ID="frm1">
        <h1 style="background-color:aqua;color:forestgreen;">This is our First Content Page</h1>
        <br />
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnclick" runat="server" Text="My Button 1" OnClick="btnclick_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn2" runat="server" Text="My Button 2" OnClick="btn2_Click" />
    </form>


</asp:Content>
