<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tools.aspx.cs" Inherits="keyclue.Tools" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Logged in as:
    <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Log Out" />
</p>
<p>
    &nbsp;</p>
<p>
    <a href="tools/clocks.zip">Institute Clock Alignment Utility</a></p>
<p>
    &nbsp;</p>
<p>
    All other tools are offline for site maintenance.</p>
</asp:Content>
