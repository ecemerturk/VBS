<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"  CodeFile="BulunanVeli.aspx.cs" Inherits="BulunanVeli" %>

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
                <asp:TextBox ID="TextID" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>T.C. Kimlik Numarası:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextTC" runat="server"></asp:TextBox>
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
                <a>Veli Mail:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextMail" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Veli Mesleği:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextMeslek" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Veli Ev Telefonu:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextEvTel" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Veli İş Telefonu:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextIsTel" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Veli Cep Telefonu:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextCepTel" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Veli Sifre:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextSıfre" runat="server"></asp:TextBox>
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
<asp:Content ID="Content3" ContentPlaceHolderID="content1" runat="Server">
</asp:Content>
