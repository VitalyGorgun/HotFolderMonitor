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
            printHeightLabel = new Label();
            mediaThiknessLabel = new Label();
            sprayAmount = new NumericUpDown();
            sprayLabel = new Label();
            yOffset = new NumericUpDown();
            yOffsetLabel = new Label();
            xCenter = new CheckBox();
            groupBox1 = new GroupBox();
            palletNameLabel = new Label();
            palletNameComboBox = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            xCenterLabel = new Label();
            fourPassCheckBox = new CheckBox();
            fourPassLabel = new Label();
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
            // printHeightLabel
            // 
            printHeightLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            printHeightLabel.AutoSize = true;
            printHeightLabel.ForeColor = SystemColors.GrayText;
            printHeightLabel.Location = new Point(3, 7);
            printHeightLabel.Name = "printHeightLabel";
            printHeightLabel.Size = new Size(98, 15);
            printHeightLabel.TabIndex = 6;
            printHeightLabel.Text = "Print height";
            printHeightLabel.Click += Label_Click;
            // 
            // mediaThiknessLabel
            // 
            mediaThiknessLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mediaThiknessLabel.AutoSize = true;
            mediaThiknessLabel.ForeColor = SystemColors.GrayText;
            mediaThiknessLabel.Location = new Point(151, 7);
            mediaThiknessLabel.Name = "mediaThiknessLabel";
            mediaThiknessLabel.Size = new Size(98, 15);
            mediaThiknessLabel.TabIndex = 7;
            mediaThiknessLabel.Text = "Media thikness";
            mediaThiknessLabel.Click += Label_Click;
            // 
            // sprayAmount
            // 
            sprayAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sprayAmount.Enabled = false;
            sprayAmount.Location = new Point(255, 33);
            sprayAmount.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            sprayAmount.Name = "sprayAmount";
            sprayAmount.Size = new Size(40, 23);
            sprayAmount.TabIndex = 8;
            sprayAmount.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // sprayLabel
            // 
            sprayLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sprayLabel.AutoSize = true;
            sprayLabel.ForeColor = SystemColors.GrayText;
            sprayLabel.Location = new Point(151, 37);
            sprayLabel.Name = "sprayLabel";
            sprayLabel.Size = new Size(98, 15);
            sprayLabel.TabIndex = 9;
            sprayLabel.Text = "Spray";
            sprayLabel.Click += Label_Click;
            // 
            // yOffset
            // 
            yOffset.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yOffset.Enabled = false;
            yOffset.Location = new Point(107, 33);
            yOffset.Name = "yOffset";
            yOffset.Size = new Size(38, 23);
            yOffset.TabIndex = 10;
            // 
            // yOffsetLabel
            // 
            yOffsetLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yOffsetLabel.AutoSize = true;
            yOffsetLabel.ForeColor = SystemColors.GrayText;
            yOffsetLabel.Location = new Point(3, 37);
            yOffsetLabel.Name = "yOffsetLabel";
            yOffsetLabel.Size = new Size(98, 15);
            yOffsetLabel.TabIndex = 11;
            yOffsetLabel.Text = "YOffset";
            yOffsetLabel.Click += Label_Click;
            // 
            // xCenter
            // 
            xCenter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            xCenter.AutoSize = true;
            xCenter.CheckAlign = ContentAlignment.MiddleRight;
            xCenter.Enabled = false;
            xCenter.Location = new Point(130, 63);
            xCenter.Name = "xCenter";
            xCenter.Size = new Size(15, 24);
            xCenter.TabIndex = 12;
            xCenter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(palletNameLabel);
            groupBox1.Controls.Add(palletNameComboBox);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 149);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Presets";
            // 
            // palletNameLabel
            // 
            palletNameLabel.AutoSize = true;
            palletNameLabel.ForeColor = SystemColors.ControlDarkDark;
            palletNameLabel.Location = new Point(6, 25);
            palletNameLabel.Name = "palletNameLabel";
            palletNameLabel.Size = new Size(69, 15);
            palletNameLabel.TabIndex = 20;
            palletNameLabel.Text = "Pallet name";
            palletNameLabel.Click += Label_Click;
            // 
            // palletNameComboBox
            // 
            palletNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            palletNameComboBox.Enabled = false;
            palletNameComboBox.FormattingEnabled = true;
            palletNameComboBox.Items.AddRange(new object[] { "Standard pallet", "Zipper hoodie pallet" });
            palletNameComboBox.Location = new Point(81, 22);
            palletNameComboBox.Name = "palletNameComboBox";
            palletNameComboBox.Size = new Size(223, 23);
            palletNameComboBox.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(printHeightLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(printHeight, 1, 0);
            tableLayoutPanel1.Controls.Add(mediaThiknessLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(mediaThikness, 3, 0);
            tableLayoutPanel1.Controls.Add(yOffsetLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(yOffset, 1, 1);
            tableLayoutPanel1.Controls.Add(sprayLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(sprayAmount, 3, 1);
            tableLayoutPanel1.Controls.Add(xCenterLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(fourPassCheckBox, 3, 2);
            tableLayoutPanel1.Controls.Add(fourPassLabel, 2, 2);
            tableLayoutPanel1.Controls.Add(xCenter, 1, 2);
            tableLayoutPanel1.Location = new Point(6, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(298, 90);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // xCenterLabel
            // 
            xCenterLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            xCenterLabel.AutoSize = true;
            xCenterLabel.ForeColor = SystemColors.GrayText;
            xCenterLabel.Location = new Point(3, 67);
            xCenterLabel.Name = "xCenterLabel";
            xCenterLabel.Size = new Size(98, 15);
            xCenterLabel.TabIndex = 15;
            xCenterLabel.Text = "XCenter";
            xCenterLabel.Click += Label_Click;
            // 
            // fourPassCheckBox
            // 
            fourPassCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            fourPassCheckBox.AutoSize = true;
            fourPassCheckBox.Enabled = false;
            fourPassCheckBox.Location = new Point(280, 63);
            fourPassCheckBox.Name = "fourPassCheckBox";
            fourPassCheckBox.Size = new Size(15, 24);
            fourPassCheckBox.TabIndex = 16;
            fourPassCheckBox.UseVisualStyleBackColor = true;
            fourPassCheckBox.CheckedChanged += Label_Click;
            // 
            // fourPassLabel
            // 
            fourPassLabel.Anchor = AnchorStyles.Left;
            fourPassLabel.AutoSize = true;
            fourPassLabel.ForeColor = SystemColors.GrayText;
            fourPassLabel.Location = new Point(151, 67);
            fourPassLabel.Name = "fourPassLabel";
            fourPassLabel.Size = new Size(39, 15);
            fourPassLabel.TabIndex = 17;
            fourPassLabel.Text = "4 pass";
            fourPassLabel.Click += Label_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 61);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(350, 250);
            MinimumSize = new Size(350, 100);
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
        private Label printHeightLabel;
        private Label mediaThiknessLabel;
        private NumericUpDown sprayAmount;
        private Label sprayLabel;
        private NumericUpDown yOffset;
        private Label yOffsetLabel;
        private CheckBox xCenter;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label xCenterLabel;
        private ComboBox palletNameComboBox;
        private Label palletNameLabel;
        private CheckBox fourPassCheckBox;
        private Label fourPassLabel;
    }
}