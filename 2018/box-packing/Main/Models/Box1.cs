
using System;
using System.Collections.Generic;

namespace Main.Models
{
    ///<summary>A one-dimensional box</summary>
    public class Box1
    {
        private bool[] _interior;
        private List<Widget> _widgets = new List<Widget>();

        public Box1(int length)
        {
            _interior = new bool[length];
        }

        public int Length(int dimension)
        {
            if (dimension < 0 || dimension > 0)
                throw new ArgumentException(nameof(dimension));

            return _interior.Length;
        }

        public List<Widget> Widgets { get => _widgets; }

        public bool PlaceInBox(Widget widget, int[] position)
        {
            return false;
        }
    }
}