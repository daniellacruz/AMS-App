<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AMS_App.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <label>User Name: </label>
    <asp:TextBox ID="UserLoginTextbox" runat="server"></asp:TextBox>
    <br />
    <br />
    <label>Password: </label>
    <asp:TextBox ID="UserPasswordTextbox" TextMode="Password" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="SubmitButton" Text="Submit" runat="server" OnClick="SubmitButton_Click"/>
    <asp:label id="ErrorMessage" runat="server"></asp:label>

</asp:Content>
