namespace HFMTouch;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        headerPanel = new Panel();
        closeButton = new Button();
        footerPanel = new Panel();
        startButton = new Button();
        comboBox1 = new ComboBox();
        label1 = new Label();
        label8 = new Label();
        label9 = new Label();
        SprayTrackBar = new CustomTrackBar();
        yOffsetTrackBar = new CustomTrackBar();
        label2 = new Label();
        label3 = new Label();
        PHTrackBar = new CustomTrackBar();
        label4 = new Label();
        label5 = new Label();
        MTTrackBar = new CustomTrackBar();
        label6 = new Label();
        label7 = new Label();
        sprayToggle = new CustomToggle();
        yOffsetToggle = new CustomToggle();
        PHToggle = new CustomToggle();
        MTToggle = new CustomToggle();
        customCheckBox1 = new UIElement.CustomCheckBox();
        label10 = new Label();
        xCenterToggle = new CustomToggle();
        fourPassToggle = new CustomToggle();
        label11 = new Label();
        customCheckBox2 = new UIElement.CustomCheckBox();
        headerPanel.SuspendLayout();
        footerPanel.SuspendLayout();
        SuspendLayout();
        // 
        // headerPanel
        // 
        headerPanel.BackColor = Color.FromArgb(0, 106, 78);
        headerPanel.Controls.Add(closeButton);
        headerPanel.Dock = DockStyle.Top;
        headerPanel.Location = new Point(0, 0);
        headerPanel.Name = "headerPanel";
        headerPanel.Size = new Size(500, 47);
        headerPanel.TabIndex = 0;
        // 
        // closeButton
        // 
        closeButton.BackColor = Color.Brown;
        closeButton.Dock = DockStyle.Right;
        closeButton.FlatStyle = FlatStyle.Flat;
        closeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        closeButton.ForeColor = Color.FromArgb(225, 225, 225);
        closeButton.Location = new Point(442, 0);
        closeButton.Name = "closeButton";
        closeButton.Size = new Size(58, 47);
        closeButton.TabIndex = 0;
        closeButton.Text = "✖";
        closeButton.UseVisualStyleBackColor = false;
        closeButton.Click += interfaceEvents;
        // 
        // footerPanel
        // 
        footerPanel.BackColor = Color.FromArgb(0, 106, 78);
        footerPanel.Controls.Add(startButton);
        footerPanel.Dock = DockStyle.Bottom;
        footerPanel.Location = new Point(0, 622);
        footerPanel.Name = "footerPanel";
        footerPanel.Size = new Size(500, 63);
        footerPanel.TabIndex = 1;
        // 
        // startButton
        // 
        startButton.Dock = DockStyle.Fill;
        startButton.FlatStyle = FlatStyle.Flat;
        startButton.Font = new Font("Franklin Gothic Medium", 21.75F);
        startButton.ForeColor = Color.FromArgb(225, 225, 225);
        startButton.Location = new Point(0, 0);
        startButton.Name = "startButton";
        startButton.Size = new Size(500, 63);
        startButton.TabIndex = 0;
        startButton.Text = "START";
        startButton.UseVisualStyleBackColor = true;
        startButton.Click += startButtonOnClick;
        // 
        // comboBox1
        // 
        comboBox1.BackColor = Color.FromArgb(0, 106, 78);
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.FlatStyle = FlatStyle.System;
        comboBox1.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "[DEFAULT]", "Standard pallet", "Zipper hoodie pallet", "RSS (AUTO)", "RSS 15.9x19.9" });
        comboBox1.Location = new Point(85, 73);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(403, 42);
        comboBox1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.ForeColor = Color.FromArgb(0, 106, 78);
        label1.Location = new Point(17, 82);
        label1.Name = "label1";
        label1.Size = new Size(64, 26);
        label1.TabIndex = 1;
        label1.Text = "Pallet";
        label1.TextAlign = ContentAlignment.BottomCenter;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label8.ForeColor = Color.Gray;
        label8.Location = new Point(85, 142);
        label8.Name = "label8";
        label8.Size = new Size(36, 26);
        label8.TabIndex = 19;
        label8.Text = "45";
        label8.TextAlign = ContentAlignment.BottomCenter;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label9.ForeColor = Color.Gray;
        label9.Location = new Point(12, 142);
        label9.Name = "label9";
        label9.Size = new Size(67, 26);
        label9.TabIndex = 15;
        label9.Text = "Spray:";
        label9.TextAlign = ContentAlignment.BottomCenter;
        // 
        // SprayTrackBar
        // 
        SprayTrackBar.Enabled = false;
        SprayTrackBar.HandlerColor = Color.FromArgb(0, 106, 78);
        SprayTrackBar.HandlerThickness = 30;
        SprayTrackBar.LeftTrackColor = Color.FromArgb(0, 106, 78);
        SprayTrackBar.Location = new Point(12, 171);
        SprayTrackBar.Maximum = 30;
        SprayTrackBar.Minimum = 0;
        SprayTrackBar.Name = "SprayTrackBar";
        SprayTrackBar.RightTrackColor = Color.FromArgb(225, 225, 225);
        SprayTrackBar.Size = new Size(476, 55);
        SprayTrackBar.TabIndex = 18;
        SprayTrackBar.Text = "customTrackBar1";
        SprayTrackBar.TickFrequency = 10;
        SprayTrackBar.TrackThickness = 15;
        SprayTrackBar.Value = 9;
        SprayTrackBar.ValueChanged += interfaceEvents;
        // 
        // yOffsetTrackBar
        // 
        yOffsetTrackBar.Enabled = false;
        yOffsetTrackBar.HandlerColor = Color.FromArgb(0, 106, 78);
        yOffsetTrackBar.HandlerThickness = 30;
        yOffsetTrackBar.LeftTrackColor = Color.FromArgb(0, 106, 78);
        yOffsetTrackBar.Location = new Point(12, 258);
        yOffsetTrackBar.Maximum = 10;
        yOffsetTrackBar.Minimum = 0;
        yOffsetTrackBar.Name = "yOffsetTrackBar";
        yOffsetTrackBar.RightTrackColor = Color.FromArgb(225, 225, 225);
        yOffsetTrackBar.Size = new Size(476, 55);
        yOffsetTrackBar.TabIndex = 21;
        yOffsetTrackBar.Text = "customTrackBar2";
        yOffsetTrackBar.TickFrequency = 10;
        yOffsetTrackBar.TrackThickness = 15;
        yOffsetTrackBar.Value = 7;
        yOffsetTrackBar.ValueChanged += interfaceEvents;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label2.ForeColor = Color.Gray;
        label2.Location = new Point(102, 229);
        label2.Name = "label2";
        label2.Size = new Size(36, 26);
        label2.TabIndex = 22;
        label2.Text = "70";
        label2.TextAlign = ContentAlignment.BottomCenter;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label3.ForeColor = Color.Gray;
        label3.Location = new Point(12, 229);
        label3.Name = "label3";
        label3.Size = new Size(84, 26);
        label3.TabIndex = 20;
        label3.Text = "YOffset:";
        label3.TextAlign = ContentAlignment.BottomCenter;
        // 
        // PHTrackBar
        // 
        PHTrackBar.Enabled = false;
        PHTrackBar.HandlerColor = Color.FromArgb(0, 106, 78);
        PHTrackBar.HandlerThickness = 30;
        PHTrackBar.LeftTrackColor = Color.FromArgb(0, 106, 78);
        PHTrackBar.Location = new Point(12, 345);
        PHTrackBar.Maximum = 10;
        PHTrackBar.Minimum = 4;
        PHTrackBar.Name = "PHTrackBar";
        PHTrackBar.RightTrackColor = Color.FromArgb(225, 225, 225);
        PHTrackBar.Size = new Size(476, 55);
        PHTrackBar.TabIndex = 24;
        PHTrackBar.Text = "customTrackBar3";
        PHTrackBar.TickFrequency = 10;
        PHTrackBar.TrackThickness = 15;
        PHTrackBar.Value = 4;
        PHTrackBar.ValueChanged += interfaceEvents;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label4.ForeColor = Color.Gray;
        label4.Location = new Point(139, 316);
        label4.Name = "label4";
        label4.Size = new Size(41, 26);
        label4.TabIndex = 25;
        label4.Text = "2.0";
        label4.TextAlign = ContentAlignment.BottomCenter;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label5.ForeColor = Color.Gray;
        label5.Location = new Point(12, 316);
        label5.Name = "label5";
        label5.Size = new Size(121, 26);
        label5.TabIndex = 23;
        label5.Text = "Print height:";
        label5.TextAlign = ContentAlignment.BottomCenter;
        // 
        // MTTrackBar
        // 
        MTTrackBar.Enabled = false;
        MTTrackBar.HandlerColor = Color.FromArgb(0, 106, 78);
        MTTrackBar.HandlerThickness = 30;
        MTTrackBar.LeftTrackColor = Color.FromArgb(0, 106, 78);
        MTTrackBar.Location = new Point(12, 430);
        MTTrackBar.Maximum = 10;
        MTTrackBar.Minimum = 2;
        MTTrackBar.Name = "MTTrackBar";
        MTTrackBar.RightTrackColor = Color.FromArgb(225, 225, 225);
        MTTrackBar.Size = new Size(476, 55);
        MTTrackBar.TabIndex = 27;
        MTTrackBar.Text = "customTrackBar4";
        MTTrackBar.TickFrequency = 10;
        MTTrackBar.TrackThickness = 15;
        MTTrackBar.Value = 2;
        MTTrackBar.ValueChanged += interfaceEvents;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label6.ForeColor = Color.Gray;
        label6.Location = new Point(160, 401);
        label6.Name = "label6";
        label6.Size = new Size(41, 26);
        label6.TabIndex = 28;
        label6.Text = "1.0";
        label6.TextAlign = ContentAlignment.BottomCenter;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label7.ForeColor = Color.Gray;
        label7.Location = new Point(12, 403);
        label7.Name = "label7";
        label7.Size = new Size(142, 24);
        label7.TabIndex = 26;
        label7.Text = "Media Thikness:";
        label7.TextAlign = ContentAlignment.BottomCenter;
        // 
        // sprayToggle
        // 
        sprayToggle.IsActiveColor = Color.FromArgb(0, 106, 78);
        sprayToggle.IsChecked = false;
        sprayToggle.IsInactiveColor = Color.Gray;
        sprayToggle.Location = new Point(418, 142);
        sprayToggle.Name = "sprayToggle";
        sprayToggle.Size = new Size(70, 26);
        sprayToggle.TabIndex = 29;
        sprayToggle.Text = "customToggle1";
        sprayToggle.ValueChanged += interfaceEvents;
        // 
        // yOffsetToggle
        // 
        yOffsetToggle.IsActiveColor = Color.FromArgb(0, 106, 78);
        yOffsetToggle.IsChecked = false;
        yOffsetToggle.IsInactiveColor = Color.Gray;
        yOffsetToggle.Location = new Point(418, 229);
        yOffsetToggle.Name = "yOffsetToggle";
        yOffsetToggle.Size = new Size(70, 26);
        yOffsetToggle.TabIndex = 30;
        yOffsetToggle.Text = "customToggle2";
        yOffsetToggle.ValueChanged += interfaceEvents;
        // 
        // PHToggle
        // 
        PHToggle.IsActiveColor = Color.FromArgb(0, 106, 78);
        PHToggle.IsChecked = false;
        PHToggle.IsInactiveColor = Color.Gray;
        PHToggle.Location = new Point(418, 316);
        PHToggle.Name = "PHToggle";
        PHToggle.Size = new Size(70, 26);
        PHToggle.TabIndex = 31;
        PHToggle.Text = "customToggle3";
        PHToggle.ValueChanged += interfaceEvents;
        // 
        // MTToggle
        // 
        MTToggle.IsActiveColor = Color.FromArgb(0, 106, 78);
        MTToggle.IsChecked = false;
        MTToggle.IsInactiveColor = Color.Gray;
        MTToggle.Location = new Point(418, 401);
        MTToggle.Name = "MTToggle";
        MTToggle.Size = new Size(70, 26);
        MTToggle.TabIndex = 32;
        MTToggle.Text = "customToggle4";
        MTToggle.ValueChanged += interfaceEvents;
        // 
        // customCheckBox1
        // 
        customCheckBox1.Enabled = false;
        customCheckBox1.IsActiveColor = Color.FromArgb(0, 106, 78);
        customCheckBox1.IsChecked = false;
        customCheckBox1.IsInactiveColor = Color.Brown;
        customCheckBox1.Location = new Point(106, 488);
        customCheckBox1.Name = "customCheckBox1";
        customCheckBox1.Size = new Size(25, 25);
        customCheckBox1.TabIndex = 34;
        customCheckBox1.Text = "customCheckBox1";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label10.ForeColor = Color.Gray;
        label10.Location = new Point(17, 488);
        label10.Name = "label10";
        label10.Size = new Size(79, 24);
        label10.TabIndex = 35;
        label10.Text = "XCenter:";
        label10.TextAlign = ContentAlignment.BottomCenter;
        // 
        // xCenterToggle
        // 
        xCenterToggle.IsActiveColor = Color.FromArgb(0, 106, 78);
        xCenterToggle.IsChecked = false;
        xCenterToggle.IsInactiveColor = Color.Gray;
        xCenterToggle.Location = new Point(418, 491);
        xCenterToggle.Name = "xCenterToggle";
        xCenterToggle.Size = new Size(70, 26);
        xCenterToggle.TabIndex = 36;
        xCenterToggle.Text = "customToggle5";
        xCenterToggle.ValueChanged += interfaceEvents;
        // 
        // fourPassToggle
        // 
        fourPassToggle.IsActiveColor = Color.FromArgb(0, 106, 78);
        fourPassToggle.IsChecked = false;
        fourPassToggle.IsInactiveColor = Color.Gray;
        fourPassToggle.Location = new Point(418, 534);
        fourPassToggle.Name = "fourPassToggle";
        fourPassToggle.Size = new Size(70, 26);
        fourPassToggle.TabIndex = 39;
        fourPassToggle.Text = "customToggle6";
        fourPassToggle.ValueChanged += interfaceEvents;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label11.ForeColor = Color.Gray;
        label11.Location = new Point(17, 531);
        label11.Name = "label11";
        label11.Size = new Size(69, 24);
        label11.TabIndex = 38;
        label11.Text = "4 pass:";
        label11.TextAlign = ContentAlignment.BottomCenter;
        // 
        // customCheckBox2
        // 
        customCheckBox2.Enabled = false;
        customCheckBox2.IsActiveColor = Color.FromArgb(0, 106, 78);
        customCheckBox2.IsChecked = false;
        customCheckBox2.IsInactiveColor = Color.Brown;
        customCheckBox2.Location = new Point(106, 531);
        customCheckBox2.Name = "customCheckBox2";
        customCheckBox2.Size = new Size(25, 25);
        customCheckBox2.TabIndex = 37;
        customCheckBox2.Text = "customCheckBox2";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(500, 685);
        Controls.Add(fourPassToggle);
        Controls.Add(label11);
        Controls.Add(customCheckBox2);
        Controls.Add(xCenterToggle);
        Controls.Add(label10);
        Controls.Add(customCheckBox1);
        Controls.Add(MTToggle);
        Controls.Add(PHToggle);
        Controls.Add(yOffsetToggle);
        Controls.Add(sprayToggle);
        Controls.Add(MTTrackBar);
        Controls.Add(label6);
        Controls.Add(label7);
        Controls.Add(PHTrackBar);
        Controls.Add(label4);
        Controls.Add(label5);
        Controls.Add(yOffsetTrackBar);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(SprayTrackBar);
        Controls.Add(label8);
        Controls.Add(label9);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Controls.Add(footerPanel);
        Controls.Add(headerPanel);
        FormBorderStyle = FormBorderStyle.None;
        MinimumSize = new Size(500, 0);
        Name = "MainForm";
        Opacity = 0.95D;
        Text = "Form1";
        headerPanel.ResumeLayout(false);
        footerPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel headerPanel;
    private Panel footerPanel;
    private Button startButton;
    private Button closeButton;
    private ComboBox comboBox1;
    private Label label1;
    private Label label8;
    private Label label9;
    private CustomTrackBar SprayTrackBar;
    private CustomTrackBar yOffsetTrackBar;
    private Label label2;
    private Label label3;
    private CustomTrackBar PHTrackBar;
    private Label label4;
    private Label label5;
    private CustomTrackBar MTTrackBar;
    private Label label6;
    private Label label7;
    private CustomToggle sprayToggle;
    private CustomToggle yOffsetToggle;
    private CustomToggle PHToggle;
    private CustomToggle MTToggle;
    private UIElement.CustomCheckBox customCheckBox1;
    private Label label10;
    private CustomToggle xCenterToggle;
    private CustomToggle fourPassToggle;
    private Label label11;
    private UIElement.CustomCheckBox customCheckBox2;
}
