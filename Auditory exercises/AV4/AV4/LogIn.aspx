<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="AV4.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            Име 
            <asp:TextBox ID="textName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredName" runat="server" class="text-danger" ErrorMessage="Внесете име!" ControlToValidate="textName"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            Лозинка 
            <asp:TextBox ID="textPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredPassword" runat="server" class="text-danger" ErrorMessage="Внесете лозинка!" ControlToValidate="textPassword"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            Потврдете лозинка 
            <asp:TextBox ID="textRePassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredRePassword" runat="server" class="text-danger" ErrorMessage="Повторно внесете ја вашата лозинка!" ControlToValidate="textRePassword"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="compareRePassword" runat="server" class="text-danger" ErrorMessage="Лозинките не се совпаѓаат!" ControlToValidate="textRePassword" ControlToCompare="textPassword"></asp:CompareValidator>
        </div>
        <br />
        <div>
            <asp:Button ID="buttonLogIn" runat="server" Text="Регистрирај се" OnClick="buttonLogIn_Click" />
        </div>
        <br />
        <div>
            <asp:Label ID="labelValid" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
