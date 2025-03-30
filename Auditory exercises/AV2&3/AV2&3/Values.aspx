<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Values.aspx.cs" Inherits="AV2_3.Values" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            Листа на валути:
            <br />
            <asp:RadioButtonList ID="listValues" runat="server" AutoPostBack="True" OnSelectedIndexChanged="listValues_SelectedIndexChanged"></asp:RadioButtonList>
        </div>
        <br />
        <div>
            Име на валута:<br />
            <asp:TextBox ID="textName" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            Вредност на валута:<br />
            <asp:TextBox ID="textValue" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="buttonAdd" runat="server" Text="Додади" OnClick="buttonAdd_Click" />
        </div>
        <br />
        <div>
            <asp:Button ID="buttonDelete" runat="server" Text="Избриши" OnClick="buttonDelete_Click" />
        </div>
        <br />
        <div>
            Број на ставки во листата:
            <asp:Label ID="labelCounter" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            Внесете сума за конверзија:
            <asp:TextBox ID="textValueToConvert" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            Внесената сума конвертирана од
            <asp:Label ID="labelToConvert" runat="server" Text=" (избрана валута) "></asp:Label>
            во денари е:
            <asp:Label ID="labelConverted" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
