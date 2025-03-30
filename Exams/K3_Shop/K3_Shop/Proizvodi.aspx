<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proizvodi.aspx.cs" Inherits="K3_Shop.Proizvodi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Производи"></asp:Label>
        </div>
        <br />
        <div>
            Цената на производот е
            <asp:Label ID="lblPrice" runat="server" Text="(цена)"></asp:Label>ден.
        </div>
        <br />
        <div>
            <asp:ListBox ID="lstItems" runat="server" ValidationGroup="group1" AutoPostBack="True" OnSelectedIndexChanged="lstItems_SelectedIndexChanged"></asp:ListBox>
            <br />
            <asp:RequiredFieldValidator ID="reqSelectItem" runat="server" CssClass="text-danger" ErrorMessage="Изберете производ од листата!" ValidationGroup="group1" ControlToValidate="lstItems"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            <asp:Button ID="btnAdd" runat="server" Text="Додади" ValidationGroup="group1" OnClick="btnAdd_Click" />
        </div>
        <br />
        <div>
            <asp:ListBox ID="lstShoppingCart" runat="server" ValidationGroup="group2"></asp:ListBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnBuy" runat="server" Text="Купи" ValidationGroup="group2" OnClick="btnBuy_Click" />
        </div>
    </div>
</asp:Content>
