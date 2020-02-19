<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="listUsers" runat="server" Height="255px" Width="365px"></asp:ListBox>
        <br />
        <br />
        <div class="buttons">
            <asp:Button ID="butInfo" runat="server" Text="User information" Height="24px" Width="116px" OnClick="butInfo_Click"/>
            <asp:Button ID="butEditUser" runat="server" Text="Edit user information" Height="24px" Width="131px" OnClick="butEditUser_Click"/>
            <asp:Button ID="butDeleteUser" runat="server" Text="Delete User" Height="24px" Width="96px" OnClick="Button3_Click"/>
        </div>
        <br />
        <br />
        <div>
            <asp:RadioButton ID="radioPrivate" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Private" AutoPostBack="True" GroupName="User" />
            <br />
            <asp:RadioButton ID="radCompany" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Company" AutoPostBack="True" GroupName="User" />
        </div>
        <br />
        <br />
        <div class="UserCreation">
            <div>
                <asp:Label ID="labUsername" runat="server" Text="Username"></asp:Label>
                <br />
                <asp:TextBox ID="textUsername" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="labPassword" runat="server" Text="Password"></asp:Label>
                <br />
                <asp:TextBox ID="textPassword" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="labEmail" runat="server" Text="Email"></asp:Label>
                <br />
                <asp:TextBox ID="textEmail" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="labName" runat="server" Text="Name"></asp:Label>
                <br />
                <asp:TextBox ID="textName" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="labSurname" runat="server" Text="Surname"></asp:Label>
                <br />
                <asp:TextBox ID="textSurname" runat="server" Enabled="False"></asp:TextBox>
                <br />
            </div>
            <div>
                <asp:Label ID="labTitle" runat="server" Text="Title"></asp:Label>
                <br />
                <asp:TextBox ID="textTitle" runat="server" Enabled="False"></asp:TextBox>
                <br />
            </div>
      </div>
         <br />
            <asp:Button ID="butCreateUser" runat="server" Text="Add User" Height="24px" Width="116px" OnClick="butCreate_Click"/>
            <br />
         <br />
        <div class="navigation">
            <asp:Button ID="butProjectsTab" runat="server" Text="Projects -&gt;" Height="24px" Width="116px" PostBackUrl="~/WebForm2.aspx"/>
            <asp:Button ID="butTasksTab" runat="server" Text="Tasks -&gt;" Height="24px" Width="116px" PostBackUrl="~/WebForm3.aspx"/>
        </div> 
    </form>
</body>
</html>
