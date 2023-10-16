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
            label1 = new Label();
            button1 = new Button();
            copiesValue = new NumericUpDown();
            printHeight = new NumericUpDown();
            mediaThikness = new NumericUpDown();
            notifyIcon1 = new NotifyIcon(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sprayAmount = new NumericUpDown();
            label5 = new Label();
            yOffset = new NumericUpDown();
            label6 = new Label();
            xCenter = new CheckBox();
            spray = new CheckBox();
            wipe = new CheckBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)copiesValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)printHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mediaThikness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprayAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yOffset).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(310, 40);
            label1.TabIndex = 0;
            label1.Text = "D:\\QuickP Production\\Common\\HotFolder";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 50);
            button1.Name = "button1";
            button1.Size = new Size(310, 40);
            button1.TabIndex = 1;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // copiesValue
            // 
            copiesValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            copiesValue.Enabled = false;
            copiesValue.Location = new Point(107, 4);
            copiesValue.Name = "copiesValue";
            copiesValue.Size = new Size(38, 23);
            copiesValue.TabIndex = 2;
            copiesValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // printHeight
            // 
            printHeight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            printHeight.DecimalPlaces = 1;
            printHeight.Enabled = false;
            printHeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            printHeight.Location = new Point(107, 35);
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
            mediaThikness.Location = new Point(107, 66);
            mediaThikness.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            mediaThikness.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            mediaThikness.Name = "mediaThikness";
            mediaThikness.Size = new Size(38, 23);
            mediaThikness.TabIndex = 4;
            mediaThikness.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "HotFolder Monitor";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "Copies";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(3, 39);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Print height";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(3, 70);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 7;
            label4.Text = "Media thikness";
            label4.Click += label4_Click;
            // 
            // sprayAmount
            // 
            sprayAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sprayAmount.Enabled = false;
            sprayAmount.Location = new Point(107, 98);
            sprayAmount.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            sprayAmount.Name = "sprayAmount";
            sprayAmount.Size = new Size(38, 23);
            sprayAmount.TabIndex = 8;
            sprayAmount.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(3, 102);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 9;
            label5.Text = "Spray";
            label5.Click += label5_Click;
            // 
            // yOffset
            // 
            yOffset.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yOffset.Enabled = false;
            yOffset.Location = new Point(255, 4);
            yOffset.Name = "yOffset";
            yOffset.Size = new Size(40, 23);
            yOffset.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(151, 8);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 11;
            label6.Text = "YOffset";
            label6.Click += label6_Click;
            // 
            // xCenter
            // 
            xCenter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            xCenter.AutoSize = true;
            xCenter.CheckAlign = ContentAlignment.MiddleRight;
            xCenter.Enabled = false;
            xCenter.Location = new Point(280, 34);
            xCenter.Name = "xCenter";
            xCenter.Size = new Size(15, 25);
            xCenter.TabIndex = 12;
            xCenter.UseVisualStyleBackColor = true;
            // 
            // spray
            // 
            spray.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            spray.AutoSize = true;
            spray.CheckAlign = ContentAlignment.MiddleRight;
            spray.Checked = true;
            spray.CheckState = CheckState.Checked;
            spray.Enabled = false;
            spray.Location = new Point(280, 65);
            spray.Name = "spray";
            spray.Size = new Size(15, 25);
            spray.TabIndex = 13;
            spray.UseVisualStyleBackColor = true;
            // 
            // wipe
            // 
            wipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            wipe.AutoSize = true;
            wipe.CheckAlign = ContentAlignment.MiddleRight;
            wipe.Checked = true;
            wipe.CheckState = CheckState.Checked;
            wipe.Enabled = false;
            wipe.Location = new Point(280, 96);
            wipe.Name = "wipe";
            wipe.Size = new Size(15, 28);
            wipe.TabIndex = 14;
            wipe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 155);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Presets";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(sprayAmount, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(mediaThikness, 1, 2);
            tableLayoutPanel1.Controls.Add(printHeight, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(wipe, 3, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(spray, 3, 2);
            tableLayoutPanel1.Controls.Add(copiesValue, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(yOffset, 3, 0);
            tableLayoutPanel1.Controls.Add(xCenter, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label8, 2, 2);
            tableLayoutPanel1.Controls.Add(label9, 2, 3);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(298, 127);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(151, 39);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 15;
            label7.Text = "XCenter";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.GrayText;
            label8.Location = new Point(151, 70);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 16;
            label8.Text = "Spray";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(151, 102);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 17;
            label9.Text = "Wipe";
            label9.Click += label9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 98);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(350, 300);
            MinimumSize = new Size(350, 135);
            Name = "Form1";
            Text = "HotFolder Monitor";
            ((System.ComponentModel.ISupportInitialize)copiesValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)printHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)mediaThikness).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprayAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)yOffset).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private NumericUpDown copiesValue;
        private NumericUpDown printHeight;
        private NumericUpDown mediaThikness;
        private NotifyIcon notifyIcon1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown sprayAmount;
        private Label label5;
        private NumericUpDown yOffset;
        private Label label6;
        private CheckBox xCenter;
        private CheckBox spray;
        private CheckBox wipe;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}