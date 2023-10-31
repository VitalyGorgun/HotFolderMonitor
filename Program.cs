namespace HotFolderMonitor {
    internal static class Program {

        static Mutex mutex = new Mutex(true, "{3B5B51A3-899D-4FC2-926B-AC09A5C710AD}");

        static void Main() {

            if (mutex.WaitOne(TimeSpan.Zero, true)) {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
                mutex.ReleaseMutex();
            } else {
                MessageBox.Show(
                    "The program is already running.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}