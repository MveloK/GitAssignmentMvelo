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
            if (number < 1 || number > 3000)
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 3000 to convert to roman numerals.");

            var result = new StringBuilder();
            var remaining = number;

            foreach (var (value, numeral) in _mapping)
            {
                while (remaining >= value)
                {
                    result.Append(numeral);
                    remaining -= value;
                }
            }

            return result.ToString();

        }
    }
}