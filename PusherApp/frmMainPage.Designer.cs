
namespace pusherProgram
{
    partial class mainPage
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
            label1 = new Label();
            timeDrivenTitle = new Label();
            LoginButton = new Button();
            dataDrivenLocation = new TextBox();
            factoryCode = new Label();
            timeDrivenLocation = new TextBox();
            timeDrivenbtn = new Button();
            datadrivenbtn = new Button();
            numericUpDown1 = new NumericUpDown();
            secondsControl = new Label();
            linklblChangeUserNameOrPassword = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(166, 39);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 2;
            label1.Text = "SELECT FOLDERS";
            // 
            // timeDrivenTitle
            // 
            timeDrivenTitle.AutoSize = true;
            timeDrivenTitle.ForeColor = Color.FromArgb(164, 165, 169);
            timeDrivenTitle.ImeMode = ImeMode.NoControl;
            timeDrivenTitle.Location = new Point(77, 93);
            timeDrivenTitle.Name = "timeDrivenTitle";
            timeDrivenTitle.Size = new Size(251, 17);
            timeDrivenTitle.TabIndex = 3;
            timeDrivenTitle.Text = "SELECT TIME DRIVEN FILE LOCATIOON ";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(116, 86, 174);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.ForeColor = Color.White;
            LoginButton.ImeMode = ImeMode.NoControl;
            LoginButton.Location = new Point(124, 339);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(282, 39);
            LoginButton.TabIndex = 12;
            LoginButton.Text = "START";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // dataDrivenLocation
            // 
            dataDrivenLocation.AccessibleDescription = "";
            dataDrivenLocation.BackColor = Color.FromArgb(230, 231, 233);
            dataDrivenLocation.BorderStyle = BorderStyle.None;
            dataDrivenLocation.Location = new Point(124, 295);
            dataDrivenLocation.Multiline = true;
            dataDrivenLocation.Name = "dataDrivenLocation";
            dataDrivenLocation.Size = new Size(282, 28);
            dataDrivenLocation.TabIndex = 11;
            // 
            // factoryCode
            // 
            factoryCode.AutoSize = true;
            factoryCode.ForeColor = Color.FromArgb(164, 165, 169);
            factoryCode.ImeMode = ImeMode.NoControl;
            factoryCode.Location = new Point(81, 250);
            factoryCode.Name = "factoryCode";
            factoryCode.Size = new Size(247, 17);
            factoryCode.TabIndex = 10;
            factoryCode.Text = "SELECT EVENT DRIVEN FILE LOCATION";
            // 
            // timeDrivenLocation
            // 
            timeDrivenLocation.AccessibleDescription = "";
            timeDrivenLocation.BackColor = Color.FromArgb(230, 231, 233);
            timeDrivenLocation.BorderStyle = BorderStyle.None;
            timeDrivenLocation.Location = new Point(124, 131);
            timeDrivenLocation.Multiline = true;
            timeDrivenLocation.Name = "timeDrivenLocation";
            timeDrivenLocation.Size = new Size(282, 28);
            timeDrivenLocation.TabIndex = 9;
            timeDrivenLocation.TextChanged += timeDrivenLocation_TextChanged;
            // 
            // timeDrivenbtn
            // 
            timeDrivenbtn.AccessibleName = "";
            timeDrivenbtn.BackgroundImageLayout = ImageLayout.Zoom;
            timeDrivenbtn.Location = new Point(412, 131);
            timeDrivenbtn.Name = "timeDrivenbtn";
            timeDrivenbtn.Size = new Size(31, 28);
            timeDrivenbtn.TabIndex = 13;
            timeDrivenbtn.Text = "^";
            timeDrivenbtn.UseVisualStyleBackColor = true;
            timeDrivenbtn.Click += timeDrivenbtn_Click;
            // 
            // datadrivenbtn
            // 
            datadrivenbtn.Location = new Point(412, 295);
            datadrivenbtn.Name = "datadrivenbtn";
            datadrivenbtn.Size = new Size(31, 28);
            datadrivenbtn.TabIndex = 14;
            datadrivenbtn.Text = "^";
            datadrivenbtn.UseVisualStyleBackColor = true;
            datadrivenbtn.Click += datadrivenbtn_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(124, 179);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 25);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // secondsControl
            // 
            secondsControl.AutoSize = true;
            secondsControl.ForeColor = Color.FromArgb(164, 165, 169);
            secondsControl.Location = new Point(250, 187);
            secondsControl.Name = "secondsControl";
            secondsControl.Size = new Size(58, 17);
            secondsControl.TabIndex = 16;
            secondsControl.Text = "Seconds";
            // 
            // linklblChangeUserNameOrPassword
            // 
            linklblChangeUserNameOrPassword.AutoSize = true;
            linklblChangeUserNameOrPassword.Location = new Point(166, 407);
            linklblChangeUserNameOrPassword.Name = "linklblChangeUserNameOrPassword";
            linklblChangeUserNameOrPassword.Size = new Size(204, 17);
            linklblChangeUserNameOrPassword.TabIndex = 17;
            linklblChangeUserNameOrPassword.TabStop = true;
            linklblChangeUserNameOrPassword.Text = "Change User Name or Password";
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(533, 501);
            Controls.Add(linklblChangeUserNameOrPassword);
            Controls.Add(secondsControl);
            Controls.Add(numericUpDown1);
            Controls.Add(datadrivenbtn);
            Controls.Add(timeDrivenbtn);
            Controls.Add(LoginButton);
            Controls.Add(dataDrivenLocation);
            Controls.Add(factoryCode);
            Controls.Add(timeDrivenLocation);
            Controls.Add(timeDrivenTitle);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            Name = "mainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainPage";
            Load += mainPage_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeDrivenTitle;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox dataDrivenLocation;
        private System.Windows.Forms.Label factoryCode;
        private System.Windows.Forms.TextBox timeDrivenLocation;
        private System.Windows.Forms.Button timeDrivenbtn;
        private System.Windows.Forms.Button datadrivenbtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label secondsControl;
        private System.Windows.Forms.LinkLabel linklblChangeUserNameOrPassword;
    }
}