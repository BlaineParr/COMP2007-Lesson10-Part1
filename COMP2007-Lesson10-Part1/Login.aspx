<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="COMP2007_Lesson10_Part1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/Default.aspx" CreateUserText="Register" CreateUserUrl="~/Todoes/Default.aspx"></asp:Login>
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
</asp:Content>
