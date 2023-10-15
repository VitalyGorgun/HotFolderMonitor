using HF_FIX;

namespace HotFolderMonitor
{
    public partial class Form1 : Form
    {
        FileProcessor x;
        public Form1() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                x = new FileProcessor(label1.Text);

                x.copies = (int)numericUpDown1.Value;
                x.printHeight = (float)numericUpDown2.Value;
                x.mediaThikness = (float)numericUpDown3.Value;

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
    }
}