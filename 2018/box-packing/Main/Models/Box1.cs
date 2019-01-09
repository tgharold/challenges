
using System;
using System.Collections.Generic;
using System.Linq;

namespace Main.Models
{
    ///<summary>A one-dimensional box</summary>
    public class Box1
    {
        private bool[] _interior;
        private List<BoxedWidget> _boxedWidgets = new List<BoxedWidget>();

        public Box1(int length)
        {
            _interior = new bool[length];
        }

        public int Dimensions => 1;

        public int Length(int dimension)
        {
            if (dimension < 0 || dimension >= Dimensions)
                throw new ArgumentOutOfRangeException(nameof(dimension));

            return _interior.Length;
        }

        public List<BoxedWidget> BoxedWidgets { get => _boxedWidgets; }

        public bool PlaceInBox(Widget widget, int[] position)
        {
            var boxedWidget = new BoxedWidget(widget, position);
            _boxedWidgets.Add(boxedWidget);

            return true; //TODO: this is a temporary lie
        }

        public string LayerToString()
        {
            return string.Join("", _interior.Select(x => x ? "*" : " "));
        }
    }
}