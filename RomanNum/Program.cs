using System.Text;
using System;
using System.Collections.Generic;
namespace RomanNum
{
    public class RomanNumeralConverter
    {
    private readonly List<(int value, string numeral)> _mapping = new()
{
    (1000, "M"),
    (500, "D"),
    (100, "C"),
    (50, "L"),
    (10, "X"),
    (5, "V"),
    (1, "I")
};

        public string Convert(int number)
        {
            if (number == 1) return "I";
            return string.Empty;
            
        }
    }
}