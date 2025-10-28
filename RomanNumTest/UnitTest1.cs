using Xunit;
using RomanNum;

namespace RomanNumTest
{
    public class UnitTest1
    {
        [Fact]
    
            public void Convert_ReturningI()
        {
            var converter = new RomanNumeralConverter();
            Assert.Equal("I", converter.Convert(1)); 
        }

        [Fact]
        public void Convert_ReturningV()
        {
            var converter = new RomanNumeralConverter();
            Assert.Equal("V", converter.Convert(5)); 
        }

        [Fact]
        public void Convert_ReturningIV()
        {
            var converter = new RomanNumeralConverter();
            Assert.Equal("IV", converter.Convert(4));

        }

        [Fact]
        public void Convert_ReturningMCMLXXXIV()
        {
            var converter = new RomanNumeralConverter();
            Assert.Equal("MCMLXXXIV", converter.Convert(1984));
        }

        [Fact]
        public void Convert_ReturningMMM()
        {
            var converter = new RomanNumeralConverter();
            Assert.Equal("MMM", converter.Convert(3000));
        }

        [Fact]
        public void Convert_ReturningCD()
        {
            var converter = new RomanNumeralConverter();
            Assert.Equal("CD", converter.Convert(400));
        }

    }
    
}
