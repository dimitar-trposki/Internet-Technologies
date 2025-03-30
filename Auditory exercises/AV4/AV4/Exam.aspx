<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exam.aspx.cs" Inherits="AV4.Exam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            Име
            <br />
            <asp:TextBox ID="textName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredName" runat="server" class="text-danger" ErrorMessage="Внесете име!" ControlToValidate="textName" ValidationGroup="group1" Display="None"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div>
            Оценка
            <br />
            <asp:TextBox ID="textGrade" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredGrade" runat="server" class="text-danger" ErrorMessage="Внесете оценка!" ControlToValidate="textGrade" ValidationGroup="group1" Display="None"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rangeGrade" runat="server" class="text-danger" ErrorMessage="Оценката треба да биде помеѓу 5 и 10!" Type="Integer" MaximumValue="10" MinimumValue="5" ControlToValidate="textGrade" ValidationGroup="group1" Display="None"></asp:RangeValidator>
        </div>
        <br />
        <div>
            Датум
            <br />
            <asp:TextBox ID="textDate" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredDate" runat="server" class="text-danger" ErrorMessage="Внесете датум!" ControlToValidate="textDate" ValidationGroup="group1" Display="None"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="compareDate" runat="server" class="text-danger" ErrorMessage="Невалиден датум!" Operator="LessThanEqual" Type="Date" ValueToCompare="03.31.2024" ControlToValidate="textDate" ValidationGroup="group1" Display="None"></asp:CompareValidator>
        </div>
        <br />
        <div>
            Телефонски број
            <br />
            <asp:TextBox ID="textPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredPhone" runat="server" class="text-danger" ErrorMessage="Внесете телефонски број!" ControlToValidate="textPhone" ValidationGroup="group2" Display="None" CssClass="text-danger"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexPhone" runat="server" class="text-danger" ErrorMessage="Невалиден формат!" ControlToValidate="textPhone" CssClass="text-danger" ValidationExpression="07[01567]\d{6}" ValidationGroup="group2" Display="None"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div>
            Email
            <br />
            <asp:TextBox ID="textEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredEmail" runat="server" class="text-danger" ErrorMessage="Внесете email!" ControlToValidate="textEmail" ValidationGroup="group2" Display="None"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexEmail" runat="server" class="text-danger" ErrorMessage="Невалиден формат!" ControlToValidate="textEmail" CssClass="text-danger" ValidationExpression="\S+@\S+\.\S+" ValidationGroup="group2" Display="None"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div>
            <asp:Button ID="buttonValid" runat="server" Text="Валидирај" OnClick="buttonValid_Click" ValidationGroup="group1" />
        </div>
        <br />
        <div>
            <asp:Button ID="buttonValid2" runat="server" Text="Валидирај" OnClick="buttonValid_Click" ValidationGroup="group2" />
        </div>
        <br />
        <div>
            <asp:Label ID="labelValid" runat="server" class="text-success" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:ValidationSummary ID="summaryValidation" runat="server" class="text-danger" ValidationGroup="group1" />
        </div>
        <br />
        <div>
            <asp:ValidationSummary ID="summaryValidation1" runat="server" class="text-danger" ValidationGroup="group2" />
        </div>
    </div>
</asp:Content>
