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
            xmlDoc.Load(filePath);
        }

        public string ReturnColorProfile()
        {
            return getSingleNode("MediaName").ToLower() == "light" ||
                getSingleNode("MediaName").ToLower() == "white" ? "white" : "black";
        }

        public void UpdateValues(Dictionary<string, string> values)
        {
            foreach (var pair in values)
            {
                switch (pair.Key)
                {
                    case "XCenter":
                        if (pair.Value != "none" && int.Parse(getSingleNode("//HeightMM")) < 150 && int.Parse(getSingleNode("WidthMM")) < 150) { }
                        else if(pair.Value != "none") { setXmlNodes(pair.Key, pair.Value); };
                        break;
                    case "YOffsetMM":

                        if (pair.Value != "none" && int.Parse(getSingleNode("//HeightMM")) + int.Parse(pair.Value) > 495)
                        {
                            int YOffsetMM = 495 - int.Parse(getSingleNode("//HeightMM"));
                            setXmlNodes(pair.Key, YOffsetMM.ToString());
                        }
                        else if (pair.Value != "none") setXmlNodes(pair.Key, pair.Value);
                        break;
                    default:
                        if (pair.Value != "none") setXmlNodes(pair.Key, pair.Value);
                        break;
                }
            }
            xmlDoc.Save(filePath);
            File.Move(filePath, filePath + "-processed");// Rename the processed file by appending "-processed" to its name
        }
        private void setXmlNodes(string key, string value)
        {
            CultureInfo culture = new("en-US");
            XmlNodeList keyNodes = xmlDoc.SelectNodes("//" + key);
            foreach (XmlNode node in keyNodes)
            {
                node.InnerText = value.ToString(culture);
            }
        }

        private string getSingleNode(string node)
        {
            string currentNode = "//" + node;
            string x = xmlDoc.DocumentElement.SelectSingleNode(node).InnerText;
            return xmlDoc.DocumentElement.SelectSingleNode(node).InnerText;
        }
    }
}
