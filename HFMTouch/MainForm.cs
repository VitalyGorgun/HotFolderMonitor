using System.Globalization;

namespace HFMTouch;

public partial class MainForm : Form {
    private string hotFolder;
    private string podatlas;
    public MainForm(string hotFolder, string podatlas) {
        InitializeComponent();
        InitializeForm();
        this.podatlas = podatlas;
        this.hotFolder = hotFolder;
    }

    private void InitializeForm() {
        this.comboBox1.SelectedIndex = 0;
        this.StartPosition = FormStartPosition.Manual;
        this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        this.Height = Screen.FromControl(this).WorkingArea.Height;
        this.TopMost = true;
    }
    private void startButtonOnClick(object sender, EventArgs e) {
        FileRemover FileRemover = new FileRemover(podatlas, hotFolder);
        HotFolderHandler HotFolderHandler = new HotFolderHandler(hotFolder, pressetConfigurator());
        VisibilityRestorerWindow MaximizeBTNWindow = new VisibilityRestorerWindow(this, HotFolderHandler, FileRemover);
        MaximizeBTNWindow.Show();
        MaximizeBTNWindow.Location = new Point(this.Location.X + this.Width - MaximizeBTNWindow.Width, this.Location.Y + this.Height / 2);
        this.Hide();
    }
    private Dictionary<string, string> pressetConfigurator() {
        CultureInfo culture = new("en-US");
        Dictionary<string, string> values = new() { };
        if (comboBox1.SelectedItem.ToString() != "[DEFAULT]") values.Add("TableName", comboBox1.SelectedItem.ToString());
        if (SprayTrackBar.Enabled) values.Add("SprayAmount", label8.Text);
        if (SprayTrackBar.Enabled) values.Add("LinearSprayAmount", label8.Text);
        if (yOffsetTrackBar.Enabled) values.Add("YOffsetMM", label2.Text);
        if (PHTrackBar.Enabled) values.Add("MediaPrintHeight", label4.Text);
        if (MTTrackBar.Enabled) values.Add("MediaThickness", label6.Text);
        if (customCheckBox1.Enabled) values.Add("XCenter", customCheckBox1.IsChecked.ToString().ToLower());
        if (customCheckBox2.Enabled) values.Add("Color4DInterlace", customCheckBox2.IsChecked.ToString().ToLower());
        if (customCheckBox2.Enabled) values.Add("White4DInterlace", customCheckBox2.IsChecked.ToString().ToLower());
        values.Add("TotalCopies", "1");
        values.Add("IsSpray", "true");
        values.Add("IsWipe", "true");

        return values;
    }
    private void interfaceEvents(object sender, EventArgs e) {
        if (sender is CustomToggle toggle) {
            switch (toggle.Name) {
                case "sprayToggle":
                    if (sprayToggle.IsChecked) {
                        SprayTrackBar.Enabled = true;
                        label8.ForeColor = Color.FromArgb(225, 225, 225);
                        label9.ForeColor = Color.FromArgb(0, 106, 78);
                    } else {
                        SprayTrackBar.Enabled = false;
                        label8.ForeColor = Color.Gray;
                        label9.ForeColor = Color.Gray;
                    }
                    break;
                case "yOffsetToggle":
                    if (yOffsetToggle.IsChecked) {
                        yOffsetTrackBar.Enabled = true;
                        label3.ForeColor = Color.FromArgb(0, 106, 78);
                        label2.ForeColor = Color.FromArgb(225, 225, 225);
                    } else {
                        yOffsetTrackBar.Enabled = false;
                        label3.ForeColor = Color.Gray;
                        label2.ForeColor = Color.Gray;
                    }
                    break;
                case "PHToggle":
                    if (PHToggle.IsChecked) {
                        PHTrackBar.Enabled = true;
                        label4.ForeColor = Color.FromArgb(225, 225, 225);
                        label5.ForeColor = Color.FromArgb(0, 106, 78);
                    } else {
                        PHTrackBar.Enabled = false;
                        label4.ForeColor = Color.Gray;
                        label5.ForeColor = Color.Gray;
                    }
                    break;
                case "MTToggle":
                    if (MTToggle.IsChecked) {
                        MTTrackBar.Enabled = true;
                        label6.ForeColor = Color.FromArgb(225, 225, 225);
                        label7.ForeColor = Color.FromArgb(0, 106, 78);
                    } else {
                        MTTrackBar.Enabled = false;
                        label6.ForeColor = Color.Gray;
                        label7.ForeColor = Color.Gray;
                    }
                    break;
                case "xCenterToggle":
                    label10.ForeColor = xCenterToggle.IsChecked ? Color.FromArgb(0, 106, 78) : Color.Gray;
                    customCheckBox1.Enabled = xCenterToggle.IsChecked ? true : false;
                    break;
                case "fourPassToggle":
                    label11.ForeColor = fourPassToggle.IsChecked ? Color.FromArgb(0, 106, 78) : Color.Gray;
                    customCheckBox2.Enabled = fourPassToggle.IsChecked ? true : false;
                    break;
            }
        } else if (sender is CustomTrackBar trackBar) {
            switch (trackBar.Name) {
                case "SprayTrackBar":
                    label8.Text = (SprayTrackBar.Value * 5).ToString();
                    break;
                case "yOffsetTrackBar":
                    label2.Text = (yOffsetTrackBar.Value * 10).ToString();
                    break;
                case "PHTrackBar":
                    label4.Text = (PHTrackBar.Value / 2.0f).ToString("F1", CultureInfo.InvariantCulture);
                    break;
                case "MTTrackBar":
                    label6.Text = (MTTrackBar.Value / 2.0f).ToString("F1", CultureInfo.InvariantCulture);
                    break;
            }
        } else if (sender is Button button) {
            switch (button.Name) {
                case "closeButton":
                    this.Close();
                    break;
            }
        }
    }
}