
using MathNet.Numerics.LinearAlgebra;

namespace main.Models
{
    ///<summary>A one-dimensional box</summary>
    public class Box1
    {
        private bool[] _interior;

        public Box1(int length)
        {
            _interior = new bool[length];
        }

        public bool[] Interior => _interior;

        public bool TryToPlaceInBox(Widget widget, Vector<int> position)
        {
            return false;
        }
    }
}