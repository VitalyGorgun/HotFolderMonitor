using HF_FIX;
using System.Globalization;
using System.Timers;

namespace HotFolderMonitor
{
    public partial class Form1 : Form
    {
        FileProcessor x;
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

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
                    ["TableName"] = comboBox1.Enabled ? comboBox1.SelectedItem.ToString() : "none",
                    ["TotalCopies"] = "1",
                    ["MediaPrintHeight"] = printHeight.Enabled ? printHeight.Value.ToString(culture) : "none",
                    ["MediaThickness"] = mediaThikness.Enabled ? mediaThikness.Value.ToString(culture) : "none",
                    ["SprayAmount"] = sprayAmount.Enabled ? sprayAmount.Value.ToString(culture) : "none",
                    ["LinearSprayAmount"] = sprayAmount.Enabled ? sprayAmount.Value.ToString(culture) : "none",
                    ["YOffsetMM"] = yOffset.Enabled ? yOffset.Value.ToString(culture) : "none",
                    ["XCenter"] = xCenter.Enabled ? xCenter.Checked.ToString().ToLower() : "none",
                    ["YCenter"] = yOffset.Enabled ? "false" : "none",
                    ["IsSpray"] = "true",
                    ["IsWipe"] = "true"
                };

                x = new FileProcessor("D:\\QuickP Production\\Common\\HotFolder", values);

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
                    case "label3":
                        printHeight.Enabled = !printHeight.Enabled;
                        label3.ForeColor = printHeight.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "label4":
                        mediaThikness.Enabled = !mediaThikness.Enabled;
                        label4.ForeColor = mediaThikness.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "label5":
                        sprayAmount.Enabled = !sprayAmount.Enabled;
                        label5.ForeColor = sprayAmount.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "label6":
                        yOffset.Enabled = !yOffset.Enabled;
                        label6.ForeColor = yOffset.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "label7":
                        xCenter.Enabled = !xCenter.Enabled;
                        label7.ForeColor = xCenter.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "label10":
                        comboBox1.Enabled = !comboBox1.Enabled;
                        label10.ForeColor = comboBox1.Enabled ? Color.Black : Color.Gray;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}