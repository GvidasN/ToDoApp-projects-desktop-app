using System;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;


namespace _3lb_graphical_interface
{
    public partial class EditForm : Form, IdefaultValues
    {
        string savedUsername;

        string provider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public void firstValues(string username)
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
                command.CommandText = "SELECT * FROM Users WHERE Username='" + username + "'";

                DbDataReader dataReader = command.ExecuteReader();

                using (dataReader)
                {
                    while (dataReader.Read())
                    {
                        editEmail.Text = dataReader["Email"].ToString();
                        editTitle.Text = dataReader["Title"].ToString();
                        editUsername.Text = dataReader["Username"].ToString();
                        editPassword.Text = "";
                    }
                }
                if (editTitle.Text == "") editTitle.Enabled = false;
            }      
        }

        public EditForm(string username)
        {        
            InitializeComponent();

            firstValues(username);
            savedUsername = username;
        }

        private void butEditUser_Click(object sender, EventArgs e)
        {
            if (editUsername.Text != "" && editPassword.Text != "" && editEmail.Text != "")
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
                    command.CommandText = "UPDATE Users SET Username='" + editUsername.Text + "'," + "Password='" + editPassword.Text + "'," + "Email='" + editEmail.Text + "',"
                                        + "Title='" + editTitle.Text + "'" + "WHERE Username='" + savedUsername + "'";
                    command.CommandText += " UPDATE Projects SET Created_by='" + editUsername.Text + "' WHERE Created_by='" + savedUsername + "'";
                    command.CommandText += " UPDATE Tasks SET For_user='" + editUsername.Text + "' WHERE For_user='" + savedUsername + "'";

                    DbDataReader dataReader = command.ExecuteReader();
                    MessageBox.Show("Updated!");
                }
            }
            else MessageBox.Show("Please fill all of the blocks");       
        }
    }
}
