using Xunit;
using RomanNum;

namespace RomanNumTest
{
    public class UnitTest1
    {
        [Fact]
    
            public void Convert_Given1_ReturnsI()
        {
            var converter = new RomanNumeralConverter();
            Assert.Equal("I", converter.Convert(1)); 
        }

    }
    
}
