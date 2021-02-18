<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SortedTable.aspx.cs" Inherits="AMS_App.SortedTable" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Repeater ID="rptDataTable" runat="server">
        <HeaderTemplate>
            <table class="table">
                <thead class="table-head">
                    <tr>
                        <th scope="col">Building Name</th>
                        <th scope="col">Floor Number</th>
                        <th scope="col">Room Number</th>
                        <th scope="col">Room Name</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("Building Name") %></td>
                <td><%# Eval("Floor Number") %></td>
                <td><%# Eval("Room Number") %></td>
                <td><%# Eval("Room Name") %></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>


</asp:Content>
