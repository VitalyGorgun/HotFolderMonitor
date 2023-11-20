namespace HFMTouch.UIElement {
    internal class CustomCheckBox : Control {
        public Color IsActiveColor { get; set; } = Color.Green;
        public Color IsInactiveColor { get; set; } = Color.Red;
        private bool _isChecked = false;

        public event EventHandler? ValueChanged;

        public bool IsChecked {
            get { return _isChecked; }
            set {
                if (_isChecked != value) {
                    _isChecked = value;
                    OnValueChanged(EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        public CustomCheckBox() {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Width = 70;
            Height = 35;
        }

        protected virtual void OnValueChanged(EventArgs e) {
            ValueChanged?.Invoke(this, e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            Color fillColor = Enabled ? (_isChecked ? IsActiveColor : IsInactiveColor) : Color.Gray;

            using (Brush backgroundBrush = new SolidBrush(fillColor)) {
                e.Graphics.FillRectangle(backgroundBrush, ClientRectangle);
            }

            int handlerSize = Height - 4;
            int handlerX = _isChecked ? Width - handlerSize - 2 : 2;


        }

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left && Enabled) {
                IsChecked = !IsChecked;
            }
        }
    }
}
