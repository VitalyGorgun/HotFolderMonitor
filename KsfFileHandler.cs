using System.Xml;

namespace HotFolderMonitor
{
    internal class KsfFileHandler
    {

        private string filePath;
        private XmlDocument xmlDoc = new XmlDocument();

        public KsfFileHandler(string filePath) 
        {
            this.filePath = filePath;
        }
        public string returnColorProfile(string fullPath)
        {
            xmlDoc.Load(filePath);

            string mediaName = xmlDoc.DocumentElement.SelectSingleNode("//MediaName").InnerText.ToLower();
            if (mediaName.Contains("white") || mediaName.Contains("white")) return "white";
            else return "another";
        }
        public void updateValues(string fullPath)
        {

        }
    }
}
