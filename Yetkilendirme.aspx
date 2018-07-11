<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Yetkilendirme.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content1" runat="Server">
    <div class="container">
        <asp:Button ID="Button1" CssClass="btn btn-danger" type="submit" runat="server" Text="Yetkili" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="btn btn-primary" type="submit" runat="server" Text="Öğretmen" OnClick="Button2_Click" />
    </div>

</asp:Content>

