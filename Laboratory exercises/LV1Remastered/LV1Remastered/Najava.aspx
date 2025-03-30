<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="LV1Remastered.Najava" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            Име <asp:TextBox ID="textName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredName" class="text-danger" runat="server" ErrorMessage="Внесете име" ControlToValidate="textName"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            Лозинка <asp:TextBox ID="textPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredPassword" class="text-danger" runat="server" ErrorMessage="Внесете лозинка" ControlToValidate="textPassword"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            Е-адреса <asp:TextBox ID="textEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredEmail" runat="server" CssClass="text-danger" ErrorMessage="Внесете email" ControlToValidate="textEmail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexEmail" class="text-danger" runat="server" ErrorMessage="Невалиден формат" ControlToValidate="textEmail" ValidationExpression="\S+@\S+.\S+"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div>
            <asp:Button ID="buttonLogIn" runat="server" Text="Најави се" OnClick="buttonLogIn_Click" />
        </div>
    </div>
</asp:Content>
