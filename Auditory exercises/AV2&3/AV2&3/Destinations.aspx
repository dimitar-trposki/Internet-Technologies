<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Destinations.aspx.cs" Inherits="AV2_3.Destinations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container text-center">
        <div>
            <asp:ListBox ID="listDestinations" runat="server" OnSelectedIndexChanged="listDestinations_SelectedIndexChanged" SelectionMode="Multiple">
                <asp:ListItem Value="0км">Скопје</asp:ListItem>
                <asp:ListItem Value="200км">Битола</asp:ListItem>
                <asp:ListItem Value="160км">Прилеп</asp:ListItem>
                <asp:ListItem Value="220км">Охрид</asp:ListItem>
                <asp:ListItem Value="200км">Гевгелија</asp:ListItem>
            </asp:ListBox>
        </div>
        <br />
        <div>
            <asp:Button ID="buttonShowName" runat="server" Text="Прикажи" OnClick="buttonShowName_Click" />
        </div>
        <br />
        <div>
            Селектираните градови се:
            <asp:Label ID="labelShowName" runat="server" Text="(изберете град)"></asp:Label><br />
            Со нивните оддалечености од Скопје соодветно: 
            <asp:Label ID="labelDistance" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
