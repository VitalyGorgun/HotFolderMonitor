namespace HFMTouch;

public abstract class FileMonitor {
    protected FileSystemWatcher watcher;

    protected FileMonitor(string folderPath) {
        watcher = new FileSystemWatcher(folderPath);
        StartMonitoring();
    }

    protected void StartMonitoring() {
        watcher.EnableRaisingEvents = true;
        watcher.IncludeSubdirectories = false;
        watcher.Created += OnFileCreated;
        Console.ReadLine();
    }
    public void StopMonitoring() {
        watcher.Created -= OnFileCreated;
        watcher.EnableRaisingEvents = false;
    }

    protected abstract void OnFileCreated(object sender, FileSystemEventArgs e);
}