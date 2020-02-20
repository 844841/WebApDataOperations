<%@ Page Language="C#" MasterPageFile="~/Site.Master" CodeBehind="WebFormdata.aspx.cs" Inherits="WebApDataOperations.WebFormdata" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotran">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>