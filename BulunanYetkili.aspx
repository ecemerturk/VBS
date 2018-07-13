<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BulunanYetkili.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <div class=" offset-md-3 align-content-center">
        <div class="row">
            <div class="col-sm-4">
                <a>Kişi Numarası:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextID" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>T.C. Kimlik Numarası:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextTC" runat="server" ></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-4">
                <a>Adı:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextAd" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Soyadı:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextSoyad" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Doğum Tarihi:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextDogum" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Kan Grubu:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextKan" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>E-mail:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextMail" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Telefon Numarası:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextTel" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Branş:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBrans" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <asp:Button CssClass=" btn btn-primary" ID="ButtonDuzenle" runat="server" Text="Düzenle" OnClick="ButtonDuzenle_Click"  />
                <asp:Button CssClass=" btn btn-danger" ID="ButtonSil" runat="server" Text="Sil" OnClick="ButtonSil_Click" />
            </div>
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content1" Runat="Server">
    
</asp:Content>

