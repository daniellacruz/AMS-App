<%@ Page Title="Form Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AMS_App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Create a New Room</h1>
        <p class="lead"> Please add Building, Room Name and Number, Floor Number, and People Information </p>
    </div>

    <div class="row">
      <div class ="form-horizontal">
               <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Building</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox ID="buildingTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="buildingTextBox"
                                CssClass="text-danger" ErrorMessage="The building is required." />
                        </div>
                    </div>
           <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Room Name</asp:Label>
                        <div class="col-md-10">
                             <asp:TextBox ID="roomNameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="roomNameTextBox"
                                CssClass="text-danger" ErrorMessage="The room name is required." />
                        </div>
                    </div>
           <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Room Number</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox ID="roomNumberTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="roomNumberTextBox"
                                CssClass="text-danger" ErrorMessage="The room number is required." />
                        </div>
                    </div>

           <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Floor Number</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox ID="floorNumberTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="floorNumberTextBox"
                                CssClass="text-danger" ErrorMessage="The floor number is required." />
                        </div>
                    </div>
            <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">First Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox ID="firstNameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="firstNameTextBox"
                                CssClass="text-danger" ErrorMessage="The first name is required." />
                        </div>
                    </div>
            <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Last Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox ID="lastNameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="lastNameTextBox"
                                CssClass="text-danger" ErrorMessage="The last name is required." />
                        </div>
                    </div>
        <br />
      

               <asp:Button  ID="submit" CssClass="btn btn-default" Text="Submit" runat="server" OnClick="submit_Click"/>
       
      </div>
        <br />
         <p>
                <a class="btn btn-default" href="SortedTable.aspx">View Facility Layout &raquo;</a>
            </p>
    </div>

</asp:Content>
