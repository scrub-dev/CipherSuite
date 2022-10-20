using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace CipherSuite.CipherHandling
{
    internal class CipherSuite
    {
        public static readonly Regex whitespaceRegex = new Regex(@"\s+");
        public enum CIPHER_TYPE
        {
            CEASER, VIGENERE
        }
        public enum MODE
        {
            ENCRYPT, DECRYPT
        }
        public static string CharListToString(ArrayList input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Count; i++)
                sb.Append(input[i]);
            return sb.ToString();
        }
    }
}
