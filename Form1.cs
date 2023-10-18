using HF_FIX;
using System.Globalization;

namespace HotFolderMonitor
{
    public partial class Form1 : Form
    {
        FileProcessor x;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                CultureInfo culture = new("en-US");
                Dictionary<string, string> values = new()
                {
                    ["TableName"] = comboBox1.Enabled ? comboBox1.SelectedItem.ToString() : "none",
                    ["TotalCopies"] = copiesValue.Enabled ? copiesValue.Value.ToString(culture) : "none",
                    ["MediaPrintHeight"] = printHeight.Enabled ? printHeight.Value.ToString(culture) : "none",
                    ["MediaThickness"] = mediaThikness.Enabled ? mediaThikness.Value.ToString(culture) : "none",
                    ["SprayAmount"] = sprayAmount.Enabled ? sprayAmount.Value.ToString(culture) : "none",
                    ["LinearSprayAmount"] = sprayAmount.Enabled ? sprayAmount.Value.ToString(culture) : "none",
                    ["YOffsetMM"] = yOffset.Enabled ? yOffset.Value.ToString(culture) : "none",
                    ["XCenter"] = xCenter.Enabled ? xCenter.Checked.ToString().ToLower() : "none",
                    ["YCenter"] = yOffset.Enabled ? "false" : "none",
                    ["IsSpray"] = spray.Enabled ? spray.Checked.ToString().ToLower() : "none",
                    ["IsWipe"] = wipe.Enabled ? wipe.Checked.ToString().ToLower() : "none"
                };

                x = new FileProcessor(label1.Text, values);

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
                    case "label1":
                        using (FolderBrowserDialog folderBrowser = new())
                        {
                            DialogResult result = folderBrowser.ShowDialog();// Відкрити діалогове вікно вибору папки
                            if (result == DialogResult.OK)
                            {
                                label1.Text = folderBrowser.SelectedPath;// Оновити текст Label і встановити його на повний шлях вибраної папки
                            }
                        }
                        break;
                    case "label2":
                        copiesValue.Enabled = !copiesValue.Enabled;
                        label2.ForeColor = copiesValue.Enabled ? Color.Black : Color.Gray;
                        break;

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
                    case "label8":
                        spray.Enabled = !spray.Enabled;
                        label8.ForeColor = spray.Enabled ? Color.Black : Color.Gray;
                        break;
                    case "label9":
                        wipe.Enabled = !wipe.Enabled;
                        label9.ForeColor = wipe.Enabled ? Color.Black : Color.Gray;
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