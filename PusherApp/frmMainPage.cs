using Microsoft.Win32;
using Newtonsoft.Json;
using PusherApp;
using System;
using System.IO;
using System.Windows.Forms;
// other using statements

namespace pusherProgram
{


    public partial class mainPage : Form
    {



        private const string FilePath = "fileLocation.json";
        LoginForm login;
        private string eventDrivenPath;
        private int waitingTime;

        private string timeDrivenPath;
        public mainPage(LoginForm login)
        {
          

            InitializeComponent();
            LoadSetting();
            this.login = login;
        }



        private void mainPage_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;

        }

        public void LoadSetting()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                var paths = JsonConvert.DeserializeObject<paths>(json);
                if (paths != null)
                {
                    timeDrivenLocation.Text = paths.timeDriven;
                    dataDrivenLocation.Text = paths.eventDriven;
                    numericUpDown1.Value = (int)paths.numeric;
                    eventDrivenPath = paths.eventDriven;
                    timeDrivenPath = paths.timeDriven;
                    waitingTime = (int)paths.numeric;
                }
            }

        }
        public void SaveSettings()
        {

            paths path = new paths();
            path.timeDriven = timeDrivenLocation.Text;
            path.eventDriven = dataDrivenLocation.Text;
            path.numeric = (int)numericUpDown1.Value;
            string json1 = JsonConvert.SerializeObject(path);
            File.WriteAllText(FilePath, json1);
        }
        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (timeDrivenLocation.Text == "" || dataDrivenLocation.Text == "" || numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Please fill all the fields", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (timeDrivenLocation.Text == dataDrivenLocation.Text)
                {
                    MessageBox.Show("Please choose diffrent folders","Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SaveSettings();
                    LoadSetting();
                    MessageBox.Show("Successfully started", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FileMonitor file = new FileMonitor(eventDrivenPath, timeDrivenPath, waitingTime);
                    this.Hide();
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timeDrivenbtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    timeDrivenLocation.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
       
        private void datadrivenbtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    dataDrivenLocation.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void linklblEditBranchDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timeDrivenLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
