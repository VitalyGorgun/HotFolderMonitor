using HFMTouch;

public class FileRemover : FileMonitor {
    private string folderPath;
    private string destinationFolder;

    public FileRemover(string folderPath, string destinationFolder) : base(folderPath) {
        this.folderPath = folderPath;
        this.destinationFolder = destinationFolder;
    }

    protected override void OnFileCreated(object sender, FileSystemEventArgs e) {
        while (File.Exists(e.FullPath)) {
            try {
                string destinationFile = Path.Combine(destinationFolder, Path.GetFileName(e.FullPath));
                if (File.Exists(destinationFile) && File.Exists(e.FullPath)) {
                    while (File.Exists(e.FullPath)) {
                        try {
                            File.Delete(e.FullPath);
                        } catch (Exception) { }
                    }
                }
                File.Move(e.FullPath, destinationFile);
            } catch (IOException) { }
        }
    }
}
