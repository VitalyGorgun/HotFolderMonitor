namespace HFMTouch;
public static class PackageFullChecker {
    public static bool isPackageFull(string colorProfile, string folderPath, string packageName, string tempExtension) {
        if (colorProfile != null && colorProfile == "light") {
            if (File.Exists(folderPath + "\\" + packageName + "C.ksf" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "C.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "G.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "K.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "M.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "R.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "Y.tif" + tempExtension)) return true;
        } else if (colorProfile != null && colorProfile == "color") {
            if (File.Exists(folderPath + "\\" + packageName + "C.ksf" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "C.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "G.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "K.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "M.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "R.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "W.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "Y.tif" + tempExtension)) return true;
        }
        return false;
    }
}
