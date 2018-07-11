<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Yetkili.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <div class=" offset-md-3 align-content-center">
        <div class="row">
            <div class="col-sm-4">
                <a>Kişi Numarası:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>T.C. Kimlik Numarası:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-4">
                <a>Adı:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Soyadı:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Doğum Tarihi:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Kan Grubu:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>E-mail:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Telefon Numarası:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Branş:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Şifre:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-3">
                <asp:Button CssClass=" btn btn-dark" ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" />
            </div>
        </div>

    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content1" runat="Server">
</asp:Content>

