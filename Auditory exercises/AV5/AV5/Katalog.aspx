<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Katalog.aspx.cs" Inherits="AV5.Katalog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="labelHeader" runat="server" Text="Каталог" Font-Size="XX-Large" Font-Bold="True"></asp:Label>
    </div>
    <br />
    <div>
        <asp:LinkButton ID="linkCars" runat="server" OnClick="linkCars_Click">Автомобили</asp:LinkButton>
    </div>
    <br />
    <div>
        <asp:LinkButton ID="linkBooks" runat="server" OnClick="linkBooks_Click">Книги</asp:LinkButton>
    </div>
    <br />
    <div>
        <asp:LinkButton ID="linkLaptops" runat="server" OnClick="linkLaptops_Click">Лаптопи</asp:LinkButton>
    </div>
</asp:Content>