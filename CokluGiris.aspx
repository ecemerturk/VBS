<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CokluGiris.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content1" runat="Server">
    <asp:Button ID="Button1" runat="server" Text="Veli Girişi" OnClick="Button1_Click"/>
    <asp:Button ID="Button2" runat="server" Text="Öğretmen Girişi" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="Yetkili Girişi" OnClick="Button3_Click" />
</asp:Content>

