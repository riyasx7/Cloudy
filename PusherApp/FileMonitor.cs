using System.Timers;
using Timer = System.Timers.Timer;
namespace PusherApp
{
    public class FileMonitor
    {
        private string eventDrivenPath;
        private string timeDrivenPath;
        private string eventDrivenTargetPath;
        private string timeDrivenTargetPath;
        private int checkInterval;
        private FileSystemWatcher eventDrivenWatcher;
        private FileSystemWatcher timeDrivenWatcher;
        private Timer timeDrivenTimer;

        public FileMonitor(string eventDrivenPath, string timeDrivenPath, int checkInterval)
        {
            try
            {
                this.eventDrivenPath = eventDrivenPath;
                this.timeDrivenPath = timeDrivenPath;
                eventDrivenTargetPath = Path.Combine(Path.GetDirectoryName(eventDrivenPath), "EventDrivenTarget");
                timeDrivenTargetPath = Path.Combine(Path.GetDirectoryName(eventDrivenPath), "TimeDrivenTarget");
                this.checkInterval = checkInterval;
                Directory.CreateDirectory(eventDrivenTargetPath);
                Directory.CreateDirectory(timeDrivenTargetPath);
                ProcessExistingDataDrivenFiles();
                ProcessExistingTimeDrivenFiles();
                InitializeEventWatcher();
                InitializeTimeWatcher();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void InitializeEventWatcher()
        {
            try
            {
                eventDrivenWatcher = new FileSystemWatcher
                {
                    Path = eventDrivenPath,
                    NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite,
                    Filter = "*.*"
                };

                eventDrivenWatcher.Created += OnDataDrivenFileCreated;
                eventDrivenWatcher.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing data-driven watcher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void InitializeTimeWatcher()
        {

            try
            {
                timeDrivenWatcher = new FileSystemWatcher
                {
                    Path = timeDrivenPath,
                    NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite,
                    Filter = "*.*"
                };

                timeDrivenWatcher.Created += TimeDrivenCheck;
                timeDrivenWatcher.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing data-driven watcher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TimeDrivenCheck(object sender, FileSystemEventArgs e)
        {
            MoveFile(e.FullPath, timeDrivenTargetPath);
        }
        public void OnDataDrivenFileCreated(object sender, FileSystemEventArgs e)
        {
            MoveFile(e.FullPath, eventDrivenTargetPath);
        }

        private void MoveFile(string filePath, string targetPath)
        {
            try
            {
                while (IsFileLocked(filePath)) ;

                // Get the file name and extension
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string fileExtension = Path.GetExtension(filePath);

                // Create a new filename with the timestamp
                string newFileName = $"{fileName}{fileExtension}";
                string destFile = Path.Combine(targetPath, newFileName);

                // Move the file
                File.Move(filePath, destFile);

                Thread.Sleep(100);

                // Ensure the original file is deleted (should be unnecessary after Move)
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception ex)
            {
                
                    MessageBox.Show($"Error moving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void ProcessExistingDataDrivenFiles()
        {
            try
            {
                var files = Directory.GetFiles(eventDrivenPath);
                foreach (var file in files)
                {
                    MoveFile(file, eventDrivenTargetPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing existing data-driven files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProcessExistingTimeDrivenFiles()
        {
            try
            {
                var files = Directory.GetFiles(timeDrivenPath);
                foreach (var file in files)
                {
                    MoveFile(file, timeDrivenTargetPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing existing data-driven files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private bool IsFileLocked(string filePath)
        {
            try
            {
                using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                return true;
            }
            return false;
        }
    }
}
