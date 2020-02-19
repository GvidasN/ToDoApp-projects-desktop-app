<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
        <br />
        <asp:ListBox ID="listTasks" runat="server" Height="255px" Width="365px"></asp:ListBox>
        <br />
        <div class="buttons">
            <asp:Button ID="butTaskInfo" runat="server" Text="Task information" Height="24px" Width="126px" OnClick="butTaskInfo_Click"/>
            <asp:Button ID="butTaskDelete" runat="server" Text="Delete task" Height="24px" Width="127px" OnClick="butTaskDelete_Click"/>
        </div>
        <br />
        <br />
        <div class="UserCreation">
            <div>
                <asp:Label ID="labTitle" runat="server" Text="Title"></asp:Label>
                <br />
                <asp:TextBox ID="textTaskTitle" runat="server"></asp:TextBox>
                <br />
            </div>
            <div>
                <asp:Label ID="labUserID" runat="server" Text="User"></asp:Label>
                <br />                
                <asp:DropDownList ID="comboForUser" runat="server">
                </asp:DropDownList>               
                <br />
            </div>
      </div>
            <br />
            <div>
                <asp:Label ID="labProjectID" runat="server" Text="Project"></asp:Label>
                <br />                
                <asp:DropDownList ID="comboBProjects" runat="server">
                </asp:DropDownList>
                
                <br />
            </div>
         <br />
            <asp:Button ID="butCreateTask" runat="server" Text="Add Task" Height="24px" Width="116px" OnClick="butCreateTask_Click"/>
            <br />
            <br />
        <div class="navigation">
            <asp:Button ID="butProjectsTab" runat="server" Text="Projects -&gt;" Height="24px" Width="116px" PostBackUrl="~/WebForm2.aspx"/>
            <asp:Button ID="butUsersTab" runat="server" Text="Users -&gt;" Height="24px" Width="116px" PostBackUrl="~/WebForm1.aspx"/>
        </div> 
        </div>
    </form>
</body>
</html>
