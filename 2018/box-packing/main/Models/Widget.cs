using System;
using MathNet.Numerics.LinearAlgebra;

namespace main.Models
{
    public class Widget
    {
        public Widget(Vector<int> size)
        {
            Orientation = size;
        }
        
        ///<summary>Size of the widget, also serves as the orientation of the widget in the box.</summary>
        public Vector<int> Orientation { get; }

        public void Swap(int a, int b)
        {
            if (a < 0 || a > Orientation.Count) throw new ArgumentException(nameof(a));

        }
    }
}