namespace Main.Models
{
    public class BoxedWidget
    {
        private int[] _position;

        public BoxedWidget(Widget widget, int[] position)
        {
            Widget = widget;
            _position = position;
        }

        public int[] Position { get => _position; }
        public Widget Widget { get; }
    }
}