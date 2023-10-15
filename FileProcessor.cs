using System.Globalization;
using System.Xml;

namespace HF_FIX
{
    internal class FileProcessor
    {
        private bool isMonitoring = true;
        private string DirectoryPath;        // The directory path where files are processed
        private string CurrentColorProfile;  // The current color profile being processed

        public int copies;
        public float printHeight;
        public float mediaThikness;


        CultureInfo culture = new CultureInfo("en-US");

        public FileProcessor(string directoryPath)
        {
            DirectoryPath = directoryPath;
            InitializeWatcher();
        }

        private void InitializeWatcher()
        {
            // Set up a FileSystemWatcher to monitor the specified directory
            FileSystemWatcher watcher = new FileSystemWatcher(DirectoryPath);
            watcher.EnableRaisingEvents = true;
            watcher.Created += (sender, e) => OnFileCreated(e.FullPath);
        }

        public void StopMonitoring() { isMonitoring = false; }

        private void OnFileCreated(string fullPath)
        {
            if (!isMonitoring) return;
            while (IsFileLocked(fullPath)) { System.Threading.Thread.Sleep(1); }
            string extension = Path.GetExtension(fullPath).ToLower();

            // Determine how to process the file based on its extension
            if (extension == ".ksf") { ProcessKsfFile(fullPath); }
            else if (extension == ".tif") { ProcessTifFile(fullPath); }
            else { File.Delete(fullPath); }

            // Check if a package is complete and ready to be returned
            if (IsPackageFull()) ReturnValues();
        }

        private bool IsFileLocked(string filePath)
        {
            try
            {
                // Attempt to open the file in exclusive mode; if successful, it's not locked
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None)) { return false; }
            }
            catch (IOException)
            {
                return true; // The file is locked
            }
        }

        private void ProcessKsfFile(string fullPath)
        {
            string xmlFilePath = fullPath;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            string mediaName = xmlDoc.DocumentElement.SelectSingleNode("//MediaName").InnerText.ToLower();
            if (mediaName.Contains("white") || mediaName.Contains("white")) CurrentColorProfile = "white";
            else CurrentColorProfile = "another";

            if (mediaThikness != 0)
            {
                xmlDoc.DocumentElement.SelectSingleNode("//MediaThickness").InnerText = mediaThikness.ToString(culture);
                xmlDoc.Save(fullPath);
            }
            if (printHeight != 0)
            {
                xmlDoc.DocumentElement.SelectSingleNode("//MediaPrintHeight").InnerText = printHeight.ToString(culture);
                xmlDoc.Save(fullPath);
            }
            if (copies != 0)
            {
                xmlDoc.DocumentElement.SelectSingleNode("//TotalCopies").InnerText = copies.ToString(culture);
                xmlDoc.Save(fullPath);
            }

            File.Move(fullPath, fullPath + "-processed");// Rename the processed file by appending "-processed" to its name
        }

        private void ProcessTifFile(string fullPath)
        {
            // Rename the processed file by appending "-processed" to its name
            File.Move(fullPath, fullPath + "-processed");
        }

        private bool IsPackageFull()
        {
            string[] fileExtensions = CurrentColorProfile == "white"
                ? new string[] { "c.ksf-processed", "c.tif-processed", "g.tif-processed", "k.tif-processed", "m.tif-processed", "r.tif-processed", "y.tif-processed" }
                : new string[] { "c.ksf-processed", "c.tif-processed", "g.tif-processed", "k.tif-processed", "m.tif-processed", "r.tif-processed", "w.tif-processed", "y.tif-processed" };

            // Check if all expected files for the current color profile are present in the directory
            foreach (string fileExtension in fileExtensions)
            {
                if (!Directory.GetFiles(DirectoryPath).Any(str => str.ToLower().Contains(fileExtension))) { return false; }
            }
            return true;
        }

        private void ReturnValues()
        {
            string[] files = Directory.GetFiles(DirectoryPath);
            foreach (string filePath in files)
            {
                string extension = Path.GetExtension(filePath);
                if (!string.IsNullOrEmpty(extension))
                {
                    // If the file is a TIFF, rename it with a ".tif" extension
                    if (extension.ToLower().Contains("tif"))
                    {
                        string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath) + ".tif");
                        File.Move(filePath, newFilePath);
                    }

                    // If the file is a KSF, rename it with a ".ksf" extension
                    if (extension.ToLower().Contains("ksf"))
                    {
                        string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath) + ".ksf");
                        File.Move(filePath, newFilePath);
                    }
                }
            }
        }
    }
}
