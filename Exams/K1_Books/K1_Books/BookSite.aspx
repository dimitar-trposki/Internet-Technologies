<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookSite.aspx.cs" Inherits="K1_Books.BookSite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            Индекс во листата:
            <asp:TextBox ID="textIndex" runat="server" Width="93px"></asp:TextBox>
            <asp:Button ID="buttonDelete" runat="server" Text="Избришете ставка" OnClick="buttonDelete_Click" />
        </div>
        <br />
        <div>
            Наслов
            <br />
            <asp:ListBox ID="listBooks" runat="server" AutoPostBack="True"></asp:ListBox>
        </div>
        <br />
        <div>
            Цена
            <br />
            <asp:ListBox ID="listPrices" runat="server" AutoPostBack="True"></asp:ListBox>
        </div>
    </div>
</asp:Content>
