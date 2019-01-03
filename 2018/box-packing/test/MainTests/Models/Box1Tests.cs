using Xunit;
using Main.Models;

namespace MainTests.Models
{
    public class Box1Tests
    {
        [Fact]
        public void CanCreateBox()
        {
            var box = new Box1(30);
            Assert.NotNull(box);
            Assert.Equal(30, box.Length(0));
        }

        [Fact]
        public void CanPutWidgetInBox()
        {
            var box = new Box1(30);
            var orientation = new int[] { 15 };
            var widget = new Widget(orientation);

            Assert.NotNull(widget);
            Assert.Equal(15, widget.Orientation[0]);

        }
    }
}