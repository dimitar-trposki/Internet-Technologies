<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CinemaSite.aspx.cs" Inherits="K2_CinemaVeles.CinemaSite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            Корисничко име:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredName" runat="server" CssClass="text-danger" ErrorMessage="Внесете корисничко име" ControlToValidate="txtName" ValidationGroup="grpLogIn"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexName" runat="server" CssClass="text-danger" ErrorMessage="Невалидно корисничко име" ControlToValidate="txtName" ValidationGroup="grpLogIn" ValidationExpression=".*[!^\!].*"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div>
            Лозинка:
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredPassword" runat="server" CssClass="text-danger" ErrorMessage="Внесете лозинка" ControlToValidate="txtPassword" ValidationGroup="grpLogIn"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredEmail" runat="server" CssClass="text-danger" ErrorMessage="Внесете email" ControlToValidate="txtEmail" ValidationGroup="grpLogIn"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexEmail" runat="server" CssClass="text-danger" ErrorMessage="Невалидна email адреса" ControlToValidate="txtEmail" ValidationExpression="\S+@\S+.\S+" ValidationGroup="grpLogIn"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div>
            <asp:Button ID="btnLogIn" runat="server" Text="Најави се" ValidationGroup="grpLogIn" OnClick="btnLogIn_Click" />
        </div>
        <br />
        <asp:Panel ID="pnlShow" runat="server" Visible="False">
            <br />
            <div>
                <asp:Image ID="imgLogo" runat="server" Visible="True" ImageUrl="https://img.freepik.com/premium-vector/movie-cinema-premiere-background_41737-251.jpg" />
            </div>
            <br />
            <div>
                <asp:ListBox ID="lstGenres" runat="server" Visible="True" AutoPostBack="True" OnSelectedIndexChanged="lstGenres_SelectedIndexChanged" CausesValidation="True" ValidationGroup="grpBuy"></asp:ListBox>
            </div>
            <br />
            <div style="display: inline-block">
                <asp:CheckBoxList ID="chkMovies" runat="server" Visible="True" OnSelectedIndexChanged="chkMovies_SelectedIndexChanged" ValidationGroup="grpBuy" AutoPostBack="True" CausesValidation="True"></asp:CheckBoxList>
            </div>
            <div style="display: inline-block">
                <asp:Panel ID="pnlTexts" runat="server">
                    <asp:TextBox ID="txtNum1" runat="server" Visible="True" AutoPostBack="True" CausesValidation="True" OnTextChanged="txtNum1_TextChanged" ValidationGroup="grpBuy"></asp:TextBox><br />
                    <asp:TextBox ID="txtNum2" runat="server" Visible="True" ValidationGroup="grpBuy" CausesValidation="True" OnTextChanged="txtNum2_TextChanged" AutoPostBack="True"></asp:TextBox><br />
                    <asp:TextBox ID="txtNum3" runat="server" Visible="True" ValidationGroup="grpBuy" CausesValidation="True" OnTextChanged="txtNum3_TextChanged" AutoPostBack="True"></asp:TextBox><br />
                </asp:Panel>
            </div>
            <div style="display: inline-block; height: 73px;">
                <asp:RequiredFieldValidator ID="requiredNum1" runat="server" CssClass="text-danger" ErrorMessage="Внесете број на билети" Enabled="False" ControlToValidate="txtNum1" ValidationGroup="grpBuy"></asp:RequiredFieldValidator><br />
                <asp:RequiredFieldValidator ID="requiredNum2" runat="server" CssClass="text-danger" ErrorMessage="Внесете број на билети" Enabled="False" ControlToValidate="txtNum2" ValidationGroup="grpBuy"></asp:RequiredFieldValidator><br />
                <asp:RequiredFieldValidator ID="requiredNum3" runat="server" CssClass="text-danger" ErrorMessage="Внесете број на билети" Enabled="False" ControlToValidate="txtNum3" ValidationGroup="grpBuy"></asp:RequiredFieldValidator><br />
            </div>
            <br />
            <br />
            <div>
                <asp:Button ID="btnBuy" runat="server" Text="Купи" Visible="True" OnClick="btnBuy_Click" Enabled="False" ValidationGroup="grpBuy" />
            </div>
            <br />
            <div>
                Вкупната цена изнесува
                <asp:Label ID="lblPrice" runat="server" Text="(цена на билети)"></asp:Label>
                МКД
            </div>
        </asp:Panel>
    </div>
</asp:Content>
