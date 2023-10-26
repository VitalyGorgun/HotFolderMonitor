namespace HotFolderMonitor
{
    public static class Logger
    {
        public static void LogError(string message, Exception ex)
        {
            string filePath = "D:\\QuickP Production\\Common\\errors.log";
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"{DateTime.Now}  {message}  {ex.Message}");
            }
        }
    }
}
