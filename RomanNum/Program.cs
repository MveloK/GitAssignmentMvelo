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
        (900, "CM"),
        (500, "D"),
        (400, "CD"),
        (100, "C"),
        (90, "XC"),
        (50, "L"),
        (40, "XL"),
        (10, "X"),
        (9, "IX"),
        (5, "V"),
        (4, "IV"),
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