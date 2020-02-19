namespace _3lb_graphical_interface
{
    partial class EditProjectForm
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
            this.labUserID = new System.Windows.Forms.Label();
            this.comboBUsers = new System.Windows.Forms.ComboBox();
            this.textProjcUpdateTitle = new System.Windows.Forms.TextBox();
            this.labProjcTitle = new System.Windows.Forms.Label();
            this.butUpdateProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labUserID
            // 
            this.labUserID.AutoSize = true;
            this.labUserID.Location = new System.Drawing.Point(42, 109);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(43, 13);
            this.labUserID.TabIndex = 22;
            this.labUserID.Text = "User ID";
            // 
            // comboBUsers
            // 
            this.comboBUsers.FormattingEnabled = true;
            this.comboBUsers.Location = new System.Drawing.Point(45, 125);
            this.comboBUsers.Name = "comboBUsers";
            this.comboBUsers.Size = new System.Drawing.Size(133, 21);
            this.comboBUsers.TabIndex = 21;
            // 
            // textProjcUpdateTitle
            // 
            this.textProjcUpdateTitle.Location = new System.Drawing.Point(28, 67);
            this.textProjcUpdateTitle.MaxLength = 100;
            this.textProjcUpdateTitle.Multiline = true;
            this.textProjcUpdateTitle.Name = "textProjcUpdateTitle";
            this.textProjcUpdateTitle.Size = new System.Drawing.Size(161, 25);
            this.textProjcUpdateTitle.TabIndex = 20;
            this.textProjcUpdateTitle.Tag = "title";
            // 
            // labProjcTitle
            // 
            this.labProjcTitle.AutoSize = true;
            this.labProjcTitle.Location = new System.Drawing.Point(25, 51);
            this.labProjcTitle.Name = "labProjcTitle";
            this.labProjcTitle.Size = new System.Drawing.Size(27, 13);
            this.labProjcTitle.TabIndex = 19;
            this.labProjcTitle.Text = "Title";
            // 
            // butUpdateProject
            // 
            this.butUpdateProject.Location = new System.Drawing.Point(45, 168);
            this.butUpdateProject.Name = "butUpdateProject";
            this.butUpdateProject.Size = new System.Drawing.Size(133, 43);
            this.butUpdateProject.TabIndex = 18;
            this.butUpdateProject.Text = "Update project";
            this.butUpdateProject.UseVisualStyleBackColor = true;
            this.butUpdateProject.Click += new System.EventHandler(this.butUpdateProject_Click);
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 271);
            this.Controls.Add(this.labUserID);
            this.Controls.Add(this.comboBUsers);
            this.Controls.Add(this.textProjcUpdateTitle);
            this.Controls.Add(this.labProjcTitle);
            this.Controls.Add(this.butUpdateProject);
            this.Name = "EditProjectForm";
            this.Text = "EditProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.ComboBox comboBUsers;
        private System.Windows.Forms.TextBox textProjcUpdateTitle;
        private System.Windows.Forms.Label labProjcTitle;
        private System.Windows.Forms.Button butUpdateProject;
    }
}