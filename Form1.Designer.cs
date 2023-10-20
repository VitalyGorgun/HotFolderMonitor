namespace HotFolderMonitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            printHeight = new NumericUpDown();
            mediaThikness = new NumericUpDown();
            notifyIcon1 = new NotifyIcon(components);
            label3 = new Label();
            label4 = new Label();
            sprayAmount = new NumericUpDown();
            label5 = new Label();
            yOffset = new NumericUpDown();
            label6 = new Label();
            xCenter = new CheckBox();
            groupBox1 = new GroupBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)printHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mediaThikness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprayAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yOffset).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(310, 40);
            button1.TabIndex = 1;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // printHeight
            // 
            printHeight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            printHeight.DecimalPlaces = 1;
            printHeight.Enabled = false;
            printHeight.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            printHeight.Location = new Point(107, 3);
            printHeight.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            printHeight.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            printHeight.Name = "printHeight";
            printHeight.Size = new Size(38, 23);
            printHeight.TabIndex = 3;
            printHeight.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // mediaThikness
            // 
            mediaThikness.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mediaThikness.DecimalPlaces = 1;
            mediaThikness.Enabled = false;
            mediaThikness.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            mediaThikness.Location = new Point(255, 3);
            mediaThikness.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            mediaThikness.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            mediaThikness.Name = "mediaThikness";
            mediaThikness.Size = new Size(40, 23);
            mediaThikness.TabIndex = 4;
            mediaThikness.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "HotFolder Monitor";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += NotifyIcon1_MouseClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(3, 7);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Print height";
            label3.Click += Label_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(151, 7);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 7;
            label4.Text = "Media thikness";
            label4.Click += Label_Click;
            // 
            // sprayAmount
            // 
            sprayAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sprayAmount.Enabled = false;
            sprayAmount.Location = new Point(255, 32);
            sprayAmount.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            sprayAmount.Name = "sprayAmount";
            sprayAmount.Size = new Size(40, 23);
            sprayAmount.TabIndex = 8;
            sprayAmount.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(151, 36);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 9;
            label5.Text = "Spray";
            label5.Click += Label_Click;
            // 
            // yOffset
            // 
            yOffset.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yOffset.Enabled = false;
            yOffset.Location = new Point(107, 32);
            yOffset.Name = "yOffset";
            yOffset.Size = new Size(38, 23);
            yOffset.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(3, 36);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 11;
            label6.Text = "YOffset";
            label6.Click += Label_Click;
            // 
            // xCenter
            // 
            xCenter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            xCenter.AutoSize = true;
            xCenter.CheckAlign = ContentAlignment.MiddleRight;
            xCenter.Enabled = false;
            xCenter.Location = new Point(130, 61);
            xCenter.Name = "xCenter";
            xCenter.Size = new Size(15, 23);
            xCenter.TabIndex = 12;
            xCenter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 148);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Presets";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(6, 25);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 20;
            label10.Text = "Pallet name";
            label10.Click += Label_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Standard pallet", "Zipper hoodie pallet" });
            comboBox1.Location = new Point(81, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 23);
            comboBox1.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(printHeight, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(mediaThikness, 3, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(yOffset, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 2, 1);
            tableLayoutPanel1.Controls.Add(sprayAmount, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(xCenter, 1, 2);
            tableLayoutPanel1.Location = new Point(6, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(298, 87);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(3, 65);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 15;
            label7.Text = "XCenter";
            label7.Click += Label_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 211);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(350, 250);
            MinimumSize = new Size(350, 250);
            Name = "Form1";
            Text = "HotFolder Monitor";
            ((System.ComponentModel.ISupportInitialize)printHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)mediaThikness).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprayAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)yOffset).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private NumericUpDown printHeight;
        private NumericUpDown mediaThikness;
        private NotifyIcon notifyIcon1;
        private Label label3;
        private Label label4;
        private NumericUpDown sprayAmount;
        private Label label5;
        private NumericUpDown yOffset;
        private Label label6;
        private CheckBox xCenter;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private ComboBox comboBox1;
        private Label label10;
    }
}