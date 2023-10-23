using System.Globalization;
using System.Timers;

namespace HotFolderMonitor
{
    public partial class Form1 : Form
    {
        FileMonitor x;
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            palletNameComboBox.SelectedIndex = 0;

            timer = new System.Timers.Timer();
            timer.Interval = 30000; // Інтервал в мілісекундах (60 000 мс = 1 хвилина)
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)//  Таймер на вимкнення
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime.TimeOfDay >= new TimeSpan(21, 45, 0) && currentTime.TimeOfDay < new TimeSpan(21, 46, 0) ||
                currentTime.TimeOfDay >= new TimeSpan(13, 45, 0) && currentTime.TimeOfDay < new TimeSpan(13, 46, 0) ||
                currentTime.TimeOfDay >= new TimeSpan(5, 45, 0) && currentTime.TimeOfDay < new TimeSpan(5, 46, 0))
            { this.Invoke(new Action(() => { this.Close(); })); }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                CultureInfo culture = new("en-US");
                Dictionary<string, string> values = new()
                {
                    ["TableName"] = palletNameComboBox.Enabled ? palletNameComboBox.SelectedItem.ToString() : "none",
                    ["TotalCopies"] = "1",
                    ["MediaPrintHeight"] = printHeight.Enabled ? printHeight.Value.ToString(culture) : "none",
                    ["MediaThickness"] = mediaThikness.Enabled ? mediaThikness.Value.ToString(culture) : "none",
                    ["SprayAmount"] = sprayAmount.Enabled ? sprayAmount.Value.ToString(culture) : "none",
                    ["LinearSprayAmount"] = sprayAmount.Enabled ? sprayAmount.Value.ToString(culture) : "none",
                    ["YOffsetMM"] = yOffset.Enabled ? yOffset.Value.ToString(culture) : "none",
                    ["XCenter"] = xCenter.Enabled ? xCenter.Checked.ToString().ToLower() : "none",
                    ["YCenter"] = yOffset.Enabled ? "false" : "none",
                    ["IsSpray"] = "true",
                    ["IsWipe"] = "true",
                    ["Color4DInterlace"] = fourPassCheckBox.Enabled ? fourPassCheckBox.Checked.ToString().ToLower() : "none",
                    ["White4DInterlace"] = fourPassCheckBox.Enabled ? fourPassCheckBox.Checked.ToString().ToLower() : "none",
                };

                x = new FileMonitor("D:\\QuickP Production\\Common\\HotFolder", values);
                this.Hide();// Згортаємо вікно в трей
                notifyIcon1.Visible = true;// Відображаємо іконку в треї
            }
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();// При кліку на іконку трею відновлюємо вікно
            x.StopMonitoring();
            notifyIcon1.Visible = false; // Ховаємо іконку в треї
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (sender is Label clickedLabel)
            {
                switch (clickedLabel.Name)
                {
                    case "palletNameLabel":
                        palletNameComboBox.Enabled = !palletNameComboBox.Enabled;
                        palletNameComboBox.ForeColor = palletNameComboBox.Enabled ? Color.Black : Color.Gray;
                        palletNameLabel.ForeColor = palletNameComboBox.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "printHeightLabel":
                        printHeight.Enabled = !printHeight.Enabled;
                        printHeightLabel.ForeColor = printHeight.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "mediaThiknessLabel":
                        mediaThikness.Enabled = !mediaThikness.Enabled;
                        mediaThiknessLabel.ForeColor = mediaThikness.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "sprayLabel":
                        sprayAmount.Enabled = !sprayAmount.Enabled;
                        sprayLabel.ForeColor = sprayAmount.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "yOffsetLabel":
                        yOffset.Enabled = !yOffset.Enabled;
                        yOffsetLabel.ForeColor = yOffset.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "xCenterLabel":
                        xCenter.Enabled = !xCenter.Enabled;
                        xCenterLabel.ForeColor = xCenter.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "fourPassLabel":
                        fourPassCheckBox.Enabled = !fourPassCheckBox.Enabled;
                        fourPassLabel.ForeColor = fourPassCheckBox.Enabled ? Color.Black : Color.Gray;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}