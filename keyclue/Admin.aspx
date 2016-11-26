<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="keyclue.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 66px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" Text="Log Out" 
            ViewStateMode="Enabled" />
    </p>
    <table class="style2">
        <tr>
            <td class="style3">
                Zoo</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" ViewStateMode="Enabled"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Geo</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" ViewStateMode="Enabled"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Mech</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" ViewStateMode="Enabled"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Chem</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" ViewStateMode="Enabled"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Civil</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" ViewStateMode="Enabled"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
