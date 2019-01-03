
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;

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

        public List<Widget> Widgets { get => _widgets; }

        public bool PlaceInBox(Widget widget, Vector<int> position)
        {
            return false;
        }
    }
}