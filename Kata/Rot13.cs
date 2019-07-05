using System.Linq;
using System.Text;

namespace Kata
{
    public class Rot13
    {
        public string Encode(string input)
        {
            const int shift = 13;

            var builder = new StringBuilder();

            foreach (var c in input.AsEnumerable())
            {
                builder.Append(Rot(shift, c));
            }
            return builder.ToString();
        }

        private static char Rot(int shift, char input)
        {
            const int modBy = 26;

            if (input >= 'a' && input <= 'z')
            {
                return (char)('a' + (input - 'a' + shift) % modBy);
            }

            if (input >= 'A' && input <= 'Z')
            {
                return (char)('A' + (input - 'A' + shift) % modBy);
            }

            return input;
        }
    }
}
