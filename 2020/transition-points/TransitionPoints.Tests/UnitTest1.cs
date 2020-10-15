using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TransitionPoints.Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            _elementsA = GenerateElements(RawElementsA);
        }
        
        /// <summary>Represent a sequence of characters that occur on regular intervals.</summary>
        private class Element
        {
            public DateTimeOffset Timestamp { get; set; }
            public char Value { get; set; }
        }

        private char[] RawElementsA = ( 
            "AAABBCCCCCDDEFFFFFGGHHHHIIIIJJJJ"
            ).ToCharArray();

        private List<Element> _elementsA;

        private List<Element> GenerateElements(char[] inputElements)
        {
            var timestamp = new DateTimeOffset(2020, 10, 14, 22, 45, 0, TimeSpan.Zero);
            var interval = new TimeSpan(0, 0, 10);

            var result = new List<Element>();
            foreach (var e in inputElements)
            {
                result.Add(new Element
                {
                    Timestamp = timestamp,
                    Value = e
                });
                timestamp += interval;
            }
            return result;
        }

        private const string _timeFormat = "HH:mm:ss";
        
        [Theory]
        [InlineData('A', "22:45:00")]
        [InlineData('B', "22:45:30")]
        [InlineData('C', "22:45:50")]
        [InlineData('D', "22:46:40")]
        [InlineData('E', "22:47:00")]
        [InlineData('F', "22:47:10")]
        [InlineData('G', "22:48:00")]
        [InlineData('H', "22:48:20")]
        [InlineData('I', "22:49:00")]
        [InlineData('J', "22:49:40")]
        public void Validate_ElementsA_earliest_seen(
            char letter, 
            string expected
            )
        {
            var firstOccurrence = _elementsA.First(x => x.Value == letter);
            var timeString = firstOccurrence.Timestamp.ToString(_timeFormat);
            Assert.Equal(expected, timeString);
        }
    }
}
