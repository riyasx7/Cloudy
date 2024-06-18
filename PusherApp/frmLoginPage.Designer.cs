
namespace pusherProgram
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.factoryNameFeild = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.factoryCodeFeild = new System.Windows.Forms.TextBox();
            this.factoryCode = new System.Windows.Forms.Label();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // factoryNameFeild
            // 
            resources.ApplyResources(this.factoryNameFeild, "factoryNameFeild");
            this.factoryNameFeild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.factoryNameFeild.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.factoryNameFeild.Name = "factoryNameFeild";
            this.factoryNameFeild.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.factoryNameFeild.KeyDown += new System.Windows.Forms.KeyEventHandler(this.factoryNameFeild_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // factoryCodeFeild
            // 
            resources.ApplyResources(this.factoryCodeFeild, "factoryCodeFeild");
            this.factoryCodeFeild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.factoryCodeFeild.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.factoryCodeFeild.Name = "factoryCodeFeild";
            this.factoryCodeFeild.TextChanged += new System.EventHandler(this.factoryCodeFeild_TextChanged);
            this.factoryCodeFeild.KeyDown += new System.Windows.Forms.KeyEventHandler(this.factoryCodeFeild_KeyDown);
            // 
            // factoryCode
            // 
            resources.ApplyResources(this.factoryCode, "factoryCode");
            this.factoryCode.Name = "factoryCode";
            this.factoryCode.Click += new System.EventHandler(this.factoryCode_Click);
            // 
            // checkPassword
            // 
            resources.ApplyResources(this.checkPassword, "checkPassword");
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.UseVisualStyleBackColor = true;
            this.checkPassword.CheckedChanged += new System.EventHandler(this.checkPassword_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.factoryCodeFeild);
            this.Controls.Add(this.factoryCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.factoryNameFeild);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox factoryNameFeild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox factoryCodeFeild;
        private System.Windows.Forms.Label factoryCode;
        private System.Windows.Forms.CheckBox checkPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

