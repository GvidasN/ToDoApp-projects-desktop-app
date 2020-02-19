namespace _3lb_graphical_interface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUsers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.textIntro = new System.Windows.Forms.TextBox();
            this.groupRegistration = new System.Windows.Forms.GroupBox();
            this.radCompany = new System.Windows.Forms.RadioButton();
            this.radioPrivate = new System.Windows.Forms.RadioButton();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.butCreateUser = new System.Windows.Forms.Button();
            this.butInfo = new System.Windows.Forms.Button();
            this.butEditUser = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.tabProjc = new System.Windows.Forms.TabPage();
            this.listProjects = new System.Windows.Forms.ListBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBProjectCreate = new System.Windows.Forms.GroupBox();
            this.labUserID = new System.Windows.Forms.Label();
            this.comboBUsers = new System.Windows.Forms.ComboBox();
            this.textProjcTitle = new System.Windows.Forms.TextBox();
            this.labProjcTitle = new System.Windows.Forms.Label();
            this.butCreateNewProject = new System.Windows.Forms.Button();
            this.butProjectInformation = new System.Windows.Forms.Button();
            this.butEditProject = new System.Windows.Forms.Button();
            this.butDeleteProject = new System.Windows.Forms.Button();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.butTaskInfo = new System.Windows.Forms.Button();
            this.butTaskDelete = new System.Windows.Forms.Button();
            this.groupTask = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboForUser = new System.Windows.Forms.ComboBox();
            this.labProject = new System.Windows.Forms.Label();
            this.comboBProjects = new System.Windows.Forms.ComboBox();
            this.textTaskTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butCreateTask = new System.Windows.Forms.Button();
            this.listTasks = new System.Windows.Forms.ListBox();
            this.tabUsers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupRegistration.SuspendLayout();
            this.tabProjc.SuspendLayout();
            this.groupBProjectCreate.SuspendLayout();
            this.tabTasks.SuspendLayout();
            this.groupTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tabPage1);
            this.tabUsers.Controls.Add(this.tabProjc);
            this.tabUsers.Controls.Add(this.tabTasks);
            this.tabUsers.Location = new System.Drawing.Point(12, 12);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.SelectedIndex = 0;
            this.tabUsers.Size = new System.Drawing.Size(1065, 491);
            this.tabUsers.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listUsers);
            this.tabPage1.Controls.Add(this.textIntro);
            this.tabPage1.Controls.Add(this.groupRegistration);
            this.tabPage1.Controls.Add(this.butInfo);
            this.tabPage1.Controls.Add(this.butEditUser);
            this.tabPage1.Controls.Add(this.butDelete);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1057, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(6, 4);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(330, 459);
            this.listUsers.TabIndex = 7;
            // 
            // textIntro
            // 
            this.textIntro.BackColor = System.Drawing.Color.White;
            this.textIntro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIntro.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIntro.Location = new System.Drawing.Point(542, 152);
            this.textIntro.Multiline = true;
            this.textIntro.Name = "textIntro";
            this.textIntro.ReadOnly = true;
            this.textIntro.Size = new System.Drawing.Size(190, 130);
            this.textIntro.TabIndex = 6;
            this.textIntro.Text = "Time to get to Work!";
            // 
            // groupRegistration
            // 
            this.groupRegistration.Controls.Add(this.radCompany);
            this.groupRegistration.Controls.Add(this.radioPrivate);
            this.groupRegistration.Controls.Add(this.textTitle);
            this.groupRegistration.Controls.Add(this.textName);
            this.groupRegistration.Controls.Add(this.textSurname);
            this.groupRegistration.Controls.Add(this.textEmail);
            this.groupRegistration.Controls.Add(this.textPassword);
            this.groupRegistration.Controls.Add(this.textUsername);
            this.groupRegistration.Controls.Add(this.labEmail);
            this.groupRegistration.Controls.Add(this.labSurname);
            this.groupRegistration.Controls.Add(this.labName);
            this.groupRegistration.Controls.Add(this.labTitle);
            this.groupRegistration.Controls.Add(this.labPassword);
            this.groupRegistration.Controls.Add(this.labUsername);
            this.groupRegistration.Controls.Add(this.butCreateUser);
            this.groupRegistration.Location = new System.Drawing.Point(738, 6);
            this.groupRegistration.Name = "groupRegistration";
            this.groupRegistration.Size = new System.Drawing.Size(292, 453);
            this.groupRegistration.TabIndex = 5;
            this.groupRegistration.TabStop = false;
            this.groupRegistration.Text = "Registration";
            // 
            // radCompany
            // 
            this.radCompany.AutoSize = true;
            this.radCompany.Location = new System.Drawing.Point(198, 28);
            this.radCompany.Name = "radCompany";
            this.radCompany.Size = new System.Drawing.Size(69, 17);
            this.radCompany.TabIndex = 17;
            this.radCompany.TabStop = true;
            this.radCompany.Text = "Company";
            this.radCompany.UseVisualStyleBackColor = true;
            this.radCompany.CheckedChanged += new System.EventHandler(this.radCompany_CheckedChanged);
            // 
            // radioPrivate
            // 
            this.radioPrivate.AutoSize = true;
            this.radioPrivate.Location = new System.Drawing.Point(46, 28);
            this.radioPrivate.Name = "radioPrivate";
            this.radioPrivate.Size = new System.Drawing.Size(94, 17);
            this.radioPrivate.TabIndex = 16;
            this.radioPrivate.TabStop = true;
            this.radioPrivate.Text = "Private Person";
            this.radioPrivate.UseVisualStyleBackColor = true;
            this.radioPrivate.CheckedChanged += new System.EventHandler(this.radioPrivate_CheckedChanged);
            // 
            // textTitle
            // 
            this.textTitle.Enabled = false;
            this.textTitle.Location = new System.Drawing.Point(79, 364);
            this.textTitle.MaxLength = 100;
            this.textTitle.Multiline = true;
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(161, 25);
            this.textTitle.TabIndex = 15;
            // 
            // textName
            // 
            this.textName.Enabled = false;
            this.textName.Location = new System.Drawing.Point(81, 305);
            this.textName.MaxLength = 100;
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(161, 25);
            this.textName.TabIndex = 14;
            // 
            // textSurname
            // 
            this.textSurname.Enabled = false;
            this.textSurname.Location = new System.Drawing.Point(81, 251);
            this.textSurname.MaxLength = 100;
            this.textSurname.Multiline = true;
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(161, 25);
            this.textSurname.TabIndex = 13;
            // 
            // textEmail
            // 
            this.textEmail.Enabled = false;
            this.textEmail.Location = new System.Drawing.Point(79, 187);
            this.textEmail.MaxLength = 100;
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(161, 25);
            this.textEmail.TabIndex = 12;
            // 
            // textPassword
            // 
            this.textPassword.Enabled = false;
            this.textPassword.Location = new System.Drawing.Point(79, 130);
            this.textPassword.MaxLength = 100;
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(161, 25);
            this.textPassword.TabIndex = 11;
            // 
            // textUsername
            // 
            this.textUsername.Enabled = false;
            this.textUsername.Location = new System.Drawing.Point(79, 73);
            this.textUsername.MaxLength = 100;
            this.textUsername.Multiline = true;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(161, 25);
            this.textUsername.TabIndex = 10;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(76, 171);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(32, 13);
            this.labEmail.TabIndex = 9;
            this.labEmail.Text = "Email";
            // 
            // labSurname
            // 
            this.labSurname.AutoSize = true;
            this.labSurname.Location = new System.Drawing.Point(76, 235);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(49, 13);
            this.labSurname.TabIndex = 8;
            this.labSurname.Text = "Surname";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(78, 289);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 13);
            this.labName.TabIndex = 7;
            this.labName.Text = "Name";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(81, 348);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(27, 13);
            this.labTitle.TabIndex = 6;
            this.labTitle.Text = "Title";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(78, 114);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(53, 13);
            this.labPassword.TabIndex = 5;
            this.labPassword.Text = "Password";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Location = new System.Drawing.Point(76, 57);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(55, 13);
            this.labUsername.TabIndex = 4;
            this.labUsername.Text = "Username";
            // 
            // butCreateUser
            // 
            this.butCreateUser.Enabled = false;
            this.butCreateUser.Location = new System.Drawing.Point(94, 404);
            this.butCreateUser.Name = "butCreateUser";
            this.butCreateUser.Size = new System.Drawing.Size(133, 43);
            this.butCreateUser.TabIndex = 3;
            this.butCreateUser.Text = "Create a new user";
            this.butCreateUser.UseVisualStyleBackColor = true;
            this.butCreateUser.Click += new System.EventHandler(this.butCreateUser_Click);
            // 
            // butInfo
            // 
            this.butInfo.Location = new System.Drawing.Point(365, 120);
            this.butInfo.Name = "butInfo";
            this.butInfo.Size = new System.Drawing.Size(144, 32);
            this.butInfo.TabIndex = 4;
            this.butInfo.Text = "User information";
            this.butInfo.UseVisualStyleBackColor = true;
            this.butInfo.Click += new System.EventHandler(this.butInfo_Click);
            // 
            // butEditUser
            // 
            this.butEditUser.Location = new System.Drawing.Point(365, 177);
            this.butEditUser.Name = "butEditUser";
            this.butEditUser.Size = new System.Drawing.Size(144, 32);
            this.butEditUser.TabIndex = 2;
            this.butEditUser.Text = "Edit user information";
            this.butEditUser.UseVisualStyleBackColor = true;
            this.butEditUser.Click += new System.EventHandler(this.butEditUser_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(365, 231);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(144, 32);
            this.butDelete.TabIndex = 1;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // tabProjc
            // 
            this.tabProjc.Controls.Add(this.listProjects);
            this.tabProjc.Controls.Add(this.textBox5);
            this.tabProjc.Controls.Add(this.textBox4);
            this.tabProjc.Controls.Add(this.textBox3);
            this.tabProjc.Controls.Add(this.textBox2);
            this.tabProjc.Controls.Add(this.textBox1);
            this.tabProjc.Controls.Add(this.groupBProjectCreate);
            this.tabProjc.Controls.Add(this.butProjectInformation);
            this.tabProjc.Controls.Add(this.butEditProject);
            this.tabProjc.Controls.Add(this.butDeleteProject);
            this.tabProjc.Location = new System.Drawing.Point(4, 22);
            this.tabProjc.Name = "tabProjc";
            this.tabProjc.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjc.Size = new System.Drawing.Size(1057, 465);
            this.tabProjc.TabIndex = 1;
            this.tabProjc.Text = "Projects";
            this.tabProjc.UseVisualStyleBackColor = true;
            // 
            // listProjects
            // 
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(3, 7);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(673, 212);
            this.listProjects.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(733, 291);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(190, 79);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Okay okay.. W.H.O";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(523, 397);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(190, 49);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Spell who?";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(396, 309);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(101, 52);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Spell.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(237, 367);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(190, 79);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Who\'s there?";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(19, 305);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 130);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Knock knock!";
            // 
            // groupBProjectCreate
            // 
            this.groupBProjectCreate.Controls.Add(this.labUserID);
            this.groupBProjectCreate.Controls.Add(this.comboBUsers);
            this.groupBProjectCreate.Controls.Add(this.textProjcTitle);
            this.groupBProjectCreate.Controls.Add(this.labProjcTitle);
            this.groupBProjectCreate.Controls.Add(this.butCreateNewProject);
            this.groupBProjectCreate.Location = new System.Drawing.Point(682, 6);
            this.groupBProjectCreate.Name = "groupBProjectCreate";
            this.groupBProjectCreate.Size = new System.Drawing.Size(292, 213);
            this.groupBProjectCreate.TabIndex = 9;
            this.groupBProjectCreate.TabStop = false;
            this.groupBProjectCreate.Text = "Project";
            // 
            // labUserID
            // 
            this.labUserID.AutoSize = true;
            this.labUserID.Location = new System.Drawing.Point(80, 83);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(43, 13);
            this.labUserID.TabIndex = 17;
            this.labUserID.Text = "User ID";
            // 
            // comboBUsers
            // 
            this.comboBUsers.FormattingEnabled = true;
            this.comboBUsers.Location = new System.Drawing.Point(83, 99);
            this.comboBUsers.Name = "comboBUsers";
            this.comboBUsers.Size = new System.Drawing.Size(133, 21);
            this.comboBUsers.TabIndex = 16;
            // 
            // textProjcTitle
            // 
            this.textProjcTitle.Location = new System.Drawing.Point(66, 41);
            this.textProjcTitle.MaxLength = 100;
            this.textProjcTitle.Multiline = true;
            this.textProjcTitle.Name = "textProjcTitle";
            this.textProjcTitle.Size = new System.Drawing.Size(161, 25);
            this.textProjcTitle.TabIndex = 15;
            this.textProjcTitle.Tag = "title";
            // 
            // labProjcTitle
            // 
            this.labProjcTitle.AutoSize = true;
            this.labProjcTitle.Location = new System.Drawing.Point(63, 25);
            this.labProjcTitle.Name = "labProjcTitle";
            this.labProjcTitle.Size = new System.Drawing.Size(27, 13);
            this.labProjcTitle.TabIndex = 6;
            this.labProjcTitle.Text = "Title";
            // 
            // butCreateNewProject
            // 
            this.butCreateNewProject.Location = new System.Drawing.Point(83, 142);
            this.butCreateNewProject.Name = "butCreateNewProject";
            this.butCreateNewProject.Size = new System.Drawing.Size(133, 43);
            this.butCreateNewProject.TabIndex = 3;
            this.butCreateNewProject.Text = "Create a new Project";
            this.butCreateNewProject.UseVisualStyleBackColor = true;
            this.butCreateNewProject.Click += new System.EventHandler(this.butCreateNewProject_Click);
            // 
            // butProjectInformation
            // 
            this.butProjectInformation.Location = new System.Drawing.Point(379, 242);
            this.butProjectInformation.Name = "butProjectInformation";
            this.butProjectInformation.Size = new System.Drawing.Size(144, 32);
            this.butProjectInformation.TabIndex = 8;
            this.butProjectInformation.Text = "Project information";
            this.butProjectInformation.UseVisualStyleBackColor = true;
            this.butProjectInformation.Click += new System.EventHandler(this.butProjectInformation_Click);
            // 
            // butEditProject
            // 
            this.butEditProject.Location = new System.Drawing.Point(195, 242);
            this.butEditProject.Name = "butEditProject";
            this.butEditProject.Size = new System.Drawing.Size(144, 32);
            this.butEditProject.TabIndex = 7;
            this.butEditProject.Text = "Edit project";
            this.butEditProject.UseVisualStyleBackColor = true;
            this.butEditProject.Click += new System.EventHandler(this.butEditProject_Click);
            // 
            // butDeleteProject
            // 
            this.butDeleteProject.Location = new System.Drawing.Point(19, 242);
            this.butDeleteProject.Name = "butDeleteProject";
            this.butDeleteProject.Size = new System.Drawing.Size(144, 32);
            this.butDeleteProject.TabIndex = 6;
            this.butDeleteProject.Text = "Delete";
            this.butDeleteProject.UseVisualStyleBackColor = true;
            this.butDeleteProject.Click += new System.EventHandler(this.butDeleteProject_Click);
            // 
            // tabTasks
            // 
            this.tabTasks.Controls.Add(this.butTaskInfo);
            this.tabTasks.Controls.Add(this.butTaskDelete);
            this.tabTasks.Controls.Add(this.groupTask);
            this.tabTasks.Controls.Add(this.listTasks);
            this.tabTasks.Location = new System.Drawing.Point(4, 22);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasks.Size = new System.Drawing.Size(1057, 465);
            this.tabTasks.TabIndex = 2;
            this.tabTasks.Text = "Tasks";
            this.tabTasks.UseVisualStyleBackColor = true;
            // 
            // butTaskInfo
            // 
            this.butTaskInfo.Location = new System.Drawing.Point(467, 153);
            this.butTaskInfo.Name = "butTaskInfo";
            this.butTaskInfo.Size = new System.Drawing.Size(144, 32);
            this.butTaskInfo.TabIndex = 20;
            this.butTaskInfo.Text = "Task information";
            this.butTaskInfo.UseVisualStyleBackColor = true;
            this.butTaskInfo.Click += new System.EventHandler(this.butTaskInfo_Click);
            // 
            // butTaskDelete
            // 
            this.butTaskDelete.Location = new System.Drawing.Point(467, 206);
            this.butTaskDelete.Name = "butTaskDelete";
            this.butTaskDelete.Size = new System.Drawing.Size(144, 32);
            this.butTaskDelete.TabIndex = 18;
            this.butTaskDelete.Text = "Delete";
            this.butTaskDelete.UseVisualStyleBackColor = true;
            this.butTaskDelete.Click += new System.EventHandler(this.butTaskDelete_Click);
            // 
            // groupTask
            // 
            this.groupTask.Controls.Add(this.label1);
            this.groupTask.Controls.Add(this.comboForUser);
            this.groupTask.Controls.Add(this.labProject);
            this.groupTask.Controls.Add(this.comboBProjects);
            this.groupTask.Controls.Add(this.textTaskTitle);
            this.groupTask.Controls.Add(this.label2);
            this.groupTask.Controls.Add(this.butCreateTask);
            this.groupTask.Location = new System.Drawing.Point(704, 89);
            this.groupTask.Name = "groupTask";
            this.groupTask.Size = new System.Drawing.Size(292, 276);
            this.groupTask.TabIndex = 17;
            this.groupTask.TabStop = false;
            this.groupTask.Text = "Task";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "User ";
            // 
            // comboForUser
            // 
            this.comboForUser.FormattingEnabled = true;
            this.comboForUser.Location = new System.Drawing.Point(83, 152);
            this.comboForUser.Name = "comboForUser";
            this.comboForUser.Size = new System.Drawing.Size(133, 21);
            this.comboForUser.TabIndex = 18;
            // 
            // labProject
            // 
            this.labProject.AutoSize = true;
            this.labProject.Location = new System.Drawing.Point(80, 83);
            this.labProject.Name = "labProject";
            this.labProject.Size = new System.Drawing.Size(40, 13);
            this.labProject.TabIndex = 17;
            this.labProject.Text = "Project";
            // 
            // comboBProjects
            // 
            this.comboBProjects.FormattingEnabled = true;
            this.comboBProjects.Location = new System.Drawing.Point(83, 99);
            this.comboBProjects.Name = "comboBProjects";
            this.comboBProjects.Size = new System.Drawing.Size(133, 21);
            this.comboBProjects.TabIndex = 16;
            // 
            // textTaskTitle
            // 
            this.textTaskTitle.Location = new System.Drawing.Point(66, 41);
            this.textTaskTitle.MaxLength = 100;
            this.textTaskTitle.Multiline = true;
            this.textTaskTitle.Name = "textTaskTitle";
            this.textTaskTitle.Size = new System.Drawing.Size(161, 25);
            this.textTaskTitle.TabIndex = 15;
            this.textTaskTitle.Tag = "title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // butCreateTask
            // 
            this.butCreateTask.Location = new System.Drawing.Point(83, 214);
            this.butCreateTask.Name = "butCreateTask";
            this.butCreateTask.Size = new System.Drawing.Size(133, 43);
            this.butCreateTask.TabIndex = 3;
            this.butCreateTask.Text = "Create a new Task";
            this.butCreateTask.UseVisualStyleBackColor = true;
            this.butCreateTask.Click += new System.EventHandler(this.butCreateTask_Click);
            // 
            // listTasks
            // 
            this.listTasks.FormattingEnabled = true;
            this.listTasks.Location = new System.Drawing.Point(6, 6);
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(374, 446);
            this.listTasks.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 515);
            this.Controls.Add(this.tabUsers);
            this.Name = "Form1";
            this.Text = "To do App";
            this.tabUsers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupRegistration.ResumeLayout(false);
            this.groupRegistration.PerformLayout();
            this.tabProjc.ResumeLayout(false);
            this.tabProjc.PerformLayout();
            this.groupBProjectCreate.ResumeLayout(false);
            this.groupBProjectCreate.PerformLayout();
            this.tabTasks.ResumeLayout(false);
            this.groupTask.ResumeLayout(false);
            this.groupTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabProjc;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.GroupBox groupRegistration;
        private System.Windows.Forms.Button butCreateUser;
        private System.Windows.Forms.Button butInfo;
        private System.Windows.Forms.Button butEditUser;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.RadioButton radCompany;
        private System.Windows.Forms.RadioButton radioPrivate;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.TextBox textIntro;
        private System.Windows.Forms.Button butProjectInformation;
        private System.Windows.Forms.Button butEditProject;
        private System.Windows.Forms.Button butDeleteProject;
        private System.Windows.Forms.GroupBox groupBProjectCreate;
        private System.Windows.Forms.TextBox textProjcTitle;
        private System.Windows.Forms.Label labProjcTitle;
        private System.Windows.Forms.Button butCreateNewProject;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.ComboBox comboBUsers;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.ListBox listProjects;
        private System.Windows.Forms.ListBox listTasks;
        private System.Windows.Forms.Button butTaskInfo;
        private System.Windows.Forms.Button butTaskDelete;
        private System.Windows.Forms.GroupBox groupTask;
        private System.Windows.Forms.Label labProject;
        private System.Windows.Forms.ComboBox comboBProjects;
        private System.Windows.Forms.TextBox textTaskTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butCreateTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboForUser;
    }
}

