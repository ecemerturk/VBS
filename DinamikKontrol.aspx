<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DinamikKontrol.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="font-family: Arial">
    <table>
    <tr>
        <td><b>Control Type</b></td>
        <td>
            <asp:CheckBoxList ID="chkBoxListControlType" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Label" Value="Label"></asp:ListItem>
                <asp:ListItem Text="TextBox" Value="TextBox"></asp:ListItem>
                <asp:ListItem Text="Button" Value="Button"></asp:ListItem>
            </asp:CheckBoxList>
        </td>
        <td><b>How Many</b></td>
        <td>
            <asp:TextBox ID="txtControlsCount" runat="server" Width="40px"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnGenerateControl" runat="server" Text="Generate Controls" 
                onclick="btnGenerateControl_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="5">
            <h3>Label Kontrolleri</h3>
        </td>
    </tr>
    <tr>
        <td colspan="5" id="tdLabel" runat="server">
            <asp:Panel ID="pnlPanel" runat="server">
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="5">
            <h3>TextBox Kontrolleri</h3>
        </td>
    </tr>
    <tr>
        <td colspan="5" id="tdTextBoxes" runat="server">
            <asp:Panel ID="pnlTextBoxes" runat="server">
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="5">
            <h3>Button Kontrolleri</h3>
        </td>
    </tr>
    <tr>
        <td colspan="5" id="tdButtons" runat="server">
            <asp:Panel ID="pnlButtons" runat="server">
            </asp:Panel>
        </td>
    </tr>
    </table>        
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content1" Runat="Server">
</asp:Content>

