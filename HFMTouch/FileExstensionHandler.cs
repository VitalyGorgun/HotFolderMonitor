namespace HFMTouch;
public static class FileExstensionHandler {
    public static void SetTempExtension(string filePath, string tempExtension) {
        try {
            while (File.Exists(filePath) && !File.Exists(filePath + tempExtension)) {
                try { File.Move(filePath, filePath + tempExtension); } catch (IOException) { }
            }
        } catch (Exception) { }
    }

    public static void DeleteTempExtension(string folderPath, string packageName, string tempExtension) {
        try {
            string[] filesToRename = Directory.GetFiles(folderPath).Where(file => Path.GetFileName(file).Contains(packageName)).ToArray();
            foreach (string file in filesToRename) {
                string returnedName = file.Substring(0, file.Length - tempExtension.Length);

                while (File.Exists(file)) {
                    try {
                        if (!File.Exists(returnedName)) {
                            File.Move(file, returnedName);
                        };
                    } catch (IOException) { }
                }
            }
            string[] filesToDelete = Directory.GetFiles(folderPath).Where(file => !Path.GetFileName(file).Contains(packageName)).ToArray();
            foreach (string file in filesToDelete) { FileHandlerTools.DeleteFile(file); }
        } catch (Exception) { }
    }
}
