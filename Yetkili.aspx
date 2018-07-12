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
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="offset-sm-2">
        <div class="row">
            <div class="col-sm-2">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" >
                    <asp:ListItem>Sistem Numarası</asp:ListItem>
                    <asp:ListItem>Tc Kimlik Numarası</asp:ListItem>
                    <asp:ListItem>İsim</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="TextBox11" runat="server" ToolTip="% kullanarak 0 veya daha çok içerme durumunu ekler, _ tek karakteri belirtir"></asp:TextBox>
            </div>
            <div class="col-sm-1">
                <asp:Button ID="Button2" runat="server" Text="Ara" OnClick="Button2_Click" />
            </div>
            <div class="col-sm-3">
                <asp:GridView ID="GridView1"  runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal"  >
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="Button3" runat="server" Text="Görüntüle"  OnClick="Button3_Click" CommandName="Görüntüle" CommandArgument='<%#Bind("KISI_ID")%>'/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />

                </asp:GridView>
            </div>
        </div>

    </div>
    <asp:ObjectDataSource 
        ID="mySource" 
        runat="server"
        SelectMethod="Select" 
        UpdateMethod="Update" 
        TypeName="MyCompany.CustomDataSource" />
    <br /><br /><br />
</asp:Content>

