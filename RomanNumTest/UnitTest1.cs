using Xunit;
using RomanNum;

namespace RomanNumTest
{
    public class UnitTest1
    {

        private readonly RomanNumeralConverter _converter = new();

        [Fact]
        public void Convert_Returning_Null()
        {
            var converter = new RomanNumeralConverter();
            Assert.Equal("N", converter.Convert(0));
        }

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

        //https://www.youtube.com/watch?v=p76WYIAW6XY referenced this youtube video might redo this project again
        //https://www.youtube.com/watch?v=ZuYa9W4aNmQ Also a good Roman numeral conversion video def will do this assignment again.

      

    }

}
