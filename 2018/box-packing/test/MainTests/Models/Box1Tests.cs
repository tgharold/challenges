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
            var box = new Box1(10);
            var orientation = new int[] { 5 };
            var widget = new Widget(orientation);
            var position = new int[] { 0 };

            Assert.NotNull(box);
            Assert.Equal(10, box.Length(0));
            Assert.NotNull(widget);
            Assert.Equal(5, widget.Orientation[0]);

            var result = box.PlaceInBox(widget, position);
            Assert.True(result);

            Assert.Equal("*****     ", box.LayerToString());
        }
    }
}