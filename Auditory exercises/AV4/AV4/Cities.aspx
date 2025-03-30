<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cities.aspx.cs" Inherits="AV4.Cities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            <asp:DropDownList ID="listCities" runat="server">
                <asp:ListItem>-град-</asp:ListItem>
                <asp:ListItem>Битола</asp:ListItem>
                <asp:ListItem>Скопје</asp:ListItem>
                <asp:ListItem>Охрид</asp:ListItem>
                <asp:ListItem>Струга</asp:ListItem>
                <asp:ListItem Value="Прилеп"></asp:ListItem>
            </asp:DropDownList> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="text-danger" ErrorMessage="Изберете град!" ControlToValidate="listCities" InitialValue="-град-"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            <asp:Button ID="buttonLogIn" runat="server" Text="Регистрирај се" OnClick="buttonLogIn_Click" />
        </div>
        <br />
        <div>
            <asp:Label ID="labelValid" runat="server" CssClass="text-success" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>