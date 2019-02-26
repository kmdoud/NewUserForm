namespace NewUserForm
{
    partial class userDatabaseEditor
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
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.userId = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(101, 99);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 135);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(101, 278);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(126, 155);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(101, 477);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(126, 161);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Edit";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(101, 682);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(126, 163);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(350, 745);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(140, 44);
            this.userId.TabIndex = 4;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(561, 99);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(269, 37);
            this.userName.TabIndex = 5;
            this.userName.Text = "userNameDisplay";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(561, 168);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(155, 37);
            this.firstName.TabIndex = 6;
            this.firstName.Text = "firstName";
            this.firstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(575, 264);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(153, 37);
            this.lastName.TabIndex = 7;
            this.lastName.Text = "lastName";
            this.lastName.Click += new System.EventHandler(this.lastName_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(582, 352);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(102, 37);
            this.Email.TabIndex = 8;
            this.Email.Text = "label3";
            // 
            // userDatabaseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 1406);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Name = "userDatabaseEditor";
            this.Text = "User Database Editor";
            this.Load += new System.EventHandler(this.userDatabaseEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label Email;
    }
}

