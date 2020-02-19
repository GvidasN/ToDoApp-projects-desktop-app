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
    public partial class WebForm3 : System.Web.UI.Page
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

        private void addTasksToList(DbProviderFactory factory, DbConnection connection)
        {
            listTasks.Items.Clear();

            using (connection)
            {
                DbCommand command = checkDbCommand(connection, factory);
                command.Connection = connection;
                command.CommandText = "Select * From Tasks";
                DbDataReader dataReader = command.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        Task tempTask = new Task(dataReader["Title"].ToString(), dataReader["Project_title"].ToString(), dataReader["For_user"].ToString());
                        listTasks.Items.Add(tempTask.ToString());
                    }
                }
            }
        }

        private void addProjectsToList(DbProviderFactory factory, DbConnection connection)
        {
            comboBProjects.Items.Clear();

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
                        comboBProjects.Items.Add(tempProject.ToString());
                    }
                }
            }
        }

        private void addUsersToList(DbProviderFactory factory, DbConnection connection)
        {
            comboForUser.Items.Clear();

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
                        comboForUser.Items.Add(tempUser.getLogin());
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
                addTasksToList(factory, connection);
            }
        }

        protected void butTaskInfo_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem == null) MessageBox.Show("Choose a Task");
            else
            {
                string task_title = listTasks.SelectedItem.ToString();
                MessageBox.Show(todo.getTaskInfo(task_title), "Information");
            }
        }

        protected void butTaskDelete_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem == null) MessageBox.Show("Choose a Task");
            else
            {
                todo.delete(listTasks.SelectedItem.ToString(), "Title", "Tasks");
                addTasksToList(factory, connection);
            }
        }

        protected void butCreateTask_Click(object sender, EventArgs e)
        {
            if (textTaskTitle.Text != "" && comboBProjects.SelectedItem != null && comboForUser.SelectedItem != null)
            {
                todo.createTask(textTaskTitle.Text, comboBProjects.SelectedItem.ToString(), comboForUser.SelectedItem.ToString());
                addTasksToList(factory, connection);
                textTaskTitle.Text = "";
            }
        }
    }
}