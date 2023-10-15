using System.Globalization;
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

        public string returnColorProfile()
        {
            xmlDoc.Load(filePath);
            string mediaName = xmlDoc.DocumentElement.SelectSingleNode("//MediaName").InnerText.ToLower();
            if (mediaName.Contains("white")
                || mediaName.Contains("light")) return "white";
            else return "another";

        }

        public void updateValues(Dictionary<string, float> values)
        {
            CultureInfo culture = new CultureInfo("en-US");
            xmlDoc.Load(filePath);

            foreach (var pair in values)
            {
                string key = pair.Key;
                float value = pair.Value;

                if (value != 0)
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
