<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Ecommerceweekly.Homepage" %>

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
            <asp:Button ID="CarrelloHome" runat="server" OnClick="CarrelloHome_Click" Text="Visualizza Carrello" />
            <div class="row" id="rigacard" runat="server">


                <asp:Repeater ID="RepeaterArticoli" runat="server">
                    <ItemTemplate>
                        <div class="col-4">
                            <div class="card" style="width: 18rem;">
                                <img class="card-img-top" style="width: 200px;" src='<%# Eval("UrlImmagine") %>' alt="Card image cap" />
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("NomeOggetto") %></h5>
                                    <p class="card-text"><%# Eval("Descrizione") %></p>
                                    <p class="card-text"><%# Eval("Prezzo")+"€" %></p>
                                    <a href='<%# "Dettagli.aspx/" + Eval("Idoggetto") %>' class="btn btn-primary">Dettagli</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
