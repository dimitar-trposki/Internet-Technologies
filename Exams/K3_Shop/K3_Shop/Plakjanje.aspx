<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Plakjanje.aspx.cs" Inherits="K3_Shop.Plakjanje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            <asp:ListBox ID="lstShoppingCart" runat="server"></asp:ListBox>
        </div>
        <br />
        <div>
            Вкупната цена на производите е:
            <asp:Label ID="lblTotalPrice" runat="server" Text="(вкупна цена)"></asp:Label>ден.
        </div>
    </div>
</asp:Content>
