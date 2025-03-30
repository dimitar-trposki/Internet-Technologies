<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ImageTest.aspx.cs" Inherits="AV2_3.ImageTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvXDiDtwm_fK1V-p54ctnUqE6qsnYxBUDp098IN9Hfkw&s" />
        </div>
        <br />
        <div>Координати на клик: 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://i.pinimg.com/564x/b1/75/1d/b1751d1f45c23038d57cf67b990c211f.jpg" OnClick="ImageButton1_Click" />
        <br />
        <div>
        </div>
    </div>
</asp:Content>