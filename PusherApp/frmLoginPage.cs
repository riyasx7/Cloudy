using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace pusherProgram
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private const string FilePath = "user.json";
        private const string BranchFilePath = "branchData.json";
        // Retrieve stored credentials
        private string storedUsername = "";
        private string storedPassword = "";

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (!File.Exists(FilePath))
            {
                // If file doesn't exist, create an empty JSON file
                File.WriteAllText(FilePath, "[]");
            }
            string json = File.ReadAllText(FilePath);
            if (json != "[]")
            {
                UserData userData = JsonConvert.DeserializeObject<UserData>(json);
                // Retrieve stored credentials
                storedUsername = userData.Username;
                storedPassword = userData.Password;
            }
            else
            {
                UserData userData = new UserData();
                userData.Username = "admin";
                userData.Password = "123";
                string json1 = JsonConvert.SerializeObject(userData);
                File.WriteAllText(FilePath, json1);
                storedUsername = userData.Username;
                storedPassword = userData.Password;
            }
            factoryNameFeild.Focus();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (factoryNameFeild.Text == "" && factoryCodeFeild.Text == "")
            {
                MessageBox.Show("User name and passsword fields are empty", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (factoryNameFeild.Text == "")
            {
                MessageBox.Show("User name field is empty", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (factoryCodeFeild.Text == "")
            {
                MessageBox.Show("Password field is empty", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string enteredUsername = factoryNameFeild.Text;
                string enteredPassword = factoryCodeFeild.Text;

                if (enteredUsername == storedUsername && enteredPassword == storedPassword)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainPage main = new mainPage(this);
                    main.Show();
                    this.Hide();

                    /*if (!File.Exists(BranchFilePath))
                    {
                        // If file doesn't exist, create an empty JSON file
                        File.WriteAllText(BranchFilePath, "[]");
                    }
                    string json = File.ReadAllText(BranchFilePath);


                    if (json != null)
                    {
                        if (json == "[]")
                        {
                            this.Hide();
                            frmBranchDetails frmBranchDetails = new frmBranchDetails("add");
                            frmBranchDetails.Show();
                        }
                        else
                        {
                            BranchData branchData = JsonConvert.DeserializeObject<BranchData>(json);
                            if (branchData != null && branchData.BranchName != "" && branchData.PcNumber != null && branchData.BranchAddress != "")
                            {
                                // Open another form after the message box is closed
                                mainPage main = new mainPage(this);
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                this.Hide();
                                frmBranchDetails frmBranchDetails = new frmBranchDetails("add");
                                frmBranchDetails.Show();
                            }
                        }
                    }*/


                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }

        private void factoryCodeFeild_TextChanged(object sender, EventArgs e)
        {
            factoryCodeFeild.PasswordChar = '●';
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                factoryCodeFeild.PasswordChar = '\0';
            }
            else
            {
                factoryCodeFeild.PasswordChar = '●'; 
            }
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void factoryCode_Click(object sender, EventArgs e)
        {

        }

        private void factoryNameFeild_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { factoryCodeFeild.Focus(); }
        }

        private void factoryCodeFeild_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { LoginButton.PerformClick(); }
        }
    }
}
