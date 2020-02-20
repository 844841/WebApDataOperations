<%@ Page Language = "C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webformupdate.aspx.cs" Inherits="Webappoperations.webformupdate" %>

    <asp:Content ID = "mycontent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <asp:Label runat = "server" Text="SID"></asp:Label>
            <asp:TextBox ID = "TextBox1" runat="server"></asp:TextBox>
            <asp:Label runat = "server" Text="updatedate"></asp:Label>
            <asp:TextBox ID = "TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button runat = "server" Text="Button" OnClick="Unnamed3_Click"></asp:Button>
            <asp:GridView ID = "GridView1" runat="server"></asp:GridView>
        </div>
        </asp:Content>

