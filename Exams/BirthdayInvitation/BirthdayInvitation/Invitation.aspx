<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Invitation.aspx.cs" Inherits="BirthdayInvitation.Invitation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            Изберете боја на позадина<br />
            <asp:DropDownList ID="dropBgColor" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div>
            Изберете фонт<br />
            <asp:DropDownList ID="dropFontStyle" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div>
            Изберете боја на фонт<br />
            <asp:DropDownList ID="dropFontColor" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div>
            Внесете големина на фонт<br />
            <asp:TextBox ID="textFontSize" runat="server" EnableViewState="True"></asp:TextBox>pt
            <br />
            <asp:RegularExpressionValidator ID="regexFontSize" runat="server" class="text-danger" ErrorMessage="Внесете број" ControlToValidate="textFontSize" ValidationExpression="\d+"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div>
            Тип на рамка<br />
            <asp:RadioButtonList ID="listBorderStyle" runat="server"></asp:RadioButtonList> <br />
            <asp:RequiredFieldValidator ID="requiredBorder" runat="server" CssClass="text-danger" ErrorMessage="Изберете рамка" ControlToValidate="listBorderStyle"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            <asp:CheckBox ID="checkImage" runat="server" />
            Додади слика
        </div>
        <br />
        <div>
            Внесете ја содржината на честитката<br />
            <asp:TextBox ID="textWish" runat="server" Height="133px" TextMode="MultiLine" Width="330px"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="requiredText" runat="server" ErrorMessage="Внесете ја роденденската порака" class="text-danger" ControlToValidate="textWish"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            <asp:Button ID="buttonCreate" runat="server" Text="Креирај" OnClick="buttonCreate_Click" />
        </div>
        <br />
        <div>
            <asp:Panel ID="panelWish" runat="server">
                <asp:Label ID="labelWish" class="" runat="server" Text=""></asp:Label>
                <br />
                <asp:Image ID="imageToShow" runat="server" ImageUrl="https://parade.com/.image/t_share/MjAzMzU3NzQxMzU4NTIzOTgz/happy-birthday-wishes-messages.jpg" Visible="False" />
            </asp:Panel>
        </div>
    </div>
</asp:Content>
