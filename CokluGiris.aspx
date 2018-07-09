<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CokluGiris.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content1" runat="Server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-danger col-lg" type="submit" Text="Veli Girişi" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary col-lg" Text="Öğretmen Girişi" type="submit" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="Yetkili Girişi" CssClass="btn btn-danger col-lg" type="submit" OnClick="Button3_Click" />
    <div>

    </div>
</asp:Content>

