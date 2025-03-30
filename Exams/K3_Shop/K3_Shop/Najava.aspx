<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="K3_Shop.Najava" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            Корисничко име
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqName" runat="server" CssClass="text-danger" ErrorMessage="Внесете корисничко име" ControlToValidate="txtName"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            Лозинка
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqPassword" runat="server" CssClass="text-danger" ErrorMessage="Внесете лозинка" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            Email
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqEmail" runat="server" CssClass="text-danger" ErrorMessage="Внесете email" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexEmail" runat="server" CssClass="text-danger" ErrorMessage="Невалиден email" ControlToValidate="txtEmail" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div>
            <asp:Button ID="btnLogIn" runat="server" Text="Најави се" OnClick="btnLogIn_Click" />
        </div>
    </div>
</asp:Content>