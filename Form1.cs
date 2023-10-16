using HF_FIX;
using System.Globalization;

namespace HotFolderMonitor
{
    public partial class Form1 : Form
    {
        FileProcessor x;
        public Form1() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                CultureInfo culture = new CultureInfo("en-US");
                Dictionary<string, string> values = new Dictionary<string, string>();
                values["TotalCopies"] = copiesValue.Enabled ? copiesValue.Value.ToString(culture) : "none";
                values["MediaPrintHeight"] = printHeight.Enabled ? printHeight.Value.ToString(culture) : "none";
                values["MediaThickness"] = mediaThikness.Enabled ? mediaThikness.Value.ToString(culture) : "none";
                values["SprayAmount"] = sprayAmount.Enabled ? sprayAmount.Value.ToString(culture) : "none";
                values["LinearSprayAmount"] = sprayAmount.Enabled ? sprayAmount.Value.ToString(culture) : "none";
                values["YOffsetMM"] = yOffset.Enabled ? yOffset.Value.ToString(culture) : "none";
                values["XCenter"] = xCenter.Enabled ? xCenter.Checked.ToString() : "none";
                values["YCenter"] = yOffset.Enabled ? "false" : "none";
                values["IsSpray"] = spray.Enabled ? spray.Checked.ToString() : "none";
                values["IsWipe"] = wipe.Enabled ? wipe.Checked.ToString() : "none";

                x = new FileProcessor(label1.Text, values);

                this.Hide();// Згортаємо вікно в трей
                notifyIcon1.Visible = true;// Відображаємо іконку в треї
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();// При кліку на іконку трею відновлюємо вікно
            x.StopMonitoring();
            notifyIcon1.Visible = false; // Ховаємо іконку в треї
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();// Відкрити діалогове вікно вибору папки
                if (result == DialogResult.OK)
                {
                    label1.Text = folderBrowser.SelectedPath;// Оновити текст Label і встановити його на повний шлях вибраної папки
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            copiesValue.Enabled = copiesValue.Enabled ? false : true;
            label2.ForeColor = copiesValue.Enabled ? Color.Black : Color.Gray;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            printHeight.Enabled = printHeight.Enabled ? false : true;
            label3.ForeColor = printHeight.Enabled ? Color.Black : Color.Gray;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            mediaThikness.Enabled = mediaThikness.Enabled ? false : true;
            label4.ForeColor = mediaThikness.Enabled ? Color.Black : Color.Gray;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            sprayAmount.Enabled = sprayAmount.Enabled ? false : true;
            label5.ForeColor = sprayAmount.Enabled ? Color.Black : Color.Gray;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            yOffset.Enabled = yOffset.Enabled ? false : true;
            label6.ForeColor = yOffset.Enabled ? Color.Black : Color.Gray;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            xCenter.Enabled = xCenter.Enabled ? false : true;
            label7.ForeColor = xCenter.Enabled ? Color.Black : Color.Gray;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            spray.Enabled = spray.Enabled ? false : true;
            label8.ForeColor = spray.Enabled ? Color.Black : Color.Gray;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            wipe.Enabled = wipe.Enabled ? false : true;
            label9.ForeColor = wipe.Enabled ? Color.Black : Color.Gray;
        }
    }
}