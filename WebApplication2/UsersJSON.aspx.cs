using _3lb_graphical_interface;
using Newtonsoft.Json;
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
    public partial class UsersJSON : System.Web.UI.Page
    {
        public string provider = ConfigurationManager.AppSettings["provider"];
        public string connectionString = ConfigurationManager.AppSettings["connectionString"];

        DbProviderFactory factory;
        DbConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();

            Response.Clear();
            Response.ContentType = "application/json; charset=utf-8";
            Response.Write(DisplayUsersJSON());
            Response.End();
        }

        string DisplayUsersJSON()
        {
            List<User> users = new List<User>();

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
                        users.Add(tempUser);
                        
                    }
                }
            }
            string jsonUser = JsonConvert.SerializeObject(users);
            return jsonUser;
        }

        private DbCommand checkDbCommand(DbConnection givenConnection, DbProviderFactory givenFactory)
        {
            if (givenConnection == null) MessageBox.Show("failed connection");

            givenConnection.ConnectionString = connectionString;
            givenConnection.Open();
            DbCommand command = givenFactory.CreateCommand();

            if (command == null) MessageBox.Show("failed command");
            return command;
        }
    }
}