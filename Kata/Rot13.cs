using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    public class Rot13
    {
        public string Encode(string input)
        {
            var builder = new StringBuilder();
            foreach (var c in input.AsEnumerable())
            {
                builder.Append(Transform(c));
            }
            return builder.ToString();
        }

        private static char Transform(char input)
        {
            if (input >= 'a' && input <= 'z')
            {
                return (char)('a' + (input - 'a' + 13) % 26);
            }

            if (input >= 'A' && input <= 'Z')
            {
                return (char)('A' + (input - 'A' + 13) % 26);
            }

            return input;
        }
    }
}
