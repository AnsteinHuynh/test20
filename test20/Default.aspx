

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>


<script runat="server">
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }
</script>





<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:Button ID="LoginButton" runat="server" Height="124px" OnClick="Button1_Click1" Text="Goto LoginPage" Width="129px" />





</asp:Content>
