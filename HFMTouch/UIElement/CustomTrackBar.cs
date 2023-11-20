namespace HFMTouch {
    public class CustomTrackBar : Control {
        private int _minimum = 0;
        private int _maximum = 100;
        private int _value = 0;
        private bool _isDragging = false;

        public event EventHandler? ValueChanged;

        public int Minimum {
            get { return _minimum; }
            set { _minimum = value; UpdateValue(); }
        }

        public int Maximum {
            get { return _maximum; }
            set { _maximum = value; UpdateValue(); }
        }

        public int Value {
            get { return _value; }
            set { _value = value; UpdateValue(); }
        }

        public int TrackThickness { get; set; } = 20; // Товщина доріжки
        public int HandlerThickness { get; set; } = 20; // Товщина бігунка (вдвічі менше)
        public Color HandlerColor { get; set; } = Color.FromArgb(255, 255, 255); // Товщина бігунка
        public int TickFrequency { get; set; } = 10;
        public Color LeftTrackColor { get; set; } = Color.LightGray;
        public Color RightTrackColor { get; set; } = Color.FromArgb(225, 225, 225);

        public CustomTrackBar() {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Width = 200;
            Height = 30;
            UpdateValue();
        }

        private void UpdateValue() {
            _value = Math.Max(_minimum, Math.Min(_maximum, _value));
            OnValueChanged(EventArgs.Empty);
            Invalidate();
        }

        protected virtual void OnValueChanged(EventArgs e) {
            ValueChanged?.Invoke(this, e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            int trackWidth = Width - 40;
            int handlerPosition = (int)((_value - _minimum) / (double)(_maximum - _minimum) * trackWidth);

            // Визначення кольору для вимкненого стану
            Color disabledColor = Color.Gray;

            // Заліваємо ліворуч від бігунка
            using (Brush leftTrackBrush = new SolidBrush(Enabled ? LeftTrackColor : disabledColor)) {
                e.Graphics.FillRectangle(leftTrackBrush, 20, Height / 2 - TrackThickness / 2, handlerPosition, TrackThickness);
            }

            // Заліваємо справа від бігунка
            using (Brush rightTrackBrush = new SolidBrush(Enabled ? RightTrackColor : disabledColor)) {
                e.Graphics.FillRectangle(rightTrackBrush, 20 + handlerPosition, Height / 2 - TrackThickness / 2, trackWidth - handlerPosition, TrackThickness);
            }

            using (Brush handlerBrush = new SolidBrush(Enabled ? HandlerColor : disabledColor)) {
                // Враховуємо половину ширини бігунка при розрахунку позиції
                int handlerWidth = HandlerThickness / 4;
                int handlerX = handlerPosition + 20 - handlerWidth;
                int handlerY = Height / 2 - HandlerThickness / 2;

                e.Graphics.FillRectangle(handlerBrush, handlerX, handlerY, HandlerThickness / 2, HandlerThickness);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left) {
                _isDragging = true;
                UpdateValueFromMouse(e.X);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);

            if (_isDragging) {
                UpdateValueFromMouse(e.X);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            base.OnMouseUp(e);

            if (_isDragging) {
                _isDragging = false;
                UpdateValueFromMouse(e.X);
            }
        }

        private void UpdateValueFromMouse(int mouseX) {
            int trackWidth = Width-20;
            double relativePosition = mouseX / (double)trackWidth;
            _value = (int)(_minimum + (relativePosition * (_maximum - _minimum)));
            UpdateValue();
        }
    }
}
