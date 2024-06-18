using Microsoft.Win32;
using Newtonsoft.Json;
using pusherProgram;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace PusherApp
{
    internal static class Program
    {
        private const string FilePath = "fileLocation.json";
        private static readonly string AppName = "PusherApp";
        

        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Ensure the application runs with admin privileges
            if (!IsRunningAsAdmin())
            {
                RestartAsAdmin();
                return;
            }

            // Add the application to startup
            AddToStartup();

            if (args.Length > 0 && args[0] == "-startup")
            {
                if (File.Exists(FilePath))
                {
                    try
                    {
                        var json = File.ReadAllText(FilePath);
                        var paths = JsonConvert.DeserializeObject<paths>(json);
                        if (paths != null && !string.IsNullOrEmpty(paths.timeDriven) && !string.IsNullOrEmpty(paths.eventDriven) && paths.numeric > 0)
                        {
                            MessageBox.Show("started");
                            FileMonitor file = new FileMonitor(paths.eventDriven, paths.timeDriven, paths.numeric);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Open the LoginForm if started manually
            Application.Run(new LoginForm());
        }

        private static bool IsRunningAsAdmin()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private static void RestartAsAdmin()
        {
            var exeName = Application.ExecutablePath;
            var startInfo = new System.Diagnostics.ProcessStartInfo(exeName)
            {
                Verb = "runas",
                UseShellExecute = true
            };

            try
            {
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("This application requires administrative privileges to run.", "Admin Access Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Application.Exit();
        }

        private static void AddToStartup()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (key.GetValue(AppName) == null)
                    {
                        key.SetValue(AppName, $"\"{Application.ExecutablePath}\" -startup");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}