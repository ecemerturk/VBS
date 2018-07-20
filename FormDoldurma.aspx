<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FormDoldurma.aspx.cs" Inherits="FormDoldurma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <div class=" offset-md-3 align-content-center">
        <div class="row">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList>
        </div>
        <div class="row">
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True"></asp:DropDownList>
        </div>
        <div class="row">
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True"></asp:DropDownList>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content1" runat="Server">
</asp:Content>
