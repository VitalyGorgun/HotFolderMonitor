namespace HFMTouch {
    internal class CustomToggle : Control {
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

        public CustomToggle() {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Width = 70;
            Height = 35;
        }

        protected virtual void OnValueChanged(EventArgs e) {
            ValueChanged?.Invoke(this, e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            using (Brush backgroundBrush = new SolidBrush(_isChecked ? IsActiveColor : IsInactiveColor)) {
                e.Graphics.FillRectangle(backgroundBrush, ClientRectangle);
            }

            //using (Pen borderPen = new Pen(Color.FromArgb(171, 171, 171))) {
            //    e.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
            //}

            int handlerSize = Height - 4;
            int handlerX = _isChecked ? Width - handlerSize - 2 : 2;

            using (Brush handlerBrush = new SolidBrush(Color.White)) {
                e.Graphics.FillRectangle(handlerBrush, handlerX, 2, handlerSize, handlerSize);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left) {
                IsChecked = !IsChecked;
            }
        }


    }
}
