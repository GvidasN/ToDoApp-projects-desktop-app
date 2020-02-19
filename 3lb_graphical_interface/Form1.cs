using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;

namespace _3lb_graphical_interface
{
    public partial class Form1 : Form
    {      
        ToDoList todo;
        
        string provider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

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
                        listTasks.Items.Add(tempTask);
                    }
                }
            }
        }

        private void addProjectsToList(DbProviderFactory factory, DbConnection connection)
        {
            listProjects.Items.Clear();
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
                        listProjects.Items.Add(tempProject);
                        comboBProjects.Items.Add(tempProject);
                    }
                }
            }
        }

        private void addUsersToList(DbProviderFactory factory, DbConnection connection)
        {
            listUsers.Items.Clear();
            comboBUsers.Items.Clear();
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
                        listUsers.Items.Add(tempUser.getLogin());
                        comboBUsers.Items.Add(tempUser.getLogin());
                        comboForUser.Items.Add(tempUser.getLogin());
                    }
                }
            }
        }

        private void refreshLists()
        {
            addUsersToList(factory, connection);
            addProjectsToList(factory, connection);
            addTasksToList(factory, connection);
        }

        public Form1()
        {        
            InitializeComponent();

            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            todo = new ToDoList();

            refreshLists();
        }

        private void radioPrivate_CheckedChanged(object sender, EventArgs e)
        {
            textEmail.Enabled = true;
            textName.Enabled = true;
            textSurname.Enabled = true;
            textUsername.Enabled = true;
            textPassword.Enabled = true;
            butCreateUser.Enabled = true;
            textTitle.Enabled = false;
        }

        private void radCompany_CheckedChanged(object sender, EventArgs e)
        {
            textEmail.Enabled = true;
            textTitle.Enabled = true;
            textUsername.Enabled = true;
            textPassword.Enabled = true;
            butCreateUser.Enabled = true;
            textSurname.Enabled = false;
            textName.Enabled = false;
        }

        private void butCreateUser_Click(object sender, EventArgs e)
        {
            User tempUser;

            if (radCompany.Checked == true)
            {
                if (textUsername.Text != "" && textPassword.Text != "" && textTitle.Text != "" && textEmail.Text != "")
                {
                    tempUser = todo.registerCompany(textUsername.Text, textPassword.Text, textTitle.Text, textEmail.Text);
                }
                else
                {
                    MessageBox.Show("Please fill all of the blocks");
                    return;
                }                
            }
            else
            {
                if (textUsername.Text != "" && textPassword.Text != "" && textName.Text != "" && textSurname.Text != "" && textEmail.Text != "")
                {
                    tempUser = todo.registerPerson(textUsername.Text, textPassword.Text, textName.Text, textSurname.Text, textEmail.Text);
                }
                else {
                    MessageBox.Show("Please fill all of the blocks");
                    return;
                }
            }
            if (tempUser != null) {
                
                refreshLists();
                MessageBox.Show("New User added!");
            }
            textEmail.Text = "";
            textTitle.Text = "";
            textUsername.Text = "";
            textPassword.Text = "";
            textSurname.Text = "";
            textName.Text = "";
        }

        private void butEditUser_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null) MessageBox.Show("Choose a User");
            else
            {
                EditForm editForm = new EditForm(listUsers.SelectedItem.ToString());
                editForm.Show();
                refreshLists();
            }     
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null) MessageBox.Show("Choose a User");
            else
            {
                todo.delete(listUsers.SelectedItem.ToString(),"Username", "Users");
                refreshLists();
            }     
        }

        private void butInfo_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null) MessageBox.Show("Choose a User");
            else MessageBox.Show(todo.getUserInfo(listUsers.SelectedItem.ToString()), "Information");
        }

        private void butCreateNewProject_Click(object sender, EventArgs e)
        {
            if (textProjcTitle.Text != "" && comboBUsers.SelectedItem != null)
            {
                todo.createProject(textProjcTitle.Text, comboBUsers.SelectedItem.ToString());
                refreshLists();
                textProjcTitle.Text = "";
            }
        }

        private void butProjectInformation_Click(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null) MessageBox.Show("Choose a Project");
            else {

                string project_title = listProjects.SelectedItem.ToString();
                MessageBox.Show(todo.getProjectInfo(project_title), "Information");
            }       
        }

        private void butEditProject_Click(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null) MessageBox.Show("Choose a Project");
            else
            {
                EditProjectForm editForm = new EditProjectForm(listProjects.SelectedItem.ToString(), comboBUsers);
                editForm.Show();
                refreshLists();
            }
        }

        private void butDeleteProject_Click(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null) MessageBox.Show("Choose a project");
            else
            {
                todo.delete(listProjects.SelectedItem.ToString(), "Title", "Projects");
                refreshLists();
            }
        }

        private void butCreateTask_Click(object sender, EventArgs e)
        {
            if (textTaskTitle.Text != "" && comboBProjects.SelectedItem != null && comboForUser.SelectedItem != null)
            {
                todo.createTask(textTaskTitle.Text, comboBProjects.SelectedItem.ToString(), comboForUser.SelectedItem.ToString());
                refreshLists();
                textTaskTitle.Text = "";
            }
        }

        private void butTaskInfo_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem == null) MessageBox.Show("Choose a Task");
            else
            {
                string task_title = listTasks.SelectedItem.ToString();
                MessageBox.Show(todo.getTaskInfo(task_title), "Information");
            }
        }

        private void butTaskDelete_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem == null) MessageBox.Show("Choose a Task");
            else
            {
                todo.delete(listTasks.SelectedItem.ToString(), "Title", "Tasks");
                refreshLists();
            }
        }
    }
}
