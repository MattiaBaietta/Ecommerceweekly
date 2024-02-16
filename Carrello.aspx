<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Ecommerceweekly.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Button ID="toCart" runat="server" OnClick="CarrelloDetails_Click" class="btn btn-primary" Text="Go to Cart" />
            <asp:Button ID="toHome" runat="server" OnClick="ToHome_Click" class="btn btn-primary" Text="Go Home" />
            <asp:Repeater ID="RepeaterAcquisti" runat="server">
                <ItemTemplate>
                    <div class="row">
                        <div class="col">
                            <h5 class="card-title"><%# Eval("NomeOggetto") %></h5>
                            <p class="card-text"><%# Eval("Descrizione") %></p>
                            <p class="card-text"><%# Eval("Prezzo")+"€" %></p>

                            <asp:Button ID="RemoveFromCart" runat="server" Text="Rimuovi dal Carrello" CssClass="btn btn-success" OnClick="RemoveFromCart_Click" CommandArgument='<%# Eval("Idoggetto") %>' />
                            <asp:Button ID="RemoveAll" runat="server" Text="Svuota Carrello" CssClass="btn btn-danger" OnClick="ClearCart" />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
