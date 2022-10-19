using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CipherSuite.CipherHandling
{
    internal class CipherSuite
    {
        public static readonly Regex whitespaceRegex = new Regex(@"\s+");
        Decipher deciher = new Decipher();
        Cipher cipher = new Cipher();
        public enum CIPHER_TYPE{
            CEASER,
            VIGENERE
        }
        public enum VIGENERE_MODE
        {
            ENCRYPT,
            DECRYPT
        }
        public CipherSuite() { }
        public static string CharListToString(ArrayList input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Count; i++)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}
