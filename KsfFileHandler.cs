using System.Globalization;
using System.Xml;

namespace HotFolderMonitor
{
    internal class KsfFileHandler
    {
        private string filePath;
        private XmlDocument xmlDoc = new();

        public KsfFileHandler(string filePath)
        {
            this.filePath = filePath;
        }

        public string ReturnColorProfile()
        {
            xmlDoc.Load(filePath);
            string mediaName = xmlDoc.DocumentElement.SelectSingleNode("//MediaName").InnerText.ToLower();
            if (mediaName.Contains("white")
                || mediaName.Contains("light")) return "white";
            else return "another";

        }

        public void UpdateValues(Dictionary<string, string> values)
        {
            CultureInfo culture = new("en-US");
            xmlDoc.Load(filePath);

            foreach (var pair in values)
            {
                string key = pair.Key;
                string value = pair.Value;

                if (value != "none")
                {
                    XmlNodeList keyNodes = xmlDoc.SelectNodes("//" + key);
                    foreach (XmlNode node in keyNodes)
                    {
                        node.InnerText = value.ToString(culture);
                    }
                }
            }
            xmlDoc.Save(filePath);
            File.Move(filePath, filePath + "-processed");// Rename the processed file by appending "-processed" to its name
        }
    }
}
