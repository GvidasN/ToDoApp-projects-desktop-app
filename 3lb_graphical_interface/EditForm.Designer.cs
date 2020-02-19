namespace _3lb_graphical_interface
{
    partial class EditForm
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
            this.editTitle = new System.Windows.Forms.TextBox();
            this.editEmail = new System.Windows.Forms.TextBox();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.editUsername = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.butEditUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editTitle
            // 
            this.editTitle.Location = new System.Drawing.Point(57, 224);
            this.editTitle.MaxLength = 100;
            this.editTitle.Multiline = true;
            this.editTitle.Name = "editTitle";
            this.editTitle.Size = new System.Drawing.Size(161, 25);
            this.editTitle.TabIndex = 28;
            // 
            // editEmail
            // 
            this.editEmail.Location = new System.Drawing.Point(57, 168);
            this.editEmail.MaxLength = 100;
            this.editEmail.Multiline = true;
            this.editEmail.Name = "editEmail";
            this.editEmail.Size = new System.Drawing.Size(161, 25);
            this.editEmail.TabIndex = 25;
            // 
            // editPassword
            // 
            this.editPassword.Location = new System.Drawing.Point(57, 111);
            this.editPassword.MaxLength = 100;
            this.editPassword.Multiline = true;
            this.editPassword.Name = "editPassword";
            this.editPassword.PasswordChar = '*';
            this.editPassword.Size = new System.Drawing.Size(161, 25);
            this.editPassword.TabIndex = 24;
            // 
            // editUsername
            // 
            this.editUsername.Location = new System.Drawing.Point(57, 54);
            this.editUsername.MaxLength = 100;
            this.editUsername.Multiline = true;
            this.editUsername.Name = "editUsername";
            this.editUsername.Size = new System.Drawing.Size(161, 25);
            this.editUsername.TabIndex = 23;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(54, 152);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(32, 13);
            this.labEmail.TabIndex = 22;
            this.labEmail.Text = "Email";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(54, 208);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(27, 13);
            this.labTitle.TabIndex = 19;
            this.labTitle.Text = "Title";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(56, 95);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(53, 13);
            this.labPassword.TabIndex = 18;
            this.labPassword.Text = "Password";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Location = new System.Drawing.Point(54, 38);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(55, 13);
            this.labUsername.TabIndex = 17;
            this.labUsername.Text = "Username";
            // 
            // butEditUser
            // 
            this.butEditUser.Location = new System.Drawing.Point(72, 385);
            this.butEditUser.Name = "butEditUser";
            this.butEditUser.Size = new System.Drawing.Size(133, 43);
            this.butEditUser.TabIndex = 16;
            this.butEditUser.Text = "Update";
            this.butEditUser.UseVisualStyleBackColor = true;
            this.butEditUser.Click += new System.EventHandler(this.butEditUser_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 474);
            this.Controls.Add(this.editTitle);
            this.Controls.Add(this.editEmail);
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.editUsername);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUsername);
            this.Controls.Add(this.butEditUser);
            this.Name = "EditForm";
            this.Text = "Vartotojo redagavimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editTitle;
        private System.Windows.Forms.TextBox editEmail;
        private System.Windows.Forms.TextBox editPassword;
        private System.Windows.Forms.TextBox editUsername;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.Button butEditUser;
    }
}