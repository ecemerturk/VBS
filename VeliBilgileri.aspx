<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="VeliBilgileri.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content1" Runat="Server">
    <div style="text-align:center"><h3><strong>VELİ BİLGİLERİ</strong></h3></div>
    <div>
        Adı: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <div>
        Soyadı: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>
    <div>
        Öğrencinin Okul Numarası: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </div>
    <div>
        Öğrencinin Sınıfı: <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </div>
    <div>
        Yakınlık Derecesi: <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </div>
    <div>
        Mesleği: <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </div>
    <div>
        Ev Telefonu: <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </div>
    <div>
        İş Telefonu: <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </div>
    <div>
        Cep Telefonu: <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    </div>
   
</asp:Content>

