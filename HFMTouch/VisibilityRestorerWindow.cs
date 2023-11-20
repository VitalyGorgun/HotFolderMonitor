namespace HFMTouch;
public partial class VisibilityRestorerWindow : Form {
    MainForm Form;
    HotFolderHandler HotFolderMonitor;
    FileRemover FileRemover;
    public VisibilityRestorerWindow(MainForm mainForm, HotFolderHandler handler,FileRemover fileRemover) {
        InitializeComponent();
        this.TopMost = true;
        this.Form = mainForm;
        this.FileRemover = fileRemover;
        this.HotFolderMonitor = handler;
    }

    private void maximizeButtonOnClick(object sender, EventArgs e) {
        this.Form.Show();
        this.Close();
        HotFolderMonitor.StopMonitoring();
        FileRemover.StopMonitoring();
    }
}
