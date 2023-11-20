using HFMTouch;

public class HotFolderHandler : FileMonitor {

    private string? colorProfile;
    private string? packageName;
    private string tempExtension;
    private string folderPath;
    private Dictionary<string, string> ksfPreset;

    public HotFolderHandler(string folderPath, Dictionary<string, string> dictionary) : base(folderPath) {
        tempExtension = "-processed";
        ksfPreset = dictionary;
        this.folderPath = folderPath;
    }

    protected override void OnFileCreated(object sender, FileSystemEventArgs e) {
        if (File.Exists(e.FullPath)) {
            packageName = Path.GetFileNameWithoutExtension(e.FullPath).Substring(0, Path.GetFileNameWithoutExtension(e.FullPath).Length - 1);

            if (Path.GetExtension(e.FullPath).ToLower() == ".tif") {
                if (!File.Exists(e.FullPath + tempExtension)) FileExstensionHandler.SetTempExtension(e.FullPath, tempExtension);
                if (PackageFullChecker.isPackageFull(colorProfile, folderPath, packageName, tempExtension))
                    FileExstensionHandler.DeleteTempExtension(folderPath, packageName, tempExtension);

            } else if (Path.GetExtension(e.FullPath).ToLower() == ".ksf") {
                if (!File.Exists(e.FullPath + tempExtension)) FileExstensionHandler.SetTempExtension(e.FullPath, tempExtension);
                colorProfile = XMLHandler.GetColorProfile(e.FullPath + tempExtension);
                XMLHandler.UpdateValues(ksfPreset, e.FullPath + tempExtension);
                if (PackageFullChecker.isPackageFull(colorProfile, folderPath, packageName, tempExtension))
                    FileExstensionHandler.DeleteTempExtension(folderPath, packageName, tempExtension);

            } else FileHandlerTools.DeleteFile(e.FullPath);
        }
    }
}