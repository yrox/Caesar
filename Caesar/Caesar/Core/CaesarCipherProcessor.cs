using System;
using System.Text;

namespace Caesar.Core
{
    public class CaesarCipherProcessor
    {
        private readonly Func<int, int, int> sum = (a, b) => a + b;

        private readonly Func<int, int, int> substract = (a, b) => a - b;

        public string Encrypt(string input, int key)
        {
            return ApplyCaesarCipherToString(input, key, sum);
        }

        public string Decrypt(string input, int key)
        {
            return ApplyCaesarCipherToString(input, key, substract);
        }

        private string ApplyCaesarCipherToString(string input, int key, Func<int, int, int> operation)
        {
            var result = new StringBuilder(input.Length);
            foreach (var character in input)
            {
                result.Append(ApplyCaesarCipherToCharacter(character, key, operation));
            }
            return result.ToString();
        }

        private char ApplyCaesarCipherToCharacter(char input, int key, Func<int, int, int> operation)
        {
            var alphabetBeginning = char.IsUpper(input) ? 'A' : 'a';

            var result = (operation(input, key) - alphabetBeginning) % 26 + alphabetBeginning;

            return (char)result;
        }


    }
}
