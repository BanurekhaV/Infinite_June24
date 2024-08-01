<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FirstWebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Button ID="btn1" runat="server"  Text="Mybutton" OnClick="btn1_Click"/>
    <br />
    <br />
    <asp:Button ID="Btn2" runat="server" Text="Button" />
    <input id="Button1" type="button" value="button"  />
</asp:Content>
