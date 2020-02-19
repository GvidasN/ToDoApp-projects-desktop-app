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
    public partial class ProjectJSON : System.Web.UI.Page
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
            Response.Write(DisplayProjectsJSON());
            Response.End();

        }

        string DisplayProjectsJSON()
        {
            List<Project> projects = new List<Project>();

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
                        projects.Add(tempProject);                        
                    }
                }
            }
            string jsonProject = JsonConvert.SerializeObject(projects);
            return jsonProject;
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