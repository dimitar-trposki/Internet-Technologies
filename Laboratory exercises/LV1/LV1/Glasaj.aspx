<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="LV1.Glasaj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            <asp:Image ID="Logo" runat="server" ImageUrl="https://upload.wikimedia.org/wikipedia/mk/6/60/%D0%9B%D0%BE%D0%B3%D0%BE-%D0%A4%D0%98%D0%9D%D0%9A%D0%98.jpg" />
        </div>
        <div>
            <asp:Label ID="Professor" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:ListBox ID="Subjects" runat="server" OnSelectedIndexChanged="Subjects_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
            <asp:ListBox ID="Credits" runat="server" AutoPostBack="True"></asp:ListBox>
        </div>
        <div>
            <asp:Button ID="Vote" runat="server" Text="Гласај" OnClick="Vote_Click" />
        </div>
        <hr />
        <div>
            Предмет:<br />
            <asp:TextBox ID="AddSubject" runat="server"></asp:TextBox> <asp:Label ID="WarningAddSubject" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            Кредити:<br />
            <asp:TextBox ID="AddCredits" runat="server"></asp:TextBox> <asp:Label ID="WarningAddCredits" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label ID="Warning" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Button ID="Add" runat="server" Text="Додади" OnClick="Add_Click" />
        </div>
        <br />
        <div>
            <asp:Button ID="Remove" runat="server" Text="Избриши" OnClick="Remove_Click" />
        </div>
    </div>
</asp:Content>
