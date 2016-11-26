<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="keyclue.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Welcome to NIHILISM!
    <br />
    Due to site maintenance our main page is down. We apologize for the inconvenience.
    <br />
    Please login or come back at a later time.
    </p>
    <br />
    <p>
    Username
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
<p>
    Password
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Log In" />
</p>
</asp:Content>
