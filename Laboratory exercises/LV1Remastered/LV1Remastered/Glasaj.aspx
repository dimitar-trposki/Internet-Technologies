<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="LV1Remastered.Glasaj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <asp:Image ID="imageLogo" runat="server" ImageUrl="https://upload.wikimedia.org/wikipedia/mk/6/60/%D0%9B%D0%BE%D0%B3%D0%BE-%D0%A4%D0%98%D0%9D%D0%9A%D0%98.jpg" />
        </div>
        <br />
        <div>
            <asp:Label ID="labelProf" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:ListBox ID="listSubjects" runat="server" AutoPostBack="True" OnSelectedIndexChanged="listSubjects_SelectedIndexChanged"></asp:ListBox>
            <asp:ListBox ID="listCredits" runat="server" AutoPostBack="True"></asp:ListBox><br />
            <asp:RequiredFieldValidator ID="requiredSubjectSelect" class="text-danger" runat="server" ErrorMessage="Изберете предмет" ControlToValidate="listSubjects"></asp:RequiredFieldValidator><br />
        </div>
        <br />
        <div>
            <asp:Button ID="buttonVote" runat="server" Text="Гласајте" OnClick="buttonVote_Click" />
        </div>
        <hr />
        <div>
            Предмет<br />
            <asp:TextBox ID="textSubject" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validSubject" runat="server" class="text-danger" ErrorMessage="Внесете предмет" ControlToValidate="textSubject" ValidationGroup="group2"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            Кредити<br />
            <asp:TextBox ID="textCredit" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredCredit" runat="server" class="text-danger" ErrorMessage="Внесете кредити" ControlToValidate="textCredit" ValidationGroup="group2"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexCredit" runat="server" class="text-danger" ErrorMessage="Невалидна вредност" ControlToValidate="textCredit" ValidationGroup="group2" ValidationExpression="\d+"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div>
            <asp:Button ID="buttonAdd" runat="server" Text="Додади" OnClick="buttonAdd_Click" ValidationGroup="group2" />
        </div>
        <br />
        <div>
            <asp:Button ID="buttonRemove" runat="server" Text="Избриши" OnClick="buttonRemove_Click" />
        </div>
    </div>
</asp:Content>
