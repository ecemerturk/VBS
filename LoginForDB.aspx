<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginForDB.aspx.cs" Inherits="LoginForDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title></title>
</head>
<body class="bg-light">
    <script src="js/bootstrap.min.js"></script>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="font/css/open-iconic.min.css" rel="stylesheet" />
    <link href="font/css/open-iconic.css" rel="stylesheet" />
    <link href="font/css/open-iconic-bootstrap.min.css" rel="stylesheet" />
    <br />
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container ">
            <div class=" offset-sm-4 col-sm-4">
                <div class="">
                    
                </div>
                <asp:Label ID="Label1" runat="server" Text="">
                <div class=" form-group">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" placeholder="Email" required=""></asp:TextBox>
                        <div class=" input-group-append">
                            <span class="input-group-text" style="width: 40px"><i class=" oi  oi-person"></i></span>
                        </div>
                    </div>
                </div>
                </asp:Label>
                <div class=" form-group">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="Şifre" required="" TextMode="Password"></asp:TextBox>
                        <div class=" input-group-append">
                            <span class="input-group-text" style="width: 40px"><i class=" oi oi-lock-locked"></i></span>
                        </div>
                    </div>
                </div>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Label" Style="color: white" class="custom-checkbox">
                        <input id="Checkbox1" type="checkbox" value=" " />
                    </asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Label">Beni Hatırla</asp:Label>
                </div>
                <div>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş" CssClass="btn btn-primary btn-lg btn-block" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
