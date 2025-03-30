<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Plakjanje.aspx.cs" Inherits="AV5.Plakjanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <asp:ListBox ID="listItemsToPay" runat="server"></asp:ListBox>
        </div>
        <br />
        <div>Сума за плаќање: 
            <asp:Label ID="labelSumPrices" runat="server" Text="0"></asp:Label>
        </div>
    </div>
</asp:Content>