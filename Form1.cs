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

                this.Hide();// �������� ���� � ����
                notifyIcon1.Visible = true;// ³��������� ������ � ���
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();// ��� ���� �� ������ ���� ���������� ����
            x.StopMonitoring();
            notifyIcon1.Visible = false; // ������ ������ � ���
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();// ³������ �������� ���� ������ �����
                if (result == DialogResult.OK)
                {
                    label1.Text = folderBrowser.SelectedPath;// ������� ����� Label � ���������� ���� �� ������ ���� ������� �����
                }
            }
        }
    }
}