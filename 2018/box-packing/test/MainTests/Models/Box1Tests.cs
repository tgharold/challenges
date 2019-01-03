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

        }
    }
}