<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="LV1.Najava" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            Име
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <asp:Label ID="NameWarning" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            Лозинка
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="PasswordWarning" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            е-адреса
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <asp:Label ID="EmailWarning" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Button ID="LogIn" runat="server" Text="Најавете се" OnClick="LogIn_Click1" />
        </div>
    </div>
</asp:Content>
