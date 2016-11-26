<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="keyclue._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Log out" />
</p>
    <p>
    Username:
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
</asp:Content>
