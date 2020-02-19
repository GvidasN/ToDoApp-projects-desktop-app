using _3lb_graphical_interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ToDoList todo;

        public string provider = ConfigurationManager.AppSettings["provider"];
        public string connectionString = ConfigurationManager.AppSettings["connectionString"];

        DbProviderFactory factory;
        DbConnection connection;


        private DbCommand checkDbCommand(DbConnection givenConnection, DbProviderFactory givenFactory)
        {
            if (givenConnection == null) MessageBox.Show("failed connection");

            givenConnection.ConnectionString = connectionString;
            givenConnection.Open();
            DbCommand command = givenFactory.CreateCommand();

            if (command == null) MessageBox.Show("failed command");
            return command;
        }

        private void addUsersToList(DbProviderFactory factory, DbConnection connection)
        {
            comboBUsers.Items.Clear();

            using (connection)
            {
                DbCommand command = checkDbCommand(connection, factory);
                command.Connection = connection;
                command.CommandText = "Select * From Users";
                DbDataReader dataReader = command.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        User tempUser = new User(dataReader["Username"].ToString(), dataReader["Password"].ToString(), dataReader["Email"].ToString());
                        comboBUsers.Items.Add(tempUser.getLogin());
                    }
                }
            }
        }

        private void addProjectsToList(DbProviderFactory factory, DbConnection connection)
        {
            listProjects.Items.Clear();

            using (connection)
            {
                DbCommand command = checkDbCommand(connection, factory);
                command.Connection = connection;
                command.CommandText = "Select * From Projects";
                DbDataReader dataReader = command.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        Project tempProject = new Project(dataReader["Title"].ToString(), dataReader["Created_by"].ToString());
                        listProjects.Items.Add(tempProject.ToString());
                    }
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            todo = new ToDoList();

            if (!IsPostBack)
            {
                addProjectsToList(factory, connection);
                addUsersToList(factory, connection);
            }
        }

        protected void butInfo_Click(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null) MessageBox.Show("Choose a Project");
            else
            {
                string project_title = listProjects.SelectedItem.ToString();
                MessageBox.Show(todo.getProjectInfo(project_title), "Information");
            }
        }

        protected void butEditProject_Click(object sender, EventArgs e)
        {

        }

        protected void butDeleteProject_Click(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null) MessageBox.Show("Choose a project");
            else
            {
                todo.delete(listProjects.SelectedItem.ToString(), "Title", "Projects");
                addProjectsToList(factory, connection);
            }
        }

        protected void butCreateProject_Click(object sender, EventArgs e)
        {
            if (textProjcTitle.Text != "" && comboBUsers.SelectedItem != null)
            {
                todo.createProject(textProjcTitle.Text, comboBUsers.SelectedItem.ToString());
                addProjectsToList(factory, connection);
                textProjcTitle.Text = "";
            }
        }
    }
}