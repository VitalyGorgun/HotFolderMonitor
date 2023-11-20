namespace HFMTouch;

internal static class Program {
    [STAThread]

    static void Main() {
        string hotFolder = "D:\\QuickP Production\\Common\\HotFolder";
        string podatlas = "D:\\QuickP Production\\Common\\PODATLAS";
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm(hotFolder,podatlas));

    }
}