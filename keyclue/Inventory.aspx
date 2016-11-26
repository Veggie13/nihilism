<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="keyclue.Inventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style2
    {
        width: 100%;
    }
    .style3
    {
        width: 348px;
    }
    .style4
    {
        width: 348px;
        font-weight: bold;
    }
    .style5
    {
        width: 423px;
    }
</style>
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
<table class="style2">
    <tr>
        <td class="style4">
            Item</td>
        <td class="style5">
            <b>Status</b></td>
        <td>
            <b>Code</b></td>
    </tr>
    <tr>
        <td class="style3">
            Decombobulator</td>
        <td class="style5">
            Available</td>
        <td>
            OOXJM
            DEC_152-23-56</td>
    </tr>
    <tr>
        <td class="style3">
            Tachyon Slowifier</td>
        <td class="style5">
            Repairs</td>
        <td>
            PWCNN
            TAC_089-08-99</td>
    </tr>
    <tr>
        <td class="style3">
            Digital Graphite Rod</td>
        <td class="style5">
            In Use</td>
        <td>
            BJLEU
            GRA_809-34-58</td>
    </tr>
    <tr>
        <td class="style3">
            H.N. Personal Effects</td>
        <td class="style5">
            Available</td>
        <td>
            CH&amp;FH
            CPL_687-86-24</td>
    </tr>
    <tr>
        <td class="style3">
            Software Toolkit</td>
        <td class="style5">
            On Loan</td>
        <td>
            NZSDF
            SWT_809-36-45</td>
    </tr>
    <tr>
        <td class="style3">
            Digging Supplies</td>
        <td class="style5">
            On Loan</td>
        <td>
            PQAGH
            DIG_835-34-65</td>
    </tr>
    <tr>
        <td class="style3">
            Extra Clocks</td>
        <td class="style5">
            Available</td>
        <td>
            LFMJN
            CLK_245-23-78</td>
    </tr>
    <tr>
        <td class="style3">
            Screwdrivers (sonic)</td>
        <td class="style5">
            In Use</td>
        <td>
            LDDKA
            SON_675-32-42</td>
    </tr>
    <tr>
        <td class="style3">
            Electronic Repair Kit</td>
        <td class="style5">
            Repairs</td>
        <td>
            JFUIW
            ELE_435-78-12</td>
    </tr>
</table>
</asp:Content>
