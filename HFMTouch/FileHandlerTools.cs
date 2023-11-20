namespace HFMTouch;
public static class FileHandlerTools {
    public static void DeleteFile(string filePath) {
        try {
            while (File.Exists(filePath)) {
                try {
                    File.Delete(filePath);
                } catch (IOException) { }
            }
        } catch (Exception) { }
    }

}
