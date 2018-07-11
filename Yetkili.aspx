<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Yetkili.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content1" runat="Server">
    <div class="container">
        <div>
            Kişi Numarası:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            T.C. Kimlik Numarası:
            <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        </div>
        <div>
            Adı:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <div>
            Soyadı:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <div>
            Doğum Tarihi:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </div>
        <div>
            Kan Grubu:
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </div>
        <div>
            E-mail:
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </div>
        <div>
            Telefon Numarası:
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </div>
        <div>
            Branş:
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </div>
        <div>
            Şifre:
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </div>
        <asp:Button CssClass=" btn btn-dark" ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" />
    </div>
</asp:Content>

