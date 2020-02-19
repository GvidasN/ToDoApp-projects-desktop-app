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
    public partial class WebForm1 : System.Web.UI.Page
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

        /*private void addTasksToList(DbProviderFactory factory, DbConnection connection)
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
        }*/

        /*private void addProjectsToList(DbProviderFactory factory, DbConnection connection)
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
        */
        private void addUsersToList(DbProviderFactory factory, DbConnection connection)
        {
            listUsers.Items.Clear();

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
                    }
                }
            }
        }

        private void refreshLists()
        {
            addUsersToList(factory, connection);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            todo = new ToDoList();

            

            if (!IsPostBack)
            {
                refreshLists();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null) MessageBox.Show("Choose a User");
            else
            {
                todo.delete(listUsers.SelectedItem.ToString(), "Username", "Users");
                refreshLists();
            }
        }

        protected void butCreate_Click(object sender, EventArgs e)
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
                else
                {
                    MessageBox.Show("Please fill all of the blocks");
                    return;
                }
            }
            if (tempUser != null)
            {

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

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textEmail.Enabled = true;
            textTitle.Enabled = true;
            textUsername.Enabled = true;
            textPassword.Enabled = true;
            butCreateUser.Enabled = true;
            textSurname.Enabled = false;
            textName.Enabled = false;
        }

        protected void butInfo_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null) MessageBox.Show("Choose a User");
            else MessageBox.Show(todo.getUserInfo(listUsers.SelectedItem.ToString()), "Information");
        }

        protected void butEditUser_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null) MessageBox.Show("Choose a User");
            else
            {
                EditForm editForm = new EditForm(listUsers.SelectedItem.ToString());
                editForm.Show();
                refreshLists();
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textEmail.Enabled = true;
            textName.Enabled = true;
            textSurname.Enabled = true;
            textUsername.Enabled = true;
            textPassword.Enabled = true;
            butCreateUser.Enabled = true;
            textTitle.Enabled = false;
        }

    }
}