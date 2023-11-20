namespace HFMTouch;

partial class VisibilityRestorerWindow {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        maximizeButton = new Button();
        SuspendLayout();
        // 
        // maximizeButton
        // 
        maximizeButton.BackColor = SystemColors.WindowFrame;
        maximizeButton.Dock = DockStyle.Fill;
        maximizeButton.FlatStyle = FlatStyle.Flat;
        maximizeButton.Font = new Font("Arial Narrow", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
        maximizeButton.Location = new Point(0, 0);
        maximizeButton.Name = "maximizeButton";
        maximizeButton.Size = new Size(100, 100);
        maximizeButton.TabIndex = 0;
        maximizeButton.Text = "<";
        maximizeButton.UseVisualStyleBackColor = false;
        maximizeButton.Click += maximizeButtonOnClick;
        // 
        // MaximizeBTNWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(100, 100);
        Controls.Add(maximizeButton);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MaximizeBTNWindow";
        Opacity = 0.5D;
        Text = "maximizeWindow";
        ResumeLayout(false);
    }

    #endregion

    private Button maximizeButton;
}