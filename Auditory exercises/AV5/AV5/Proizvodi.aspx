<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proizvodi.aspx.cs" Inherits="AV5.Proizvodi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="labelHeader" runat="server" Text="(наслов)" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
    </div>
    <br />
    <div>
        Производи<br />
        <asp:ListBox ID="listObjects" runat="server" OnSelectedIndexChanged="listObjects_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
        <br />
        Цени<br />
        <asp:ListBox ID="listPrices" runat="server" AutoPostBack="True"></asp:ListBox>
    </div>
    <br />
    <div>
        Вкупно избрани ставки: 
        <asp:Label ID="labelTotal" runat="server" Text="0"></asp:Label>
    </div>
    <br />
    <div>
        <asp:LinkButton ID="linkKatalog" runat="server" OnClick="linkKatalog_Click">Каталог</asp:LinkButton>
    </div>
    <br />
    <div>
        <asp:Button ID="buttonAdd" runat="server" Text="Додади" OnClick="buttonAdd_Click" />
    </div>
    <br />
    <div>
        <asp:ListBox ID="listAddedObjects" runat="server"></asp:ListBox>
    </div>
    <br />
    <div>
        <asp:Button ID="buttonPay" runat="server" Text="Плати" OnClick="buttonPay_Click" />
    </div>
</asp:Content>
