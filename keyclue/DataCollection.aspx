<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataCollection.aspx.cs" Inherits="keyclue.DataCollection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 108px;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Logged in as:
        <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Log Out" />
    </p>
    <p>
        &nbsp;</p>
    <table class="style2">
        <tr>
            <td class="style3">
                Date</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                2012-11-03</td>
            <td>
                <a href="DataCollection.aspx?file=20121103.zip">Download data packet</a></td>
        </tr>
        <tr>
            <td class="style3">
                2012-11-26</td>
            <td>
                <a href="DataCollection.aspx?file=20121126.zip">Download data packet</a></td>
        </tr>
        <tr>
            <td class="style3">
                2012-12-21</td>
            <td>
                <a href="DataCollection.aspx?file=20121221.zip">Download data packet</a></td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label2" runat="server" Text="2013-01-03"></asp:Label>
            </td>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Download data packet</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style3">
                2013-01-08</td>
            <td>
                <a href="DataCollection.aspx?file=20130108.zip">Download data packet</a></td>
        </tr>
    </table>
</asp:Content>
