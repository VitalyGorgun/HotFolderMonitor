﻿public class FileHandler
{
    private string? colorProfile;
    private string? packageName;
    private string tempExtension;
    private string folderPath;
    private Dictionary<string, string> ksfPreset;
    public FileHandler(Dictionary<string, string> dictionary, string folderPath)
    {
        tempExtension = "-processed";
        ksfPreset = dictionary;
        this.folderPath = folderPath;
    }
    public void OnCreate(string filePath)
    {
        if (File.Exists(filePath))
        {
            string extension = Path.GetExtension(filePath).ToLower();
            if (extension == ".tif")
            {
                RenameFile(filePath);
                if (isPackageFull()) ReturnValues();
            }
            else if (extension == ".ksf")
            {
                packageName = Path.GetFileNameWithoutExtension(filePath).Substring(0, Path.GetFileNameWithoutExtension(filePath).Length - 1);
                RenameFile(filePath);
                colorProfile = XMLHandler.GetColorProfile(filePath + tempExtension);
                XMLHandler.UpdateValues(ksfPreset, filePath + tempExtension);
                if (isPackageFull()) ReturnValues();
            }
            else DeleteFile(filePath);
        }
    }

    private void ReturnValues()
    {
        string[] filesToRename = Directory.GetFiles(folderPath).Where(file => Path.GetFileName(file).Contains(packageName)).ToArray();
        foreach (string file in filesToRename)
        {
            string returnedName = file.Substring(0, file.Length - tempExtension.Length); ;
            while (File.Exists(file)) { try { File.Move(file, returnedName); } catch (IOException) { } }
        }
        string[] filesToDelete = Directory.GetFiles(folderPath).Where(file => !Path.GetFileName(file).Contains(packageName)).ToArray();
        foreach (string file in filesToDelete) { DeleteFile(file); }
    }
    private bool isPackageFull()
    {
        if (colorProfile != null && colorProfile == "light")
        {
            if (File.Exists(folderPath + "\\" + packageName + "C.ksf" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "C.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "G.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "K.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "M.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "R.tif" + tempExtension) &&
                File.Exists(folderPath + "\\" + packageName + "Y.tif" + tempExtension)) return true;
        }
        else if (colorProfile != null && colorProfile == "color")
        {
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
    private void RenameFile(string filePath)
    {
        while (File.Exists(filePath) && !File.Exists(filePath + tempExtension))
        {
            try { File.Move(filePath, filePath + tempExtension); }
            catch (IOException) { }
        }
    }
    private void DeleteFile(string filePath)
    {
        while (File.Exists(filePath))
        {
            try { File.Delete(filePath); }
            catch (IOException) { }
        }
    }
}
