using System;
using MathNet.Numerics.LinearAlgebra;

namespace Main.Models
{
    public class Widget
    {
        private Vector<int> _orientation;

        public Widget(Vector<int> size)
        {
            _orientation = size;
        }
        
        ///<summary>Size of the widget, also serves as the orientation of the widget in the box.</summary>
        public Vector<int> Orientation { get => _orientation; }

        public void Swap(int a, int b)
        {
            if (a < 0 || a > Orientation.Count) throw new ArgumentException(nameof(a));
            var tmp = _orientation[a];
            _orientation[a] = _orientation[b];
            _orientation[b] = _orientation[a];
        }

        public void Flip(int a)
        {
            if (a < 0 || a > Orientation.Count) throw new ArgumentException(nameof(a));
            _orientation[a] = _orientation[a] * -1;
        }
    }
}