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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            notifyIcon1 = new NotifyIcon(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown4 = new NumericUpDown();
            label5 = new Label();
            numericUpDown5 = new NumericUpDown();
            label6 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
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
            label1.Text = "D:\\";
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
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(107, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(38, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown2.DecimalPlaces = 1;
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown2.Location = new Point(107, 35);
            numericUpDown2.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(38, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown3.DecimalPlaces = 1;
            numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown3.Location = new Point(107, 66);
            numericUpDown3.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(38, 23);
            numericUpDown3.TabIndex = 4;
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
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "Copies";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 39);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Print height";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 70);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 7;
            label4.Text = "Media thikness";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown4.Location = new Point(107, 98);
            numericUpDown4.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(38, 23);
            numericUpDown4.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 102);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 9;
            label5.Text = "Spray";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown5.Location = new Point(255, 4);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(40, 23);
            numericUpDown5.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(151, 8);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 11;
            label6.Text = "YOffset";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(280, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 25);
            checkBox1.TabIndex = 12;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(280, 65);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 25);
            checkBox2.TabIndex = 13;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox3.AutoSize = true;
            checkBox3.CheckAlign = ContentAlignment.MiddleRight;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(280, 96);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 28);
            checkBox3.TabIndex = 14;
            checkBox3.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.Controls.Add(numericUpDown4, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(numericUpDown3, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBox3, 3, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(checkBox2, 3, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown5, 3, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 3, 1);
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
            label7.Location = new Point(151, 39);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 15;
            label7.Text = "XCenter";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(151, 70);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 16;
            label8.Text = "Spray";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(151, 102);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 17;
            label9.Text = "Wipe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 96);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(350, 300);
            MinimumSize = new Size(350, 135);
            Name = "Form1";
            Text = "HotFolder Monitor";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NotifyIcon notifyIcon1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown4;
        private Label label5;
        private NumericUpDown numericUpDown5;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}