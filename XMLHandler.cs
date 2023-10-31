using System.Globalization;
using System.Xml;

public static class XMLHandler {

    private static CultureInfo culture = new("en-US");
    private static XmlDocument xmlDoc = new XmlDocument();

    public static string GetColorProfile(string filePath) {
        xmlDoc.Load(filePath);
        string mediaName = xmlDoc.DocumentElement.SelectSingleNode("//MediaName").InnerText;
        if (mediaName.ToLower().Contains("white") || mediaName.ToLower().Contains("light")) return "light";
        return "color";
    }

    public static void UpdateValues(Dictionary<string, string> values, string filePath) {
        try { xmlDoc.Load(filePath); } catch (Exception) { return; }

        foreach (var pair in values) {
            if (pair.Value == "none") continue;

            switch (pair.Key) {
                case "XCenter"://Якщо плік менше 15х15см не центрувати
                    try {
                        if (float.Parse(getSingleNode("//HeightMM")) < 150 &&
                            float.Parse(getSingleNode("WidthMM")) < 150) { } else setXmlNodes(pair.Key, pair.Value);
                    } catch (Exception) { }
                    break;
                case "YOffsetMM"://Якщо оффсет + довжинаНадруку > довжиниПалети 
                    try {
                        if (float.Parse(getSingleNode("//HeightMM")) + float.Parse(pair.Value) > 495) {
                            float YOffsetMM = 495 - float.Parse(getSingleNode("//HeightMM"));
                            setXmlNodes(pair.Key, YOffsetMM.ToString());
                        } else setXmlNodes(pair.Key, pair.Value);
                    } catch (Exception) { }
                    break;
                default:
                    try { setXmlNodes(pair.Key, pair.Value); } catch (Exception) { }
                    break;
            }
        }
        try { xmlDoc.Save(filePath); } catch (Exception) { }
    }

    private static void setXmlNodes(string key, string value) {
        try {
            XmlNodeList keyNodes = xmlDoc.SelectNodes("//" + key);
            foreach (XmlNode node in keyNodes) node.InnerText = value.ToString(culture);
        } catch (Exception) { }

    }

    private static string getSingleNode(string node) {
        try {
            string currentNode = "//" + node;
            string x = xmlDoc.DocumentElement.SelectSingleNode(node).InnerText;
            return xmlDoc.DocumentElement.SelectSingleNode(node).InnerText;
        } catch (Exception) { return "false"; }
    }
}
