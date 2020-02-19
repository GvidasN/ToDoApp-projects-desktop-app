<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <br />
        <asp:ListBox ID="listProjects" runat="server" Height="255px" Width="365px"></asp:ListBox>
        <br />
        <div class="buttons">
            <asp:Button ID="butProjectInformation" runat="server" Text="Project information" Height="24px" Width="126px" OnClick="butInfo_Click"/>
            <asp:Button ID="butEditProject" runat="server" Text="Edit project" Height="24px" Width="110px" OnClick="butEditProject_Click"/>
            <asp:Button ID="butDeleteProject" runat="server" Text="Delete project" Height="24px" Width="127px" OnClick="butDeleteProject_Click"/>
        </div>
        <br />
        <br />
        <div class="UserCreation">
            <div>
                <asp:Label ID="labTitle" runat="server" Text="Title"></asp:Label>
                <br />
                <asp:TextBox ID="textProjcTitle" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>
                <asp:Label ID="labUserID" runat="server" Text="User"></asp:Label>
                <br />                
                <asp:DropDownList ID="comboBUsers" runat="server">
                </asp:DropDownList>
                
                <br />
            </div>
      </div>
         <br />
            <asp:Button ID="butCreateProject" runat="server" Text="Add Project" Height="24px" Width="116px" OnClick="butCreateProject_Click"/>
            <br />
            <br />
        <div class="navigation">
            <asp:Button ID="butUsersTab" runat="server" Text="Users -&gt;" Height="24px" Width="116px" PostBackUrl="~/WebForm1.aspx" />
            <asp:Button ID="butTasksTab" runat="server" Text="Tasks -&gt;" Height="24px" Width="116px" PostBackUrl="~/WebForm3.aspx"/>
        </div> 
        </div>
    </form>
</body>
</html>
