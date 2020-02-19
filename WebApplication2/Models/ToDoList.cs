using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;

namespace _3lb_graphical_interface
{
    class ToDoList
    {
        string provider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        DbProviderFactory factory;
        DbConnection connection;

        private bool checkIfExistInDB(string title, string columnName, string database)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();

            List<string> foundvalues = new List<string>();

            using (connection)
            {
                DbCommand command = checkDbCommand(connection, factory);
                command.Connection = connection;
                command.CommandText = "SELECT * FROM " + database + " WHERE " + columnName + "=" + "'" + title + "'";
                DbDataReader dataReader = command.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read()) foundvalues.Add((dataReader[columnName].ToString()));
                }
            }
            if (foundvalues.Count > 0) return true;
            else return false;
        }

        private DbCommand checkDbCommand (DbConnection givenConnection, DbProviderFactory givenFactory)
        {
            if (givenConnection == null) MessageBox.Show("failed connection");

            givenConnection.ConnectionString = connectionString;
            givenConnection.Open();
            DbCommand command = givenFactory.CreateCommand();

            if (command == null) MessageBox.Show("failed command");
            return command;
        }


        public Person registerPerson(String login, String password, String name, String surname, String email)
        {
            if (!checkIfExistInDB(login, "Username", "Users"))
            {
                Person newPerson = new Person(login, password, name, surname, email);
                factory = DbProviderFactories.GetFactory(provider);
                connection = factory.CreateConnection();

                using (connection)
                {
                    DbCommand command = checkDbCommand(connection, factory);

                    command.Connection = connection;
                    //command.CommandText = "DELETE FROM Users";
                    command.CommandText = "INSERT INTO Users (Username, Password, Email, Name, Surname) VALUES ('" + newPerson.getLogin()
                                          + "', '" + password + "', '" + email + "', '" + name + "', '" + surname + "')";

                    DbDataReader dataReader = command.ExecuteReader();
                }
                return newPerson;
            }
            else
            {
                MessageBox.Show("User with such username already exists");
                return null;
            }                    
        }

        public Company registerCompany(String login, String password, String title, String email)
        {      
            if (!checkIfExistInDB(login, "Username", "Users"))
            {
                Company newCompany = new Company(login, password, email, title);
                factory = DbProviderFactories.GetFactory(provider);
                connection = factory.CreateConnection();

                using (connection)
                {
                    DbCommand command = checkDbCommand(connection, factory);

                    command.Connection = connection;

                    command.CommandText = "INSERT INTO Users (Username, Password, Email, Title) VALUES ('" + login
                                          + "', '" + password + "', '" + email + "', '" + title + "')";

                    DbDataReader dataReader = command.ExecuteReader();
                }
                return newCompany;
            } 
            else
            {
                MessageBox.Show("User with such username already exists");
                return null;
            }           
        }

        public void delete(string toDelete, string columnName, string database)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();

            using (connection)
            {

                DbCommand command = checkDbCommand(connection, factory);
                command.Connection = connection;
                if(database == "Projects")
                {
                    command.CommandText = "DELETE FROM " + database + " WHERE " + columnName + "='" + toDelete + "'";
                    command.CommandText += "DELETE FROM Tasks WHERE Project_title = '" + toDelete + "'"; 
                }
                else
                {
                    command.CommandText = "DELETE FROM " + database + " WHERE " + columnName + "='" + toDelete + "'";
                }
                
                DbDataReader dataReader = command.ExecuteReader();
            }
            MessageBox.Show("Deleted");
        }

        public string getUserInfo(string username)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            string info = "";

            using (connection)
            {
                DbCommand command = checkDbCommand(connection, factory);
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Users WHERE Username='" + username + "'";
                DbDataReader dataReader = command.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        info += "Username = " + dataReader["Username"].ToString() + '\n';
                        info += "Password = " + dataReader["Password"].ToString() + '\n';
                        info += "Email = " + dataReader["Email"].ToString() + '\n';
                    } 
                }
            }
            return info;
        }

        public Project createProject (string title, string creator)
        {
            if (!checkIfExistInDB(title,"Title", "Projects"))
            {
                Project project = new Project(title, creator);

                using (connection)
                {
                    DbCommand command = checkDbCommand(connection, factory);
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Projects (Title, Created_by) VALUES ('" + title + "','" + creator + "')";
                    command.CommandText += " UPDATE Users SET Project='" + title + "' WHERE Username='" + creator + "'";
                    DbDataReader dataReader = command.ExecuteReader();
                }
                return project;
            }
            else
            {
                MessageBox.Show("Project with such title already exists");
                return null;
            }
        }

        public string getProjectInfo (string title)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            string info = "";

            using (connection)
            {
                DbCommand command = checkDbCommand(connection, factory);
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Projects WHERE Title='" + title + "'";
                DbDataReader dataReader = command.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        info += "Title = " + dataReader["Title"].ToString() + '\n';
                        info += "Created by = " + dataReader["Created_by"].ToString() + '\n';            
                    }
                }
            }
            return info;
        }

        public Task createTask(string title, string for_project, string for_user)
        {
            if (!checkIfExistInDB(title, "Title", "Tasks"))
            {
                Task task = new Task(title, for_user, for_project);

                using (connection)
                {
                    DbCommand command = checkDbCommand(connection, factory);
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Tasks (Title, Project_title, For_user) VALUES ('" + title + "','" + for_project + "','" + for_user + "')";
                    command.CommandText += " UPDATE Users SET Task='" + title + "' WHERE Username='" + for_user + "'";
                    command.CommandText += " UPDATE Projects SET Task='" + title + "' WHERE Title='" + for_project + "'";
                    DbDataReader dataReader = command.ExecuteReader();
                }
                return task;
            }
            else
            {
                MessageBox.Show("Task with such title already exists");
                return null;
            }
        }

        public string getTaskInfo (string title)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            string info = "";

            using (connection)
            {
                DbCommand command = checkDbCommand(connection, factory);
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Tasks WHERE Title='" + title + "'";
                DbDataReader dataReader = command.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        info += "Title = " + dataReader["Title"].ToString() + '\n';
                        info += "Project = " + dataReader["Project_title"].ToString() + '\n';
                        info += "Created for = " + dataReader["For_user"].ToString() + '\n';
                    }
                }
            }
            return info;
        }
    }
}
