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
    public partial class EditProjectForm : Form, IdefaultValues
    {
        string savedtitle;
        string provider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public void firstValues(string title)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            DbConnection connection = factory.CreateConnection();

            using (connection)
            {
                if (connection == null) MessageBox.Show("failed connection");

                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = factory.CreateCommand();

                if (command == null) MessageBox.Show("failed command");

                command.Connection = connection;
                command.CommandText = "SELECT * FROM Projects WHERE Title='" + title + "'";

                DbDataReader dataReader = command.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        textProjcUpdateTitle.Text = dataReader["Title"].ToString();
                    }
                }
            }
        }

        private void getUsers(ComboBox users)
        {
            for (int i = 0; i < users.Items.Count; i++)
            {
                comboBUsers.Items.Add(users.Items[i]);
            }
        }

        public EditProjectForm(string title, ComboBox Userslist)
        {
            InitializeComponent();
            firstValues(title);
            getUsers(Userslist);
            savedtitle = title;
        }

        private void butUpdateProject_Click(object sender, EventArgs e)
        {
            if (textProjcUpdateTitle.Text != "")
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
                DbConnection connection = factory.CreateConnection();

                using (connection)
                {
                    if (connection == null) MessageBox.Show("failed connection");

                    connection.ConnectionString = connectionString;
                    connection.Open();
                    DbCommand command = factory.CreateCommand();

                    if (command == null) MessageBox.Show("failed command");

                    command.Connection = connection;
                    command.CommandText = "UPDATE Projects SET Title='" + textProjcUpdateTitle.Text + "'," + "Created_by='" + comboBUsers.SelectedItem.ToString() + "'"
                                        + "WHERE Title='" + savedtitle + "'";
                    command.CommandText += " UPDATE Users SET Project='" + textProjcUpdateTitle.Text + "' WHERE Project='" + savedtitle + "'";
                    command.CommandText += " UPDATE Tasks SET Project_title='" + textProjcUpdateTitle.Text + "' WHERE Project_title='" + savedtitle + "'";

                    DbDataReader dataReader = command.ExecuteReader();
                    MessageBox.Show("List will be updated shorty", "Updated!");
                }
            }
            else MessageBox.Show("Please fill all of the blocks");
        }
    }
}
