using System.Globalization;
using System.Xml;

public static class XMLHandler
{
    private static CultureInfo culture = new("en-US");
    private static XmlDocument xmlDoc = new XmlDocument();
    public static string GetColorProfile(string filePath)
    {
        xmlDoc.Load(filePath);
        string mediaName = xmlDoc.DocumentElement.SelectSingleNode("//MediaName").InnerText;
        if (mediaName.ToLower().Contains("white") || mediaName.ToLower().Contains("light")) return "light";
        return "color";
    }
    public static void UpdateValues(Dictionary<string, string> values, string filePath)
    {
        xmlDoc.Load(filePath);

        foreach (var pair in values)
        {
            switch (pair.Key)
            {
                case "XCenter":
                    if (pair.Value != "none" && int.Parse(getSingleNode("//HeightMM")) < 150 && int.Parse(getSingleNode("WidthMM")) < 150) { }
                    else if (pair.Value != "none") { setXmlNodes(pair.Key, pair.Value); };
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
    }


    private static void setXmlNodes(string key, string value)
    {
        try
        {
            XmlNodeList keyNodes = xmlDoc.SelectNodes("//" + key);
            foreach (XmlNode node in keyNodes) node.InnerText = value.ToString(culture);
        }
        catch (Exception e)
        {

        }
        
    }
    private static string getSingleNode(string node)
    {
        try{
            string currentNode = "//" + node;
            string x = xmlDoc.DocumentElement.SelectSingleNode(node).InnerText;
            return xmlDoc.DocumentElement.SelectSingleNode(node).InnerText;
        }
        catch(Exception e)
        {
            return "false";
        }

    }
}
