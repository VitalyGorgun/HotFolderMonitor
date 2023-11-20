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
                ////////////////////////////////////////////////////////////////////////////////
                case "TableName":
                    if (pair.Value == "RSS (AUTO)") {
                        switch (getSingleNode("//TableName")) {

                            case "Zipper hoodie pallet":
                                if (float.Parse(getSingleNode("HeightMM")) <= 294.5) {//green pad
                                    if (float.Parse(getSingleNode("HeightMM")) + float.Parse(getSingleNode("YOffsetMM")) > 294.5) {
                                        try { setXmlNodes("YCenter", "true"); } catch (Exception) { };
                                    }
                                    try { setXmlNodes(pair.Key, "RSS 15.9x11.75"); } catch (Exception) { }
                                } else if (float.Parse(getSingleNode("HeightMM")) <= 331) {//orange pad
                                    if (float.Parse(getSingleNode("HeightMM")) + float.Parse(getSingleNode("YOffsetMM")) > 331) {
                                        try { setXmlNodes("YCenter", "true"); } catch (Exception) { };
                                    }
                                    try { setXmlNodes(pair.Key, "RSS 15.9x13.1"); } catch (Exception) { }
                                } else if (float.Parse(getSingleNode("HeightMM")) <= 358) {//purple pad
                                    if (float.Parse(getSingleNode("HeightMM")) + float.Parse(getSingleNode("YOffsetMM")) > 358) {
                                        try { setXmlNodes("YCenter", "true"); } catch (Exception) { };
                                    }
                                    try { setXmlNodes(pair.Key, "RSS 15.9x14.25"); } catch (Exception) { }
                                } else {//default blue pad
                                    if (float.Parse(getSingleNode("HeightMM")) + float.Parse(getSingleNode("YOffsetMM")) > 495) {
                                        try { setXmlNodes("YCenter", "true"); } catch (Exception) { };
                                    }
                                    try { setXmlNodes(pair.Key, "RSS 15.9x19.9"); } catch (Exception) { }
                                }
                                break;

                            case "Standard pallet":
                                try { setXmlNodes(pair.Key, "RSS 15.9x19.9"); } catch (Exception) { }
                                break;

                            case "Youth ladies pallet":
                                if (float.Parse(getSingleNode("HeightMM")) <= 370 && float.Parse(getSingleNode("WidthMM")) <= 300) {
                                    try { setXmlNodes(pair.Key, "RSS 11x15"); } catch (Exception) { }
                                } else {//default blue pad
                                    try { setXmlNodes(pair.Key, "RSS 15.9x19.9"); } catch (Exception) { }
                                }
                                try { setXmlNodes(pair.Key, "RSS 11x15"); } catch (Exception) { }
                                break;

                            case "Atlas - Children (L)":
                                try { setXmlNodes(pair.Key, "RSS 10.6x13.2"); } catch (Exception) { }
                                break;

                            case "Atlas - Children (S)":
                                try { setXmlNodes(pair.Key, "RSS 11x10"); } catch (Exception) { }
                                break;

                            case "Children pallet small":
                                try { setXmlNodes(pair.Key, "RSS 11x10"); } catch (Exception) { }
                                break;

                            case "Atlas - Tote bag":
                                try { setXmlNodes(pair.Key, "RSS 10.6x13.2"); } catch (Exception) { }
                                break;

                            case "Tote bag":
                                try { setXmlNodes(pair.Key, "RSS 10.6x13.2"); } catch (Exception) { }
                                break;
                            default:
                                try { setXmlNodes(pair.Key, "RSS 15.9x19.9"); } catch (Exception) { };
                                break;
                        }
                    } else {
                        try { setXmlNodes(pair.Key, pair.Value); } catch (Exception) { };
                    }
                    break;
                ////////////////////////////////////////////////////////////////////////////////


                case "XCenter"://Якщо плік менше 15х15см не центрувати
                    try {
                        if (float.Parse(getSingleNode("HeightMM")) < 150 &&
                            float.Parse(getSingleNode("WidthMM")) < 150) { } else setXmlNodes(pair.Key, pair.Value);
                    } catch (Exception) { }
                    break;
                case "YOffsetMM"://Якщо оффсет + довжинаНадруку > довжиниПалети 
                    try {
                        if (float.Parse(getSingleNode("HeightMM")) + float.Parse(pair.Value) > 495) {
                            float YOffsetMM = 495 - float.Parse(getSingleNode("HeightMM"));
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
