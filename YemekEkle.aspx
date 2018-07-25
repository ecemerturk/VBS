<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="YemekEkle.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <br />
    <br />
    <br />
    <div class=" offset-md-3 align-content-center">
        <div class="row">
            <div class="col-sm-4">
                <a>Ana Yemek:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtYemek" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Yan Yemek:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtYanYemek" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-4">
                <a>Salata:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtSalata" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a>Tatlı:</a>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtTatli" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-3">
                <asp:Button CssClass=" btn btn-dark" ID="Kaydet" runat="server" Text="Kaydet" OnClick="Kaydet_Click" />
            </div>
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content1" Runat="Server">
</asp:Content>

