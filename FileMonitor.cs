public class FileMonitor
{
    private FileSystemWatcher watcher;
    private FileHandler fileHandler;
   
    public FileMonitor(string folderPath, Dictionary<string, string> ksfPreset)
    {
        watcher = new FileSystemWatcher(folderPath);
        fileHandler = new FileHandler(ksfPreset, folderPath);
        StartMonitoring();
    }

    public void StartMonitoring()
    {
        watcher.EnableRaisingEvents = true;
        watcher.IncludeSubdirectories = false;
        watcher.Created += OnFileCreated;
        Console.ReadLine();
    }

    public void StopMonitoring()
    {
        watcher.Created -= OnFileCreated; // Видалення обробника подій
        watcher.EnableRaisingEvents = false; // Вимкнення підвищення подій
    }

    private void OnFileCreated(object sender, FileSystemEventArgs e)
    {
        fileHandler.OnCreate(e.FullPath);
    }
}
